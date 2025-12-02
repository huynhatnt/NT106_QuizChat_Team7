namespace ServerForm.Forms
{
    partial class QuizEditorForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblQuestion = new System.Windows.Forms.Label();
            this.txtQuestion = new System.Windows.Forms.TextBox();

            this.lblA = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();

            this.lblB = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();

            this.lblC = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();

            this.lblD = new System.Windows.Forms.Label();
            this.txtD = new System.Windows.Forms.TextBox();

            this.lblCorrect = new System.Windows.Forms.Label();
            this.cboCorrectAnswer = new System.Windows.Forms.ComboBox();

            this.lblTime = new System.Windows.Forms.Label();
            this.numTime = new System.Windows.Forms.NumericUpDown();

            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.lstQuestions = new System.Windows.Forms.ListBox();

            this.btnSaveQuiz = new System.Windows.Forms.Button();
            this.txtQuizTitle = new System.Windows.Forms.TextBox();
            this.lblQuizTitle = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.numTime)).BeginInit();
            this.SuspendLayout();

            // lblQuizTitle
            this.lblQuizTitle.AutoSize = true;
            this.lblQuizTitle.Location = new System.Drawing.Point(20, 15);
            this.lblQuizTitle.Name = "lblQuizTitle";
            this.lblQuizTitle.Size = new System.Drawing.Size(52, 13);
            this.lblQuizTitle.Text = "Quiz Title";

            // txtQuizTitle
            this.txtQuizTitle.Location = new System.Drawing.Point(100, 12);
            this.txtQuizTitle.Width = 300;

            // lblQuestion
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(20, 50);
            this.lblQuestion.Text = "Question:";

            this.txtQuestion.Location = new System.Drawing.Point(100, 47);
            this.txtQuestion.Width = 300;

            // lblA
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(20, 85);
            this.lblA.Text = "A:";

            this.txtA.Location = new System.Drawing.Point(100, 82);
            this.txtA.Width = 300;

            // lblB
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(20, 115);
            this.lblB.Text = "B:";

            this.txtB.Location = new System.Drawing.Point(100, 112);
            this.txtB.Width = 300;

            // lblC
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(20, 145);
            this.lblC.Text = "C:";

            this.txtC.Location = new System.Drawing.Point(100, 142);
            this.txtC.Width = 300;

            // lblD
            this.lblD.AutoSize = true;
            this.lblD.Location = new System.Drawing.Point(20, 175);
            this.lblD.Text = "D:";

            this.txtD.Location = new System.Drawing.Point(100, 172);
            this.txtD.Width = 300;

            // lblCorrect
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.Location = new System.Drawing.Point(20, 210);
            this.lblCorrect.Text = "Correct:";

            // cboCorrectAnswer
            this.cboCorrectAnswer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCorrectAnswer.Location = new System.Drawing.Point(100, 207);
            this.cboCorrectAnswer.Width = 80;
            this.cboCorrectAnswer.Items.AddRange(new object[] { "A", "B", "C", "D" });
            this.cboCorrectAnswer.SelectedIndex = 0;

            // lblTime
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(200, 210);
            this.lblTime.Text = "Time (sec):";

            // numTime
            this.numTime.Location = new System.Drawing.Point(260, 207);
            this.numTime.Minimum = 1;
            this.numTime.Maximum = 300;
            this.numTime.Value = 30;

            // btnAddQuestion
            this.btnAddQuestion.Location = new System.Drawing.Point(100, 245);
            this.btnAddQuestion.Text = "Add Question";
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);

            // lstQuestions
            this.lstQuestions.Location = new System.Drawing.Point(100, 280);
            this.lstQuestions.Width = 300;
            this.lstQuestions.Height = 150;

            // btnSaveQuiz
            this.btnSaveQuiz.Location = new System.Drawing.Point(100, 450);
            this.btnSaveQuiz.Text = "Save Quiz";
            this.btnSaveQuiz.Click += new System.EventHandler(this.btnSave_Click);

            // QuizEditorForm
            this.ClientSize = new System.Drawing.Size(450, 500);
            this.Controls.Add(this.lblQuizTitle);
            this.Controls.Add(this.txtQuizTitle);

            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.txtQuestion);

            this.Controls.Add(this.lblA);
            this.Controls.Add(this.txtA);

            this.Controls.Add(this.lblB);
            this.Controls.Add(this.txtB);

            this.Controls.Add(this.lblC);
            this.Controls.Add(this.txtC);

            this.Controls.Add(this.lblD);
            this.Controls.Add(this.txtD);

            this.Controls.Add(this.lblCorrect);
            this.Controls.Add(this.cboCorrectAnswer);

            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.numTime);

            this.Controls.Add(this.btnAddQuestion);
            this.Controls.Add(this.lstQuestions);
            this.Controls.Add(this.btnSaveQuiz);

            this.Text = "Quiz Editor";
            ((System.ComponentModel.ISupportInitialize)(this.numTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TextBox txtQuestion;

        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox txtA;

        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txtB;

        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.TextBox txtC;

        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.TextBox txtD;

        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.ComboBox cboCorrectAnswer;

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.NumericUpDown numTime;

        private System.Windows.Forms.ListBox lstQuestions;
        private System.Windows.Forms.Button btnAddQuestion;

        private System.Windows.Forms.Button btnSaveQuiz;
        private System.Windows.Forms.TextBox txtQuizTitle;
        private System.Windows.Forms.Label lblQuizTitle;
    }
}
