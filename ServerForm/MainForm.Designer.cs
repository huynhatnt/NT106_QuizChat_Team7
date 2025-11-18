namespace ServerForm.Forms
{
    partial class MainForm
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
            this.btnQuizManager = new System.Windows.Forms.Button();
            this.btnRoomManager = new System.Windows.Forms.Button();
            this.btnMonitor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQuizManager
            // 
            this.btnQuizManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuizManager.Location = new System.Drawing.Point(112, 168);
            this.btnQuizManager.Name = "btnQuizManager";
            this.btnQuizManager.Size = new System.Drawing.Size(150, 80);
            this.btnQuizManager.TabIndex = 0;
            this.btnQuizManager.Text = "Quiz Manager";
            this.btnQuizManager.UseVisualStyleBackColor = true;
            this.btnQuizManager.Click += new System.EventHandler(this.btnQuizManager_Click);
            // 
            // btnRoomManager
            // 
            this.btnRoomManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomManager.Location = new System.Drawing.Point(316, 168);
            this.btnRoomManager.Name = "btnRoomManager";
            this.btnRoomManager.Size = new System.Drawing.Size(150, 80);
            this.btnRoomManager.TabIndex = 1;
            this.btnRoomManager.Text = "Room Manager";
            this.btnRoomManager.UseVisualStyleBackColor = true;
            this.btnRoomManager.Click += new System.EventHandler(this.btnRoomManager_Click);
            // 
            // btnMonitor
            // 
            this.btnMonitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonitor.Location = new System.Drawing.Point(518, 168);
            this.btnMonitor.Name = "btnMonitor";
            this.btnMonitor.Size = new System.Drawing.Size(150, 80);
            this.btnMonitor.TabIndex = 2;
            this.btnMonitor.Text = "Monitor";
            this.btnMonitor.UseVisualStyleBackColor = true;
            this.btnMonitor.Click += new System.EventHandler(this.btnMonitor_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMonitor);
            this.Controls.Add(this.btnRoomManager);
            this.Controls.Add(this.btnQuizManager);
            this.Name = "MainForm";
            this.Text = "Dashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuizManager;
        private System.Windows.Forms.Button btnRoomManager;
        private System.Windows.Forms.Button btnMonitor;
    }
}

