namespace StudentScores {
    partial class addStudentForm {
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
            this.scoreBox = new System.Windows.Forms.TextBox();
            this.scoresOutput = new System.Windows.Forms.TextBox();
            this.addScoreBtn = new System.Windows.Forms.Button();
            this.clearScoreBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.acceptBtn = new System.Windows.Forms.Button();
            this.nameLbl = new System.Windows.Forms.Label();
            this.scoreLbl = new System.Windows.Forms.Label();
            this.scoresLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(58, 12);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(201, 20);
            this.nameBox.TabIndex = 4;
            // 
            // scoreBox
            // 
            this.scoreBox.Location = new System.Drawing.Point(58, 38);
            this.scoreBox.Name = "scoreBox";
            this.scoreBox.Size = new System.Drawing.Size(110, 20);
            this.scoreBox.TabIndex = 5;
            // 
            // scoresOutput
            // 
            this.scoresOutput.Location = new System.Drawing.Point(58, 64);
            this.scoresOutput.Name = "scoresOutput";
            this.scoresOutput.ReadOnly = true;
            this.scoresOutput.Size = new System.Drawing.Size(201, 20);
            this.scoresOutput.TabIndex = 6;
            this.scoresOutput.TabStop = false;
            // 
            // addScoreBtn
            // 
            this.addScoreBtn.Location = new System.Drawing.Point(174, 38);
            this.addScoreBtn.Name = "addScoreBtn";
            this.addScoreBtn.Size = new System.Drawing.Size(85, 20);
            this.addScoreBtn.TabIndex = 7;
            this.addScoreBtn.Text = "Add Score";
            this.addScoreBtn.UseVisualStyleBackColor = true;
            this.addScoreBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // clearScoreBtn
            // 
            this.clearScoreBtn.Location = new System.Drawing.Point(174, 90);
            this.clearScoreBtn.Name = "clearScoreBtn";
            this.clearScoreBtn.Size = new System.Drawing.Size(85, 20);
            this.clearScoreBtn.TabIndex = 8;
            this.clearScoreBtn.Text = "Clear Scores";
            this.clearScoreBtn.UseVisualStyleBackColor = true;
            this.clearScoreBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(174, 116);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(85, 20);
            this.cancelBtn.TabIndex = 9;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // acceptBtn
            // 
            this.acceptBtn.Location = new System.Drawing.Point(83, 116);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(85, 20);
            this.acceptBtn.TabIndex = 10;
            this.acceptBtn.Text = "OK";
            this.acceptBtn.UseVisualStyleBackColor = true;
            this.acceptBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // nameLbl
            // 
            this.nameLbl.Location = new System.Drawing.Point(5, 11);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(47, 20);
            this.nameLbl.TabIndex = 18;
            this.nameLbl.Text = "Name:";
            this.nameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // scoreLbl
            // 
            this.scoreLbl.Location = new System.Drawing.Point(5, 37);
            this.scoreLbl.Name = "scoreLbl";
            this.scoreLbl.Size = new System.Drawing.Size(47, 20);
            this.scoreLbl.TabIndex = 19;
            this.scoreLbl.Text = "Score:";
            this.scoreLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // scoresLbl
            // 
            this.scoresLbl.Location = new System.Drawing.Point(5, 63);
            this.scoresLbl.Name = "scoresLbl";
            this.scoresLbl.Size = new System.Drawing.Size(47, 20);
            this.scoresLbl.TabIndex = 20;
            this.scoresLbl.Text = "Scores:";
            this.scoresLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // addStudentForm
            // 
            this.AcceptButton = this.acceptBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(273, 149);
            this.ControlBox = false;
            this.Controls.Add(this.scoresLbl);
            this.Controls.Add(this.scoreLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.acceptBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.clearScoreBtn);
            this.Controls.Add(this.addScoreBtn);
            this.Controls.Add(this.scoresOutput);
            this.Controls.Add(this.scoreBox);
            this.Controls.Add(this.nameBox);
            this.Name = "addStudentForm";
            this.Text = "Add New Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox scoreBox;
        private System.Windows.Forms.TextBox scoresOutput;
        private System.Windows.Forms.Button addScoreBtn;
        private System.Windows.Forms.Button clearScoreBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button acceptBtn;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label scoreLbl;
        private System.Windows.Forms.Label scoresLbl;
    }
}