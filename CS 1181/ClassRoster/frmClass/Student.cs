/*
ClassRoster.Student.cs
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace ClassRoster
{
    class Student
    {
        // Fields
        private string _name;
        private string _major;
        private double _testGradeAverage;
        private double _assignmentGradeAverage;
        Student[] students;
        frmClass classForm;

        // Properties
        public string Name {
            get {
                return _name;
            }
            set {
                _name = value;
            }
        }
        public string Major {
            get {
                return _major;
            }
            set {
                _major = value;
            }
        }
        public double TestGradeAverage {
            get {
                return _testGradeAverage;
            }
            set {
                _testGradeAverage = value;
            }
        }
        public double AssignmentGradeAverage {
            get {
                return _assignmentGradeAverage;
            }
            set {
                _assignmentGradeAverage = value;
            }
        }

        // Constructor
        public Student(string name, string major)
        {
            _name = name;
            _major = major;
        }

        public Student(frmClass classForm)
        {
            this.classForm = classForm;
        }

        // Methods
        public double ClassGrade()
        {
            return AssignmentGradeAverage * 0.55 + TestGradeAverage * 0.45;
        }

        public Student[] FillStudents(ref bool wasSuccess, string fileName = "students.csv")
        {
            wasSuccess = true;
            FileInfo fileInfo = new FileInfo(fileName);
            //Verifying the file exists, or prompting user to locate the file:
            if (!fileInfo.Exists)
            {
                // ask user if they want to locate file. if not, too bad.
                DialogResult result = MessageBox.Show("File could not be found.\r\nWould you like to locate it?",
                    "File Not Found", MessageBoxButtons.YesNo);
                while (result != DialogResult.Yes) result = MessageBox.Show
                        ("File could not be found.\r\nWould you like to locate it?", "File Not Found",
                        MessageBoxButtons.YesNo);
                // user selected yes, they want to locate file manually.
                if (result == DialogResult.Yes)
                {
                    OpenFileDialog ofd = new OpenFileDialog();
                    DialogResult result2 = ofd.ShowDialog();
                    fileName = ofd.FileName;
                    // user cancelled. we can't have that.
                    while (result2 != DialogResult.OK)
                    {
                        MessageBox.Show("Please choose a file location.");
                        ofd = new OpenFileDialog();
                        result2 = ofd.ShowDialog();
                        fileName = ofd.FileName;
                    }
                }
                
            }
            // Create a string Array(contains: Name, Major, Assignments, Test)
            try
            {
                string[] tempArr = File.ReadAllLines(fileName);
                // create Student array
                students = new Student[tempArr.Length - 1];
                // fill students, a Student array
                char[] delim = { ',' };
                for (int i = 1; i < tempArr.Length; i++)
                {
                    // break apart file-imported strings into tokens
                    string[] tokens = tempArr[i].Split(delim);
                    // fill students array with tokens
                    students[i - 1] = new Student(tokens[0], tokens[1]);
                    if (double.TryParse(tokens[2], out double assignments)) students[i - 1].AssignmentGradeAverage = assignments;
                    else
                    {
                        wasSuccess = false;
                        Error("File contains non-numerical data for assignment scores.", "Please reopen the program, and select a valid import file.");
                    }
                    if (double.TryParse(tokens[3], out double test)) students[i - 1].TestGradeAverage = test;
                    else
                    {
                        wasSuccess = false;
                        Error("File contains non-numerical data for test score", "Please reopen the program, and select a valid import file.");
                    }
                }
                return students;
            }
            catch (IOException)
            {
                wasSuccess = false;
                Error("File is being used by another program.", "Please close the file and try again.");
            }
            catch
            {
                wasSuccess = false;
                Error("Something went horribly, horribly, wrong.", "Student.FillStudents() ~ line 157.");
            }
            return null;
        }

        public void ShowNames(ListBox listBox, Student[] studentsArray, ref bool wasSuccess)
        {
            if (wasSuccess)
                for (int i = 0; i < students.Length; i++)
                {
                    listBox.Items.Add(studentsArray[i].Name);
                }
        }

        public void DisplayStudentDetails(Student studentObject, Label lblStudentName, Label lblStudentMajor, 
            Label lblStudentAssignments, Label lblStudentTest, Label lblStudentGrade)
        {
            lblStudentName.Text = studentObject.Name.ToString();
            lblStudentMajor.Text = studentObject.Major.ToString();
            if ((int)studentObject.AssignmentGradeAverage != (double)studentObject.AssignmentGradeAverage)
                lblStudentAssignments.Text = studentObject.AssignmentGradeAverage.ToString("n2");
            else
                lblStudentAssignments.Text = studentObject.AssignmentGradeAverage.ToString();
            if ((int)studentObject.TestGradeAverage != (double)studentObject.TestGradeAverage)
                lblStudentTest.Text = studentObject.TestGradeAverage.ToString("n2");
            else
                lblStudentTest.Text = studentObject.TestGradeAverage.ToString();
            lblStudentGrade.Text = studentObject.ClassGrade().ToString("n2");
        }

        public void Error(string errorMessage, string solutionMessage)
        {
            frmError errorForm = new frmError(classForm, errorMessage, solutionMessage);
            errorForm.Show();
        }
    }
}
