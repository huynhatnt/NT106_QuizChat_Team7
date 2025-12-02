using QuizShared.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ServerForm.Forms
{
    public partial class QuizSelectForm : Form
    {
        private readonly List<Quiz> _quizzes;

        public string SelectedQuizId { get; private set; }

        public QuizSelectForm(List<Quiz> quizzes)
        {
            InitializeComponent();
            _quizzes = quizzes ?? new List<Quiz>();
            LoadQuizList();
        }

        private void LoadQuizList()
        {
            lstQuiz.Items.Clear();

            if (_quizzes.Count == 0)
            {
                lstQuiz.Items.Add("Không có quiz nào!");
                lstQuiz.Enabled = false;
                return;
            }

            foreach (var q in _quizzes)
            {
                string id = string.IsNullOrEmpty(q.QuizId) ? "(NoId)" : q.QuizId;
                lstQuiz.Items.Add(id + " - " + q.Title);
            }

            lstQuiz.Enabled = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (_quizzes.Count == 0)
            {
                MessageBox.Show("Không có quiz để chọn.");
                return;
            }

            int index = lstQuiz.SelectedIndex;
            if (index < 0 || index >= _quizzes.Count)
            {
                MessageBox.Show("Hãy chọn một quiz!");
                return;
            }

            SelectedQuizId = _quizzes[index].QuizId;
            if (string.IsNullOrEmpty(SelectedQuizId))
            {
                MessageBox.Show("QuizId không hợp lệ!");
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
