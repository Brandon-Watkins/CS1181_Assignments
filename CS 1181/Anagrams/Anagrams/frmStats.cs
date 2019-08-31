/*
Anagrams.frmStats
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

namespace Anagrams
{
    public partial class frmStats : Form
    {
        Form formParent;
        frmDifficultySelection formDifficultySelection;
        public int correctGuesses;
        public int incorrectGuesses;
        public int averageTimePerWord;
        public int winStreakHighScoreForThisGame;
        public string winStreak_HighScore;
        public string averageTimePerWord_HighScore;
        Random random;


        /// <summary>
        /// Initialize form, with high scores
        /// </summary>
        /// <param name="formParent">(Form)</param>
        /// <param name="correctGuesses">(int)</param>
        /// <param name="incorrectGuesses">(int)</param>
        /// <param name="averageTimePerWord">(int)</param>
        /// <param name="winStreakHighScoreForThisGame">(int)</param>
        /// <param name="winStreak_HighScore">(string)</param>
        /// <param name="averageTimePerWord_HighScore">(string)</param>
        public frmStats(Form formParent, frmDifficultySelection formDifficultySelection, int correctGuesses, int incorrectGuesses,int averageTimePerWord, 
            int winStreakHighScoreForThisGame, string winStreak_HighScore, string averageTimePerWord_HighScore)
        {
            InitializeComponent();
            this.formDifficultySelection = formDifficultySelection;
            this.formParent = formParent;
            this.correctGuesses = correctGuesses;
            this.incorrectGuesses = incorrectGuesses;
            this.averageTimePerWord = averageTimePerWord;
            this.winStreakHighScoreForThisGame = winStreakHighScoreForThisGame;
            this.winStreak_HighScore = winStreak_HighScore;
            this.averageTimePerWord_HighScore = averageTimePerWord_HighScore;
            random = new Random();
        }

        /// <summary>
        /// Shows whichever form opened this form, before closing this one.
        /// </summary>
        private void CloseStats()
        {
            formDifficultySelection.UpdateSave();
            formParent.Show();
            this.Close();
        }

        /// <summary>
        /// Load the labels with corresponding stats
        /// </summary>
        private void LoadStats()
        {
            lblAverageTime.Text = averageTimePerWord.ToString() + " seconds";
            lblAverageTimeHighScore.Text = averageTimePerWord_HighScore + " seconds";
            lblCorrectGuesses.Text = correctGuesses.ToString();
            lblIncorrectGuesses.Text = incorrectGuesses.ToString();
            lblWinStreak.Text = winStreakHighScoreForThisGame.ToString();
            lblWinStreakHighScore.Text = winStreak_HighScore;
            lblCorrectIncorrectRatio.Text = ((double)correctGuesses / incorrectGuesses).ToString("n2");// unsure if thats correct
        }

        private void frmStats_Load(object sender, EventArgs e)
        {
            LoadStats();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            CloseStats();
        }
    }
}
