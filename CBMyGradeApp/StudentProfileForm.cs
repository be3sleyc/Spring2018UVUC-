//Name: Christian Beesley
//Class: INFO 1200
//Section: 001
//Professor: Crandall
//Date: 20180202
//Project #: 2A
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
    public partial class StudentProfileForm : Form
    {
        public StudentProfileForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Closes this form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCloseStudentProfForm_Click(object sender, EventArgs e)
        {
            // close this form
            this.Close();
        }

        /// <summary>
        /// Show Profile photo 1 and hide Profile photo 2, also 
        /// display a message box stating Profile photo 1 is active
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowProfile1_Click(object sender, EventArgs e)
        {
            // hide Profile photo 2
            picBoxProfile2.Hide();
            
            // show Profile photo 1
            picBoxProfile1.Show();
            
            // show message box stating Profile photo 1 is active
            MessageBox.Show("Profile photo 1 is set to active", "Photo Selected");

        }

        /// <summary>
        /// Show Profile photo 2 and hide Profile photo 1, also 
        /// display a message box stating Profile photo 2 is active
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowProfile2_Click(object sender, EventArgs e)
        {
            // hide Profile photo 1
            picBoxProfile1.Hide();

            // show Profile photo 2
            picBoxProfile2.Show();

            // show message box stating Profile photo 2 is active
            MessageBox.Show("Profile photo 2 is set to active", "Photo Selected");

        }

        /// <summary>
        /// Reset the Form's text boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            // clear the first name text box
            txtBoxFirstName.Text = "";

            // clear the last name text box
            txtBoxLastName.Text = "";

            // clear the preferred email text box
            txtBoxPrefEmail.Text = "";

            // clear the major text box
            txtBoxMajor.Text = "";

            // clear the year text box
            txtBoxYear.Text = "";

        }
    }
}
