namespace ServerForm.Forms
{
    partial class RoomManagerForm
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
            this.btnCreateRoom = new System.Windows.Forms.Button();
            this.cmbQuizList = new System.Windows.Forms.ComboBox();
            this.txtRoomIdResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreateRoom
            // 
            this.btnCreateRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateRoom.Location = new System.Drawing.Point(570, 82);
            this.btnCreateRoom.Name = "btnCreateRoom";
            this.btnCreateRoom.Size = new System.Drawing.Size(120, 60);
            this.btnCreateRoom.TabIndex = 0;
            this.btnCreateRoom.Text = "Create Room";
            this.btnCreateRoom.UseVisualStyleBackColor = true;
            this.btnCreateRoom.Click += new System.EventHandler(this.btnCreateRoom_Click);
            // 
            // cmbQuizList
            // 
            this.cmbQuizList.FormattingEnabled = true;
            this.cmbQuizList.Location = new System.Drawing.Point(299, 125);
            this.cmbQuizList.Name = "cmbQuizList";
            this.cmbQuizList.Size = new System.Drawing.Size(121, 21);
            this.cmbQuizList.TabIndex = 1;
            // 
            // txtRoomIdResult
            // 
            this.txtRoomIdResult.Location = new System.Drawing.Point(76, 126);
            this.txtRoomIdResult.Name = "txtRoomIdResult";
            this.txtRoomIdResult.Size = new System.Drawing.Size(100, 20);
            this.txtRoomIdResult.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Room ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(295, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Choose quiz";
            // 
            // RoomManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRoomIdResult);
            this.Controls.Add(this.cmbQuizList);
            this.Controls.Add(this.btnCreateRoom);
            this.Name = "RoomManagerForm";
            this.Text = "RoomManagerForm";
            this.Load += new System.EventHandler(this.RoomManagerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateRoom;
        private System.Windows.Forms.ComboBox cmbQuizList;
        private System.Windows.Forms.TextBox txtRoomIdResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}