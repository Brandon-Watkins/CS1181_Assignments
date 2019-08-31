/*
frmFactorialFinder.cs
CS 1181
Brandon Watkins 
19 February 2019
Robert Howe
Description: Calculates tax, tip, and overall costs for date night

Sorry in advance, after about 40 hours spent on this assignment, i decided to just get it working, and took out a lot of my fancy stuff,
and stopped utilizing methods for the remainder. I decided to keep a lot of my old code, in the hopes that I could get some pointers on it, but it is "messy" looking.

WOW:
Automated calculations, to show the costs, taxes, and fees as they are checked.
Buttons:
    Added a reset button, which uses its own method to clear the entered data.
        The reset button can be triggered by pressing alt r
    Added a close button, to close the form
        The close button can be triggered by pressing alt e, or esc
        The probability button can be triggered by pressing alt p
    The calculate button can be triggered by pressing alt c, or enter
Radio Buttons:
    Added a tip percent button, to utilize the required trackbar in addition to text input
        Output the tip percentage from the trackbar into the txtTipPercent.Text
        Tip percent and tip total changes cause both values to change in relationship with each other 
        Clicking on the radio button will enter the textbox focus.
        The tip total textbox will output what the tip amount was, individually. 
        Verified double data was entered, otherwise gives an error message and resets the field, upon leaving focus.
    Added a tip total button, for those that would rather tip a dollar amount than a percentage
        Output the tip percentage (rounded) equivalent to the tip amount, into the tip percent textbox
        Clicking on the radio button will enter the textbox focus
        Verified double data was entered, otherwise gives an error message and resets the field, upon leaving focus. 
Taxes:
    Added a tax total label to output the tax costs, specifically
    Verified that the tax rate input is double data type 
Methods:
    Added several more generic methods to declutter several other child methods (if that's correct usage).
    Implemented several error-proofing methods throughout

I had most of these working, but ran into an inssue involving the relationship between tip percent/total and tax rate, and ran out of time, so I just deleted/commented them out:
Limited the tax rate input to 1000%
Limited the tip percent to 1000%
I've allowed the user to input a tip amount between the values of 0 and 5500.
max value for tip total will fluctuate with respect to the current tax rate, not exceeding 1000% tip.

Decided to comment out and delete these features in favor of more automated calculations
if tip percent is checked, tip total textbox would go invisible, to ensure user knew which was actually being calculated, and vice versa
The tip textboxes will reappear upon calculation, also outputting what the tip amount was, individually. 

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


namespace DateNightCalculator
{
    public partial class frmDateNightCalculator : Form
    {

        // ************Global Variables************ //
        public const double PERCENT_CONVERSION = 0.01;
        public double tipValue = 5 * PERCENT_CONVERSION;
        public double tipRate = 5;
        public double tipCost = 0;
        public bool tipTotalOkay = true;
        public bool tipPercentOkay = true;
        public double taxTotal = 0;


        public frmDateNightCalculator()
        {
            InitializeComponent();
        }


        // ********** Custom Methods**************** //


        /// <summary>
        /// Calculates cost of taxes
        /// </summary>
        /// <param name="pre_tax_cost">double</param>
        /// <returns>the cost of taxes (double)</returns>
        private double GetTaxRate(double pre_tax_cost)
        {
            double taxRate = 0;

            if (txtTaxRate.Text != "")
            {
                taxRate = double.Parse(txtTaxRate.Text) * PERCENT_CONVERSION;
            }
            else
            {
                taxRate = 0;
            }
            return taxRate * pre_tax_cost;
            
        }


        /// <summary>
        /// Calculates the cost of the tip
        /// </summary>
        /// <param name="pre_tax_and_tip_cost">double</param>
        /// <returns>the cost of tip (double)</returns>
        private double GetTip(double pre_tax_and_tip_cost)
        {
            
            double tipPercent = 0;
            if (IsUsingTipTotal())
            {
                tipRate = double.Parse(txtTipTotal.Text) / (((pre_tax_and_tip_cost) * (1 + double.Parse(txtTaxRate.Text) * PERCENT_CONVERSION)) * PERCENT_CONVERSION);
                return double.Parse(txtTipTotal.Text);
            }

            else
            {
                tipPercent = double.Parse(txtTipPercent.Text) * PERCENT_CONVERSION;
                return (pre_tax_and_tip_cost + GetTaxRate(pre_tax_and_tip_cost)) * tipPercent;
            }
            
            
        }

            /*private void TipLimiter()
        {
            // is dinner "tippable"?
            if (GetCost(rbDinner_None, rbDinner_McDonalds, rbDinner_Applebees, rbDinner_SandPipers) == 3 ||
                GetCost(rbDinner_None, rbDinner_McDonalds, rbDinner_Applebees, rbDinner_SandPipers) == 4)
            {
                // get the tax rate for dinner 
                double dinnerTaxRate = GetTaxRate(GetDinnerCost());

                // does the tip rate exceed max?
                double maxTipPercent = 1000;
                if (IsUsingTipTotal())
                {
                    // if so, set the tip total for total at max tip rate
                    if (double.Parse(txtTipTotal.Text) / (((GetCost(rbDinner_None, rbDinner_McDonalds, rbDinner_Applebees, rbDinner_SandPipers)) *
                        (1 + double.Parse(txtTaxRate.Text) * PERCENT_CONVERSION)) * PERCENT_CONVERSION) > maxTipPercent)
                    {
                        txtTipTotal.Text = (GetDinnerCost() * maxTipPercent * PERCENT_CONVERSION).ToString("n2");
                        txtTipPercent.Text = "1000.0";
                    }
                }
            }

            else
            {
                txtTipTotal.Text = "0.00";
            }
        }*/

        /// <summary>
        /// Generic method requesting 4 Radio Button inputs, and outputting which button is checked.
        /// </summary>
        /// <param name="choice1">Radio Button</param>
        /// <param name="choice2">Radio Button</param>
        /// <param name="choice3">Radio Button</param>
        /// <param name="choice4">Radio Button</param>
        /// <returns>which Radio Button has been checked (1-4) (int)</returns>
        private int GetCost(RadioButton choice1, RadioButton choice2, RadioButton choice3, RadioButton choice4)
        {
            if (choice1.Checked)
            {
                return 1;
            }
            else if (choice2.Checked)
            {
                return 2;
            }
            else if (choice3.Checked)
            {
                return 3;
            }
            else if (choice4.Checked)
            {
                return 4;
            }
            else
            {
                return 0;
            }
        }


        /// <summary>
        /// Puts the Radio Buttons from Travel into the GetCost method, calculates taxes, outputs the cost for Travel.
        /// </summary>
        /// <returns>The cost for the checked travel radio button (double)</returns>
        private double GetTravelCost()
        {
            double cost = 0;
            
            if (GetCost(rbTravel_Bus, rbTravel_Bicycle, rbTravel_Car, rbTravel_CarriageRide) == 1)
            {
                cost = 1;
            }
            else if (GetCost(rbTravel_Bus, rbTravel_Bicycle, rbTravel_Car, rbTravel_CarriageRide) == 2)
            {
                cost = 20;
            }
            else if (GetCost(rbTravel_Bus, rbTravel_Bicycle, rbTravel_Car, rbTravel_CarriageRide) == 3)
            {
                cost = 5;
            }
            else if (GetCost(rbTravel_Bus, rbTravel_Bicycle, rbTravel_Car, rbTravel_CarriageRide) == 4)
            {
                cost = 50;
            }
            else if (GetCost(rbTravel_Bus, rbTravel_Bicycle, rbTravel_Car, rbTravel_CarriageRide) == 0)
            {
                cost = 0;
            }
            
            
            return cost + GetTaxRate(cost);
        }

        /// <summary>
        /// Calculates the taxes from travel
        /// </summary>
        /// <returns>taxes from travel (double)</returns>
        private double GetTravelTaxes()
        {
            double cost = 0;

            if (GetCost(rbTravel_Bus, rbTravel_Bicycle, rbTravel_Car, rbTravel_CarriageRide) == 1)
            {
                cost = 1;
            }
            else if (GetCost(rbTravel_Bus, rbTravel_Bicycle, rbTravel_Car, rbTravel_CarriageRide) == 2)
            {
                cost = 20;
            }
            else if (GetCost(rbTravel_Bus, rbTravel_Bicycle, rbTravel_Car, rbTravel_CarriageRide) == 3)
            {
                cost = 5;
            }
            else if (GetCost(rbTravel_Bus, rbTravel_Bicycle, rbTravel_Car, rbTravel_CarriageRide) == 4)
            {
                cost = 50;
            }
            else if (GetCost(rbTravel_Bus, rbTravel_Bicycle, rbTravel_Car, rbTravel_CarriageRide) == 0)
            {
                cost = 0;
            }


            return GetTaxRate(cost);
        }


        /// <summary>
        /// Puts the Radio Buttons from Dinner into the GetCost method, calculates the taxes and tip, outputs the cost for Dinner.
        /// </summary>
        /// <returns>The cost for the checked dinner radio button (double)</returns>
        private double GetDinnerCost()
        {
            double cost = 0;
 
            if (GetCost(rbDinner_None, rbDinner_McDonalds, rbDinner_Applebees, rbDinner_SandPipers) == 1)
            {
                cost = 0;
            }
            else if (GetCost(rbDinner_None, rbDinner_McDonalds, rbDinner_Applebees, rbDinner_SandPipers) == 2)
            {
                cost = 10;
            }
            else if (GetCost(rbDinner_None, rbDinner_McDonalds, rbDinner_Applebees, rbDinner_SandPipers) == 3)
            {
                cost = 25;
            }
            else if (GetCost(rbDinner_None, rbDinner_McDonalds, rbDinner_Applebees, rbDinner_SandPipers) == 4)
            {
                cost = 50;
            }
            else if (GetCost(rbTravel_Bus, rbTravel_Bicycle, rbTravel_Car, rbTravel_CarriageRide) == 0)
            {
                cost = 0;
            }

            tipCost = GetTip(cost);

            if (GetCost(rbDinner_None, rbDinner_McDonalds, rbDinner_Applebees, rbDinner_SandPipers) == 3 ||
                GetCost(rbDinner_None, rbDinner_McDonalds, rbDinner_Applebees, rbDinner_SandPipers) == 4)
            {
                return cost + GetTaxRate(cost) + GetTip(cost);
            }
            else
            {
                return cost + GetTaxRate(cost);
            }
}


        /// <summary>
        /// Calculates taxes from dinner
        /// </summary>
        /// <returns>taxes from dinner (double)</returns>
        private double GetDinnerTaxes()
        {
            double cost = 0;

            if (GetCost(rbDinner_None, rbDinner_McDonalds, rbDinner_Applebees, rbDinner_SandPipers) == 1)
            {
                cost = 0;
            }
            else if (GetCost(rbDinner_None, rbDinner_McDonalds, rbDinner_Applebees, rbDinner_SandPipers) == 2)
            {
                cost = 10;
            }
            else if (GetCost(rbDinner_None, rbDinner_McDonalds, rbDinner_Applebees, rbDinner_SandPipers) == 3)
            {
                cost = 25;
            }
            else if (GetCost(rbDinner_None, rbDinner_McDonalds, rbDinner_Applebees, rbDinner_SandPipers) == 4)
            {
                cost = 50;
            }
            else if (GetCost(rbTravel_Bus, rbTravel_Bicycle, rbTravel_Car, rbTravel_CarriageRide) == 0)
            {
                cost = 0;
            }
            
            return GetTaxRate(cost);
            
        }


        /// <summary>
        /// Puts the Radio Buttons from Dessert into the GetCost method, calculates taxes and tips, outputs the cost for Dessert.
        /// </summary>
        /// <returns>The cost for the checked dessert radio button (double)</returns>
        private double GetDessertCost()
        {
        double cost = 0;
            
        if (GetCost(rbDessert_None, rbDessert_IceCreamCones, rbDessert_Shakes, rbDessert_Smores) == 1)
        {
            cost = 0;
        }
        else if (GetCost(rbDessert_None, rbDessert_IceCreamCones, rbDessert_Shakes, rbDessert_Smores) == 2)
        {
            cost = 3;
        }
        else if (GetCost(rbDessert_None, rbDessert_IceCreamCones, rbDessert_Shakes, rbDessert_Smores) == 3)
        {
            cost = 8;
        }
        else if (GetCost(rbDessert_None, rbDessert_IceCreamCones, rbDessert_Shakes, rbDessert_Smores) == 4)
        {
            cost = 4;
        }
        else if (GetCost(rbTravel_Bus, rbTravel_Bicycle, rbTravel_Car, rbTravel_CarriageRide) == 0)
        {
            cost = 0;
        }
            
        return cost + GetTaxRate(cost);
        }


        /// <summary>
        /// calculates the taxes from dessert
        /// </summary>
        /// <returns>taxes from dessert (double)</returns>
        private double GetDessertTaxes()
        {
            double cost = 0;

            if (GetCost(rbDessert_None, rbDessert_IceCreamCones, rbDessert_Shakes, rbDessert_Smores) == 1)
            {
                cost = 0;
            }
            else if (GetCost(rbDessert_None, rbDessert_IceCreamCones, rbDessert_Shakes, rbDessert_Smores) == 2)
            {
                cost = 3;
            }
            else if (GetCost(rbDessert_None, rbDessert_IceCreamCones, rbDessert_Shakes, rbDessert_Smores) == 3)
            {
                cost = 8;
            }
            else if (GetCost(rbDessert_None, rbDessert_IceCreamCones, rbDessert_Shakes, rbDessert_Smores) == 4)
            {
                cost = 4;
            }
            else if (GetCost(rbTravel_Bus, rbTravel_Bicycle, rbTravel_Car, rbTravel_CarriageRide) == 0)
            {
                cost = 0;
            }

            return GetTaxRate(cost);
        }


        /// <summary>
        /// Puts the Radio Buttons from Entertainment into the GetCost method, calculates taxes, outputs the cost for Entertainment.
        /// </summary>
        /// <returns>The cost for the checked entertainment radio button (double)</returns>
        private double GetEntertainmentCost()
        {
            double cost = 0;

             
            if (GetCost(rbEntertainment_TakeAWalk, rbEntertainment_Bowling, rbEntertainment_Movie,
                rbEntertainment_MinatureGolf) == 1)
            {
                    cost = 0;
            }
            else if (GetCost(rbEntertainment_TakeAWalk, rbEntertainment_Bowling, rbEntertainment_Movie,
                rbEntertainment_MinatureGolf) == 2)
            {
                cost = 6;
            }
            else if (GetCost(rbEntertainment_TakeAWalk, rbEntertainment_Bowling, rbEntertainment_Movie,
                rbEntertainment_MinatureGolf) == 3)
            {
                cost = 26;
            }
            else if (GetCost(rbEntertainment_TakeAWalk, rbEntertainment_Bowling, rbEntertainment_Movie,
                rbEntertainment_MinatureGolf) == 4)
            {
                cost = 10;
            }
            else if (GetCost(rbTravel_Bus, rbTravel_Bicycle, rbTravel_Car, rbTravel_CarriageRide) == 0)
            {
                cost = 0;
            }
            
            return cost + GetTaxRate(cost);
        }


        /// <summary>
        /// calculates taxes for entertainment
        /// </summary>
        /// <returns>taxes for entertainment (double)</returns>
        private double GetEntertainmentTaxes()
        {
            double cost = 0;


            if (GetCost(rbEntertainment_TakeAWalk, rbEntertainment_Bowling, rbEntertainment_Movie,
                rbEntertainment_MinatureGolf) == 1)
            {
                cost = 0;
            }
            else if (GetCost(rbEntertainment_TakeAWalk, rbEntertainment_Bowling, rbEntertainment_Movie,
                rbEntertainment_MinatureGolf) == 2)
            {
                cost = 6;
            }
            else if (GetCost(rbEntertainment_TakeAWalk, rbEntertainment_Bowling, rbEntertainment_Movie,
                rbEntertainment_MinatureGolf) == 3)
            {
                cost = 26;
            }
            else if (GetCost(rbEntertainment_TakeAWalk, rbEntertainment_Bowling, rbEntertainment_Movie,
                rbEntertainment_MinatureGolf) == 4)
            {
                cost = 10;
            }
            else if (GetCost(rbTravel_Bus, rbTravel_Bicycle, rbTravel_Car, rbTravel_CarriageRide) == 0)
            {
                cost = 0;
            }

            return GetTaxRate(cost);
        }


        /// <summary>
        /// Resets all radio buttons, tip trackbar, tip value, tax rate, and total cost.
        /// </summary>
        private void Reset()
        {
            // Reset all radio buttons
            rbDessert_IceCreamCones.Checked = false;
            rbDessert_None.Checked = false;
            rbDessert_Shakes.Checked = false;
            rbDessert_Smores.Checked = false;
            rbDinner_Applebees.Checked = false;
            rbDinner_McDonalds.Checked = false;
            rbDinner_None.Checked = false;
            rbDinner_SandPipers.Checked = false;
            rbEntertainment_Bowling.Checked = false;
            rbEntertainment_MinatureGolf.Checked = false;
            rbEntertainment_Movie.Checked = false;
            rbEntertainment_TakeAWalk.Checked = false;
            rbTravel_Bicycle.Checked = false;
            rbTravel_Bus.Checked = false;
            rbTravel_Car.Checked = false;
            rbTravel_CarriageRide.Checked = false;
            rbTipPercent.Checked = true;
            rbTipTotal.Checked = false;

            //reset tip trackbar
            tkbrTipPercent.Value = 5;

            // reset tip value
            txtTipTotal.Text = "0.00";
            txtTipPercent.Text = "5.0";
            tipValue = 5 * PERCENT_CONVERSION;

            // reset tax rate
            lblTaxTotal_Output.Text = "$0.00";
            txtTaxRate.Text = "0.0";

            // reset total cost
            lblTotalCost_Output.Text = "$0.00";
        }


        /*  /// <summary>
          /// Gives an error message if there's a number outside of parameters.
          /// </summary>
          /// <param name="num1">double</param>
          /// <param name="lowerLimit">int</param>
          /// <param name="upperLimit">int</param>
          /// <returns>true if everything looks accurate</returns>
          private bool Verification(double numberToVerifyIsInBounds, int lowerLimit, int upperLimit)
          {
              if (numberToVerifyIsInBounds >= upperLimit || numberToVerifyIsInBounds < lowerLimit)
              {
                  MessageBox.Show("I f***ed up.\r\nUnexpected results.");
                  Reset();
                  return false;
              }
              else
              {
                  return true;
              }
          }*/


        /// <summary>
        /// Outputs the total cost after verifying everything is okay, according to Verification method.
        /// </summary>
        /// <param name="numberToOutput">double</param>
        /// <param name="controlToOutputTo">string</param>
        //private void Output(bool passedVerification, double numberToOutput, Control controlToOutputTo)
        private void Output(double numberToOutput, Control controlToOutputTo)
        {
            //if (passedVerification == true)
            {
                controlToOutputTo.Text = numberToOutput.ToString("c2");
            }
        }


        /// <summary>
        /// Checks to see which tip input to use
        /// </summary>
        /// <returns>true if using tip total input (bool)</returns>
        private bool IsUsingTipTotal()
        {
            bool useTotal = false;
            if (rbTipTotal.Checked)
            {
                useTotal = true;
                txtTipPercent.Text = tipRate.ToString("n1");
                
            }
            return useTotal;
        }


        /// <summary>
        /// Hides tip info so user is aware of which input i'm using for calculations
        /// </summary>
       /* private void TipIsHidden()
        {
            if (IsUsingTipTotal())
            {
                tkbrTipPercent.Visible = false;
                txtTipPercent.Visible = false;
                txtTipTotal.Visible = true;
                txtTipPercent.Text = tkbrTipPercent.Value.ToString();
            }
            else
            {
                txtTipTotal.Visible = false;
                tkbrTipPercent.Visible = true;
                txtTipPercent.Visible = true;
                txtTipTotal.Text = "0.00";
            }
        }*/


        /// <summary>
        /// Adds up all costs, and outputs result to lblTotalCost_Output
        /// </summary>
        private void CalculateTotalCosts()
        {
            double totalCost = 0;

            //add up all costs (taxes and tips are included already, in the following methods)
            totalCost += GetTravelCost();
            totalCost += GetDinnerCost();
            totalCost += GetDessertCost();
            totalCost += GetEntertainmentCost();

            //Output total costs
            //Output(Verification(totalCost, 0, 7000), totalCost, lblTotalCost_Output);
            Output(totalCost, lblTotalCost_Output);
        }

        /// <summary>
        /// sets tip controls appropriately, displaying correct data
        /// </summary>
        private void TipValues()
        {
            // output additional tip information

            // What to do if using TIP TOTAL
            if (rbTipTotal.Checked)
            {

                txtTipPercent.Text = tipRate.ToString("n1");
                txtTipPercent.Visible = true;
                txtTipTotal.Visible = true;
                if (double.Parse(txtTipPercent.Text) >= 5 && double.Parse(txtTipPercent.Text) <= 35)
                {
                    tkbrTipPercent.Value = int.Parse((double.Parse(txtTipPercent.Text)).ToString("n0"));
                    tkbrTipPercent.Visible = true;
                }
            }

            // What to do if using TIP PERCENT
            else
            {
                txtTipTotal.Visible = true;
                txtTipTotal.Text = tipCost.ToString("n2");
                txtTipPercent.Visible = true;
                if (double.Parse(txtTipPercent.Text) >= 5 && double.Parse(txtTipPercent.Text) <= 35)
                {
                    tkbrTipPercent.Value = int.Parse((double.Parse(txtTipPercent.Text)).ToString("n0"));
                    tkbrTipPercent.Visible = true;
                }
            }

        }


        /// <summary>
        /// Generic method for checking for  correct numerical input from a .text string
        /// </summary>
        /// <param name="numericalInput">string</param>
        /// <param name="nullValue">string</param>
        private bool CheckTip(Control numericalInput, string nullValue)
        {            if (numericalInput.Text != nullValue.ToString())
            {
                if (double.TryParse(numericalInput.Text, out double tryTT))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Please enter a valid double data-type-character");
                    return false;
                }
            }
            else
            {
                return true;
            }
        }


        /// <summary>
        /// calculate taxes for output
        /// </summary>
        private void TaxValues()
        {
            taxTotal = 0;
            // add up all taxes specifically
            taxTotal += GetTravelTaxes();
            taxTotal += GetEntertainmentTaxes();
            taxTotal += GetDinnerTaxes();
            taxTotal += GetDessertTaxes();

            // output total taxes
            //Output(Verification(taxTotal, 0, 1400), taxTotal, lblTaxTotal_Output);
            Output(taxTotal, lblTaxTotal_Output);
        }


        /*/// <summary>
        /// Generic method to verify the numerical string in a control is within specified range.
        /// </summary>
        /// <param name="controlToCheckIsWithinBounds">Control</param>
        /// <param name="lowerLimit">double</param>
        /// <param name="upperLimit">double</param>
        private void IsWithinBounds(Control controlToCheckIsWithinBounds, double lowerLimit, double upperLimit)
        {
            if (double.Parse(controlToCheckIsWithinBounds.Text) < lowerLimit || double.Parse(controlToCheckIsWithinBounds.Text) > upperLimit)
            {
                if (double.Parse(controlToCheckIsWithinBounds.Text) < lowerLimit)
                {
                    MessageBox.Show("Values must be within the range of " + lowerLimit + " to " + upperLimit + ".");
                    controlToCheckIsWithinBounds.Text = lowerLimit.ToString();
                }
                else
                {
                    MessageBox.Show("Values must be within the range of " + lowerLimit + " to " + upperLimit + ".");
                    controlToCheckIsWithinBounds.Text = upperLimit.ToString();
                }
            }
        }*/

        
        /// <summary>
        /// Limits the decimal (or adds one), to parameter defined value, 
        /// or can be more widely used to adjust any ToString properties.
        /// </summary>
        /// <param name="controlToLimitDecimalPlacesFor">Control</param>
        /// <param name="stringProperties">int</param>
        private void DecimalLimiter(Control controlToLimitDecimalPlacesFor, string stringProperties)
        {
            string numDec = "n" + stringProperties;
            controlToLimitDecimalPlacesFor.Text = double.Parse(controlToLimitDecimalPlacesFor.Text).ToString(stringProperties);
        }
        


        // ***********End of Custom Methods*********** //
        

        private void btnCalculate_Click(object sender, EventArgs e)// Add up costs and display results.
        {
            CalculateTotalCosts();
            TipValues();
            TaxValues();
        }

        private void btnClose_Click(object sender, EventArgs e)// close the form
        {
            this.Close();
        }

        private void tkbrTipValue_ValueChanged(object sender, EventArgs e)// auto-adjusts tip percent when trackbar value changes.
        {
            txtTipPercent.Text = tkbrTipPercent.Value.ToString();
            CalculateTotalCosts();
            TipValues();
            TaxValues();
        }

        private void frmDateNightCalculator_Load(object sender, EventArgs e) // Clear initial values upon load
        {
            txtTipPercent.Text = "5.0";
            lblTaxTotal_Output.Text = "$0.00";
            lblTotalCost_Output.Text = "$0.00";
        }
        

        private void btnReset_Click(object sender, EventArgs e) //reset form when clicked
        {
            Reset();
        }

        private void rbTipPercent_CheckedChanged(object sender, EventArgs e) // check to see what's changed, modify controls accordingly.
        {
            //TipIsHidden();
        }

        private void rbTipTotal_CheckedChanged(object sender, EventArgs e) // check to see what's changed, modify controls accordingly.
        {
            //TipIsHidden();
        }
        
        private void txtTipPercent_TextChanged(object sender, EventArgs e)
        {
            if (CheckTip(txtTipPercent, "5.0") == false)
            {
                txtTipPercent.Text = "5.0";
            }
            //TipLimiter();
            IsUsingTipTotal();
            //IsWithinBounds(txtTipPercent, 0, 1000);
            DecimalLimiter(txtTipPercent,"n1");
            if (double.Parse(txtTipPercent.Text) >= 5 && double.Parse(txtTipPercent.Text) <= 35)
            {
                tkbrTipPercent.Value = int.Parse((double.Parse(txtTipPercent.Text)).ToString("n0"));
            }
            CalculateTotalCosts();
            TipValues();
            TaxValues();
        }

        private void txtTipTotal_TextChanged(object sender, EventArgs e)
        {
            if (CheckTip(txtTipTotal, "0.00") == false)
            {
                txtTipTotal.Text = "0.00";
            }
            //TipLimiter();
            IsUsingTipTotal();
            //IsWithinBounds(txtTipTotal, 0, 5500);
            DecimalLimiter(txtTipTotal, "n2");
            CalculateTotalCosts();
            if (double.Parse(txtTipPercent.Text) >= 5 && double.Parse(txtTipPercent.Text) <= 35)
            {
                tkbrTipPercent.Value = int.Parse((double.Parse(txtTipPercent.Text)).ToString("n0"));
                tkbrTipPercent.Visible = true;
            }
            TipValues();
            TaxValues();

        }

        private void txtTaxRate_TextChanged(object sender, EventArgs e)
        {
            if (CheckTip(txtTaxRate, "0.0") == false)
            {
                txtTaxRate.Text = "0.0";
            }
            //TipLimiter();
            //IsWithinBounds(txtTaxRate, 0, 1000);
            DecimalLimiter(txtTaxRate, "n1");
            if (double.Parse(txtTipPercent.Text) >= 5 && double.Parse(txtTipPercent.Text) <= 35)
            {
                tkbrTipPercent.Value = int.Parse((double.Parse(txtTipPercent.Text)).ToString("n0"));
                tkbrTipPercent.Visible = true;
            }
            CalculateTotalCosts();
            TipValues();
            TaxValues();
        }

        private void rbTipPercent_Click(object sender, EventArgs e)
        {
            txtTipPercent.Focus();
            CalculateTotalCosts();
            TipValues();
            TaxValues();
        }

        private void txtTipPercent_Click(object sender, EventArgs e)
        {
            rbTipTotal.Checked = false;
            rbTipPercent.Checked = true;
        }

        private void txtTipTotal_Click(object sender, EventArgs e)
        {
            rbTipPercent.Checked = false;
            rbTipTotal.Checked = true;
        }

        private void rbTipTotal_Click(object sender, EventArgs e)
        {
            txtTipTotal.Focus();
            CalculateTotalCosts();
            TipValues();
            TaxValues();
        }

        private void tkbrTipPercent_Enter(object sender, EventArgs e)
        {
            rbTipTotal.Checked = false;
            rbTipPercent.Checked = true;
        }

        private void frmDateNightCalculator_Click(object sender, EventArgs e)
        {
            CalculateTotalCosts();
            TipValues();
            TaxValues();
        }


        //////////////////// Begin click events for radio buttons ////////////////////////////

        private void rbBus_Click(object sender, EventArgs e)
        {
            CalculateTotalCosts();
            TipValues();
            TaxValues();
        }

        private void rbBicycle_Click(object sender, EventArgs e)
        {
            CalculateTotalCosts();
            TipValues();
            TaxValues();
        }

        private void rbCar_Click(object sender, EventArgs e)
        {
            CalculateTotalCosts();
            TipValues();
            TaxValues();
        }

        private void rbCarriageRide_Click(object sender, EventArgs e)
        {
            CalculateTotalCosts();
            TipValues();
            TaxValues();
        }

        private void rbTakeAWalk_Click(object sender, EventArgs e)
        {
            CalculateTotalCosts();
            TipValues();
            TaxValues();
        }

        private void rbBowling_Click(object sender, EventArgs e)
        {
            CalculateTotalCosts();
            TipValues();
            TaxValues();
        }

        private void rbMovie_Click(object sender, EventArgs e)
        {
            CalculateTotalCosts();
            TipValues();
            TaxValues();
        }

        private void rbMiniatureGolf_Click(object sender, EventArgs e)
        {
            CalculateTotalCosts();
            TipValues();
            TaxValues();
        }

        private void rbNone_Click(object sender, EventArgs e)
        {
            CalculateTotalCosts();
            TipValues();
            TaxValues();
        }

        private void rbMcDonalds_Click(object sender, EventArgs e)
        {
            CalculateTotalCosts();
            TipValues();
            TaxValues();
        }

        private void rbAppleBees_Click(object sender, EventArgs e)
        {
            CalculateTotalCosts();
            TipValues();
            TaxValues();
        }

        private void rbSandPipers_Click(object sender, EventArgs e)
        {
            CalculateTotalCosts();
            TipValues();
            TaxValues();
        }

        private void rbNone2_Click(object sender, EventArgs e)
        {
            CalculateTotalCosts();
            TipValues();
            TaxValues();
        }

        private void rbIceCreamCones_Click(object sender, EventArgs e)
        {
            CalculateTotalCosts();
            TipValues();
            TaxValues();
        }

        private void rbShakes_Click(object sender, EventArgs e)
        {
            CalculateTotalCosts();
            TipValues();
            TaxValues();
        }

        private void rbSmores_Click(object sender, EventArgs e)
        {
            CalculateTotalCosts();
            TipValues();
            TaxValues();
        }
        //////////////// End Click Events //////////////////
    }
}
