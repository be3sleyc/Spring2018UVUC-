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
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {

        }
    }
}
