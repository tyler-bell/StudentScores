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
    public partial class addScoreForm : Form {

        private string grade;              //string to store grade we're adding

        public addScoreForm() {
            InitializeComponent();
        }

        public string GetNewGrade() {           //getter for grade
            return grade;                           //returns grade
        }

        private void button1_Click(object sender, EventArgs e) {        //okay button
            if (!String.IsNullOrEmpty(addScore.Text)) {                      //if addScore.Text isn't blank
                if (Double.TryParse(addScore.Text, out double score)) {             //if addScore.Text is a valid double
                    if (score >= 0 && score <= 100) {                               //if addScore.Text is between 0 and 100
                        grade = addScore.Text;                                          //set grade as addScore.Text
                        this.Close();                                                   //close form
                    } else {                                                        //error if not between 0 and 100
                        MessageBox.Show("Please enter a number between 0 and 100.");
                    }
                } else {                                                        //error if not a double
                    MessageBox.Show("Please enter a number between 0 and 100.");
                }
            } else {                                                        //error if empty
                MessageBox.Show("Please enter a number or hit cancel.");
            }
        }


        private void button2_Click(object sender, EventArgs e) {        //cancel button
            this.Close();                                                   //close form
        }

    }
}