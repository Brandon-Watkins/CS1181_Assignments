/*
Memory
CS 1181
Brandon Watkins 
2 April 2019
Robert Howe
Description: Play memory, a pair matching game. dynamic board setting, save / read high scores

WOW:
Added multiple forms for:
    choosing difficulty
    entering custom difficulty
        error-proofed the inputs, locking out the button, and displaying an error message with it.
        inputs require that a positive integer is entered, and that one of them is even, 
            to ensure proper pairing.
    displaying game board
Added multiple difficulties (sizes of game boards)
Added the ability to randomnly generate a difficulty
Uses Tags to relate the button matrix with the string matrix
Dynamically generates the button matrix, string matrix, tags, etc.
Buttons change color when clicked, and reset. Is set to display images upon sucessful pairing, but commented out the code in favor of plain text.
Made the main form window display "Memory: <Difficulty Setting> (<Dimensions>) ..Cont below.   
    <Current Timer> / <High Score(for that difficulty)>"
Added the ability to choose the dimensions of your game board
    Game auto populates the game board with the correct number of elements
    if using over 84 elements, it will revert to a number system instead of strings 
        (Still uses string data type, due to lack of time. But it uses numbers to be able to scale dynamically).
I have a default list of 42 strings for use as button "pairs". 
    When game board is 84 elements or smaller, I made it randomly pick from the default list, 
        so that you get different names to pair every time.
    Added a highscore tracker
Saves your highscore to a file, to keep your highscore between play sessions
    Retrieves your high score from said file
Added buttons to close the game
Added buttons to go back to difficulty selection
Got rid of the title bar (control box), because I can.
Added a background image for kicks, and made buttons turn translucent. Didn't have time to adjust the size of the image dynamically.

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
using System.IO;
using System.Threading;

namespace Memory
{
    public partial class frmGameSelect : Form
    {
        // Global Variables
        public Button gameSelectButtonThatWasClicked;
        public Random random;
        public int rows = 0;
        public int cols = 0;
        public string[] nameOptions;
        public string easyHighScore = "N/A";
        public string mediumHighScore = "N/A";
        public string hardHighScore = "N/A";
        public string customHighScore = "N/A";


        /// <summary>
        /// Initialize form, and the random object
        /// </summary>
        public frmGameSelect()
        {
            InitializeComponent();
            random = new Random();
        }

        /// <summary>
        /// Randomly selects a game difficulty, artificially clicking the difficulty's button
        /// </summary>
        public void RandomGameSelect()
        {
            int temp = random.Next(1, 4);
            if (temp == 1)
            {
                // random = easy
                gameSelectButtonThatWasClicked = btnEasy;
            }
            else if (temp == 2)
            {
                // random = medium
                gameSelectButtonThatWasClicked = btnMedium;
            }
            else if (temp == 3)
            {
                // random = hard
                gameSelectButtonThatWasClicked = btnHard;
            }
            else
                MessageBox.Show("Something Broke.\r\nfrmGameSelect.RandomGameSelect");
        }

        /// <summary>
        /// Determines which difficulty was selected, and opens the game form, hiding this form
        /// <param name="sender">button that was clicked (Object)</param>
        public void InitiateNewGame(object sender)
        {
            gameSelectButtonThatWasClicked = (Button)sender;
            this.Hide();
            rows = 0;
            cols = 0;
            DialogResult result;
            
            if (gameSelectButtonThatWasClicked == btnSurpriseMe)
            {
                RandomGameSelect();
            }

            // open form to choose custom dimensions
            if (gameSelectButtonThatWasClicked == btnCustom)
            {
                Form CustomSelection = new frmCustomSelection(this);
                CustomSelection.Owner = this;

                result = CustomSelection.ShowDialog(this);// unsure if i want showdialog or just show

                if(result == DialogResult.Cancel)
                {
                    return;// stops creating the MemoryGame form, if user clicked cancel.
                }
            }

            // open frmMemoryGame form
            Form MemoryGame = new frmMemoryGame(this);
            MemoryGame.Owner = this;
            MemoryGame.Show();
            this.Hide();
        }

        /// <summary>
        /// Creates a text file with default string names for the game's buttons. 42 strings, for a max game size of 84.
        /// </summary>
        private void BorderlandsNames()
        {
            // Write names to save file. ideally id verify contents to avoid rewriting every time, 
            // but im not currently concerned about that.
            StreamWriter names;
            names = File.CreateText("BorderlandsNames.txt");
            names.WriteLine("Axton");
            names.WriteLine("Gaige");
            names.WriteLine("Dr. Tannis");
            names.WriteLine("Maya");
            names.WriteLine("Salvador");
            names.WriteLine("Sir Hammerlock");
            names.WriteLine("Tiny Tina");
            names.WriteLine("Zer0");
            names.WriteLine("Krieg");
            names.WriteLine("Brick");
            names.WriteLine("Claptrap");
            names.WriteLine("Lilith");
            names.WriteLine("Mad Moxxi");
            names.WriteLine("Marcus");
            names.WriteLine("Mordecai");
            names.WriteLine("Roland");
            names.WriteLine("Mr. Torgue");
            names.WriteLine("Scooter");
            names.WriteLine("Handsome Jack");
            names.WriteLine("Dr. Zed");
            names.WriteLine("Crazy Earl");
            names.WriteLine("Ellie");
            names.WriteLine("Borderlands");
            names.WriteLine("Firehawk");
            names.WriteLine("Angel");
            names.WriteLine("Willhelm");
            names.WriteLine("CL4P-TP");
            names.WriteLine("BNK3R");
            names.WriteLine("Warrior");
            names.WriteLine("Knuckle Dragger");
            names.WriteLine("Bad Maw");
            names.WriteLine("BloodWing");
            names.WriteLine("Bone Head");
            names.WriteLine("Moe");
            names.WriteLine("Mortar");
            names.WriteLine("Captain Flynt");
            names.WriteLine("Nine-Toes");
            names.WriteLine("Doc Mercy");
            names.WriteLine("Flesh-Stick");
            names.WriteLine("Psycho");
            names.WriteLine("Cannibal Midget");
            names.WriteLine("God-liath");
            Thread.Sleep(300); // To help ensure all data is written before closing the file.
            names.Close();

            // read names into an array that holds all possible button names, to randomize later.
            StreamReader namesRead;
            namesRead = File.OpenText("BorderlandsNames.txt");
            int index = 0;
            nameOptions = new string[42];
            while (namesRead.EndOfStream == false)
            {
                nameOptions[index] = namesRead.ReadLine();
                index++;
            }
        }

        /// <summary>
        /// Gets all 3 high scores, for initial loading of scores.
        /// </summary>
        public void LoadHighScores()
        {
            GetHighScores("Easy", out easyHighScore, lblHighScoreEasy);
            GetHighScores("Medium", out mediumHighScore, lblHighScoreMedium);
            GetHighScores("Hard", out hardHighScore, lblHighScoreHard);
            GetHighScores("Custom", out customHighScore, lblHighScoreCustom);
        }

        /// <summary>
        /// Gets the highscores, and resets them when erroneous or missing.
        /// </summary>
        /// <param name="difficulty">Easy, Medium, or Hard. (string)</param>
        /// <param name="difficultyHighScore">outputs High Score variable (string)</param>
        /// <param name="lblHighScoreDifficulty">Name of the label to set (Control)</param>
        public void GetHighScores(string difficulty, out string difficultyHighScore, Control lblHighScoreDifficulty)
        {
            double score;
            string scoreStr;

            // If no save file exists, create a new one with score = -1
            if (!File.Exists(difficulty + "HighScore.txt"))
            {
                StreamWriter HS;
                HS = File.CreateText(difficulty + "HighScore.txt");
                HS.WriteLine(-1);
                Thread.Sleep(50);
                HS.Close();
            }
            
            // else if file is empty, add new score = -2
            else if (new FileInfo(difficulty + "HighScore.txt").Length == 0)
            {
                StreamWriter HS;
                HS = File.AppendText(difficulty + "HighScore.txt");
                HS.WriteLine(-1);
                Thread.Sleep(50);
                HS.Close();
            }

            // if file contains non-numeric data, create new file with score = -3
            StreamReader HSR;
            HSR = File.OpenText(difficulty + "HighScore.txt");
            scoreStr = HSR.ReadLine();
            Thread.Sleep(50);
            HSR.Close();
            try
            {
                score = double.Parse(scoreStr);
            }
            catch
            {
                StreamWriter HS;
                HS = File.CreateText(difficulty + "HighScore.txt");
                HS.WriteLine(-1);
                Thread.Sleep(50);
                HS.Close();
                score = -3;
            }

            // if score <= 0, display "N/A" as the high score.
            if (score <= 0)
            {
                difficultyHighScore= "-1";
                lblHighScoreDifficulty.Text = "N/A";
            }

            // if score > 0, save as difficultyHighScore.
            else
            {
                difficultyHighScore = score.ToString();
                lblHighScoreDifficulty.Text = score.ToString();
            }
        }

        /// <summary>
        /// Resets the highscore save files, variables, and labels.
        /// </summary>
        private void ResetHighScores()
        {
            StreamWriter HS;
            HS = File.CreateText("EasyHighScore.txt");
            HS.WriteLine(0);
            Thread.Sleep(50);
            HS.Close();

            StreamWriter HS2;
            HS2 = File.CreateText("MediumHighScore.txt");
            HS2.WriteLine(0);
            Thread.Sleep(50);
            HS2.Close();

            StreamWriter HS3;
            HS3 = File.CreateText("HardHighScore.txt");
            HS3.WriteLine(0);
            Thread.Sleep(50);
            HS3.Close();

            StreamWriter HS4;
            HS4 = File.CreateText("CustomHighScore.txt");
            HS4.WriteLine(0);
            Thread.Sleep(50);
            HS4.Close();

            LoadHighScores();
        }


        // ************************ Event Handlers Begin **************************

        private void btnEasy_Click(object sender, EventArgs e)
        {
            InitiateNewGame(sender);
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            InitiateNewGame(sender);
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            InitiateNewGame(sender);
        }

        private void btnSurpriseMe_Click(object sender, EventArgs e)
        {
            InitiateNewGame(sender);
        }

        private void btnCustom_Click(object sender, EventArgs e)
        {
            InitiateNewGame(sender);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGameSelect_Load(object sender, EventArgs e)
        {
            LoadHighScores();
            BorderlandsNames();
        }

        private void btnResetScores_Click(object sender, EventArgs e)
        {
            ResetHighScores();
        }
    }
}
