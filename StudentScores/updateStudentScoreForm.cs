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
    public partial class updateStudentScoreForm : Form {

        private string student;                     //string to store student string
        private string name;                        //string to store name
        private List<string> tempList;              //list of strings to display scores
        private string newStudent;             //string to store updatedStudent string

        public updateStudentScoreForm(string student) {
            this.student = student;             //set student string as class var student
            InitializeComponent();
            ConvertFromString(this.student);    //convert student sting to list
            UpdateScoreBox();                   //update scoreBox
        }

        public string GetNewStudent() {                 //getter for newStudent
            return newStudent;                              //returning newStudent
        }

        private void ConvertFromString(string temp) {               //method to convert string to list
            string[] tempArray = temp.Split('|');                   //splitting the string into a tempArray
            for (int i = 0; i < tempArray.Length; i++) {            //itterate through the array to remove white space
                string tempValue = tempArray[i];                        //store value as temp string
                tempValue = tempValue.Trim();                           //trim temp string
                tempArray[i] = tempValue;                               //replace the value in the array
            }
            name = tempArray[0];                                    //assign tempArray[0] to name to recover if they clear
            tempList = tempArray.ToList();                          //converting the tempArray to a list
        }

        private void ConvertToString() {                    //converting the list to a string
            newStudent = tempList[0];                           //first put the name in the string
            for (int i = 1; i < tempList.Count; i++) {          //itterate through the rest of the list
                newStudent += " | " + tempList[i];                 //append each score with | as divider
            }
        }

        private void UpdateScoreBox() {              //updating the scoreBox
            scoreBox.Items.Clear();                         //clear the listbox
            nameBox.Text = tempList[0];       //nameBox text = first value of list
            for (int i = 1; i < tempList.Count; i++) {      //itterate through the array to get the scores excluding the first value
                scoreBox.Items.Add(tempList[i]);                       //add each value to scoreBox
            }

        }

        private void button1_Click(object sender, EventArgs e) {        //add button
            addScoreForm f4 = new addScoreForm();                                         //create new Form4 as f4        
            f4.ShowDialog();                                                //show f4
            if (!String.IsNullOrEmpty(f4.GetNewGrade())){                   //if there is a new grade from f4
                tempList.Add(f4.GetNewGrade());                                 //add the grade to the tempList
            }
            UpdateScoreBox();                                               //update the scoreBox
        }

        private void button2_Click(object sender, EventArgs e) {                 //update button
            if (scoreBox.SelectedIndex >= 0) {                                       //if there is a score selected
                updateScoreForm f5 = new updateScoreForm(tempList[scoreBox.SelectedIndex + 1]);             //create f5 and pass the value
                f5.ShowDialog();                                                        //show f5
                if (!f5.GetNewGrade().Equals(tempList[scoreBox.SelectedIndex + 1])) {   //if the new grade is different
                    tempList[scoreBox.SelectedIndex + 1] = f5.GetNewGrade();                //update the tempList
                }
                UpdateScoreBox();                                                       //update the scoreBox
            } else {                                                                //if no score is selected
                MessageBox.Show("Please choose a score to update.");                    //show error
            }
        }

        private void button3_Click(object sender, EventArgs e) {     //remove button
            if (scoreBox.SelectedIndex >= 0) {                          //if the scorebox has a selected value
                tempList.RemoveAt(scoreBox.SelectedIndex + 1);                 //remove the value from the students list based on the displaybox index
                UpdateScoreBox();                                              //update the scorebox
            } else {                                                    //if no score is selected
                MessageBox.Show("Please choose a score to remove.");        //show error
            }
        }

        private void button4_Click(object sender, EventArgs e) {    //clear scores
            tempList.Clear();                                           //clear the tempList
            tempList.Add(name);                                         //add the name back to the list
            UpdateScoreBox();                                           //update the scorebox
        }

        private void button6_Click(object sender, EventArgs e) {        //okay button
            ConvertToString();                                              //convert the list to string
            this.Close();                                                   //close form
        }

        private void button5_Click(object sender, EventArgs e) {        //cancel button
            this.Close();                                                   //close form
        }
    }
}
