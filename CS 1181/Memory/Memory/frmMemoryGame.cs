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
using System.Timers;


namespace Memory
{
    public partial class frmMemoryGame : Form
    {
        // Global Variables
        frmGameSelect formGameSelect;
        Random random;
        public int[] gameSelection = new int[2];
        public int rows = 0;
        public int cols = 0;
        public string[] nameArray;
        List<string> nameList = new List<string>();
        List<string> nameList2 = new List<string>();
        List<int> elementNumbers = new List<int>();
        private string[,] buttonMatrix;
        public int[] clickOne = new int[2];
        public int[] clickTwo = new int[2];
        public int[] turn = { 0 };
        public int[] pairsCleared = { 0 };
        Button firstChoice;
        public string currentDifficultyHighScore;
        public Button theButtonThatWasClicked;
        public int[] coordsInt;
        public string previousHighScore = "N/A";
        public string titleBarStats;

        DateTime start;
        DateTime stop;
        TimeSpan playTime;

        // **************************** Begin Setting the Game Board **************************** //

        /// <summary>
        /// initialize form, creates random object, sets the game board
        /// </summary>
        /// <param name="formGameSelect"></param>
        public frmMemoryGame(frmGameSelect formGameSelect)
        {
            InitializeComponent();
            random = new Random();
            this.formGameSelect = formGameSelect;
            SetBoard();
        }

        /// <summary>
        /// Displays game difficulty, dimensions, timer, and highscore on the title bar.
        /// </summary>
        private void DifficultyDisplay(out string titleBarStats)
        {
            string message1 = "N/A";
            if (int.Parse(currentDifficultyHighScore) > 0) message1 = currentDifficultyHighScore;

            titleBarStats = "Memory:  " + formGameSelect.gameSelectButtonThatWasClicked.Text + " ( " + 
                gameSelection[0].ToString() + " x " + gameSelection[1].ToString() + " )        " + "High Score: " + 
                message1 + " seconds        Current Score: ";
            this.Text = titleBarStats;
        }

        /// <summary>
        /// Determines the size of the game to populate. Saves rows as gameSelection[0], cols as gameSelection[1]
        /// </summary>
        private void GameSelection()
        {
            if (formGameSelect.gameSelectButtonThatWasClicked.Text == "Easy")
            {
                gameSelection[0] = 4;
                gameSelection[1] = 4;
                currentDifficultyHighScore = formGameSelect.easyHighScore;
            }

            else if (formGameSelect.gameSelectButtonThatWasClicked.Text == "Medium")
            {
                gameSelection[0] = 6;
                gameSelection[1] = 6;
                currentDifficultyHighScore = formGameSelect.mediumHighScore;
            }

            else if (formGameSelect.gameSelectButtonThatWasClicked.Text == "Hard")
            {
                gameSelection[0] = 8;
                gameSelection[1] = 8;
                currentDifficultyHighScore = formGameSelect.hardHighScore;
            }

            else if (formGameSelect.gameSelectButtonThatWasClicked.Text == "Custom")
            {
                gameSelection[0] = formGameSelect.rows; // rows specified by user
                gameSelection[1] = formGameSelect.cols; // columns specified by user
                currentDifficultyHighScore = formGameSelect.customHighScore;
            }
        }

        /// <summary>
        /// Creates the array to use to fill out the buttons, called nameArray.
        /// </summary>
        /// <param name="useCustomStrings">use custom buttons = true (bool)</param>
        public void CreatePairsArray(bool useCustomStrings = false)
        {
            int maxIndex = gameSelection[0] * gameSelection[1];
            int maxDefault = formGameSelect.nameOptions.Length;
            int iLessThan1;
            int iLessThan2;
            int count;

            if (!useCustomStrings)
            {
                //Duplicates the name array, putting into an editable list.
                for (int i = 0; i < maxDefault; i++)
                {
                    nameList.Add(formGameSelect.nameOptions[i]);
                }

                int max = maxDefault - (maxIndex / 2);
                // trim out random names for unique names every game
                for (int i = maxIndex / 2; i < maxDefault; i++)
                {
                    int index = random.Next(nameList.Count);
                    nameList.RemoveAt(index);
                }

                count = nameList.Count;
                // add pairs to the list
                for (int i = 0; i < maxIndex / 2; i++)
                {
                    nameList.Add(nameList[i]);
                }
            }
            else
            {
                iLessThan1 = maxIndex;
                iLessThan2 = iLessThan1;
                // don't have time to be adding this extra feature, but it'll bug me if I don't. 
                //But im just plugging numbers into existing code to increase custom game size limit past 84.
                for (int i = 0; i < maxIndex / 2; i++)
                {
                    nameList.Add(i.ToString());
                }

                count = nameList.Count;
                // add pairs to the list
                for (int i = 0; i < maxIndex / 2; i++)
                {
                    nameList.Add(nameList[i]);
                }
            }

            //Randomnly select names from full name list, to have different names every game.
            // also creates a copy of each, for its pair.
            nameArray = new string[maxIndex];
            for (int i = 0; i < maxIndex; i ++)
            {
                int index = random.Next(nameList.Count);
                nameArray[i] = nameList[index];
                nameList.RemoveAt(index);
            }
        }

        /// <summary>
        /// Creates a matrix with the randomized string positions, called buttonMatrix.
        /// </summary>
        private void CreatePairMatrix()
        {
            int rows = gameSelection[0];
            int cols = gameSelection[1];

            //Determine game elements
            int totalButtons = rows * cols;

            // create a list of 0 to totalButtons
            for (int i = 0; i < totalButtons; i++)
            {
                elementNumbers.Add(i);
            }

            // create the pair matrix
            buttonMatrix = new string[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    int index = random.Next(elementNumbers.Count);
                    buttonMatrix[row, col] = nameArray[elementNumbers[index]];
                    elementNumbers.RemoveAt(index);
                }
            }
        }

        /// <summary>
        /// Creates buttons for the game board. button tags are "row, col"
        /// </summary>
        private void CreateButtonMatrix()
        {
            int rows = gameSelection[0];
            int cols = gameSelection[1];
            int top = 0;

            // create a button matrix
            // with each loop:
            // name each button
            // tag each button with its coords
            // define its position / location
            for (int row = 0; row < rows; row++)
            {
                int left = 0;
                for (int col = 0; col < cols; col++)
                {
                    Button button = new Button();
                    button.Name = "btn_row" + row + "_col" + col;
                    button.Top = top;
                    button.Left = left;
                    button.Size = new Size(75, 42);
                    button.Tag = row + "," + col;
                    button.Text = "";
                    button.Click += new EventHandler(ButtonClick);
                    button.BackColor = Color.Snow;
                    button.FlatStyle = FlatStyle.Popup;
                    this.Controls.Add(button);
                    left += button.Width + 3;
                }
                top += 45;
            }
        }

        /// <summary>
        /// Primary method, in charge of coordinating other methods to populate the game board.
        /// </summary>
        private void SetBoard()
        {
            // Determine which game difficulty was selected, and the number of elements, 
            // saves rows as gameSelection[0], columns as gameSelection[1].
            GameSelection();

            // change the forms displayed name, indicating difficulty.
            DifficultyDisplay(out titleBarStats);

            // create an array of pairs to later be randomly placed in the buttonMatrix, saved as nameArray[].
            if (gameSelection[0] * gameSelection[1] <= 84) CreatePairsArray();
            else CreatePairsArray(true);

            // create matrix with randomized string positions, saved as buttonMatrix.
            CreatePairMatrix();

            // create a button matrix
            CreateButtonMatrix();
        }
        
        // ******************************** Begin Game Play ********************************* //

        /// <summary>
        /// Button was clicked: tell the peons to get to work.
        /// </summary>
        /// <param name="sender">Button that was clicked (object)</param>
        /// <param name="e">hell if I know. (EventArgs)</param>
        public void ButtonClick(object sender, System.EventArgs e)
        {
            DoStuff((Button)sender);
        }

        /// <summary>
        /// Button was clicked: start timer, track turns, sends click info onwards.
        /// </summary>
        /// <param name="sender">Button that was clicked (object)</param>
        private void DoStuff(object sender)
        {
            theButtonThatWasClicked = (Button)sender;
            turn[0]++;
            if (turn[0] == 1) StartTimer();// if first turn, start the timer
            string tagContents = (string)theButtonThatWasClicked.Tag;
            coordsInt = CoordsConversion(((Button)sender).Tag.ToString());// returns coordsInt[]

            GUIStuff(theButtonThatWasClicked, coordsInt);// display/hide text, colors, etc
        }

        /// <summary>
        /// highlights buttons, determines game state to decide on which button-changing method to use
        /// </summary>
        /// <param name="theButtonThatWasClicked">the button that was clicked... ((Button)sender)</param>
        /// <param name="coordsInt">the coords of the button that was clicked (int[])</param>
        private void GUIStuff(Button theButtonThatWasClicked, int[] coordsInt)
        {
            HighlightButtonString();
            Refresh();

            if (IsFirstChoice())
            {
                firstChoice = theButtonThatWasClicked;
                clickOne[0] = coordsInt[0];
                clickOne[1] = coordsInt[1];
            }
            else if (!IsFirstChoice())
            {
                clickTwo[0] = coordsInt[0];
                clickTwo[1] = coordsInt[1];
                if (CorrectPairing())
                {
                    pairsCleared[0]++;
                    if (GameIsOver())
                    {
                        ShowGrayButtonString(0);
                        CleanUp();
                    }
                    else ShowGrayButtonString(800);
                }
                else HideButtonString(800);
            }
        }

        /// <summary>
        /// Checks to see if there's any more unmatched pairs
        /// </summary>
        /// <returns>true if all pairs have been matched (bool)</returns>
        private bool GameIsOver()
        {
            if (pairsCleared[0] == gameSelection[0] * gameSelection[1] / 2) return true;
            else return false;
        }

        /// <summary>
        /// Game's Over. Save and display scores, ask for replay.
        /// </summary>
        private void CleanUp()
        {
            tmrGameClock.Enabled = false;
            string message1 = "";
            string message2 = "Current";
            string message3 = "N/A";
            bool IsDefaultHighScore;

            StopTimer();
            if (IsNewHighScore(out IsDefaultHighScore))
            {
                UpdateHighScore(formGameSelect.gameSelectButtonThatWasClicked.Text, playTime);
                message1 += "             Congrats! New High Score!" + Environment.NewLine;
                message2 = "Previous ";
                if (!IsDefaultHighScore) message3 = currentDifficultyHighScore + " seconds.";
            }

            // Display game results, ask if user wants to play again.
            DialogResult response = MessageBox.Show(message1 + "                     Score:  " +
                playTime.TotalSeconds.ToString("N0") + " seconds" + Environment.NewLine +
                "                  Number of clicks:  " + turn[0] + "." + Environment.NewLine +
                message2 + "High Score for " + formGameSelect.gameSelectButtonThatWasClicked.Text +
                    ":  " + message3 + Environment.NewLine + Environment.NewLine + 
                "                          Play again?", "Game Results",
                MessageBoxButtons.YesNo);

            if (response == DialogResult.Yes)
            {
                formGameSelect.LoadHighScores();
                Owner.Show();
                this.Close();
            }

            else if (response == DialogResult.No)
            {
                Owner.Close();
                this.Close();
            }
        }

        /// <summary>
        /// Checks if pair is a match
        /// </summary>
        /// <returns>true if the pair matches (bool)</returns>
        private bool CorrectPairing()
        {
            if (buttonMatrix[clickOne[0], clickOne[1]] == buttonMatrix[clickTwo[0], clickTwo[1]]) return true;
            else return false;
        }

        /// <summary>
        /// Highlights button, shows text.
        /// </summary>
        private void HighlightButtonString()
        {
            // show button string
            theButtonThatWasClicked.Enabled = false;
            theButtonThatWasClicked.Text = buttonMatrix[coordsInt[0], coordsInt[1]];
            theButtonThatWasClicked.BackColor = Color.FromArgb(145, 255, 200);
            
        }

        /// <summary>
        /// Hides button text, and returns color to normal
        /// </summary>
        /// <param name="sleepTime">delay between highlighting button and returning to hidden (int)</param>
        private void HideButtonString(int sleepTime)
        {
            Thread.Sleep(sleepTime);
            // hide button string after __ sec pause 
            theButtonThatWasClicked.Enabled = true;
            theButtonThatWasClicked.Text = "";
            theButtonThatWasClicked.BackColor = Color.Snow;
            firstChoice.Enabled = true;
            firstChoice.Text = "";
            firstChoice.BackColor = Color.Snow;
        }

        /// <summary>
        /// Changes appearance of buttons, showing text, and graying.
        /// </summary>
        /// <param name="sleepTime">the delay between highlighting button and graying button (int)</param>
        private void ShowGrayButtonString(int sleepTime)
        {
            Thread.Sleep(sleepTime);
            // show button string after__ sec pause 
            theButtonThatWasClicked.Enabled = false;
            theButtonThatWasClicked.Text = buttonMatrix[coordsInt[0], coordsInt[1]];
            theButtonThatWasClicked.BackColor = Color.Transparent;
            //theButtonThatWasClicked.BackgroundImage = Image.FromFile("BL2Logo.jpg");
            theButtonThatWasClicked.BackgroundImageLayout = ImageLayout.Stretch;
            firstChoice.Enabled = false;
            firstChoice.Text = buttonMatrix[clickOne[0], clickOne[1]];
            firstChoice.BackColor = Color.Transparent;

            //firstChoice.BackgroundImage = Image.FromFile("BL2Logo.jpg");
            firstChoice.BackgroundImageLayout = ImageLayout.Stretch;
        }

        /// <summary>
        /// Determines if this is the first "card" flipped this "round"
        /// </summary>
        /// <returns>true if first choice (bool)</returns>
        private bool IsFirstChoice()
        {
            if (turn[0] % 2 == 0) return false;
            else return true;
        }

        /// <summary>
        /// Starts the timers used for score and title bar stats
        /// </summary>
        private void StartTimer()
        {
            start = DateTime.Now;
            tmrGameClock.Enabled = true;// used to show play time on title bar
            tmrGameClock.Interval = 100;
        }

        /// <summary>
        /// Stops the timer, used to compute the playTime TimeSpan
        /// </summary>
        private void StopTimer()
        {
            stop = DateTime.Now;
            playTime = stop - start;
        }

        /// <summary>
        /// Determines if new score is better than previous high score, and whether or not its still using the default high score.
        /// </summary>
        /// <param name="IsDefaultHighScore">Checks if high score is using default score (bool)</param>
        /// <returns>true if score is better than highscore (bool)</returns>
        private bool IsNewHighScore(out bool IsDefaultHighScore)
        {
            int highScore = int.Parse(currentDifficultyHighScore);
            int currentScore = int.Parse(playTime.TotalSeconds.ToString("N0"));
            IsDefaultHighScore = false;

            if (highScore <= 0)
            {
                IsDefaultHighScore = true;
                return true;
            }
            else if (highScore > 0) if (highScore >= currentScore) return true;
            return false;
        }

        /// <summary>
        /// splits coords string into an array
        /// </summary>
        /// <param name="coords">i,j coords (string)</param>
        /// <returns>coords in an array (int[])</returns>
        private int[] CoordsConversion(string coords)
        {
            string[] coordsString = coords.Split(',');
            int[] coordsInt = new int[coordsString.Length];
            for (int i = 0; i < coordsString.Length; i++)
            {
                int.TryParse(coordsString[i], out coordsInt[i]);
            }

            return coordsInt;
        }
        
        /// <summary>
        /// Saves the new highscore to the text file
        /// </summary>
        /// <param name="difficulty">"Easy" etc (string)</param>
        /// <param name="playTime">start - stop (TimeSpan)</param>
        public void UpdateHighScore(string difficulty, TimeSpan playTime)
        {
            // if new score is better (lower) than previous score:
            // overwrite save file

            StreamWriter HS;
            HS = File.CreateText(difficulty + "HighScore.txt");
            HS.WriteLine(playTime.TotalSeconds.ToString("N0"));
            Thread.Sleep(100);
            HS.Close();
        }

        /// <summary>
        /// Close this form, go back to difficulty selection.
        /// </summary>
        private void Cancel()
        {
            this.Owner.Show();
            this.Close();
        }

        /// <summary>
        /// Closes the entire program.
        /// </summary>
        private void Quit()
        {
            this.Owner.Close();
            this.Close();
        }
        
        //*********************** Begin Event Handlers ************************ //

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Quit();
        }

        private void btnChangeDifficulty_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void tmrGameClock_Tick(object sender, EventArgs e)
        {
            this.Text = titleBarStats + ((DateTime.Now - start).TotalSeconds).ToString("N1") + " seconds";
        }
    }
}
