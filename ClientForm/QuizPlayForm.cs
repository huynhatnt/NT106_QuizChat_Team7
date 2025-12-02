using ClientForm.Services;
using QuizShared.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClientForm.Forms
{
    public partial class QuizPlayForm : Form
    {
        private readonly string _uid;
        private readonly string _roomId;

        private readonly RoomService _roomService = new RoomService();
        private readonly QuizService _quizService = new QuizService();

        private Room _room;
        private List<Question> _questions = new List<Question>();

        public QuizPlayForm(string roomId, string uid)
        {
            InitializeComponent();
            _roomId = roomId;
            _uid = uid;
            _roomService.ListenRoom(roomId, OnRoomUpdate);
        }

        private async void OnRoomUpdate(Room room)
        {
            if (room == null)
                return;

            _room = room;

            if (_questions.Count == 0 && !string.IsNullOrWhiteSpace(room.QuizId))
            {
                var temp = await _quizService.LoadQuestionsAsync(room.QuizId);
                _questions = temp ?? new List<Question>();
            }

            if (!IsDisposed && IsHandleCreated)
            {
                try { Invoke(new Action(RefreshUI)); }
                catch { /* form đã dispose */ }
            }
        }

        private void RefreshUI()
        {
            if (_room == null)
                return;

            lblState.Text = _room.State.ToString();
            lblIndex.Text = "Câu: " + (_room.CurrentQuestionIndex + 1);

            if (_questions.Count == 0)
            {
                lblQ.Text = "Đang tải câu hỏi...";
                return;
            }

            if (_room.State == QuizState.InQuestion)
            {
                if (_room.CurrentQuestionIndex >= 0 &&
                    _room.CurrentQuestionIndex < _questions.Count)
                {
                    var q = _questions[_room.CurrentQuestionIndex];

                    lblQ.Text = q.Text;
                    btnA.Text = q.Options.ContainsKey("A") ? q.Options["A"] : "(trống)";
                    btnB.Text = q.Options.ContainsKey("B") ? q.Options["B"] : "(trống)";
                    btnC.Text = q.Options.ContainsKey("C") ? q.Options["C"] : "(trống)";
                    btnD.Text = q.Options.ContainsKey("D") ? q.Options["D"] : "(trống)";
                }
                else
                {
                    lblQ.Text = "Câu hỏi không hợp lệ!";
                }
            }

            if (_room.State == QuizState.ShowingResult)
                lblResult.Text = "Đang hiển thị kết quả...";

            if (_room.State == QuizState.Finished)
                lblResult.Text = "Quiz đã kết thúc!";
        }

        private async void Answer_Click(object sender, EventArgs e)
        {
            if (_room == null || _room.State != QuizState.InQuestion)
                return;

            if (!(sender is Button btn) || btn.Tag == null)
                return;

            string ans = btn.Tag.ToString();

            try
            {
                await _quizService.SubmitAnswerAsync(_roomId, _uid, ans);
                lblResult.Text = "Bạn chọn: " + ans;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi gửi đáp án: " + ex.Message);
            }
        }
    }
}
