/*
Anagrams.frmAnagramsGame
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
using System.Threading;

namespace Anagrams
{
    public partial class frmAnagramsGame : Form
    {
        // ******************* Global Variables ************************* //
        frmDifficultySelection formDifficultySelection;

        /// <summary>
        /// Initializes the game
        /// </summary>
        /// <param name="formDifficultySelection"></param>
        public frmAnagramsGame(frmDifficultySelection formDifficultySelection)
        {
            InitializeComponent();
            this.formDifficultySelection = formDifficultySelection;
        }
        
        /// <summary>
        /// Loads the game.
        /// </summary>
        public void LoadGame()
        {
            formDifficultySelection.Shuffle(formDifficultySelection.difficultyList);
        }

        /// <summary>
        /// Verifies input is letters
        /// </summary>
        public void CheckForLetters()
        {
            string answer = tbAnswer.Text;
            answer.Trim();
            answer.ToLower();
            char[] ans = answer.ToCharArray();
            bool isGood = true;
            int index = 0;
            for (int i = 0; i < answer.Length; i++)
            {
                if (!char.IsLetter(ans[i])) isGood = false;
                index = i;
                break;
            }

            if (!isGood && index > 0) answer = answer.Substring(0, index);
            else if (!isGood && index <= 0) answer = "";

            tbAnswer.Text = answer;

            CheckForFullWord();
        }

        /// <summary>
        ///  clears the text field when entering focus
        /// </summary>
        private void ClearText()
        {
            if (tbAnswer.Text == "Unscramble the word and type your answer here!")
            tbAnswer.Text = "";
        }

        /// <summary>
        /// Resets text field if left blank
        /// </summary>
        private void ShowText()
        {
            if (tbAnswer.Text == "")
            tbAnswer.Text = "Unscramble the word and type your answer here!";
        }

        /// <summary>
        /// Checks to see if user has entered enough chars to complete the word. If so, calls WasGuessCorrect
        /// </summary>
        public void CheckForFullWord()
        {
            if (tbAnswer.Text.Length == formDifficultySelection.word.Length)
                formDifficultySelection.WasGuessCorrect();
        }

        /// <summary>
        /// Takes user back to home screen to change difficulty
        /// </summary>
        private void ChangeDifficulty()
        {
            formDifficultySelection.UpdateSave();
            formDifficultySelection.Show();
            this.Close();
        }

        /// <summary>
        /// Checks to see if data is saved, then closes the parent form
        /// </summary>
        private void Quit()
        {
            formDifficultySelection.UpdateSave();
            Thread.Sleep(50);
            formDifficultySelection.Close();
        }


        // *************************** Event Handlers ************************* //


        private void frmAnagramsGame_Load(object sender, EventArgs e)
        {
            LoadGame();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Quit();
        }

        private void tbAnswer_TextChanged(object sender, EventArgs e)
        {
            CheckForLetters();
        }

        private void btnHint_Click(object sender, EventArgs e)
        {
            formDifficultySelection.Hint();
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            formDifficultySelection.Hint(formDifficultySelection.wordDupe.Count);
        }

        private void tbAnswer_Enter(object sender, EventArgs e)
        {
            ClearText();
        }

        private void tbAnswer_Leave(object sender, EventArgs e)
        {
            ShowText();
        }
        
        private void btnStats_Click(object sender, EventArgs e)
        {
            formDifficultySelection.ViewStats(this, formDifficultySelection, formDifficultySelection.correctGuesses, 
                formDifficultySelection.incorrectGuesses, formDifficultySelection.averageTimePerWord, 
                formDifficultySelection.winStreakHighScoreForThisGame, formDifficultySelection.winStreak_HighScore,
                formDifficultySelection.averageTimePerWord_HighScore);
        }

        private void btnChangeDifficulty_Click(object sender, EventArgs e)
        {
            ChangeDifficulty();
        }
    }
}
