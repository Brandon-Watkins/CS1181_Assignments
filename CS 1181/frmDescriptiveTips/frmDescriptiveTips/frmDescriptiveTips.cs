/* 
frmDescriptiveTips.cs
CS 1181
Brandon Watkins
2 February 2019
Robert Howe
Description: Application that collects user inputs on price and service to determine an appropriate tip.
WOW:
I've made my buttons change color when clicked. I changed the alpha between different stages of clicking to give
    the impresion of a gradual change in color. They will reset back to default upon leaving the button.
I gave my application a reset button, as well as a close button.
I have the tip percentage automatically updated as the user checks the checkboxes. I would have made all computations 
    immediate, but the instructions demanded a functional "calculate" button, which would have then been useless.
My code should be relatively fool-proof. If the user puts in incorrect values, my application will revert the value, 
    and display a message box telling the user what they did wrong, and giving them the opportunity to fix it.
I have a placeholder message in the textbox, that clears upon entering, and reappears upon erroneous or blank input.
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

namespace frmDescriptiveTips
{
    public partial class frmDescriptiveTips : Form
    {

        double tip_SeatedPromptly = 0;
        double tip_ServerWasFriendly = 0;
        double tip_ComplaintsHandledProfessionally = 0;
        double tip_DrinksKeptFull = 0;
        double tip_FoodServedPromptly = 0;
        double mealCost = 0;
        double tip_Total = 0;
        


        public frmDescriptiveTips()
        {
            InitializeComponent();
        }
        

        private void chkSeatedPromptly_CheckedChanged(object sender, EventArgs e)
        {
            // if checked, add 5% to the tip automatically
            if (chkSeatedPromptly.Checked)
            {
                tip_SeatedPromptly = .05;
            }
            else
            {
                tip_SeatedPromptly = 0;
            }
            tip_Total = tip_ServerWasFriendly + tip_SeatedPromptly + tip_FoodServedPromptly + tip_DrinksKeptFull + tip_ComplaintsHandledProfessionally;
            lblTipPercent_Output.Text = tip_Total.ToString("P0");

        }

        private void chkServerWasFriendly_CheckedChanged(object sender, EventArgs e)
        {
            // if checked, add 5% to the tip automatically
            if (chkServerWasFriendly.Checked)
            {
                tip_ServerWasFriendly = .05;
            } else
            {
                tip_ServerWasFriendly = 0;
            }
            tip_Total = tip_ServerWasFriendly + tip_SeatedPromptly + tip_FoodServedPromptly + tip_DrinksKeptFull + tip_ComplaintsHandledProfessionally;
            lblTipPercent_Output.Text = tip_Total.ToString("P0");

        }

        private void chkComplaintsHandledProfessionally_CheckedChanged(object sender, EventArgs e)
        {
            // If checked, add 5% to the tip automatically
            if (chkComplaintsHandledProfessionally.Checked)
            {
                tip_ComplaintsHandledProfessionally = .05;
            }
            else
            {
                tip_ComplaintsHandledProfessionally = 0;
            }
            tip_Total = tip_ServerWasFriendly + tip_SeatedPromptly + tip_FoodServedPromptly + tip_DrinksKeptFull + tip_ComplaintsHandledProfessionally;
            lblTipPercent_Output.Text = tip_Total.ToString("P0");

        }

        private void chkDrinksKeptFull_CheckedChanged(object sender, EventArgs e)
        {
            // If checked, add 5% to the tip automatically
            if (chkDrinksKeptFull.Checked)
            {
                tip_DrinksKeptFull = .05;
            }
            else
            {
                tip_DrinksKeptFull = 0;
            }
            tip_Total = tip_ServerWasFriendly + tip_SeatedPromptly + tip_FoodServedPromptly + tip_DrinksKeptFull + tip_ComplaintsHandledProfessionally;
            lblTipPercent_Output.Text = tip_Total.ToString("P0");

        }

        private void chkFoodServedPromptly_CheckedChanged(object sender, EventArgs e)
        {
            // if checked, add 5% to the tip automatically
            if (chkFoodServedPromptly.Checked)
            {
                tip_FoodServedPromptly = .05;
            }
            else
            {
                tip_FoodServedPromptly = 0;
            }
            tip_Total = tip_ServerWasFriendly + tip_SeatedPromptly + tip_FoodServedPromptly + tip_DrinksKeptFull + tip_ComplaintsHandledProfessionally;
            lblTipPercent_Output.Text = tip_Total.ToString("P0");

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            tip_Total = tip_ServerWasFriendly + tip_SeatedPromptly + tip_FoodServedPromptly + tip_DrinksKeptFull + tip_ComplaintsHandledProfessionally;
            lblTipPercent_Output.Text = tip_Total.ToString("P0");

            if (txtMealCost_Input.Text != "Enter the cost of your meal")
            {
                // calculate the tip amount
                lblTipAmount_Output.Text = (tip_Total * double.Parse(txtMealCost_Input.Text)).ToString("C2");
                // calculate the total amount
                lblTotalAmount_Output.Text = (double.Parse(txtMealCost_Input.Text) + (tip_Total * double.Parse(txtMealCost_Input.Text))).ToString("C2");

            }
            else
            {
                MessageBox.Show("Please enter a value for the cost of your meal (Before Tips), before attempting to calculate.");
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // close the application
            this.Close();
        }

        private void txtMealCost_Input_Enter(object sender, EventArgs e)
        {
            // Clear the generic message upon entering the textbox
            if (txtMealCost_Input.Text == "Enter the cost of your meal")
            {
                txtMealCost_Input.Text = "";
            }
        }

        private void txtMealCost_Input_Leave(object sender, EventArgs e)
        {
            // Make sure that input is a double data type
            if (txtMealCost_Input.Text != "Enter the cost of your meal" && txtMealCost_Input.Text != "")
            {
                if (!double.TryParse(txtMealCost_Input.Text, out mealCost))
                {
                    txtMealCost_Input.Text = "Enter the cost of your meal";
                    MessageBox.Show("Incorrect value entered. Please enter a numerical value for the cost of your meal.");
                }
            }
            // Make sure that input is a positive value
            if (txtMealCost_Input.Text != "Enter the cost of your meal" && txtMealCost_Input.Text != "")
            {
                if (double.Parse(txtMealCost_Input.Text) < 0.0)
                {
                    txtMealCost_Input.Text = "Enter the cost of your meal";
                    MessageBox.Show("You're screwing with me, right? Please enter a positive value for the cost of your meal.");
                }
            }
            // Reset the generic message if text box is empty upon leaving
            if (txtMealCost_Input.Text == "")
            {
                txtMealCost_Input.Text = "Enter the cost of your meal";
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Reset all controls when clicking the reset button
            chkComplaintsHandledProfessionally.Checked = false;
            chkDrinksKeptFull.Checked = false;
            chkFoodServedPromptly.Checked = false;
            chkSeatedPromptly.Checked = false;
            chkServerWasFriendly.Checked = false;
            txtMealCost_Input.Text = "Enter the cost of your meal";
            lblTipAmount_Output.Text = "";
            lblTipPercent_Output.Text = "";
            lblTotalAmount_Output.Text = "";

        }

        // change the colors of the buttons when clicked

                     // Reset button
        private void btnReset_MouseEnter(object sender, EventArgs e)
        {
            btnReset.BackColor = Color.FromArgb(75, 0, 255, 128);
        }

        private void btnReset_MouseDown(object sender, MouseEventArgs e)
        {
            btnReset.BackColor = Color.FromArgb(160, 0, 255, 128);
        }

        private void btnReset_MouseUp(object sender, MouseEventArgs e)
        {
            btnReset.BackColor = Color.FromArgb(255, 0, 255, 128);
        }

        private void btnReset_MouseLeave(object sender, EventArgs e)
        {
            btnReset.BackColor = SystemColors.Control;
        }


                   // Calculate Button
        private void btnCalculate_MouseEnter(object sender, EventArgs e)
        {
            btnCalculate.BackColor = Color.FromArgb(75, 0, 128, 255);
        }

        private void btnCalculate_MouseDown(object sender, MouseEventArgs e)
        {
            btnCalculate.BackColor = Color.FromArgb(160, 0, 128, 255);
        }

        private void btnCalculate_MouseUp(object sender, MouseEventArgs e)
        {
            btnCalculate.BackColor = Color.FromArgb(255, 0, 128, 255);
        }

        private void btnCalculate_MouseLeave(object sender, EventArgs e)
        {
            btnCalculate.BackColor = SystemColors.Control;
        }


                     // Close Button
        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.FromArgb(75, 255, 51, 51);
        }

        private void btnClose_MouseDown(object sender, MouseEventArgs e)
        {
            btnClose.BackColor = Color.FromArgb(160, 255, 51, 51);
        }

        private void btnClose_MouseUp(object sender, MouseEventArgs e)
        {
            btnClose.BackColor = Color.FromArgb(255, 255, 51, 51);
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = SystemColors.Control;
        }

    }
}
