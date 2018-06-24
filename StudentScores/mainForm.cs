using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentScores {
    public partial class mainForm : Form {

        private List<string> students = new List<string>();             //List of strings to store students
        private double total;                                               //double to display total of grades
        private double average;                                             //double to display average of grades
        private int count;                                                  //int to display count of grades

        public mainForm() {
            InitializeComponent();
            PopulateData();                                     //method to populate starting data
        }

        private void PopulateData() {                                           //method to populate data on program start
            students.Add("Tyler | 100 | 100 | 100");                                //adding students to list
            students.Add("Mike | 99.99 | 99.99 | 99.99");                           //adding students to list
            students.Add("Jordan | 99.98 | 99.98 | 99.98");                         //adding students to list
            UpdateListbox(students);                                                //updating displayBox
        }

        private void UpdateListbox(List<string> studs) {                        //update the listbox
            displayBox.Items.Clear();                                               //clear the listbox
            foreach (string temp in studs) {                                        //loop through students list
                displayBox.Items.Add(temp);                                             //display each string in the list
            }
            if (displayBox.Items.Count > 0) {                                       //if the displaybox has any items
                displayBox.SelectedIndex = 0;                                           //select the first one (prevents OOB exception on update/delete button)
            }

        }

        private void CalcMath() {                                                     //method to calculate total, count and average
            string temp = students[displayBox.SelectedIndex];                           //make a temp string from the student list based on the index
            temp = temp.Trim();                                                         //trim the temp string
            string[] tempArray = temp.Split('|');                                       //split the string into an array at each |
            for (int i = 1; i < tempArray.Length; i++) {                                //itterate through the array to get the total, count and average
                total += Double.Parse(tempArray[i]);                                         //store the values as double total
            }
            count = tempArray.Length - 1;                                               //count is equal to array length minus 1 (for name field)
            if (count > 0) {                                                            //if the count is greater than 0 (prevents dividing by 0)
                average = total / count;                                                    //average is total / count
                scoreTotal.Text = total.ToString("N2");                                     //scoreTotal text = total as string showing only 2 decimals
                scoreCount.Text = count.ToString();                                         //scoreCount text = count as string
                scoreAverage.Text = average.ToString("N2");                                 //scoreAverage text = average as string showing only 2 decimals
            } else {                                                                    //if count is 0, there's no grades 
                scoreTotal.Text = "n/a";                                                    //scoreTotal text = n/a
                scoreCount.Text = "n/a";                                                    //scoreCount text = n/a
                scoreAverage.Text = "n/a";                                                  //scoreAverage text = n/a
            }
            total = 0;                                                                  //reset total value
            average = 0;                                                                //reset average value
            count = 0;                                                                  //reset the count value
        }

        private void displayBox_SelectedIndexChanged(object sender, EventArgs e) {  //when the selected value of the displaybox changes
            if (displayBox.SelectedIndex >= 0) {                                        //if there is a selected displaybox item
                CalcMath();                                                               //call the CalcMath 
            }
        }

        private void button1_Click(object sender, EventArgs e) {                //add new form
            addStudentForm f2 = new addStudentForm();                               //create addStudentForm object named f2
            f2.ShowDialog();                                                        //show f2
            if (!String.IsNullOrEmpty(f2.GetAddStudent())) {                        //if the GetAddStudent doesn't return null
                students.Add(f2.GetAddStudent());                                       //add the GetAddStudent return to the list
                UpdateListbox(students);                                                //update displaybox
            }

        }

        private void button2_Click(object sender, EventArgs e) {                //update form
            if (displayBox.SelectedIndex >= 0) {                                    //if the displaybox has a selected value
                updateStudentScoreForm f3 = new updateStudentScoreForm(students[displayBox.SelectedIndex]);  //create Form3 object as f3 passing a student string
                f3.ShowDialog();                                                                     //show f3       
                if (!String.IsNullOrEmpty(f3.GetNewStudent())) {                                     //if the update returns a string
                    students[displayBox.SelectedIndex] = f3.GetNewStudent();                            //add the string at the correct index
                    UpdateListbox(students);                                                            //update displayBox
                }
            } else {                                                                //if the displaybox doesn't have a selected value
                MessageBox.Show("Please choose a student from the list.");              //error message
            }

        }

        private void deleteBTN_Click(object sender, EventArgs e) {      //delete button
            if (displayBox.SelectedIndex >= 0) {                            //if the displaybox has a selected value
                students.RemoveAt(displayBox.SelectedIndex);                    //remove the value from the students list based on the displaybox index
                UpdateListbox(students);                                        //update the displaybox
            } else {                                                        //if the displaybox doesn't have a selected value
                MessageBox.Show("Please choose a student from the list.");      //error message
            }
            if (displayBox.Items.Count > 0) {                               //if the displaybox has any items
                displayBox.SelectedIndex = 0;                                   //select the first one (prevents OOB exception on update/delete button)
            } else {                                                        //if the displaybox has no items
                scoreTotal.Text = "";                                           //set the textboxs to blank
                scoreCount.Text = "";                                           //set the textboxs to blank
                scoreAverage.Text = "";                                         //set the textboxs to blank
            }
        }

        private void button4_Click(object sender, EventArgs e) {                //exit button
            this.Close();                                                           //close form
        }

    }
}
