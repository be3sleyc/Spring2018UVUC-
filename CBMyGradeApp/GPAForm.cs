//Name: Christian Beesley
//Class: INFO 1200
//Section: 001
//Professor: Crandall
//Date: 20180421
//Project #: 10A
//I declare that the source code contained in this assignment was written solely by me.
//I understand that copying any source code, in whole or in part,
// constitutes cheating, and that I will receive a zero on this project
// if I am found in violation of this policy.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CBMyGradeApp
{
    public partial class GPAForm : Form
    {
        // create a field constant for the maximum array size
        private const int COURSE_MAX = 50;

        // create fields to hold the currentFileName and an array of strings
        private string currentFileName;
        private string[] letterGrades;

        public GPAForm()
        {
            InitializeComponent();

            // intialize the currentfilename
            currentFileName = "courses.txt";

            // initialize the lettergrade array in the form constructor
            letterGrades = new string[COURSE_MAX];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GPAForm_Load(object sender, EventArgs e)
        {
            // create variables to hold the total courses count and the gpa
            int count = 0;
            double gpa;

            // create a stream reader object to read through the courses
            StreamReader courseReader;

            // prepare to catch any file operation errors
            try
            {
                // open the courses file to read
                courseReader = File.OpenText(currentFileName);

                // until the end of file is reached
                while(!courseReader.EndOfStream)
                {
                    // populate the letterGrades array using the SetLetterGrade method
                    SetLetterGrade(courseReader.ReadLine(), count);

                    // increment the count
                    count++;
                }

                // close the courses file
                courseReader.Close();

                // calculate the GPA and post it to the GPA label
                lblGPA.Text = CalculateGPA(count).ToString("F2");
            }
            catch (Exception)
            {
                // display an error Message
                MessageBox.Show("Could not read from file.\nPlease ensure you have the correct permissions and the file contains data before continuing.","File Error");
            }
            
        }

        /// <summary>
        /// Parses the grade from a course string and sets it to index i in letterGrades
        /// </summary>
        /// <param name="courseString"></param>
        /// <param name="index"></param>
        public void SetLetterGrade(string courseString, int i)
        {
            // split the course string to make getting the grade easier
            string[] input = courseString.Split(',');

            // set the letterGrade
            letterGrades[i] = input[4];
        }

        /// <summary>
        /// uses count and the sum of grades in letterGrades to get the total GPA
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public double CalculateGPA(int count)
        {
            // declare a variable to hold the gpa
            double gpa = 0.0;

            // for each letter grade in the letter grades array
            foreach (string  grade in letterGrades)
            {
                // associate the letter grade with a point value and sum them together
                gpa += grade == "A" ? 4.0 : 
                    grade == "A-" ? 3.7 :      //			A  	4.0	A- 	3.7
                    grade == "B+" ? 3.3 :      //B+	3.3	B	3.0	B-	2.7
                    grade == "B" ? 3.0 :       //C+	2.3	C	2.0	C-	1.7
                    grade == "B-" ? 2.7 :      //D+	1.3	D	1.0	D-	0.7
                    grade == "C+" ? 2.3 :      //E     0
                    grade == "C" ? 2.0 :
                    grade == "C-" ? 1.7 :
                    grade == "D+" ? 1.3 :
                    grade == "D" ? 1.0 :
                    grade == "D-" ? 0.7 :
                    0.0;
            }

            // divide gpa (the grade point total) by the count to get the grade point average
            gpa /= count;

            // return the gpa
            return gpa;
        }

        /// <summary>
        /// closes the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            // close the form
            this.Close();
        }
    }
}
