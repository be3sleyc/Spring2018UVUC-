//Name: Christian Beesley
//Class: INFO 1200
//Section: 001
//Professor: Crandall
//Date: 20180222
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
    public partial class ScoringMethodsForm : Form
    {
        // field constant varaiables for category weights used for calculating the weighted score
        private const double PROJECT_W = 0.45;
        private const double EXAM_W = 0.3;
        private const double ASSIGNMENT_W = 0.25;

        public ScoringMethodsForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Calculates the weighted and cumulative score
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Calculate_Click(object sender, EventArgs e)
        {
            try // prepare to catch any input errors
            {
                // declare variables for the 2 project scores and the project max score value
                int scoreProject1, scoreProject2, scoreMaxProject1, scoreMaxProject2;

                // initialize the project 1 & 2 score and max score variables
                scoreProject1 = int.Parse(txtBoxProject1.Text);
                scoreProject2 = int.Parse(txtBoxProject2.Text);
                scoreMaxProject1 = int.Parse(lblProject1MaxScore.Text);
                scoreMaxProject2 = int.Parse(lblProject2MaxScore.Text);

                // declare variables for the 2 exam scores and the exam max score value
                int scoreExam1, scoreExam2, scoreMaxExam1, scoreMaxExam2;

                // initialize the Exam 1 & 2 score and max score variable
                scoreExam1 = int.Parse(txtBoxExam1.Text);
                scoreExam2 = int.Parse(txtBoxExam2.Text);
                scoreMaxExam1 = int.Parse(lblExam1MaxScore.Text);
                scoreMaxExam2 = int.Parse(lblExam2MaxScore.Text);

                // declare variables for the 2 assignment scores and the assignment max score value
                int scoreAssignment1, scoreAssignment2, scoreMaxAssignment1, scoreMaxAssignment2;

                // initialize the Assignment 1 & 2 score and max score variable
                scoreAssignment1 = int.Parse(txtBoxAssignment1.Text);
                scoreAssignment2 = int.Parse(txtBoxAssignment2.Text);
                scoreMaxAssignment1 = int.Parse(lblAssignment1MaxScore.Text);
                scoreMaxAssignment2 = int.Parse(lblAssignment2MaxScore.Text);

                // declare variables for the intermediate steps of the weighted calculations
                int categoryCount = 2;
                double categoryProjectAvg, categoryExamAvg, categoryAssignmentAvg;

                // declare variables for the intermediate step of the cumulative calculations
                double sumMaxScores, sumUserScores;

                // declare variables for the weighted and cumulative scores
                double weightedScore, cumulativeScore;

                // calculate the weighted score by summing the category averages times the category weights
                // calculate the average percent scored for Projects
                categoryProjectAvg = (((double)scoreProject1 / (double)scoreMaxProject1) + ((double)scoreProject2 / (double)scoreMaxProject2)) / (double)categoryCount;
                
                // calculate the average percent scored for Exams
                categoryExamAvg = (((double)scoreExam1 / (double)scoreMaxExam1) + ((double)scoreExam2 / (double)scoreMaxExam2)) / (double)categoryCount;

                // calculate the average percent scored for Assignments
                categoryAssignmentAvg = (((double)scoreAssignment1 / (double)scoreMaxAssignment1) + ((double)scoreAssignment2 / (double)scoreMaxAssignment2)) / (double)categoryCount;

                // multiply the category averages by their weights and then sum them all together
                weightedScore = categoryProjectAvg * PROJECT_W + categoryExamAvg * EXAM_W + categoryAssignmentAvg * ASSIGNMENT_W;

                // calculate the cumulative score by dividing the sum total user score and sum total max score
                // sum together all the user scores
                sumUserScores = scoreProject1 + scoreProject2 + scoreExam1 + scoreExam2 + scoreAssignment1 + scoreAssignment2;
                
                // sum together all the max scores
                sumMaxScores = scoreMaxProject1 + scoreMaxProject2 + scoreMaxExam1 + scoreMaxExam2 + scoreMaxAssignment1 + scoreMaxAssignment2;
                
                // divide the total user scores by the total max scores
                cumulativeScore = sumUserScores / sumMaxScores;

                // display the calculated scores
                lblWeighted.Text = weightedScore.ToString("p3");
                lblCumulative.Text = cumulativeScore.ToString("p3");
            }
            catch (Exception) // Display an error message if an error occured and reset the txtbox controls
            {
                // display an error message
                MessageBox.Show("Invalid Input:\n\tPlease submit an integer", "Input Error");

                // clear the 2 project text boxes
                txtBoxProject1.Clear();
                txtBoxProject2.Clear();

                // clear the 2 exam text boxes
                txtBoxExam1.Clear();
                txtBoxExam2.Clear();

                // clear the 2 assignment text boxes
                txtBoxAssignment1.Clear();
                txtBoxAssignment2.Clear();

                // give back focus
                txtBoxProject1.Focus();
            }
        }

        /// <summary>
        /// Clears the form's text boxes and calculated score labels nd returns focus to the first (project 1) text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            // clear the 2 project text boxes
            txtBoxProject1.Clear();
            txtBoxProject2.Clear();

            // clear the 2 exam text boxes
            txtBoxExam1.Clear();
            txtBoxExam2.Clear();

            // clear the 2 assignment text boxes
            txtBoxAssignment1.Clear();
            txtBoxAssignment2.Clear();

            // clear the 2 calculated score labels
            lblWeighted.Text = "";
            lblCumulative.Text = "";

            // give back focus
            txtBoxProject1.Focus();
        }

        /// <summary>
        /// Closes the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
    }
}
