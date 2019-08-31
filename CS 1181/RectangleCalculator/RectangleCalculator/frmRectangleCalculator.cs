/*

frmRectangleCalculator.cs
CS 1181
Brandon Watkins
22 January 2019
Robert Howe
Description - Application that computes the area, perimeter, and diagonal length of a rectangle
    using width and length inputs from the user.

WOW:
Added access keys to each of the buttons, in addition to setting the accept button to
    "calculate" and the cancel button to "exit".
Added buttons to clear all previous data, and to exit the program.
Set it up to auto clear textboxes upon entering focus, and to fill with instructions if left
    empty.
Adjusted the tab order, to a more intuitive one.
Added an error message if you enter invalid numbers.

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

namespace RectangleCalculator
{
    public partial class frmRectangleCalculator : Form
    {
        // Declaring variables
        private int length, width;
        private double lW2;



        public frmRectangleCalculator()
        {
            InitializeComponent();
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            // Resetting labels and textboxes
            txtLength.Text = "Enter the length here.";
            txtWidth.Text = "Enter the width here.";
            lblAreaOutput.Text = "";
            lblDiagonalOutput.Text = "";
            lblPerimeterOutput.Text = "";

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Closing the program
            this.Close();
        }

        
        private void btnCalculate_Click(object sender, EventArgs e)
        {

            // Shows an error message in the message box if you have invalid inputs
            try
            {
                // Converting String to integral
                length = int.Parse(txtLength.Text);
                width = int.Parse(txtWidth.Text);
            }
            catch
            {
                MessageBox.Show("Invalid input. Please enter whole numbers for the dimensions.");
            }

            //  Converting integrals back to a string for display, and calculating results.
            lblAreaOutput.Text = (length * width).ToString("n0");
            lblPerimeterOutput.Text = (2 * (length + width)).ToString("n0");
            lW2 = (length * length + width * width);
            lblDiagonalOutput.Text = Math.Sqrt(lW2).ToString("n2");
        }
        


        private void txtLength_Enter(object sender, EventArgs e)
        {
            // Clears the length textbox upon entering focus
            if (
                txtLength.Text == "Enter the length here."
                )
                txtLength.Text = "";
        }

        private void txtLength_Leave(object sender, EventArgs e)
        {
            // Refills the length textbox if leaving focus and box is still empty.
            if (
                txtLength.Text == ""
                )
                txtLength.Text = "Enter the length here.";
        }

        private void txtWidth_Leave(object sender, EventArgs e)
        {
            // Refills the width textbox if leaving focus and box is still empty.
            if (
                txtWidth.Text == ""
                )
                txtWidth.Text = "Enter the width here.";
        }

        private void txtWidth_Enter(object sender, EventArgs e)
        {
            // Clears the width textbox upon entering focus
            if (
                txtWidth.Text == "Enter the width here."
                )
                txtWidth.Text = "";
        }
    }
}
