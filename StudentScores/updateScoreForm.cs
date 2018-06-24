using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentScores {
    public partial class updateScoreForm : Form {

        private string grade;                       //string to store grade we're updating

        public updateScoreForm(string grade) {          //receives grade from Form3
            this.grade = grade;                             //sets grade as the class instance grade
            InitializeComponent();
            updateScore.Text = this.grade;                  //sets updateScore.Text as currently selected grade
        }

        public string GetNewGrade() {       //getter for grade
            return grade;                       //returns grade
        }

        private void button1_Click(object sender, EventArgs e) {        //update button
            if (!String.IsNullOrEmpty(updateScore.Text)) {                      //if updateScore.Text isn't blank
                if (Double.TryParse(updateScore.Text, out double score)) {             //if updateScore.Text is a valid double
                    if (score >= 0 && score <= 100) {                               //if updateScore.Text is between 0 and 100
                        grade = updateScore.Text;                                          //set grade as updateScore.Text
                        this.Close();                                                   //close form
                    } else {                                                        //error if not between 0 and 100
                        MessageBox.Show("Please enter a number between 0 and 100.");
                    }
                } else {                                                        //error if not an int
                    MessageBox.Show("Please enter a number between 0 and 100.");
                }
            } else {                                                        //error if empty
                MessageBox.Show("Please enter a number or hit cancel.");
            }
        }

        private void button2_Click(object sender, EventArgs e) {        //cancel button
            this.Close();                                                   //closes form
        }

    }
}
