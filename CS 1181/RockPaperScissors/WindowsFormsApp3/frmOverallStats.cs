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
    public partial class frmOverallStats : Form
    {
        public frmOverallStats()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // hide this form. unsure why this was necesary.
            this.Hide();

            // open frmRockPaperScissors
            frmRockPaperScissors frmRockPaperScissors = new frmRockPaperScissors();
            frmRockPaperScissors.ShowDialog();

            // close this form
            this.Close();
        }

        private void frmOverallStats_Load(object sender, EventArgs e)
        {
            // open files
            StreamReader inputFile1;
            StreamReader inputFile2;
            StreamReader inputFile3;
            StreamReader inputFile4;
            inputFile1 = File.OpenText("PlayerNames.txt");
            inputFile2 = File.OpenText("GamesPlayed.txt");
            inputFile3 = File.OpenText("PlayerOneWins.txt");
            inputFile4 = File.OpenText("PlayerTwoWins.txt");

            // read files
            string player1 = inputFile1.ReadLine();
            string player2 = inputFile1.ReadLine();
            string header = "Rock, Paper, Scissors! Overall Statistics:";
            string c0r1 = "Players";
            string c0r2 = player1; // player 1
            string c0r3 = player2; // player 2
            string c1r1 = "Wins:";
            string c1r2 = inputFile3.ReadLine();
            c1r2 = inputFile3.ReadLine(); // P1 wins
            string c1r3 = inputFile4.ReadLine();
            c1r3 = inputFile4.ReadLine(); // P2 wins
            string c3r1 = "Losses:";
            string c7r2 = inputFile2.ReadLine();
            c7r2 = inputFile2.ReadLine();
            string c7r3 = c7r2;
            string c5r2 = (int.Parse(c7r2) - int.Parse(c1r2) - int.Parse(c1r3)).ToString();// ties
            string c5r3 = c5r2;
            string c2r1 = "Win %:";
            string c2r2 = (double.Parse(c1r2) / double.Parse(c7r2)).ToString("p2"); // P1 win %
            string c2r3 = (double.Parse(c1r3) / double.Parse(c7r3)).ToString("p2"); // P2 win %
            string c3r2 = (int.Parse(c7r2) - int.Parse(c1r2) - int.Parse(c5r2)).ToString(); // P1 losses
            string c3r3 = (int.Parse(c7r3) - int.Parse(c1r3) - int.Parse(c5r3)).ToString(); // P2 losses
            string c4r1 = "Loss %:";
            string c4r2 = (double.Parse(c3r2) / double.Parse(c7r2)).ToString("p2"); // P1 loss %
            string c4r3 = (double.Parse(c3r3) / double.Parse(c7r3)).ToString("p2"); // P2 loss %
            string c5r1 = "Ties:";
            string c6r1 = "Tie %"; 
            string c6r2 = (double.Parse(c5r2) / double.Parse(c7r2)).ToString("p2"); // P1 tie %
            string c6r3 = (double.Parse(c5r3) / double.Parse(c7r3)).ToString("p2"); // P2 tie %

            // display saved files
            txtOverallStats.Text =
                header +
                Environment.NewLine +
                Environment.NewLine +
                c0r1.PadRight(14) + " | " + c1r1.PadRight(11) + " | " + c2r1.PadRight(6) + " | " + c3r1.PadRight(11) + " | " + c4r1.PadRight(6) + " | " + c5r1.PadRight(11) + " | " + c6r1.PadRight(6) + " | " + c7r2 +
                Environment.NewLine +
                c0r2.PadRight(17) + c1r2.PadRight(14) + c2r2.PadRight(9) + c3r2.PadRight(14) + c4r2.PadRight(9) + c5r2.PadRight(14) + c6r2.PadRight(9) + c7r2 +
                Environment.NewLine +
                c0r3.PadRight(17) + c1r3.PadRight(14) + c2r3.PadRight(9) + c3r3.PadRight(14) + c4r3.PadRight(9) + c5r3.PadRight(14) + c6r3.PadRight(9) + c7r3 +
                Environment.NewLine;
            
            // close files
            inputFile1.Close();
            inputFile2.Close();
            inputFile3.Close();
            inputFile4.Close();
        }
    }
}
