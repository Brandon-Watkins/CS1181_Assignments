  /*
frmFactorialFinder.cs
CS 1181
Brandon Watkins 
9 February 2019
Robert Howe
Description: Application that calculates and displays factorials between 1 and a user-defined integer less than 21.
WOW:
Added numbers to the trackbar to help the user to see which number they were selecting, in addition to an
    automatically updated text-based description of their selection.
Made the trackbar numbers move to keep their relations with the resizing of the form.
Made Several of the trackbar numbers visible/invisible to compensate for an inaccuracy in their relations to 
    their "ticks", during the resizing event.
Had to calculate the size of the newly resized window, to move the interior trackbar numbers, to maintain
    their correct proportion/relation to their ticks.
Added a button to calculate a random factorial.
Added a button to exit the application.
Couldn't figure out how to make everything keep its proportions, so I limited the resize so that all buttons and textboxes
    are visible (You will still need to scroll down to see the full bottom textbox, but at least you will know it's there).
...Added scroll bars.
<enter> will use the generate factorials button.
<esc> will use the quit button.
<shift> + <r> will use the generate random factorial button.
<shift> + <f> will use the generate factorials button.
<shit> + <Q> will use the quit button.
adjusting the trackbar will clear the previous results, and update the "n" factorial textbox.

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


namespace frm.FactorialFinder
{
    public partial class frmFactorialFinder : Form
    {

        // misc class-variables
        String nFactorials = "1";

        public frmFactorialFinder()
        {
            InitializeComponent();
        } // Initialize form

        private void tkbrFactorialTrackbar_Input_Scroll(object sender, EventArgs e) 
        {
            // Update the lblFactorialsUpTo_Output with trackbar's current location.
            lblFactorialsUpTo_Output.Text = "Factorials up to:   " + tkbrFactorialTrackBar_Input.Value;

            // Clear previous factorial results.
            txtFactorialsInt_Output.Text = "";
            txtFactorialsLong_Output.Text = "";
        } // TrackBar Position reset

        private void tkbrFactorialTrackbar_Input_ValueChanged(object sender, EventArgs e)
        {
            
            nFactorials = "";
            // list n factorials.
            for (int n = 1; n <= tkbrFactorialTrackBar_Input.Value; n++)
            {
                nFactorials += n + "!\r\n";
                
            }
            // automatically update N factorials.
            txtNFactorialsInt_Output.Text = nFactorials;
            txtNFactorialsLong_Output.Text = nFactorials;
        }  // TrackBar sets factorial tracking text box

        private void btnGenerateFactorials_Click(object sender, EventArgs e)
        {
            int productTotal = 1; // Used to sum up the products
            long productTotalLong = 1;
            String productString = ""; // Just used to populate the factorial output
            String productStringLong = "";

            for (int outer = 1; outer <= tkbrFactorialTrackBar_Input.Value; outer++)
            {
                productTotal = 1;
                productTotalLong = 1;
                for (int inner = 1; inner <= outer; inner++)
                {
                    if (inner < outer)
                    {
                        productString += inner.ToString("n0") + " * ";
                        productTotal *= inner;
                        productStringLong += inner.ToString("n0") + " * ";
                        productTotalLong *= inner;
                    }
                    else
                    {
                        
                        productTotal *= inner;
                        productTotalLong *= inner;

                        if (productTotal == productTotalLong)
                        {
                            productString += inner.ToString("n0") + " = " + productTotal.ToString("n0");
                            productStringLong += inner.ToString("n0") + " = " + productTotalLong.ToString("n0");
                        }

                        else
                        {
                            productString += inner.ToString("n0") + " = " + productTotal.ToString("n0") + "   (Data Overflow!!!)";
                            productStringLong += inner.ToString("n0") + " = " + productTotalLong.ToString("n0");
                        }
                    
                    }
                }
                productString += "\r\n";
                productStringLong += "\r\n";
            }
            txtFactorialsInt_Output.Text = productString;
            txtFactorialsLong_Output.Text = productStringLong;

        } // Generates the factorial product outputs

        private void frmFactorialFinder_ResizeBegin(object sender, EventArgs e)
        {
            // make invisible: lblTrackBarFivePosition, lblTrackBarTenPosition, and lblTrackBarFifteenPosition, 
            // as they don't move properly while actively resizing the form.
            lblTrackBarFivePosition.Visible = false;
            lblTrackBarTenPosition.Visible = false;
            lblTrackBarFifteenPosition.Visible = false;

        } // Form resize temporarily clears trackbar label positions

        private void frmFactorialFinderResizeEnd(object sender, EventArgs e)
        {
            // make visible: lblTrackBarFivePosition, lblTrackBarTenPosition, and lblTrackBarFifteenPosition.
            lblTrackBarFivePosition.Visible = true;
            lblTrackBarTenPosition.Visible = true;
            lblTrackBarFifteenPosition.Visible = true;

            // Find new form size.
            double heightNew = tkbrFactorialTrackBar_Input.Size.Height;
            double widthNew = tkbrFactorialTrackBar_Input.Size.Width;

            // calculate  where 5, 10 and 15 need to be placed.
            // set new locations for 5, 10, and 15.
            if (widthNew > 1600)
            {
                int fifteenPositionNew = (int)(widthNew * 0.707 + 50);
                lblTrackBarFifteenPosition.Location = new Point(fifteenPositionNew, 60);

                int tenPositionNew = (int)(widthNew * 0.46 + 31);
                lblTrackBarTenPosition.Location = new Point(tenPositionNew, 60);

                int fivePositionNew = (int)(widthNew * 0.216 + 6);
                lblTrackBarFivePosition.Location = new Point(fivePositionNew, 60);
            }

            else if (widthNew <= 1600 && widthNew > 1300)
            {
                int fifteenPositionNew = (int)(widthNew * 0.707 + 40);
                lblTrackBarFifteenPosition.Location = new Point(fifteenPositionNew, 60);

                int tenPositionNew = (int)(widthNew * 0.46 + 26);
                lblTrackBarTenPosition.Location = new Point(tenPositionNew, 60);

                int fivePositionNew = (int)(widthNew * 0.216 + 7);
                lblTrackBarFivePosition.Location = new Point(fivePositionNew, 60);
            }

            else if (widthNew <= 1300 && widthNew > 1000)
            {
                int fifteenPositionNew = (int)(widthNew * 0.707 + 31);
                lblTrackBarFifteenPosition.Location = new Point(fifteenPositionNew, 60);

                int tenPositionNew = (int)(widthNew * 0.46 + 20);
                lblTrackBarTenPosition.Location = new Point(tenPositionNew, 60);

                int fivePositionNew = (int)(widthNew * 0.216 + 7);
                lblTrackBarFivePosition.Location = new Point(fivePositionNew, 60);
            }

            else if (widthNew <= 1000 && widthNew > 650)
            {
                int fifteenPositionNew = (int)(widthNew * 0.707 + 22);
                lblTrackBarFifteenPosition.Location = new Point(fifteenPositionNew, 60);

                int tenPositionNew = (int)(widthNew * 0.46 +15);
                lblTrackBarTenPosition.Location = new Point(tenPositionNew, 60);

                int fivePositionNew = (int)(widthNew * 0.216 + 9);
                lblTrackBarFivePosition.Location = new Point(fivePositionNew, 60);
            }

            else if (widthNew <= 650)
            {
                int fifteenPositionNew = (int)(widthNew * 0.707 + 15);
                lblTrackBarFifteenPosition.Location = new Point(fifteenPositionNew, 60);

                int tenPositionNew = (int)(widthNew * 0.46 + 10);
                lblTrackBarTenPosition.Location = new Point(tenPositionNew, 60);

                int fivePositionNew = (int)(widthNew * 0.216 + 10);
                lblTrackBarFivePosition.Location = new Point(fivePositionNew, 60);
            }

        } // Resetting the trackbar label positions

        private void btnGenerateRandomFactorials_Click(object sender, EventArgs e)
        {
            // create random object
            Random random = new Random();

            // generate a random factorial
            int randomFactorial = random.Next(20);

            // Sending Factorial to "n" textboxes
            txtNFactorialsInt_Output.Text = randomFactorial + "!";
            txtNFactorialsLong_Output.Text = randomFactorial + "!";

            // Declaring variables
            int randomProductInt = 1;
            long randomProductLong = 1;
            String randomProductStringInt = "";
            String randomProductStringLong = "";

            // display the factorial
            for (int i = 1; i <= randomFactorial; i++)
            {
                randomProductInt *= i;
                randomProductLong *= i;

                if(i < randomFactorial)
                {
                    randomProductStringInt += i.ToString("n0") + " * ";
                    randomProductInt *= i;
                    randomProductStringLong += i.ToString("n0") + " * ";
                    randomProductLong *= i;
                }
                else
                {
                    if (randomProductInt == randomProductLong)
                    {
                        randomProductStringInt += i.ToString("n0") + " = " + randomProductInt.ToString("n0");
                        randomProductStringLong += i.ToString("n0") + " = " + randomProductLong.ToString("n0");
                    }

                    else
                    {
                        randomProductStringInt += i.ToString("n0") + " = " + randomProductInt.ToString("n0") + "   (Data Overflow!!!)";
                        randomProductStringLong += i.ToString("n0") + " = " + randomProductLong.ToString("n0");
                    }
                }
                
            }
            txtFactorialsInt_Output.Text = randomProductStringInt;
            txtFactorialsLong_Output.Text = randomProductStringLong;

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            // exit the application
            this.Close();
        } // Closes the application


    }
}
