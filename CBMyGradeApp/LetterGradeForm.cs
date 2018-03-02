//Name: Christian Beesley
//Class: INFO 1200
//Section: 001
//Professor: Crandall
//Date: 20180301
//Project #: 5A
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

namespace CBMyGradeApp
{
    public partial class LetterGradeForm : Form
    {
        // declare field constants for assignment Max scores and the Min score
        private const int MAX_PROJECT = 50, MAX_QUIZ = 15, MAX_EXAM = 100, MIN_SCORE = 0;

        public LetterGradeForm()
        {
            InitializeComponent();
        }

        private void btnFindLetterGrade_Click(object sender, EventArgs e)
        {
            // declare variables for Assignment scores
            int project1Score, quiz1Score, exam1Score;

            // declare variables for the percentage and letter grade
            double gradeTotal;
            string letterGrade;

            // validate the assignment scores in order: project, quiz, and exam
            // if neither the try parse succeeds nor the score is in the proper range, display the error message, clear the input text box, and refocus on it
            if (!(int.TryParse(txtBoxProject1Score.Text, out project1Score) && (project1Score <= MAX_PROJECT && project1Score >= MIN_SCORE)))
            {
                MessageBox.Show($"Please enter a valid grade between {MIN_SCORE} and {MAX_PROJECT}.", "Problem with Project 1 Score");
                txtBoxProject1Score.Clear();
                txtBoxProject1Score.Focus();
            }
            else if (!(int.TryParse(txtBoxQuiz1Score.Text, out quiz1Score) && (quiz1Score <= MAX_QUIZ && quiz1Score >= MIN_SCORE)))
            {
                MessageBox.Show($"Please enter a valid grade between {MIN_SCORE} and {MAX_QUIZ}.", "Problem with Quiz 1 Score");
                txtBoxQuiz1Score.Clear();
                txtBoxQuiz1Score.Focus();
            }
            else if (!(int.TryParse(txtBoxExam1Score.Text, out exam1Score) && (exam1Score <= MAX_EXAM && exam1Score >= MIN_SCORE)))
            {
                MessageBox.Show($"Please enter a valid grade between {MIN_SCORE} and {MAX_EXAM}.", "Problem with Exam 1 Score");
                txtBoxExam1Score.Clear();
                txtBoxExam1Score.Focus();
            }


        }

        /// <summary>
        /// Clear the Assignment textboxes and result label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            // clear the assignment score input text boxes
            txtBoxProject1Score.Clear();
            txtBoxQuiz1Score.Clear();
            txtBoxExam1Score.Clear();

            // clear the result label
            lblGradeReport.Text = "";
        }

        /// <summary>
        /// Close the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
