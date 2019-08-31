using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Memory
{
    public partial class frmCustomSelection : Form
    {
        frmGameSelect formGameSelect;
        /// <summary>
        /// Initialize form, and sets instance(?) of main form
        /// </summary>
        /// <param name="formGameSelect">The name of the main form (Form)</param>
        public frmCustomSelection(frmGameSelect formGameSelect)
        {
            InitializeComponent();
            this.formGameSelect = formGameSelect;
        }

        /// <summary>
        /// Enables the Play button, and displays the play mode on button text
        /// </summary>
        private void PositiveIntegerCorrect()
        {
            btnCustomPlay.Text = "Play Memory: " + tbNumberOfRows_Input.Text + " x " + tbNumberOfColumns_Input.Text;
            btnCustomPlay.BackColor = DefaultBackColor;
            btnCustomPlay.Enabled = true;
        }

        /// <summary>
        /// Disables the Play button, and changes the color of the button to red, with an error message.
        /// </summary>
        private void Error(string message = "Please Enter Positive Integers.")
        {
            btnCustomPlay.Text = message;
            btnCustomPlay.BackColor = Color.FromArgb(255, 192, 192);
            btnCustomPlay.Enabled = false;
        }

        /// <summary>
        /// Tests both textboxes for positive integers, disabling the button and displaying an error if invalid input
        /// </summary>
        /// <param name="numToTestOne">number of rows textbox (Control)</param>
        /// <param name="numToTestTwo">number of columns textbox (Control)</param>
        private void IsPositiveInteger(Control numToTestOne, Control numToTestTwo)
        {
            if (IsPositiveInteger(tbNumberOfRows_Input) && IsPositiveInteger(tbNumberOfColumns_Input))
            {
                PositiveIntegerCorrect();
            }
            else Error();
        }

        /// <summary>
        /// Checks an individual textbox to verify its a positive integer.
        /// </summary>
        /// <param name="numberToTest">the textbox to test (Control)</param>
        /// <returns>true if it's a positive integer (bool)</returns>
        private bool IsPositiveInteger(Control numberToTest)
        {
            try
            {
                if (numberToTest.Text != "")
                {
                    try
                    {
                        if (int.Parse(numberToTest.Text) <= 0) return false;

                        if (int.Parse(numberToTest.Text) > 0 && 
                            int.Parse(numberToTest.Text) == double.Parse(numberToTest.Text))
                            return true;

                        if (int.Parse(numberToTest.Text) != double.Parse(numberToTest.Text))
                            return false;
                    }
                    catch
                    {
                        Error();
                        return false;
                    }
                }
                else return false;
            }
            catch
            {
                MessageBox.Show("Something Broke.\r\nfrmCustomSelection.IsPositiveInteger");
                numberToTest.Text = "";
                return false;
            }
            return false;
        }

        /// <summary>
        /// Verifies textbox is an even number, or yells at user and disables the button
        /// </summary>
        /// <returns>true if there's an even dimension (bool)</returns>
        private bool CheckForEvenElements()
        {
            try
            {
                if (int.Parse(tbNumberOfRows_Input.Text) % 2 == 0 || int.Parse(tbNumberOfColumns_Input.Text) % 2 == 0) return true;
                else
                {
                    Error("One of the dimensions must be even.");
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("SomethingBroke.\r\nfrmCustomSelection.CheckForEvenElements");
                tbNumberOfColumns_Input.Text = "";
                tbNumberOfRows_Input.Text = "";
                return false;
            }
        }

        /// <summary>
        /// If everything is in order, it sends the requested data back to frmGameSelect, to populate a new game.
        /// </summary>
        public void PlayCustom()
        {
            // cancels the process and resets fields if invalid input is entered
            if (CheckForEvenElements() == false) return; 
            IsPositiveInteger(tbNumberOfRows_Input, tbNumberOfColumns_Input);
            this.Owner.Show();
            formGameSelect.rows = int.Parse(tbNumberOfRows_Input.Text);
            formGameSelect.cols = int.Parse(tbNumberOfColumns_Input.Text);
            this.DialogResult = DialogResult.OK; // needs this verification for the game to load.
            this.Close();
        }

        /// <summary>
        /// Close this form, go back to choosing a difficulty
        /// </summary>
        private void Cancel()
        {
            this.Owner.Show();
            this.Close();
            formGameSelect.rows = 0;
            formGameSelect.cols = 0;
        }

        /// <summary>
        /// Close entire program
        /// </summary>
        private void Quit()
        {
            this.Owner.Close();
            this.Close();
        }

        //*************************** Begin Event Handlers ***************************//

        private void tbNumberOfRows_Input_TextChanged(object sender, EventArgs e)
        {
            IsPositiveInteger(tbNumberOfRows_Input, tbNumberOfColumns_Input);
        }

        private void tbNumberOfColumns_Input_TextChanged(object sender, EventArgs e)
        {
            IsPositiveInteger(tbNumberOfRows_Input, tbNumberOfColumns_Input);
        }

        private void btnCustomPlay_Click(object sender, EventArgs e)
        {
            PlayCustom();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Quit();
        }
    }
}
