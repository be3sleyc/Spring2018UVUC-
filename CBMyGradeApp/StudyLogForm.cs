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
using System.IO;

namespace CBMyGradeApp
{
    public partial class StudyLogForm : Form
    {
        // use a global private field to hold the current file name
        private string currentFilename;

        public StudyLogForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Prepares the form to run by setting up the current date label and 
        /// preparing the study entry log and list box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StudyLogForm_Load(object sender, EventArgs e)
        {
            // use string variables to hold the current date string and the entry string
            string currentDate = DateTime.Now.ToString("d");
            string entryStr = "";

            // set the Today's date label to the current date
            lblToday.Text = currentDate;

            // modify the currentFileName to hold the date + studylog.txt
            currentFilename = currentDate.Replace("/", "_") + "studylog" + ".txt";

            // declare a stream reader to read in the study log from text files
            StreamReader inputFile;

            // set default course selection to first item
            lstBoxCourses.SelectedIndex = 0;

            // try to ...
            try
            {
                // open the currentFileName file
                inputFile = File.OpenText(currentFilename);

                // clear study entries list box
                lstBoxStudyEntries.Items.Clear();

                // loop through the input file streamer
                while (!inputFile.EndOfStream)
                {
                    // store a line from input file in the entrystring
                    entryStr = inputFile.ReadLine();
                    
                    // add the entry string to the study entries list box
                    lstBoxStudyEntries.Items.Add(entryStr);
                }

                // close the file when done
                inputFile.Close();
            }
            catch (Exception)
            {
                // if an exception occurs, display an error message
                MessageBox.Show("Unable to read from file.\nIf this in not the first run, please check your persmissions.", "Reading from File Error");
            }
        }

        /// <summary>
        /// Adds an entry to the study entry list box if duration has a valid value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddStudyEntry_Click(object sender, EventArgs e)
        {
            // declare an int variable to store duration
            int dur = 0;

            // test if duration input is a positive integer and assign it to dur
            if (int.TryParse(txtBoxDuration.Text, out dur) && dur > 0)
            {
                // add the concatenation of the selected course, the value of duration, and notes text boxes
                lstBoxStudyEntries.Items.Add("Course: "+ lstBoxCourses.SelectedItem.ToString() + " " +
                    " Duration: " + txtBoxDuration.Text + " mins. " +
                    "Notes: " + txtBoxNotes.Text);

                // Clear all the users input and set the course selection to the first item
                txtBoxDuration.Clear();
                txtBoxNotes.Clear();
                lstBoxCourses.SelectedIndex = 0;
            }
            else
            {
                // Display an error message
                MessageBox.Show("Invalid duration Entry\nPlease enter a positive whole number for minutes of duration", "Input Error");

                // clear and refocus input to duration text box
                txtBoxDuration.Focus();
                txtBoxDuration.Clear();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveLog_Click(object sender, EventArgs e)
        {
            // create an int variable to store the item count for the entry list box
            int entryCount = 0;

            // get the count of entries in the study entries list box
            entryCount = lstBoxStudyEntries.Items.Count;

            // create a streamwrite and output file with the current filename
            StreamWriter outfile = File.CreateText(currentFilename);

            // try to ...
            try
            {
                // loop through the study entries list box items and write them to file
                for (int i = 0; i < entryCount; i++)
                {
                    outfile.WriteLine(lstBoxStudyEntries.Items[i]);
                }

                // close the file when done
                outfile.Close();
            }
            catch (Exception)
            {
                // if an exception occurs, display an error message
                MessageBox.Show("Unable to write to file.\nPlease Check your persmissions.", "Writing to File Error");
            }
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
