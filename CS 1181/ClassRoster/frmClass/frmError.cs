/*
ClassRoster.frmError.cs
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
    public partial class frmError : Form
    {
        frmClass classForm;
        /// <summary>
        /// Initialize the form, loading, assembling, and outputting the error message.
        /// </summary>
        /// <param name="errorMessage"></param>
        public frmError(frmClass classForm, string errorMessage, string solutionMessage)
        {
            InitializeComponent();
            ErrorMessage(errorMessage, solutionMessage);
            LabelPosition();
            this.classForm = classForm;
        }

        /// <summary>
        /// keeps user from going back to main form. Didn't want to use ShowDialog(), no particular reason.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmError_Leave(object sender, EventArgs e)
        {
            // can't have that...
            this.Focus();
        }

        /// <summary>
        /// Assembles the error message, and assigns it to the error label
        /// </summary>
        private void ErrorMessage(string errorMessage, string solutionMessage)
        {
            string message = errorMessage + Environment.NewLine + Environment.NewLine + solutionMessage;
            lblError.Text = message;
        }

        /// <summary>
        /// Centers the label (Horizontally) dynamically, based on what text has been input into the message
        /// </summary>
        private void LabelPosition()
        {
            const int HEIGHT = 20;
            const int FORM_WIDTH = 322;
            int labelWidth = lblError.Size.Width;
            int positionX = (FORM_WIDTH - labelWidth) / 2;
            int positionY = HEIGHT;
            lblError.Location = new Point(positionX, positionY);
        }

        /// <summary>
        /// Closes all forms
        /// </summary>
        private void btnOkay_Click(object sender, EventArgs e)
        {
            classForm.Close();
            this.Close();
        }
    }
}
