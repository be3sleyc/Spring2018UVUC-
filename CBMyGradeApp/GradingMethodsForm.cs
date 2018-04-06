//Name: Christian Beesley
//Class: INFO 1200
//Section: 001
//Professor: Crandall
//Date: 20180406
//Project #: 9A
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
    public partial class GradingMethodsForm : Form
    {
        // create const fields for category percentages and max scores
        // use doubles to avoid need to cast
        private const double PROJECT_MAX_SCORE = 50.0;
        private const double QUIZ_MAX_SCORE = 15.0;
        private const double EXAM_MAX_SCORE = 100.0;
        private const double PROJECT_PERCENT = .45;
        private const double QUIZ_PERCENT = .25;
        private const double EXAM_PERCENT = .30;

        // create backing fields for the numerical and letter grade
        private double _grade;
        private string _letter;

        public GradingMethodsForm()
        {
            InitializeComponent();
        }

        // create properies with read(get) and write(set) methods for the backing fields
        public double Grade
        {
            get { return _grade; }
            set { _grade = value; }
        }

        public string Letter
        {
            get { return _letter; }
            set { _letter = value; }
        }

        /// <summary>
        /// Validates user input and calculates a numerical and letter grade
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFindGrade_Click(object sender, EventArgs e)
        {
            // create int variables for each score
            int project1Score = 0, project2Score = 0, project3Score = 0;
            int quiz1Score = 0, quiz2Score = 0, quiz3Score = 0, quiz4Score = 0;
            int exam1Score = 0, exam2Score = 0;

            // create double variable for the final score
            double totalScore;

            // create string variable for letter grade
            string letterGrade;

            // validate all the assignment scores and calculate a total score and letter grade
            if (ValidateProjects(ref project1Score, ref project2Score, ref project3Score))
            {
                if (ValidateExams(ref exam1Score, ref exam2Score))
                {
                    if (ValidateQuizzes(ref quiz1Score, ref quiz2Score, ref quiz3Score, ref quiz4Score))
                    {
                        // calculate the total score
                        totalScore = CalculateGrade(project1Score, project2Score, project3Score,
                            quiz1Score, quiz2Score, quiz3Score, quiz4Score,
                            exam1Score, exam2Score);

                        // convert the total score to a letter grade
                        letterGrade = LetterGrade(totalScore);

                        this.Grade = totalScore;  // set this form’s Grade property
                        this.Letter = letterGrade;  // set this form’s Letter property
                        this.Close();  // close this form

                    }
                }
            }
        }

        /// <summary>
        /// Validate the project scores and let the user know if any errors are found
        /// </summary>
        /// <param name="project1"></param>
        /// <param name="project2"></param>
        /// <param name="project3"></param>
        /// <returns></returns>
        private bool ValidateProjects(ref int project1, ref int project2, ref int project3)
        {
            // validate project1 score is a valid int between 0 and the Max score
            if (int.TryParse(txtBoxProject1.Text, out project1) && (project1 > -1 && project1 <= PROJECT_MAX_SCORE))
            {
                // validate project2 score is a valid int between 0 and the Max score
                if (int.TryParse(txtBoxProject2.Text, out project2) && (project2 > -1 && project2 <= PROJECT_MAX_SCORE))
                {
                    // validate project3 score is a valid int between 0 and the Max score
                    if (int.TryParse(txtBoxProject3.Text, out project3) && (project3 > -1 && project3 <= PROJECT_MAX_SCORE))
                    {
                        return true;
                    }
                    else
                    {
                        // Show a message box explaining the error and then clear and refocus on the text box
                        MessageBox.Show($"Invalid score entered for Project 3.\nPlease correct the score for Project 3 to be a positive integer no larger then the maximum score({PROJECT_MAX_SCORE}).", "Input Error");
                        txtBoxProject3.Clear();
                        txtBoxProject3.Focus();
                    }
                }
                else
                {
                    // Show a message box explaining the error and then clear and refocus on the text box
                    MessageBox.Show($"Invalid score entered for Project 2.\nPlease correct the score for Project 2 to be a positive integer no larger then the maximum score({PROJECT_MAX_SCORE}).", "Input Error");
                    txtBoxProject2.Clear();
                    txtBoxProject2.Focus();
                }
            }
            else
            {
                // Show a message box explaining the error and then clear and refocus on the text box
                MessageBox.Show($"Invalid score entered for Project 1.\nPlease correct the score for Project 1 to be a positive integer no larger then the maximum score({PROJECT_MAX_SCORE}).", "Input Error");
                txtBoxProject1.Clear();
                txtBoxProject1.Focus();
            }

            return false;
        }

        /// <summary>
        /// validate the quiz scores and let the user know if any errors are found
        /// </summary>
        /// <param name="quiz1"></param>
        /// <param name="quiz2"></param>
        /// <param name="quiz3"></param>
        /// <param name="quiz4"></param>
        /// <returns></returns>
        private bool ValidateQuizzes(ref int quiz1, ref int quiz2, ref int quiz3, ref int quiz4)
        {
            // validate quiz1 score is a valid int between 0 and the Max score
            if (int.TryParse(txtBoxQuiz1.Text, out quiz1) && (quiz1 > -1 && quiz1 <= QUIZ_MAX_SCORE))
            {
                // validate quiz2 score is a valid int between 0 and the Max score
                if (int.TryParse(txtBoxQuiz2.Text, out quiz2) && (quiz2 > -1 && quiz2 <= QUIZ_MAX_SCORE))
                {
                    // validate quiz3 score is a valid int between 0 and the Max score
                    if (int.TryParse(txtBoxQuiz3.Text, out quiz3) && (quiz3 > -1 && quiz3 <= QUIZ_MAX_SCORE))
                    {
                        // validate quiz4 score is a valid int between 0 and the Max score
                        if (int.TryParse(txtBoxQuiz4.Text, out quiz4) && (quiz4 > -1 && quiz4 <= QUIZ_MAX_SCORE))
                        {
                            return true;
                        }
                        else
                        {
                            // Show a message box explaining the error and then clear and refocus on the text box
                            MessageBox.Show($"Invalid score entered for Quiz 4.\nPlease correct the score for Quiz 4 to be a positive integer no larger then the maximum score({QUIZ_MAX_SCORE}).", "Input Error");
                            txtBoxQuiz4.Clear();
                            txtBoxQuiz4.Focus();
                        }
                    }
                    else
                    {
                        // Show a message box explaining the error and then clear and refocus on the text box
                        MessageBox.Show($"Invalid score entered for Quiz 3.\nPlease correct the score for Quiz 3 to be a positive integer no larger then the maximum score({QUIZ_MAX_SCORE}).", "Input Error");
                        txtBoxQuiz3.Clear();
                        txtBoxQuiz3.Focus();
                    }
                }
                else
                {
                    // Show a message box explaining the error and then clear and refocus on the text box
                    MessageBox.Show($"Invalid score entered for Quiz 2.\nPlease correct the score for Quiz 2 to be a positive integer no larger then the maximum score({QUIZ_MAX_SCORE}).", "Input Error");
                    txtBoxQuiz2.Clear();
                    txtBoxQuiz2.Focus();
                }
            }
            else
            {
                // Show a message box explaining the error and then clear and refocus on the text box
                MessageBox.Show($"Invalid score entered for Quiz 1.\nPlease correct the score for Quiz 1 to be a positive integer no larger then the maximum score.({QUIZ_MAX_SCORE})", "Input Error");
                txtBoxQuiz1.Clear();
                txtBoxQuiz1.Focus();
            }

            return false;
        }

        /// <summary>
        /// validate the exam scores and lets the user know if any errors were found
        /// </summary>
        /// <param name="exam1"></param>
        /// <param name="exam2"></param>
        /// <param name="exam3"></param>
        /// <returns></returns>        
        private bool ValidateExams(ref int exam1, ref int exam2)
        {
            // validate exam1 score is a valid int between 0 and the Max score
            if (int.TryParse(txtBoxExam1.Text, out exam1) && (exam1 > -1 && exam1 <= EXAM_MAX_SCORE))
            {
                // validate exam2 score is a valid int between 0 and the Max score
                if (int.TryParse(txtBoxExam2.Text, out exam2) && (exam2 > -1 && exam2 <= EXAM_MAX_SCORE))
                {
                    return true;
                }
                else
                {
                    // Show a message box explaining the error and then clear and refocus on the text box
                    MessageBox.Show($"Invalid score entered for Exam 2.\nPlease correct the score for Exam 2 to be a positive integer no larger then the maximum score({EXAM_MAX_SCORE}).", "Input Error");
                    txtBoxExam2.Clear();
                    txtBoxExam2.Focus();
                }
            }
            else
            {
                // Show a message box explaining the error and then clear and refocus on the text box
                MessageBox.Show($"Invalid score entered for Exam 1.\nPlease correct the score for Exam 1 to be a positive integer no larger then the maximum score({EXAM_MAX_SCORE}).", "Input Error");
                txtBoxExam1.Clear();
                txtBoxExam1.Focus();
            }

            return false;
        }

        /// <summary>
        /// Returns the calculated weighted grade using the assignment scores
        /// </summary>
        /// <param name="project1"></param>
        /// <param name="project2"></param>
        /// <param name="project3"></param>
        /// <param name="quiz1"></param>
        /// <param name="quiz2"></param>
        /// <param name="quiz3"></param>
        /// <param name="quiz4"></param>
        /// <param name="exam1"></param>
        /// <param name="exam2"></param>
        /// <returns></returns>
        private double CalculateGrade(int project1, int project2, int project3, int quiz1, int quiz2, int quiz3, int quiz4, int exam1, int exam2)
        {
            // declare double variables to keep track of assignment categories and to store the grade
            double projectsCat, quizzesCat, examsCat;
            double grade;

            // create in variable to count the total quantity of each assignment
            double totalProjects = 3.0;
            double totalQuizzes = 4.0;
            double totalExams = 2.0;

            // get the categorical averages 
            projectsCat = (project1 / PROJECT_MAX_SCORE + project2 / PROJECT_MAX_SCORE + project3 / PROJECT_MAX_SCORE) / totalProjects;
            quizzesCat = (quiz1 / QUIZ_MAX_SCORE + quiz2 / QUIZ_MAX_SCORE + quiz3 / QUIZ_MAX_SCORE + quiz4 / QUIZ_MAX_SCORE) / totalQuizzes;
            examsCat = (exam1 / EXAM_MAX_SCORE + exam2 / EXAM_MAX_SCORE) / totalExams;

            // calculate the total grade by summing the multiplication of the categorical averages with their weights
            grade = projectsCat * PROJECT_PERCENT + quizzesCat * QUIZ_PERCENT + examsCat * EXAM_PERCENT;

            // return the grade
            return grade;
        }

        /// <summary>
        /// return the calculated letter grade using the final grade
        /// </summary>
        /// <param name="finalGrade"></param>
        /// <returns></returns>
        private string LetterGrade(double finalGrade)
        {
            // declare a string variable to store the final letter grade
            string letterGrade;

            // calculate letter grade using class syllabus information and final grade
            letterGrade = (finalGrade >= 0.94) ? "A" : // 94 +	A
                (finalGrade >= 0.90) ? "A-" :          // 90-93	A-
                (finalGrade >= 0.87) ? "B+" :          // 87-89	B+
                (finalGrade >= 0.83) ? "B" :           // 83-86	B
                (finalGrade >= 0.80) ? "B-" :          // 80-82	B-
                (finalGrade >= 0.77) ? "C+" :          // 77-79	C+
                (finalGrade >= 0.73) ? "C" :           // 73-76	C
                (finalGrade >= 0.70) ? "C-" :          // 70-72 C-
                (finalGrade >= 0.67) ? "D+" :          // 67-69 D+
                (finalGrade >= 0.63) ? "D" :           // 63-66 D
                (finalGrade >= 0.60) ? "D-" :          // 60-62 D-
                "E";                                   // - 60  E

            // return the letter grade
            return letterGrade;
        }
    }
}
