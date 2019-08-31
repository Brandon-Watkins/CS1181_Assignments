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

namespace WindowsFormsApp3
{
    public partial class frmWelcomeForm : Form
    {
        public frmWelcomeForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPlayerOneName_Enter(object sender, EventArgs e)
        {
            if (txtPlayerOneName.Text == "Player One")
            {
                txtPlayerOneName.Text = "";
            }
        }

        private void txtPlayerOneName_Leave(object sender, EventArgs e)
        {
            if (txtPlayerOneName.Text == "")
            {
                txtPlayerOneName.Text = "Player One";
            }
            if (txtPlayerOneName.Text.Length > 12) // to keep names from interfering with throw results
            {
                txtPlayerOneName.Text = "Player One";
                MessageBox.Show("Please limit names to 12 characters each.");
            }
        }

        private void txtPlayerTwoName_Enter(object sender, EventArgs e)
        {
            if (txtPlayerTwoName.Text == "Player Two")
            {
                txtPlayerTwoName.Text = "";
            }
        }

        private void txtPlayerTwoName_Leave(object sender, EventArgs e)
        {
            if (txtPlayerTwoName.Text == "")
            {
                txtPlayerTwoName.Text = "Player Two";
            }
            if (txtPlayerTwoName.Text.Length > 12) // to keep names from interfering with throw results
            {
                txtPlayerTwoName.Text = "Player Two";
                MessageBox.Show("Please limit names to 12 characters each.");
            }
        }

        private void btnLoadfrmRockPaperScissors_Click(object sender, EventArgs e)
        {
            // save player names
            StreamWriter outputFile;
            outputFile = File.CreateText("PlayerNames.txt");
            outputFile.WriteLine(txtPlayerOneName.Text);
            outputFile.WriteLine(txtPlayerTwoName.Text);
            outputFile.Close();

            string player1 = lblPlayerOneName.Text;
            string player2 = lblPlayerTwoName.Text;

            StreamWriter sw2;
            sw2 = File.CreateText("PlayerOneWins.txt");
            sw2.WriteLine(player1 + " won:");
            sw2.Write("0");
            sw2.Close();

            StreamWriter sw3;
            sw3 = File.CreateText("PlayerTwoWins.txt");
            sw3.WriteLine(player2 + " won:");
            sw3.Write("0");
            sw3.Close();

            StreamWriter sw4;
            sw4 = File.CreateText("GamesPlayed.txt");
            sw4.WriteLine("Games Played:");
            sw4.Write("0");
            sw4.Close();
        

            this.Hide();

            // open frmRockPaperScissors
            frmRockPaperScissors frmRockPaperScissors = new frmRockPaperScissors();
            frmRockPaperScissors.ShowDialog();

            // close this form
            //this.Close();
        }
    }
}
