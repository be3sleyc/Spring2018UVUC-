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
    public partial class AddCourseForm : Form
    {

        // create a private string field to fold the current filename
        private string currentFileName;

        public AddCourseForm()
        {
            InitializeComponent();

            // initialize currentFileName in the Form Constructor
            currentFileName = "courses.txt";
        }

        /// <summary>
        /// Before the form opens, read courses from the currentFileName
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCourseForm_Load(object sender, EventArgs e)
        {
            // create a stream reader
            StreamReader courseReader;

            // clear the courses list box
            lstBoxCourses.Items.Clear();

            // prepare to catch any file errors
            try
            {
                // open the courses file
                courseReader = File.OpenText(currentFileName);

                // until we reach the end of file
                while (!courseReader.EndOfStream)
                {
                    // add line of information to the courses list box
                    lstBoxCourses.Items.Add(courseReader.ReadLine());
                }

                // close the streamreader
                courseReader.Close();

            }
            catch (Exception)
            {
                // display an error message
                MessageBox.Show("File Error!", "No course information found in course file.\nPlease record some course information.");
            }
        }

        /// <summary>
        /// If user input for Course Name, Semester and Instructor are valid,
        /// create a grading methods form to get the numerical and letter grades for the course
        /// Clear all textbox controls when finished.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            // create an instance of the course object
            Course course = new Course();
            if (ValidateCourse(course))
            {
                GradingMethodsForm gradingMethods = new GradingMethodsForm();
                gradingMethods.ShowDialog();

                // set Course Grade property from GradingMethods Grade property
                course.Grade = gradingMethods.Grade;
                // set Course LetterGrade property from GradingMethods Letter property
                course.LetterGrade = gradingMethods.Letter;

                // add course object to the course ListBox as a string
                lstBoxCourses.Items.Add(course.ToString());

                // Display a MessageBox message stating "Course input was valid"
                MessageBox.Show("Course input was valid", "Adding Course");

                // clear all the addcourseform controls
                txtBoxCourseName.Clear();
                txtBoxSemester.Clear();
                txtBoxInstructor.Clear();

            }
        }

        /// <summary>
        /// Ensure the user put something in the course name, semester and instructor text boxes
        /// If true: set the new courses CourseName, Semester and Instructor properties with the user values
        /// Else: display an error message decribing the missing information, and refocus on that control
        /// </summary>
        /// <param name="course"></param>
        /// <returns></returns>
        private bool ValidateCourse(Course mycourse)
        {
            double tmp;

            // make sure the user put text in each of the text box controls
            if (txtBoxCourseName.Text != "" && !double.TryParse(txtBoxCourseName.Text, out tmp))
            {
                if (txtBoxSemester.Text != "" && !double.TryParse(txtBoxSemester.Text, out tmp))
                {
                    if (txtBoxInstructor.Text != "" && !double.TryParse(txtBoxInstructor.Text, out tmp))
                    {
                        // set the properties with the user input
                        mycourse.CourseName = txtBoxCourseName.Text;
                        mycourse.Semester = txtBoxSemester.Text;
                        mycourse.Instructor = txtBoxInstructor.Text;

                        return true;  // all input was given and properties are set
                    }
                    else
                    {
                        // show an error message for Instructor input
                        MessageBox.Show("Please provide an valid instructor name for the course.","Invalid Input");
                        txtBoxInstructor.Clear(); // clear the erroneous content
                        txtBoxInstructor.Focus(); // refocus on the erroneous control
                        return false;
                    }
                }
                else
                {
                    // show an error message for Semester input
                    MessageBox.Show("Please provide a valid semester for the course.", "Invalid Input");
                    txtBoxSemester.Clear(); // clear the erroneous content
                    txtBoxSemester.Focus(); // refocus on the erroneous control
                    return false;
                }
            }
            else
            {
                // show an error message for Course Name input
                MessageBox.Show("Please provide a valid name for the course.","Invalid Input");
                txtBoxCourseName.Clear(); // clear the erroneous content
                txtBoxCourseName.Focus(); // refocus on the erroneous control
                return false;
            }
            
        }

        /// <summary>
        /// Writes any new information and closes the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            // create a stream writer
            StreamWriter courseWriter;

            try
            {
                // open the courses file to overwrite any information
                courseWriter = File.CreateText(currentFileName);

                // for each course string in the listbox
                foreach (string course in lstBoxCourses.Items)
                {
                    // write the course informtion to file
                    courseWriter.WriteLine(course);
                }

                // close the stream writer
                courseWriter.Close();
            }
            catch (Exception)
            {
                // display an error message
                MessageBox.Show("File Error!", $"Could not write course information to {currentFileName}.\nEnsure you have the proper permissions and then resume.");
            }

            // close the form
            this.Close();
        }
    }
}
