namespace StudentScores {
    partial class updateStudentScoreForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.nameBox = new System.Windows.Forms.TextBox();
            this.addScoreBtn = new System.Windows.Forms.Button();
            this.updateScoreBtn = new System.Windows.Forms.Button();
            this.removeScoreBtn = new System.Windows.Forms.Button();
            this.clearScoresBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.acceptBtn = new System.Windows.Forms.Button();
            this.nameLbl = new System.Windows.Forms.Label();
            this.scoresLbl = new System.Windows.Forms.Label();
            this.scoreBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(55, 12);
            this.nameBox.Name = "nameBox";
            this.nameBox.ReadOnly = true;
            this.nameBox.Size = new System.Drawing.Size(201, 20);
            this.nameBox.TabIndex = 6;
            this.nameBox.TabStop = false;
            // 
            // addScoreBtn
            // 
            this.addScoreBtn.Location = new System.Drawing.Point(181, 38);
            this.addScoreBtn.Name = "addScoreBtn";
            this.addScoreBtn.Size = new System.Drawing.Size(75, 20);
            this.addScoreBtn.TabIndex = 9;
            this.addScoreBtn.Text = "Add";
            this.addScoreBtn.UseVisualStyleBackColor = true;
            this.addScoreBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // updateScoreBtn
            // 
            this.updateScoreBtn.Location = new System.Drawing.Point(181, 64);
            this.updateScoreBtn.Name = "updateScoreBtn";
            this.updateScoreBtn.Size = new System.Drawing.Size(75, 20);
            this.updateScoreBtn.TabIndex = 10;
            this.updateScoreBtn.Text = "Update";
            this.updateScoreBtn.UseVisualStyleBackColor = true;
            this.updateScoreBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // removeScoreBtn
            // 
            this.removeScoreBtn.Location = new System.Drawing.Point(181, 90);
            this.removeScoreBtn.Name = "removeScoreBtn";
            this.removeScoreBtn.Size = new System.Drawing.Size(75, 20);
            this.removeScoreBtn.TabIndex = 11;
            this.removeScoreBtn.Text = "Remove";
            this.removeScoreBtn.UseVisualStyleBackColor = true;
            this.removeScoreBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // clearScoresBtn
            // 
            this.clearScoresBtn.Location = new System.Drawing.Point(181, 116);
            this.clearScoresBtn.Name = "clearScoresBtn";
            this.clearScoresBtn.Size = new System.Drawing.Size(75, 20);
            this.clearScoresBtn.TabIndex = 12;
            this.clearScoresBtn.Text = "Clear Scores";
            this.clearScoresBtn.UseVisualStyleBackColor = true;
            this.clearScoresBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(181, 159);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 20);
            this.cancelBtn.TabIndex = 13;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.button5_Click);
            // 
            // acceptBtn
            // 
            this.acceptBtn.Location = new System.Drawing.Point(100, 159);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(75, 20);
            this.acceptBtn.TabIndex = 14;
            this.acceptBtn.Text = "OK";
            this.acceptBtn.UseVisualStyleBackColor = true;
            this.acceptBtn.Click += new System.EventHandler(this.button6_Click);
            // 
            // nameLbl
            // 
            this.nameLbl.Location = new System.Drawing.Point(2, 9);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(47, 20);
            this.nameLbl.TabIndex = 17;
            this.nameLbl.Text = "Name:";
            this.nameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // scoresLbl
            // 
            this.scoresLbl.Location = new System.Drawing.Point(2, 38);
            this.scoresLbl.Name = "scoresLbl";
            this.scoresLbl.Size = new System.Drawing.Size(47, 20);
            this.scoresLbl.TabIndex = 18;
            this.scoresLbl.Text = "Scores:";
            this.scoresLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // scoreBox
            // 
            this.scoreBox.FormattingEnabled = true;
            this.scoreBox.Location = new System.Drawing.Point(55, 41);
            this.scoreBox.Name = "scoreBox";
            this.scoreBox.Size = new System.Drawing.Size(120, 95);
            this.scoreBox.TabIndex = 19;
            // 
            // updateStudentScoreForm
            // 
            this.AcceptButton = this.acceptBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(268, 191);
            this.ControlBox = false;
            this.Controls.Add(this.scoreBox);
            this.Controls.Add(this.scoresLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.acceptBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.clearScoresBtn);
            this.Controls.Add(this.removeScoreBtn);
            this.Controls.Add(this.updateScoreBtn);
            this.Controls.Add(this.addScoreBtn);
            this.Controls.Add(this.nameBox);
            this.Name = "updateStudentScoreForm";
            this.Text = "Update Student Scores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button addScoreBtn;
        private System.Windows.Forms.Button updateScoreBtn;
        private System.Windows.Forms.Button removeScoreBtn;
        private System.Windows.Forms.Button clearScoresBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button acceptBtn;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label scoresLbl;
        private System.Windows.Forms.ListBox scoreBox;
    }
}