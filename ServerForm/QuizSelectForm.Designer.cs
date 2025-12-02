namespace ServerForm.Forms
{
    partial class QuizSelectForm
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
            this.lstQuiz = new System.Windows.Forms.ListBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Text = "Chọn Quiz:";
            this.lblTitle.Location = new System.Drawing.Point(15, 15);

            // lstQuiz
            this.lstQuiz.Location = new System.Drawing.Point(18, 40);
            this.lstQuiz.Size = new System.Drawing.Size(350, 200);

            // btnOK
            this.btnOK.Text = "OK";
            this.btnOK.Location = new System.Drawing.Point(60, 260);
            this.btnOK.Size = new System.Drawing.Size(100, 30);
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);

            // btnCancel
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Location = new System.Drawing.Point(200, 260);
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // QuizSelectForm
            this.ClientSize = new System.Drawing.Size(390, 310);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lstQuiz);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select Quiz";

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox lstQuiz;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTitle;
    }
}
