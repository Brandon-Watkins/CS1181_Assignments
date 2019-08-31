/*
Anagrams.frmDifficultySelection
CS 1181
Brandon Watkins 
9 May 2019
Robert Howe
Description: Play anagrams, scrambles a word, user guesses what the word is.

WOW:
added some minor data checking, hopefully ensuring the word list file consists of only letters.
added a second form to ask user for their preferred difficulty.
added 8 difficulty settings, setting up their game with word sizes limited by the chosen difficulty.
added files to save game scores/stats, which are read to populate the game upon load 
tracks the win streak, correct guesses, incorrect guesses, and average time per word. 
added a hint button, which displays a letter in its correct position, and causing time and guess penalties.
added a skip word button, which is equivalent to using hint for half of the characters in the word.
the title bar displays your current stats
dynamically added the label to display the scrambled word to user, in order to center the text, regardless of the length of word.
added a messagebox indicating that using hints will penalize user, asking if they want to continue.
    auto focus the textbox afterwards, for a more seamless game
Added a stats / score form, that displays the users current-session high scores, and previously achieved high score
    this form randomly places the labels, for no reason, other than because I can, without overlapping them
    closing this form will re-show whichever form requested the stats form
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

namespace Anagrams
{
    public partial class frmDifficultySelection : Form
    {

        // ******************* Global Variables ************************** //


        Form AnagramsGame;
        public string difficulty = "Hard : Bring on the big'n's!";
        public DateTime appStartTime; // used only for logging the time that the program started
        public string wordListFileLocation; // the word list file location
        public string[] wordList; // contains entire word list
        public string[] difficultyList; // contains word list for selected difficulty
        public Random random;
        public int deckCounter; // counts the "deck", to ensure no repeat words are drawn until counter = length
        public string word = ""; // the random word that was drawn, pre-Anagram
        public string newWord = ""; // the anagrammed word
        public char[] wordChars; // the random word, pre-Anagram, broken into a char array
        public List<char> wordDupe = new List<char> { }; // copy of the newWord, that I can alter.
        public int hintCounter = 0;
        public int hintPenalties = 0; //keeps track of time penalties for using hints
        public int tick;

        // current game stats
        public string titleBarStats; // the stats that are listed on the title bar
        public int correctGuesses = 0; // current game's correct guesses
        public int incorrectGuesses = 0; // current game's incorrect guesses
        public int winStreak = 0;
        public int winStreakHighScoreForThisGame = 0;// current game's winstreak
        public DateTime wordStart; // timer keeping track of when each new word is drawn
        public DateTime wordEnd; // timer keeping track of when each new word is correctly guessed
        public int[] timePerWord = { 0 }; // current array of times spent per word, used for calculating average
        public int averageTimePerWord; // current game's average time spent per word

        // game stats, update from save files
        public string winStreak_HighScore; // high score win streak, saved to file
        public string averageTimePerWord_HighScore; // high score average time, saved to file
        public string correctIncorrectRatio_HighScore; // high score win/lose ratio


        // *********************** Initial Methods *************************** //


        /// <summary>
        /// initiate the form, create instance of random object
        /// </summary>
        public frmDifficultySelection()
        {
            InitializeComponent();
            random = new Random();
        }

        /// <summary>
        /// Gets things moving, logs time, loads word list
        /// </summary>
        private void LoadForm()
        {
            appStartTime = DateTime.Now;
            Log("Starting Anagrams Program");
            LoadWordList();
            LoadScores();
        }

        /// <summary>
        /// Loads the word list (or attempts to), and logs its attempts
        /// </summary>
        private void LoadWordList()
        {
            if (FileAndPathAreGood()) // file is in executing folder
            {
                Log("Successfully loaded word list from " + wordListFileLocation);
            }
            else
            {
                Log("Couldn't load word list from " + wordListFileLocation);
                string fullPath = Environment.ExpandEnvironmentVariables("%systemroot%\\" + "wordlist.txt");
                wordListFileLocation = fullPath;

                if (FileAndPathAreGood(wordListFileLocation)) // file is in system root
                {
                    Log("Successfully loaded word list from " + wordListFileLocation);
                }
                else // file couldnt be found. asking user for file location
                {
                    Log("Couldn't load word list from " + wordListFileLocation);
                    DialogResult result = MessageBox.Show("Unable to locate wordlist.txt" + Environment.NewLine +
                        "Please select the file you'd like to use.", "Locate Word List", MessageBoxButtons.OK);

                    if (result == DialogResult.Cancel) // user clicked 'X' on MB to NOT locate file
                    {
                        Log("User did not select a word list file. Closing program");
                        this.Close();
                        return;
                    }

                    else
                    {
                        OpenFileDialog ofd = new OpenFileDialog();
                        DialogResult result2 = ofd.ShowDialog();
                        wordListFileLocation = ofd.FileName;

                        if (result2 == DialogResult.Cancel) // user didnt choose a file. close
                        {
                            Log("User did not select a word list file. Closing program");
                            this.Close();
                            return;
                        }
                        else if (!FileAndPathAreGood(wordListFileLocation)) // word list had invalid chars in it. close
                        {
                            Log("User-defined word list is invalid: " + wordListFileLocation + ". Closing program");
                            this.Close();
                            return;
                        }
                        else if (FileAndPathAreGood(wordListFileLocation)) // user-defined file seems valid
                        {
                            Log("Successfully loaded word list from " + wordListFileLocation);
                        }
                    }
                }
            }
            ReadWordList();
        }

        /// <summary>
        /// Reads the word list file into the wordList string[]
        /// </summary>
        private void ReadWordList()
        {
            wordList = File.ReadAllLines(wordListFileLocation);
        }

        /// <summary>
        /// Writes the time and string input to a log file
        /// </summary>
        /// <param name="writeToLog">Message to write to the log (string)</param>
        public void Log(string writeToLog)
        {
            string log = DateTime.Now.ToShortDateString() + " " + 
                DateTime.Now.ToLongTimeString() + "   " + writeToLog + ".";
            string fullLog = Environment.NewLine + log;

            FileInfo logFile = new FileInfo("log.txt");
            if (!logFile.Exists)
            {
                File.AppendAllText("log.txt", log);
                Thread.Sleep(100);
            }
            else
            {
                File.AppendAllText("log.txt", fullLog);
                Thread.Sleep(100);
            }
        }

        /// <summary>
        /// Verifies that the file path is good, and that the file's first 2 lines are letters
        /// </summary>
        /// <param name="filePath">The word list's file path (string)</param>
        /// <returns>True if everything checks out (bool)</returns>
        private bool FileAndPathAreGood(string filePath = "wordlist.txt")// for the word list file
        {
            bool pathIsGood = false;
            bool fileIsGood = false;
            
            FileInfo fileInfo = new FileInfo(filePath);

            if (fileInfo.Exists) // check path
            {
                pathIsGood = true;
                if (fileInfo.Length > 0) // check for letters
                {
                    StreamReader sR;
                    sR = new StreamReader(filePath);
                    string line = sR.ReadLine();
                    if (!sR.EndOfStream) line += sR.ReadLine();
                    sR.Close();

                    // I'm aware this only checks the first 2 lines of code.
                    // Seems it's quite likely to catch any other misc files
                    // without having to circle through the entire file
                    for (int i = 0; i < line.Length; i++) 
                    {
                        if (!char.IsLetter(line, i))
                        {
                            fileIsGood = false;
                            break;
                        }
                        else fileIsGood = true;
                    }
                }
            }
            wordListFileLocation = filePath;

            if (fileIsGood && pathIsGood) return true;
            else return false;
        }

        /// <summary>
        /// Outputs trackbar-selected difficulty
        /// </summary>
        /// <param name="difficulty">saves the difficulty description (string)</param>
        private void DifficultyOutput(out string difficulty)
        {
            if (tkbrDifficulty.Value == 10) difficulty = "Hard : Bring on the big'n's!";
            else if (tkbrDifficulty.Value == 4) difficulty = "Easy : 4 letters or less.";
            else if (tkbrDifficulty.Value == 5) difficulty = "Easy : 5 letters or less.";
            else if (tkbrDifficulty.Value == 6) difficulty = "Medium : 6 letters or less.";
            else if (tkbrDifficulty.Value == 7) difficulty = "Medium : 7 letters or less.";
            else if (tkbrDifficulty.Value == 8) difficulty = "Hard : 8 letters or less.";
            else if (tkbrDifficulty.Value == 9) difficulty = "Hard : 9 letters or less.";
            else if (tkbrDifficulty.Value == 11) difficulty = "Godmode : 9 letters or more!";
            else
            {
                difficulty = "Something broke.";
            }
            lblDifficultyDescription.Text = difficulty;
        }

        /// <summary>
        /// Resets the high scores, overwriting the save files
        /// </summary>
        private void ResetScores()
        {
            SaveData("WinStreak.txt", "0", ref winStreak_HighScore);
            SaveData("AverageTimePerWord.txt", "1000", ref averageTimePerWord_HighScore);
            SaveData("CorrectIncorrectRatio.txt", "0", ref correctIncorrectRatio_HighScore);
            LoadScores();
        }

        /// <summary>
        /// Loads the high scores in from the save files
        /// </summary>
        private void LoadScores()
        {
            if (!LoadData("WinStreak.txt", ref winStreak_HighScore))
                SaveData("WinStreak.txt", "0", ref winStreak_HighScore);
            if (!LoadData("AverageTimePerWord.txt", ref averageTimePerWord_HighScore))
                SaveData("AverageTimePerWord.txt", "1000", ref averageTimePerWord_HighScore);
            if (!LoadData("CorrectIncorrectRatio.txt", ref correctIncorrectRatio_HighScore))
                SaveData("CorrectIncorrectRatio.txt", "0", ref correctIncorrectRatio_HighScore);
        }

        /// <summary>
        /// Generic method for loading data from a text file (1 line only)
        /// </summary>
        /// <param name="fileLocation">file path (string)</param>
        /// <param name="message">the data to load (string)</param>
        /// <returns>true if the file exists (bool)</returns>
        private bool LoadData(string fileLocation, ref string message)
        {
            FileInfo fileInfo = new FileInfo(fileLocation);
            if (fileInfo.Exists && fileInfo.Length > 0)
            {
                StreamReader reader;
                reader = File.OpenText(fileLocation);
                message = File.ReadAllText(fileLocation);
                reader.Close();
                return true;
            }
            else
            {
                message = null;
                return false; // save data, instead
            }
        }

        /// <summary>
        /// Generic method for saving a line of text to a file
        /// </summary>
        /// <param name="fileLocation">file path (string)</param>
        /// <param name="message">the message you want to save (string)</param>
        public void SaveData(string fileLocation, string message, ref string variableToSave)
        {
            StreamWriter writer;
            File.Delete(fileLocation);
            writer = File.CreateText(fileLocation);
            writer.WriteLine(message);
            Thread.Sleep(50);
            writer.Close();
            variableToSave = message;
        }

        public void UpdateSave()
        {
            // Correct:Incorrect Ratio
            string temp = ((double)correctGuesses / incorrectGuesses).ToString("n2");
            double temp2 = double.Parse(temp);
            if (double.Parse(correctIncorrectRatio_HighScore) < temp2)
                SaveData("CorrectIncorrectRatio.txt", temp2.ToString("n2"), ref correctIncorrectRatio_HighScore);
            // average time spent per word
            if(averageTimePerWord < int.Parse(averageTimePerWord_HighScore))
                SaveData("AverageTimePerWord.txt", averageTimePerWord.ToString(), ref averageTimePerWord_HighScore);
            hintCounter = 0;
        }

        /// <summary>
        /// Opens the stats form, to display high scores
        /// </summary>
        /// <param name="formThatRequestedThis">(Form)</param>
        /// <param name="correctGuesses">(int)</param>
        /// <param name="incorrectGuesses">(int)</param>
        /// <param name="averageTimePerWord">(int)</param>
        /// <param name="winStreakHighScoreForThisGame">(int)</param>
        /// <param name="winStreak_HighScore">(string)</param>
        /// <param name="averageTimePerWord_HighScore">(string)</param>
        public void ViewStats(Form formThatRequestedThis, frmDifficultySelection frmDifficultySelection, int correctGuesses, int incorrectGuesses, int averageTimePerWord, 
            int winStreakHighScoreForThisGame, string winStreak_HighScore, string averageTimePerWord_HighScore)
        {
            Form Stats = new frmStats(formThatRequestedThis, frmDifficultySelection, correctGuesses, incorrectGuesses,
                averageTimePerWord, winStreakHighScoreForThisGame, winStreak_HighScore, averageTimePerWord_HighScore);
            UpdateSave();
            this.Hide();
            Stats.Show();
        }

        /// <summary>
        /// Checks to see if it needs to save data, then closes the form
        /// </summary>
        private void Quit()
        {
            string temp = ((double)correctGuesses / incorrectGuesses).ToString("n2");
            double temp2 = double.Parse(temp);
            UpdateSave();
            Thread.Sleep(50);
            this.Close();
        }


        // *********** Preparing The Game : User has selected a difficulty ************* //


        /// <summary>
        /// Randomizes the letters in the drawn word, starts the timer for said word.
        /// </summary>
        /// <param name="wordToShuffle">Word to shuffle (char[])</param>
        public void Shuffle(char[] wordToShuffle) // char shuffle 
        {
            newWord = "";
            wordDupe.Clear();
            // take deck shuffle's wordChars, and shuffle the chars
            for (int i = 0; i < wordChars.Length; i++)
            {
                char temp = wordChars[i];
                int index = random.Next(i, wordChars.Length);
                wordChars[i] = wordChars[index];
                wordChars[index] = temp;
                wordDupe.Add(wordChars[i]);
                newWord += wordChars[i].ToString();
            }

            // print newer word (anagram) to log
            Log("Shuffled word has been randomized to form: " + newWord);

            // create a label to display the word
            DestroyLabel();
            CreateLabel();

            // start the timer for average time per word
            wordStart = DateTime.Now;
            
            tmrTime.Enabled = true;
        }

        /// <summary>
        /// Picks a random word from the "deck", swapping indexes to keep track of words used
        /// </summary>
        /// <param name="wordListToShuffle">List of Words to shuffle (string[])</param>
        public void Shuffle(string[] wordListToShuffle) // deck shuffle
        {
            // shuffle deck for new word
            Swap(wordListToShuffle, ref deckCounter);

            //print new word to log
            Log("Random word drawn from shuffle: " + word);

            // create a char array with the string
            wordChars = new char[word.Length];
            for (int i = 0; i < word.Length; i++)
            {
                wordChars[i] = word[i];
            }

            // shuffle the new word for an anagram (word shuffle method)
            Shuffle(wordChars);
        }

        /// <summary>
        /// Creates a new panel and label for each word, to center the anagram.
        /// </summary>
        public void CreateLabel()
        {
            int width = AnagramsGame.Size.Width - 24;
            int height = 80;

            Panel panel = new Panel();
            panel.Name = "pnlAnagramOutput";
            panel.Location = new Point(12, 30);
            panel.Size = new Size(width, height);
            panel.Anchor = AnchorStyles.Left;
            panel.Anchor = AnchorStyles.Right;
            panel.Anchor = AnchorStyles.Top;

            Label label = new Label();
            label.Name = "lblWord";
            label.Text = newWord;
            label.AutoSize = false;
            label.Dock = DockStyle.Fill;
            label.TextAlign = ContentAlignment.TopCenter;
            label.Top = 40;
            int size = label.Size.Width;
            panel.Controls.Add(label);

            AnagramsGame.Controls.Add(panel);
        }

        /// <summary>
        /// removes the panel / label, so that a new one can be made in its place.
        /// </summary>
        public void DestroyLabel()
        {
            foreach(Control panel in AnagramsGame.Controls.OfType<Panel>())
            {
                AnagramsGame.Controls.Remove(panel);
            }
        }

        /// <summary>
        /// Swaps out a randomly selected letter to its correct position
        /// </summary>
        /// <param name="counter">counts number of hints for this word (int)</param>
        public void Swap(ref int counter) 
        {
            if (counter == wordChars.Length) // sets the label as the unscrambled word, once enough hints == word.Length, because (see next comment)
            {
                foreach (Control label in AnagramsGame.Controls.OfType<Label>())
                {
                    if (label.Name == "lblWord") label.Text = word;
                }
                CorrectGuess();
                return;
            }

            // does not work correctly with words containing multiples of the same letter.
            string wordStr = "";
            char temp = wordChars[counter];
            for (int i = 0; i < wordChars.Length; i++) wordStr += wordChars[i];
            int index = newWord.IndexOf(word[counter], counter);
            wordChars[counter] = wordChars[index];
            wordChars[index] = temp;
            wordDupe.RemoveAt(wordDupe.Count - 1);

            newWord = "";
            for (int i = 0; i < wordChars.Length; i++) // put chars back into a string
            {
                newWord += wordChars[i];
            }

            counter++;
            DestroyLabel();
            CreateLabel();
        }

        /// <summary>
        /// Used to shuffle the deck
        /// </summary>
        /// <param name="toShuffle">deck of strings to shuffle (string[])</param>
        /// <param name="counter">counts number of words already seen (int)</param>
        public void Swap(string[] toShuffle, ref int counter)
        {
            // if counter == toShuffle.Length, reset counter
            if (counter == toShuffle.Length) counter = 0;

            //shuffle the "deck", to get a new word
            int index = random.Next(counter, toShuffle.Length);
            string temp = toShuffle[counter];
            toShuffle[counter] = toShuffle[index];
            toShuffle[index] = temp;

            word = toShuffle[counter];
            counter++;
        }

        /// <summary>
        /// Determines the average time per word
        /// </summary>
        public void AverageTime()
        {
            // when word has been guessed correctly, time for word = current time - start time.
            wordEnd = DateTime.Now;
            MakeBigger();
            TimeSpan total = wordEnd - wordStart + TimeSpan.FromSeconds(hintPenalties);
            timePerWord[timePerWord.Length - 1] = (int)total.TotalSeconds;
            int words = 0;
            int time = 0;
            for (int i = 0; i < timePerWord.Length; i++)
            {
                words++;
                time += timePerWord[i];
            }
            averageTimePerWord = time / (words - 1);

            // rewrite the save file with that number.
            hintPenalties = 0;
        }

        /// <summary>
        /// Makes the array larger
        /// </summary>
        public void MakeBigger()
        {
            int length = timePerWord.Length;
            int[] copy = new int[length + 1];
            for (int i = 0; i < length; i++)
            {
                copy[i] = timePerWord[i];
            }
            timePerWord = copy;
        }

        /// <summary>
        /// Updates the title bar with current time and stats
        /// </summary>
        /// <returns>stats and time for displaying in title bar (string)</returns>
        public string TimerEvent()
        {
                titleBarStats = "Anagrams : " + difficulty + "      Win Streak : " +
                winStreak.ToString() + "      Average Time(s) Per Word: " +
                averageTimePerWord.ToString() + "      Time(s) On This Word: " +
                ((DateTime.Now - wordStart).TotalSeconds + hintPenalties).ToString("n0");
            return titleBarStats;
        }

        /// <summary>
        /// deducts poins / time, and gives them a letter in the correct position
        /// </summary>
        /// <param name="chars">number of characters left in word (int)</param>
        public void Hint(int chars = 1)
        {
            // if chars > 1, Hint multiplies the below deductions X chars / 2 (used for skipping the word)
            if (chars > 1 && wordDupe.Count > 0) // SKIP
            {
                DialogResult result;
                result = MessageBox.Show("Skipping word is equivalent to " +
                    (wordDupe.Count / 2) + " hints. "
                    + "Using a hint will add an incorrect guess " +
                    "and add 15 seconds to your time." +
                    Environment.NewLine + "Continue?", "Continue?", MessageBoxButtons.YesNo);
                if (result != DialogResult.Yes) return;

                hintPenalties += 15 * chars / 2;
                incorrectGuesses += 1 * chars / 2;
                IncorrectGuess(0);
                if (hintCounter <= wordChars.Length) tmrHint.Enabled = true;
            }
            else if (chars <= 1 && wordDupe.Count > 0) // HINT
            {
                DialogResult result;
                result = MessageBox.Show("Using a hint will add an incorrect guess " +
                   "and add 15 seconds to your time. " + 
                   Environment.NewLine +"Continue?", "Continue?", MessageBoxButtons.YesNo);
                if (result != DialogResult.Yes) return;

                // hint will add 30 seconds to their time
                hintPenalties += 15;

                // hint adds 1 incorrect guess
                IncorrectGuess(1);

                // display one RANDOM char, in its proper place. 
                Swap(ref hintCounter);
            }
            foreach (Control textBox in AnagramsGame.Controls.OfType<TextBox>())
            {
                textBox.Focus();
            }
        }
        
        /// <summary>
        /// Used to display one letter change at a time
        /// </summary>
        /// <param name="tick">tick event (Timer)</param>
        private void HintTimer(ref int tick)
        {
            tick++;
            if (tick > word.Length)
            {
                tmrHint.Enabled = false;
                tick = 0;
                CorrectGuess();
                return;
            }
            Swap(ref hintCounter);
            Refresh();
            foreach (Control label in AnagramsGame.Controls.OfType<Label>()) if (label.Name == "lblWord") label.Text = word;
        }

        /// <summary>
        /// Determines whether guess was correct or not
        /// </summary>
        public void WasGuessCorrect()
        {
            bool wasWin = false;
            // correct response:
            foreach (Control textBox in AnagramsGame.Controls.OfType<TextBox>())
            {
                if (textBox.Text == word)
                {
                    CorrectGuess();
                    wasWin = true;
                }
                textBox.Text = "";
            }

            if (!wasWin)
            {
                IncorrectGuess(1);
                foreach (Control textBox in AnagramsGame.Controls.OfType<TextBox>())
                {
                    textBox.Text = "";
                }
            }
            Thread.Sleep(300);
        }

        /// <summary>
        /// Guessed correctly: adjust scores and draw new word
        /// </summary>
        public void CorrectGuess()
        {
            //if correct stop timer and reset hintCounter
            AverageTime();
            hintCounter = 0;
            correctGuesses++;
            winStreak++;
            if (winStreak > winStreakHighScoreForThisGame) winStreakHighScoreForThisGame = winStreak;
            if (winStreakHighScoreForThisGame > int.Parse(winStreak_HighScore))
            {
                winStreak_HighScore = winStreak.ToString();
                SaveData("WinStreak.txt", winStreak_HighScore, ref winStreak_HighScore);
            }
            Shuffle(difficultyList);
            foreach (Control label in AnagramsGame.Controls.OfType<Label>())
            {
                if (label.Name == "lblCorrect") label.Text = correctGuesses.ToString();
                if (label.Name == "lblWinStreak") label.Text = "Win Streak: " + winStreak.ToString();
            }
        }

        /// <summary>
        /// Guessed incorrectly: adjust scores
        /// </summary>
        public void IncorrectGuess(int numberOfGuesses)
        {
            incorrectGuesses += numberOfGuesses;
            winStreak = 0;
            foreach (Control label in AnagramsGame.Controls.OfType<Label>())
            {
                if (label.Name == "lblIncorrect") label.Text = incorrectGuesses.ToString();
                if (label.Name == "lblWinStreak") label.Text = "Win Streak: " + winStreak.ToString();
            }
        }

        /// <summary>
        /// Determines which values to send on for sorting the word list
        /// </summary>
        /// <param name="difficulty">the chosen difficulty seetting (string)</param>
        /// <returns>difficultyList (string[])</returns>
        public string[] CreateWordListArray(string difficulty)
        {
            int starting = 0;
            int ending = 0;
            // sort the word list string, and make a new array for the specified difficulty.
            if (difficulty == "Easy : 4 letters or less.") ending = 4;
            else if (difficulty == "Easy : 5 letters or less.") ending = 5;
            else if (difficulty == "Medium : 6 letters or less.") ending = 6;
            else if (difficulty == "Medium : 7 letters or less.") ending = 7;
            else if (difficulty == "Hard : 8 letters or less.") ending = 8;
            else if (difficulty == "Hard : 9 letters or less.") ending = 9;
            else if (difficulty == "Godmode : 9 letters or more!") { ending = 15; starting = 9; }
            else ending = 15;

            CreateWordListArray(starting, ending);
            return difficultyList;
        }

        /// <summary>
        /// Sorts through the word list to pick out which words meet difficulty settings
        /// </summary>
        /// <param name="starting">lower end of word length (int)</param>
        /// <param name="ending">upper end of word length (int)</param>
        public void CreateWordListArray(int starting, int ending)
        {
            List<string> diffList = new List<string>();
            for (int i = 0; i < wordList.Length; i++)// makes copy of word list to a List, instead of rebuilding the array 5000 times
            {
                if (wordList[i].Length >= starting && wordList[i].Length <= ending)
                {
                    diffList.Add(wordList[i]);
                }
            }
            difficultyList = new string[diffList.Count];
            for (int i = 0; i < diffList.Count; i++)// copies List over to array, for no real reason.
            {
                difficultyList[i] = diffList[i];
            }
        }

        
        // *********************** Playing The Game ************************** //


        /// <summary>
        /// Loads and shows the game form
        /// </summary>
        private void Play()
        {
            CreateWordListArray(difficulty);
            this.AnagramsGame = new frmAnagramsGame(this);
            AnagramsGame.Owner = this;
            AnagramsGame.Show();
            this.Hide();
            AnagramsGame.Text = "Anagrams : " + difficulty + "      Win Streak : " + 
                "0      Average Time Per Word : 0      Seconds On This Word : 0";
        }
        

        // ************************* Event Handlers *********************** //


        private void btnQuit_Click(object sender, EventArgs e)
        {
            Quit();
        }

        private void tkbrDifficulty_Scroll(object sender, EventArgs e)
        {
            DifficultyOutput(out difficulty);
        }

        private void frmDifficultySelection_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Play();
        }

        private void btnResetScores_Click(object sender, EventArgs e)
        {
            ResetScores();
        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            AnagramsGame.Text = TimerEvent();
        }

        private void btnViewStats_Click(object sender, EventArgs e)
        {
            ViewStats(this, this, correctGuesses, incorrectGuesses,
                averageTimePerWord, winStreakHighScoreForThisGame, winStreak_HighScore, averageTimePerWord_HighScore);
        }

        private void tmrHint_Tick(object sender, EventArgs e)
        {
            HintTimer(ref tick);
        }
    }
}
