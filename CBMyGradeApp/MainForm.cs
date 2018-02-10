//Name: Christian Beesley
//Class: INFO 1200
//Section: 001
//Professor: Crandall
//Date: 20180210
//Project #: 3A
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Displays a welcome message
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWelcome_Click(object sender, EventArgs e)
        {
            // summon messagebox and display a welcome message
            MessageBox.Show("Welcome to Project 3.A!", "Welcome!");
        }

        /// <summary>
        /// Close the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            // Close this
            this.Close();
        }

        /// <summary>
        /// directs the users focus to the student profile form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStudentProfile_Click(object sender, EventArgs e)
        {
            // calls the form’s constructor. Must match the form name exactly
            StudentProfileForm studentProfile = new StudentProfileForm();
            
            studentProfile.ShowDialog();    //  shows the form as a dialog
        }

        private void btnScoringMethods_Click(object sender, EventArgs e)
        {
            ScoringMethodsForm scoringMethods = new ScoringMethodsForm();
            // calls the form’s constructor. 
            // must match the form class name exactly
            scoringMethods.ShowDialog();    //  shows the form as a dialog
        }
    }
}
