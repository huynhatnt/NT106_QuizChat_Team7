namespace ServerForm.Forms
{
    partial class QuizEditorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.listQuestions = new System.Windows.Forms.ListBox();
            this.btnAddQ = new System.Windows.Forms.Button();
            this.btnEditQ = new System.Windows.Forms.Button();
            this.btnDeleteQ = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(205, 55);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(207, 20);
            this.txtTitle.TabIndex = 0;
            // 
            // listQuestions
            // 
            this.listQuestions.FormattingEnabled = true;
            this.listQuestions.Location = new System.Drawing.Point(522, 44);
            this.listQuestions.Name = "listQuestions";
            this.listQuestions.Size = new System.Drawing.Size(253, 368);
            this.listQuestions.TabIndex = 1;
            // 
            // btnAddQ
            // 
            this.btnAddQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddQ.Location = new System.Drawing.Point(84, 261);
            this.btnAddQ.Name = "btnAddQ";
            this.btnAddQ.Size = new System.Drawing.Size(120, 60);
            this.btnAddQ.TabIndex = 2;
            this.btnAddQ.Text = "Add";
            this.btnAddQ.UseVisualStyleBackColor = true;
            this.btnAddQ.Click += new System.EventHandler(this.btnAddQ_Click);
            // 
            // btnEditQ
            // 
            this.btnEditQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditQ.Location = new System.Drawing.Point(84, 340);
            this.btnEditQ.Name = "btnEditQ";
            this.btnEditQ.Size = new System.Drawing.Size(120, 60);
            this.btnEditQ.TabIndex = 3;
            this.btnEditQ.Text = "Edit";
            this.btnEditQ.UseVisualStyleBackColor = true;
            this.btnEditQ.Click += new System.EventHandler(this.btnEditQ_Click);
            // 
            // btnDeleteQ
            // 
            this.btnDeleteQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteQ.Location = new System.Drawing.Point(223, 261);
            this.btnDeleteQ.Name = "btnDeleteQ";
            this.btnDeleteQ.Size = new System.Drawing.Size(120, 60);
            this.btnDeleteQ.TabIndex = 4;
            this.btnDeleteQ.Text = "Delete";
            this.btnDeleteQ.UseVisualStyleBackColor = true;
            this.btnDeleteQ.Click += new System.EventHandler(this.btnDeleteQ_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(223, 340);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 60);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter quiz name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Question create";
            // 
            // QuizEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDeleteQ);
            this.Controls.Add(this.btnEditQ);
            this.Controls.Add(this.btnAddQ);
            this.Controls.Add(this.listQuestions);
            this.Controls.Add(this.txtTitle);
            this.Name = "QuizEditorForm";
            this.Text = "QuizEditorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.ListBox listQuestions;
        private System.Windows.Forms.Button btnAddQ;
        private System.Windows.Forms.Button btnEditQ;
        private System.Windows.Forms.Button btnDeleteQ;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}