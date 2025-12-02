using QuizShared.Models;
using ServerForm.Services;
using Google.Cloud.Firestore;
using System;
using System.Threading;
using System.Windows.Forms;

namespace ServerForm.Forms
{
    public partial class ServerDashboardForm : Form
    {
        private readonly RoomManager _roomManager = new RoomManager();
        private readonly QuizManager _quizManager = new QuizManager();
        private readonly QuizRepository _quizRepo = new QuizRepository();

        private FirestoreChangeListener _listener;
        private Room _room;

        public ServerDashboardForm()
        {
            InitializeComponent();
        }

        private async void btnCreateRoom_Click(object sender, EventArgs e)
        {
            var allQuiz = await _quizRepo.GetAllQuizAsync();

            if (allQuiz.Count == 0)
            {
                MessageBox.Show("Chưa có quiz nào. Hãy tạo quiz trước.");
                return;
            }

            var selectForm = new QuizSelectForm(allQuiz);
            if (selectForm.ShowDialog() != DialogResult.OK)
                return;

            string selectedQuizId = selectForm.SelectedQuizId;
            string host = "HOST";
            string title = txtRoomTitle.Text.Trim();

            string roomId = await _roomManager.CreateRoomAsync(host, title, selectedQuizId);
            lblRoomId.Text = $"Room ID: {roomId}";

            ListenRoom(roomId);
        }

        private void ListenRoom(string roomId)
        {
            // Stop previous listener (nếu có)
            StopListener();

            var roomRef = FirestoreService.Db.Collection("rooms").Document(roomId);

            // Firestore 2.5.0: callback chỉ có snapshot
            _listener = roomRef.Listen(snapshot =>
            {
                if (snapshot == null || !snapshot.Exists)
                    return;

                _room = snapshot.ConvertTo<Room>();

                // Cập nhật UI từ thread Firestore → thread UI
                Invoke(new Action(UpdateUI));
            });
        }

        private void UpdateUI()
        {
            if (_room == null) return;

            lstPlayers.Items.Clear();

            foreach (var p in _room.Players.Values)
                lstPlayers.Items.Add($"{p.Name} - {p.Score}");

            lblState.Text = $"State: {_room.State}";
            lblCurrent.Text = $"Câu: {_room.CurrentQuestionIndex + 1}";
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            if (_room != null)
                await _quizManager.StartQuizAsync(_room.RoomId);
        }

        private async void btnNext_Click(object sender, EventArgs e)
        {
            if (_room == null) return;

            int next = _room.CurrentQuestionIndex + 1;
            await _quizManager.NextQuestionAsync(_room.RoomId, next);
        }

        private async void btnFinish_Click(object sender, EventArgs e)
        {
            if (_room != null)
                await _quizManager.FinishQuizAsync(_room.RoomId);
        }

        private void btnCreateQuiz_Click(object sender, EventArgs e)
        {
            new QuizEditorForm().ShowDialog();
        }

        private void StopListener()
        {
            if (_listener != null)
            {
                _listener.StopAsync(CancellationToken.None)
                         .GetAwaiter()
                         .GetResult();
                _listener = null;
            }
        }
    }
}
