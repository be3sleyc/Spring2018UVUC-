//Name: Christian Beesley
//Class: INFO 1200
//Section: 001
//Professor: Crandall
//Date: 20180330
//Project #: 8A
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
using System.Threading;
using System.Media;
using System.Windows.Forms;

namespace CBMyGradeApp
{
    public partial class QuizTimerForm : Form
    {
        // declare field constants to keep track of beep count, Sleep time, and min/ max timer limits
        private const int BEEP = 3, SLEEP = 1000; // 1000 milliseconds for 1 second
        private const int TIME_MIN = 0, TIME_MAX = 3600; // limit max to 1 hour

        public QuizTimerForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Validates user input and starts the timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            // create a variable for user time input
            int time = 0;

            // validate the user input
            if (InputIsValid(out time))
            {
                // Check the radio buttons
                if (rBtnCountD.Checked)
                {
                    // count down from time
                    for (int i = time; i >= 0; i--)
                        UpdateTimer(i); // call to UpdateTimer method
                }
                else
                {
                    // count up from zero
                    for (int i = 0; i <= time; i++)
                        UpdateTimer(i); // call to UpdateTimer method
                }

                // Beep when done
                if (chkBoxAlarm.Checked)
                {
                    for (int i = 0; i < BEEP; i++)
                    {
                        // Beep
                        SystemSounds.Beep.Play();

                        Thread.Sleep(SLEEP / 3); // pauses the program for a third of sleep time
                        Application.DoEvents(); // redraws the GUI
                    }
                }
            }
            else
            {
                // explain the validation error, clear and re-focus on the text box.
                MessageBox.Show($"Timer value must be a value of seconds greater than {TIME_MIN} and less than {TIME_MAX} seconds. Please enter a new value.", "Invalid Input");
                txtBoxTimerVal.Clear();
                txtBoxTimerVal.Focus();
            }

            // clear out all i/o controls before exiting handler method
            lblTimer.Text = "00:00";
            txtBoxTimerVal.Clear();
            txtBoxTimerVal.Focus(); // re-focus on text box.

        }

        /// <summary>
        /// Validates user input and returns true if successful
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        private bool InputIsValid(out int time)
        {
            // try to parse the time value to an int variable
            if (int.TryParse(txtBoxTimerVal.Text, out time))
            {
                // check that it meets minimum and maximum value requirements
                if (time < TIME_MAX && time > TIME_MIN)
                {
                    return true;
                }
            }

            // haven't returned true, so must be false
            return false;
        }

        /// <summary>
        /// uses a tick value to increment or decrement a timer label, then sleeps
        /// </summary>
        /// <param name="tick"></param>
        private void UpdateTimer(int tick)
        {
            // create a time span object to pace the timer
            TimeSpan currentTime = new TimeSpan(0, 0, tick);

            // display the current time to the timer label
            lblTimer.Text = currentTime.ToString(@"mm\:ss");

            Thread.Sleep(SLEEP); // count a second
            Application.DoEvents(); // redraws the GUI
        }

        /// <summary>
        /// Closes the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            // catch any sleeping threads
            this.Refresh();

            // close this form
            this.Close();
        }
    }
}
