using QuizShared.Models;
using ServerForm.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ServerForm.Forms
{
    public partial class QuizEditorForm : Form
    {
        private readonly List<Question> _questions = new List<Question>();
        private readonly QuizRepository _quizRepo = new QuizRepository();

        public QuizEditorForm()
        {
            InitializeComponent();
            cboCorrectAnswer.Items.AddRange(new[] { "A", "B", "C", "D" });
            cboCorrectAnswer.SelectedIndex = 0;
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            var q = new Question
            {
                Text = txtQuestion.Text.Trim(),
                Options = new Dictionary<string, string>
                {
                    { "A", txtA.Text.Trim() },
                    { "B", txtB.Text.Trim() },
                    { "C", txtC.Text.Trim() },
                    { "D", txtD.Text.Trim() },
                },
                CorrectAnswer = cboCorrectAnswer.SelectedItem.ToString(),
                TimeLimitSeconds = (int)numTime.Value
            };

            _questions.Add(q);
            lstQuestions.Items.Add(q.Text);

            ClearFields();
        }

        private void ClearFields()
        {
            txtQuestion.Clear();
            txtA.Clear(); txtB.Clear(); txtC.Clear(); txtD.Clear();
            cboCorrectAnswer.SelectedIndex = 0;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            string title = txtQuizTitle.Text.Trim();
            if (title.Length == 0)
            {
                MessageBox.Show("Chưa nhập tên quiz!");
                return;
            }

            if (_questions.Count == 0)
            {
                MessageBox.Show("Quiz chưa có câu hỏi!");
                return;
            }

            string id = await _quizRepo.CreateQuizAsync(title, _questions);

            MessageBox.Show($"Quiz đã lưu!\nQuiz ID: {id}");
            this.Close();
        }
    }
}
