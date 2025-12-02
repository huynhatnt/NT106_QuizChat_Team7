namespace ClientForm.Forms
{
    partial class QuizPlayForm
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
            this.lblState = new System.Windows.Forms.Label();
            this.lblIndex = new System.Windows.Forms.Label();
            this.lblQ = new System.Windows.Forms.Label();
            this.btnA = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblState.Location = new System.Drawing.Point(18, 15);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(51, 19);
            this.lblState.TabIndex = 0;
            this.lblState.Text = "State: -";
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblIndex.Location = new System.Drawing.Point(18, 45);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(81, 19);
            this.lblIndex.TabIndex = 1;
            this.lblIndex.Text = "Câu: (none)";
            // 
            // lblQ
            // 
            this.lblQ.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblQ.Location = new System.Drawing.Point(18, 80);
            this.lblQ.Name = "lblQ";
            this.lblQ.Size = new System.Drawing.Size(520, 80);
            this.lblQ.TabIndex = 2;
            this.lblQ.Text = "Câu hỏi sẽ hiển thị ở đây";
            // 
            // btnA
            // 
            this.btnA.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnA.Location = new System.Drawing.Point(22, 180);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(240, 50);
            this.btnA.TabIndex = 3;
            this.btnA.Tag = "A";
            this.btnA.Text = "Đáp án A";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.Answer_Click);
            // 
            // btnB
            // 
            this.btnB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnB.Location = new System.Drawing.Point(300, 180);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(240, 50);
            this.btnB.TabIndex = 4;
            this.btnB.Tag = "B";
            this.btnB.Text = "Đáp án B";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.Answer_Click);
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnC.Location = new System.Drawing.Point(22, 250);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(240, 50);
            this.btnC.TabIndex = 5;
            this.btnC.Tag = "C";
            this.btnC.Text = "Đáp án C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.Answer_Click);
            // 
            // btnD
            // 
            this.btnD.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnD.Location = new System.Drawing.Point(300, 250);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(240, 50);
            this.btnD.TabIndex = 6;
            this.btnD.Tag = "D";
            this.btnD.Text = "Đáp án D";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.Answer_Click);
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblResult.ForeColor = System.Drawing.Color.DarkRed;
            this.lblResult.Location = new System.Drawing.Point(22, 320);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(518, 30);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "Kết quả: -";
            // 
            // QuizPlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 370);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.lblQ);
            this.Controls.Add(this.lblIndex);
            this.Controls.Add(this.lblState);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "QuizPlayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblIndex;
        private System.Windows.Forms.Label lblQ;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Label lblResult;
    }
}
