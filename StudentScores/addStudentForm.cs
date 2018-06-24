using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StudentScores {
    public partial class addStudentForm : Form {

        private string student;            //string to store student string
        private string name;                    //string to store student name

        public addStudentForm() {
            InitializeComponent();
        }

        public string GetAddStudent() {                         //getter for student string
            return student;                                         //returns student string
        }

        private void button1_Click(object sender, EventArgs e) {             //add button    (could definitely be better)
            if (String.IsNullOrEmpty(nameBox.Text)) {                           //if the nameBox is empty
                MessageBox.Show("Please enter a name");                             //display error message
            } else {                                                            //if the namebBox isn't empty
                if (String.IsNullOrEmpty(student)) {                                //if the student string is empty
                    student = nameBox.Text;                                             //add name to student string
                    name = nameBox.Text;                                                //store name as string name    
                }
            }
            if (Double.TryParse(scoreBox.Text, out double score)) {                //if scoreBox.Text is a valid double
                if (score >= 0 && score <= 100) {                                   //between 0 and 100
                    student += " | " + scoreBox.Text;                                   //add score to student string 
                    if (String.IsNullOrEmpty(scoresOutput.Text)) {                          //if scoreoutput is empty
                        scoresOutput.Text = scoreBox.Text;                              //add scorebox text
                    } else if (!String.IsNullOrEmpty(scoresOutput.Text)) {                  //if scoureput is not empty
                        scoresOutput.Text = scoresOutput.Text + " | " + scoreBox.Text;  //append scores from scorebox text
                    }
                } else {                                                            //error if not between 0 and 100
                    MessageBox.Show("Please enter a number between 0 and 100.");
                }
            } else {                                                                //error if not a double
                MessageBox.Show("No score entered, but the name has been saved.");
            }
            if (!name.Equals(nameBox.Text)) {                                   //if string name doesn't match the namebox
                student = nameBox.Text + " | " + scoresOutput.Text;                 //recreate the student string with the new name
            }
        }

        private void button2_Click(object sender, EventArgs e) {        //clear button
            scoresOutput.Text = "";                                         //set scoreoutput to blank
            student = "";                                                   //set student string to blank
        }

        private void button4_Click(object sender, EventArgs e) {        //okay button
            this.Close();                                                   //close form
            if (String.IsNullOrEmpty(student)) {                            //if the student string is blank
                if (!String.IsNullOrEmpty(nameBox.Text)) {                       //if the nameBox has an entry
                    student = nameBox.Text;                                         //add nameBox.Text to student
                    MessageBox.Show("No score entered, but the name has been saved.");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e) {        //cancel button
            this.Close();                                                   //close form on cancel click
        }



    }
}

