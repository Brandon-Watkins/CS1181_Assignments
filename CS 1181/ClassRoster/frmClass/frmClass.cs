/*
ClassRoster.frmClass.cs
CS 1181
Brandon Watkins
13 April 2019
Robert Howe
Description: Pulls data from a file to populate a listbox of student names, which display their grades when clicked.
WOW:
Student.cs:
    FillStudents() on line 97: 
        Added some error checking: 
            If no file is found, it asks user to locate a file to import.
            If user doesn't want to locate a file, there's nothing to load, so I stick them in a loop until they select one.
            If test/assignment scores have non-numerical data, I give them frmError.
    DisplayStudentDetails() on line 157:
        Added some more checks:
            If either test score or assignment score has a decimal, it will output the score to 2 decimal places.
                I'm aware our sample file doesn't have decimals, but this will allow other files to be used.
            Else, it will output the score with no decimals.
frmClass.cs:
    Seemed pretty straightforward, couldn't really think of anything that didn't utilize buttons or anything, that wasn't trivial
        (such as getting the class averages).
frmError.cs:
    I made a new form to host my error messages.
    Got rid of the title bar, the control box, and altered the color scheme.
            see the names still.
    LabelPosition() on line 52: 
        Dynamically places the label containing the error message, so that it's centered (horizontally).
    Clicking Okay will close both frmClass and frmError.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassRoster
{
    public partial class frmClass : Form
    {
        Student studentClass;
        Student[] studentsArray;
        private bool wasSuccess;
        
        public frmClass()
        {
            InitializeComponent();
            studentClass = new Student(this);
            studentsArray = studentClass.FillStudents(ref wasSuccess);
            if (wasSuccess)
                studentClass.ShowNames(lbStudentNames, studentsArray, ref wasSuccess);
        }

        private void lbStudentNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            int listBoxIndex = lbStudentNames.SelectedIndex;
            studentClass.DisplayStudentDetails(studentsArray[listBoxIndex], lblStudentName, lblStudentMajor, 
                lblStudentAssignments, lblStudentTests, lblStudentGrade);
        }
        
    }
}
