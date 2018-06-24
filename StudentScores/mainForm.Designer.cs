namespace StudentScores {
    partial class mainForm {
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
            this.addBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.scoreTotal = new System.Windows.Forms.TextBox();
            this.scoreCount = new System.Windows.Forms.TextBox();
            this.scoreAverage = new System.Windows.Forms.TextBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.studentsLbl = new System.Windows.Forms.Label();
            this.scoreTotalLbl = new System.Windows.Forms.Label();
            this.scoreCountLbl = new System.Windows.Forms.Label();
            this.scoreAverageLbl = new System.Windows.Forms.Label();
            this.displayBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(234, 34);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(90, 21);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "Add new...";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitBtn.Location = new System.Drawing.Point(234, 214);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(90, 20);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // scoreTotal
            // 
            this.scoreTotal.Location = new System.Drawing.Point(182, 162);
            this.scoreTotal.Name = "scoreTotal";
            this.scoreTotal.ReadOnly = true;
            this.scoreTotal.Size = new System.Drawing.Size(46, 20);
            this.scoreTotal.TabIndex = 7;
            this.scoreTotal.TabStop = false;
            // 
            // scoreCount
            // 
            this.scoreCount.Location = new System.Drawing.Point(182, 188);
            this.scoreCount.Name = "scoreCount";
            this.scoreCount.ReadOnly = true;
            this.scoreCount.Size = new System.Drawing.Size(46, 20);
            this.scoreCount.TabIndex = 9;
            this.scoreCount.TabStop = false;
            // 
            // scoreAverage
            // 
            this.scoreAverage.Location = new System.Drawing.Point(182, 214);
            this.scoreAverage.Name = "scoreAverage";
            this.scoreAverage.ReadOnly = true;
            this.scoreAverage.Size = new System.Drawing.Size(46, 20);
            this.scoreAverage.TabIndex = 11;
            this.scoreAverage.TabStop = false;
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(234, 61);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(90, 20);
            this.updateBtn.TabIndex = 12;
            this.updateBtn.Text = "Update...";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(234, 87);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(90, 20);
            this.deleteBtn.TabIndex = 13;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBTN_Click);
            // 
            // studentsLbl
            // 
            this.studentsLbl.Location = new System.Drawing.Point(9, 9);
            this.studentsLbl.Name = "studentsLbl";
            this.studentsLbl.Size = new System.Drawing.Size(59, 20);
            this.studentsLbl.TabIndex = 20;
            this.studentsLbl.Text = "Students:";
            this.studentsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // scoreTotalLbl
            // 
            this.scoreTotalLbl.Location = new System.Drawing.Point(102, 161);
            this.scoreTotalLbl.Name = "scoreTotalLbl";
            this.scoreTotalLbl.Size = new System.Drawing.Size(74, 20);
            this.scoreTotalLbl.TabIndex = 21;
            this.scoreTotalLbl.Text = "Score total:";
            this.scoreTotalLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // scoreCountLbl
            // 
            this.scoreCountLbl.Location = new System.Drawing.Point(102, 187);
            this.scoreCountLbl.Name = "scoreCountLbl";
            this.scoreCountLbl.Size = new System.Drawing.Size(74, 20);
            this.scoreCountLbl.TabIndex = 22;
            this.scoreCountLbl.Text = "Score count:";
            this.scoreCountLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // scoreAverageLbl
            // 
            this.scoreAverageLbl.Location = new System.Drawing.Point(102, 213);
            this.scoreAverageLbl.Name = "scoreAverageLbl";
            this.scoreAverageLbl.Size = new System.Drawing.Size(74, 20);
            this.scoreAverageLbl.TabIndex = 23;
            this.scoreAverageLbl.Text = "Average:";
            this.scoreAverageLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // displayBox
            // 
            this.displayBox.FormattingEnabled = true;
            this.displayBox.Location = new System.Drawing.Point(12, 34);
            this.displayBox.Name = "displayBox";
            this.displayBox.Size = new System.Drawing.Size(216, 121);
            this.displayBox.TabIndex = 25;
            this.displayBox.SelectedIndexChanged += new System.EventHandler(this.displayBox_SelectedIndexChanged);
            // 
            // mainForm
            // 
            this.AcceptButton = this.addBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitBtn;
            this.ClientSize = new System.Drawing.Size(331, 244);
            this.Controls.Add(this.displayBox);
            this.Controls.Add(this.scoreAverageLbl);
            this.Controls.Add(this.scoreCountLbl);
            this.Controls.Add(this.scoreTotalLbl);
            this.Controls.Add(this.studentsLbl);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.scoreAverage);
            this.Controls.Add(this.scoreCount);
            this.Controls.Add(this.scoreTotal);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.addBtn);
            this.Name = "mainForm";
            this.Text = "Student Scores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.TextBox scoreCount;
        private System.Windows.Forms.TextBox scoreAverage;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Label studentsLbl;
        private System.Windows.Forms.Label scoreTotalLbl;
        private System.Windows.Forms.Label scoreCountLbl;
        private System.Windows.Forms.Label scoreAverageLbl;
        private System.Windows.Forms.TextBox scoreTotal;
        private System.Windows.Forms.ListBox displayBox;
    }
}

