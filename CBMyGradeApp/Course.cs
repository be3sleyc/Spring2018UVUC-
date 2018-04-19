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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBMyGradeApp
{
    class Course
    {
        private string _courseName, _semester, _instructor, _letterGrade;
        private double _grade;

        /// <summary>
        /// create a default constructor with no values
        /// </summary>
        public Course()
        {
            // set all the backing fields with default, empty values;
            _courseName = "";
            _semester = "";
            _instructor = "";
            _letterGrade = "";
            _grade = 0.00;
        }

        /// <summary>
        /// create a multi-argument constructor with all the possible values
        /// </summary>
        /// <param name="name"></param>
        /// <param name="semester"></param>
        /// <param name="instructor"></param>
        /// <param name="letter"></param>
        /// <param name="grade"></param>
        public Course(string name, string semester, string instructor, string letter, double grade)
        {
            // initialize the backing fields with the provided argument values.
            _courseName = name;
            _semester = semester;
            _instructor = instructor;
            _letterGrade = letter;
            _grade = grade;
        }

        /// <summary>
        /// create property for the _courseName backing field
        /// give it read/get and write/set methods
        /// </summary>
        public string CourseName
        {
            get { return _courseName; }
            set { _courseName = value; }
        }

        /// <summary>
        /// create property for the _semester backing field
        /// give it read/get and write/set methods
        /// </summary>
        public string Semester
        {
            get { return _semester; }
            set { _semester = value; }
        }

        /// <summary>
        /// create property for the _instructor backing field
        /// give it read/get and write/set methods
        /// </summary>
        public string Instructor
        {
            get { return _instructor; }
            set { _instructor = value; }
        }

        /// <summary>
        /// create property for the _letterGrade backing field
        /// give it read/get and write/set methods
        /// </summary>
        public string LetterGrade
        {
            get { return _letterGrade; }
            set { _letterGrade = value; }
        }

        /// <summary>
        /// create property for the _grade backing field
        /// give it read/get and write/set methods
        /// </summary>
        public double Grade
        {
            get { return _grade; }
            set { _grade = value; }
        }

        /// <summary>
        /// Override the default to string method to 
        /// return a string of all the class backing fields 
        /// concatenated together and separated with commas.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string tmp = $"{_courseName},{_semester},{_instructor},{_grade.ToString("p")},{_letterGrade}";

            return tmp;
        }
    }
}
