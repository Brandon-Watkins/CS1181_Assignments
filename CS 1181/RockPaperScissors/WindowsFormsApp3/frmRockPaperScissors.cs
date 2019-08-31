/*

frmRockPaperScissors.cs
CS 1181
Brandon Watkins 
24 February 2019
Robert Howe
Description: Play rock paper scissors single player, 2 player, or automatic

WOW:
made a seperate form to gather player names, which defaults to Player One and Player Two
gave it a play button, and assigned enter to it
gave it a quit button, and assigned escape to it.
made a button to revisit the name form to change your name
gave a warning message box indicating file save loss if you rename, giving the opportunity to turn back
player names are stored to a file
total stats stored to file
total stats read back and displayed for user upon request
added a button to reset the overall stats, and another to reset the visible control stats, which will send those to the overall stats files.
two player mode announces which player's turn it is, no more guess work!
automatic has less "fluff" for quicker computations
gave it a button to quit, and assigned the escape key to it.
made yet another form to display the saved overall results
added a button to go back to the game, which I assigned enter to
added a button to quit, which i asigned escape to.

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


namespace WindowsFormsApp3
{
    public partial class frmRockPaperScissors : Form
    {

        // Global Variables 
        public int turn = 0;
        public string player1 = "Player One";
        public string player2 = "Player Two";
        public int playerOneThrowResult = 0;
        public int playerTwoThrowResult = 0;
        public int lastClick = 0;
        public string result = "";
        public int[] autoThrowResultsPlayerOne = { };
        public int[] autoThrowResultsPlayerTwo = { };
        public Random random;

        public frmRockPaperScissors()
        {
            InitializeComponent();
            random = new Random();
        }
    


        // ************************ Custom Methods Begin ****************** //


        /// <summary>
        /// retrieves the saved player names from frmWelcomeForm's inputs
        /// </summary>
        public void GetPlayerNames()
        {
            StreamReader inputFile;
            // Get player 1's name
            inputFile = File.OpenText("PlayerNames.txt");
            player1 = inputFile.ReadLine();

            // get player 2's name
            player2 = inputFile.ReadLine();
            inputFile.Close();

        }


        /// <summary>
        ///  This runs everything, used after click events
        /// </summary>
        /// <param name="clickedOnGesture">int</param>
        private void DoStuff(int clickedOnGesture, string whichGameMode)// run first upon clicking gesture
        {
            // all game modes
            LastClick(clickedOnGesture, ref lastClick);// Determines what was clicked on last

            // Single player and Two player games
            if (whichGameMode == "Single Player" || whichGameMode == "Two Player")
            {
                //Single Player Games
                if (whichGameMode == "Single Player")
                {
                    Throw(lastClick, ref playerOneThrowResult, ref playerTwoThrowResult);
                }

                // Two Player Games
                else if (whichGameMode == "Two Player")
                {
                    Throw(lastClick, ref playerOneThrowResult, ref playerTwoThrowResult, ref turn);
                }

                if (!IsPlayerOnesTurn(ref turn))
                {
                    DidThrowTie(playerOneThrowResult, playerTwoThrowResult, lblGamesPlayed_Output, ref result);

                    if (!DidThrowTie(playerOneThrowResult, playerTwoThrowResult, lblGamesPlayed_Output, ref result))
                    {
                        DidThrowWin(playerOneThrowResult, playerTwoThrowResult, lblPlayerOneWins_Output, lblPlayerTwoWins_Output);
                    }

                    AnnounceWinner();
                }
            }
        }


        /// <summary>
        /// this runs everything, for automatic games
        /// </summary>
        private void DoStuff()// for automatic games
        {
            Throw(ref autoThrowResultsPlayerOne, ref autoThrowResultsPlayerTwo);
            DidThrowTie(ref autoThrowResultsPlayerOne, ref autoThrowResultsPlayerTwo, lblGamesPlayed_Output);
            AnnounceStats();
        }

        /// <summary>
        /// Outputs whose turn it is, in 2 player mode
        /// </summary>
        private void Turn()
        {
            if (!IsPlayerOnesTurn(ref turn))
            {
                lblTwoPlayerTurn.Text = "It's " + player1 + "'s turn!";
            }
            if (IsPlayerOnesTurn(ref turn))
            {
                lblTwoPlayerTurn.Text = "it's " + player2 + "'s turn!";
            }
        }


        /// <summary>
        /// gathers player one's throw, and calculates automatic throw for player 2
        /// </summary>
        /// <param name="lastClick">int</param>
        /// <param name="playerOneThrowResult">int</param>
        /// <param name="playerTwoThrowResult">int</param>
        /// <param name="getRandomThrow">int</param>
        private void Throw(int lastClick, ref int playerOneThrowResult, ref int playerTwoThrowResult)// for single player throws. Run after DoStuff
        {
            // Player one's throw:
            turn++;
            playerOneThrowResult = 0;
            playerOneThrowResult = lastClick;
            Turn();

            //Random player two throw:
            turn++;
            playerTwoThrowResult = 0;
            playerTwoThrowResult = GetRandomThrow();
            Turn();
            
            

        }


        /// <summary>
        /// gathers throws for 2 player games
        /// </summary>
        /// <param name="lastClick">int</param>
        /// <param name="playerOneThrowResult">int</param>
        /// <param name="playerTwoThrowResult">int</param>
        private void Throw(int lastClick, ref int playerOneThrowResult, ref int playerTwoThrowResult, ref int turn)// for two player throws. run after Do Stuff
        {
            turn++;
            // Player one's throw:
            if (IsPlayerOnesTurn(ref turn))
            {
                playerOneThrowResult = 0;
                playerOneThrowResult = lastClick;

                //display players 2's turn
                Turn();

            }
            // Player two's throw:
            else if (!IsPlayerOnesTurn(ref turn))
            {
                playerTwoThrowResult = 0;
                playerTwoThrowResult = lastClick;

                //display player 1's turn
                Turn();
            }
        }


        /// <summary>
        /// calculates random throws for automatic games
        /// </summary>
        /// <param name="autoThrowResultsPlayerOne">int</param>
        /// <param name="autoThrowResultsPlayerTwo">int</param>
        private void Throw(ref int[] autoThrowResultsPlayerOne, ref int[] autoThrowResultsPlayerTwo)// for automatic games. run after DoStuff
        {
            autoThrowResultsPlayerOne = new int[tkbrAutomaticRPS.Value];
            autoThrowResultsPlayerTwo = new int[tkbrAutomaticRPS.Value];

            for (int i = 0, j = 0; i < tkbrAutomaticRPS.Value; i++, j++)
            {
                autoThrowResultsPlayerOne[i] = GetRandomThrow();
                autoThrowResultsPlayerTwo[j] = GetRandomThrow();
            }
        }


        /// <summary>
        /// Outputs overall throw stats for automatic games
        /// </summary>
        private void AnnounceStats()// for automatic games. run after DidThrowTie
        {
            // throw results label
            lblThrowResults.Text = player1 + " won " + int.Parse(lblPlayerOneWins_Output.Text) + " out of " + tkbrAutomaticRPS.Value + " games." + Environment.NewLine +
                player2 + " won " + int.Parse(lblPlayerTwoWins_Output.Text) + " out of " + tkbrAutomaticRPS.Value + " games.";

        }


        /// <summary>
        /// Outputs throw results
        /// </summary>
        private void AnnounceWinner()// run after DidThrowWin (excluding automatic games)
        {
            //throw results label
            lblThrowResults.Text = player1 + " threw " + Gesture(playerOneThrowResult) + "." + Environment.NewLine +
                player2 + " threw " + Gesture(playerTwoThrowResult) + "." + Environment.NewLine;

            //Find winner
            // was it a tie?
            if (DidThrowTie(playerOneThrowResult, playerTwoThrowResult, lblGamesPlayed_Output, ref result) == false)// if not a tie:
            {
                // who won?
                if (DidThrowWin(playerOneThrowResult, playerTwoThrowResult, lblPlayerOneWins_Output, lblPlayerTwoWins_Output))
                {
                    result = player1 + " wins!";
                    lblPlayerOneWins_Output.Text = (int.Parse(lblPlayerOneWins_Output.Text) + 1).ToString();
                }
                else if (DidThrowWin(playerOneThrowResult, playerTwoThrowResult, lblPlayerOneWins_Output, lblPlayerTwoWins_Output) == false)
                {
                    result = player2 + " wins!";
                    lblPlayerTwoWins_Output.Text = (int.Parse(lblPlayerTwoWins_Output.Text) + 1).ToString();
                }
            }
            else if (DidThrowTie(playerOneThrowResult, playerTwoThrowResult, lblGamesPlayed_Output, ref result) == true)// if it's a tie:
            {
                result = "Tie!";
            }
            lblThrowResults.Text += result;
            lblGamesPlayed_Output.Text = (int.Parse(lblGamesPlayed_Output.Text) + 1).ToString();
        }


        /// <summary>
        /// generates a random number between 1 and 3, for throw
        /// </summary>
        /// <returns>random number, 1 to 3 (int)</returns>
        private int GetRandomThrow() //Generates a random number, 1-3
        {
            return random.Next(3) + 1;
        }


        /// <summary>
        /// Determines whether or not a tie occured
        /// </summary>
        /// <param name="playerOneThrowResult">int</param>
        /// <param name="playerTwoThrowResult">int</param>
        /// <param name="lblGamesPlayed_Output">int</param>
        /// <param name="result">string</param>
        /// <returns>true if a tie occured (bool)</returns>
        private bool DidThrowTie(int playerOneThrowResult, int playerTwoThrowResult, Control lblGamesPlayed_Output, ref string result) // run after throw (excluding automatic games)
        {
            // if players tied, return true
            if (playerOneThrowResult == playerTwoThrowResult)
            {
                result = "Tie!";
                return true;
            }

            else
            return false;// not a tie
        }


        /// <summary>
        /// Determines Both whether the automatic throws tied, or won, to reduce number of arrays
        /// </summary>
        /// <param name="autoThrowResultsPlayerOne">int</param>
        /// <param name="autoThrowResultsPlayerTwo">int</param>
        /// <param name="lblGamesPlayed_Output">int</param>
        private void DidThrowTie(ref int[] autoThrowResultsPlayerOne, ref int[] autoThrowResultsPlayerTwo, Control lblGamesPlayed_Output)// for automatic games. run after throw. 
            // Didn't want to slow the program by outputting throw results for each of the 10000 instantaneous matches
            // so I made an entirely new method, just for auto games, instead of using the original.
        {
            for (int i = 0; i < tkbrAutomaticRPS.Value; i++)
            {
                lblGamesPlayed_Output.Text = (int.Parse(lblGamesPlayed_Output.Text) + 1).ToString();

                if (autoThrowResultsPlayerOne[i] != autoThrowResultsPlayerTwo[i])// if not a tie
                {

                    if (DidThrowWin(autoThrowResultsPlayerOne[i], autoThrowResultsPlayerTwo[i], lblPlayerOneWins_Output, lblPlayerTwoWins_Output))
                    {
                        lblPlayerOneWins_Output.Text = (int.Parse(lblPlayerOneWins_Output.Text) + 1).ToString();
                    }

                    else //if (DidThrowWin(autoThrowResultsPlayerOne[i], autoThrowResultsPlayerTwo[i], lblPlayerOneWins_Output, lblPlayerTwoWins_Output) == false)
                    {
                        lblPlayerTwoWins_Output.Text = (int.Parse(lblPlayerTwoWins_Output.Text) + 1).ToString();
                    }
                }
            }
        }


        /// <summary>
        /// Determines who won the throw
        /// </summary>
        /// <param name="playerOneThrowResult">int</param>
        /// <param name="playerTwoThrowThrowResult">int</param>
        /// <returns>true if player one won the throw (bool)</returns>
        private bool DidThrowWin(int playerOneThrowResult, int playerTwoThrowResult, 
            Control lblPlayerOneWins_Output, Control lblPlayerTwoWins_Output)   // determines who won the throw. run after DidThrowTie (excluding automatic games, this method is built into it).
        {
            // if player 1 throws rock
            if (playerOneThrowResult == 1)
            {
                // if p2 throws scissors
                if (playerTwoThrowResult == 3)
                {
                    AddToPlayerWinsSinceUpdate(int.Parse(lblPlayerOneWins_Output.Text));
                    return true;
                }
            }
            // if p1 = paper
            else if (playerOneThrowResult == 2)
            {
                //if p2 = rock
                if (playerTwoThrowResult == 1)
                {
                    AddToPlayerWinsSinceUpdate(int.Parse(lblPlayerOneWins_Output.Text));
                    return true;
                }
            }
            // if p1 = scissors
            else if (playerOneThrowResult == 3)
            {
                // if p2 = paper
                if (playerTwoThrowResult == 2)
                {
                    AddToPlayerWinsSinceUpdate(int.Parse(lblPlayerOneWins_Output.Text));
                    return true;
                }
            }
            AddToPlayerWinsSinceUpdate(int.Parse(lblPlayerTwoWins_Output.Text));
            return false;
            
        }


        /// <summary>
        /// adds a win to overall wins
        /// </summary>
        /// <param name="whichPlayerToAddWinTo">int</param>
        private void AddToPlayerWinsSinceUpdate(int whichPlayerToAddWinTo)
        {
            whichPlayerToAddWinTo++;
        }


        /// <summary>
        /// Updates the overall wins .txt files
        /// </summary>
        /// <param name="int.Parse(lblPlayerOneWins_Output.Text)">int</param>
        /// <param name="int.Parse(lblPlayerTwoWins_Output.Text)">int</param>
        private void UpdateOverallPlayerWins(Control lblPlayerOneWins_Output, Control lblPlayerTwoWins_Output, Control lblGamesPlayed_Output)
        {
            // update player 1's wins
            string p1Wins = "0";
            StreamReader srInput1;
            srInput1 = File.OpenText("PlayerOneWins.txt");
            p1Wins = srInput1.ReadLine(); // table title, disregarding.
            p1Wins = srInput1.ReadLine(); // score to edit
            srInput1.Close();

            StreamWriter swOutput1;
            swOutput1 = File.CreateText("PlayerOneWins.txt");
            swOutput1.WriteLine(player1 + " won:");
            swOutput1.WriteLine((int.Parse(p1Wins) + int.Parse(lblPlayerOneWins_Output.Text)).ToString());
            swOutput1.Close();


            // update player 2's wins
            string p2Wins = "0";
            StreamReader srInput2;
            srInput2 = File.OpenText("PlayerTwoWins.txt");
            p2Wins = srInput2.ReadLine(); // table title, disregarding.
            p2Wins = srInput2.ReadLine(); // score to edit
            srInput2.Close();

            StreamWriter swOutput2;
            swOutput2 = File.CreateText("PlayerTwoWins.txt");
            swOutput2.WriteLine(player2 + " won:");
            swOutput2.WriteLine((int.Parse(p2Wins) + int.Parse(lblPlayerTwoWins_Output.Text)).ToString());
            swOutput2.Close();
            

            // update games played
            string gamesPlayed = "0";
            StreamReader srInput3;
            srInput3 = File.OpenText("GamesPlayed.txt");
            gamesPlayed = srInput3.ReadLine(); // table title, disregarding.
            gamesPlayed = srInput3.ReadLine(); // score to edit
            srInput3.Close();

            StreamWriter swOutput3;
            swOutput3 = File.CreateText("GamesPlayed.txt");
            swOutput3.WriteLine("Games Played:");
            swOutput3.WriteLine((int.Parse(gamesPlayed) + int.Parse(lblGamesPlayed_Output.Text)).ToString());
            swOutput3.Close();

            // reset overall stats since update
            lblGamesPlayed_Output.Text = "0";
            lblPlayerOneWins_Output.Text = "0";
            lblPlayerTwoWins_Output.Text = "0";
        }


        /// <summary>
        /// determines which hand gesture the players used, based on the numbers 0-3
        /// </summary>
        /// <param name="playerThrowResult">int</param>
        /// <returns>rock, paper, scissors, or error (string)</returns>
        private string Gesture(int playerThrowResult)
        {
            if (playerThrowResult == 1)
                return "rock";
            if (playerThrowResult == 2)
                return "paper";
            if (playerThrowResult == 3)
                return "scissors";
            else
                return "error";

        }


        /// <summary>
        /// Determines whos turn it is
        /// </summary>
        /// <param name="turn">int</param>
        /// <returns>true if it's player one's turn (bool)</returns>
        private bool IsPlayerOnesTurn(ref int turn)
        {
            if (turn % 2 != 0)
                return true;

            else
                return false;
        }


        /// <summary>
        /// stores which button was clicked on
        /// </summary>
        /// <param name="clickMethod">int</param>
        /// <param name="lastClick">int</param>
        private void LastClick(int clickMethod/*ClickedOnRock(), etc*/, ref int lastClick) // determines which button was clicked
        {
            lastClick = clickMethod;
        }


        /// <summary>
        /// used to store button presses
        /// </summary>
        /// <returns>1 (int)</returns>
        private int ClickedOnRock()
        {
            return 1;
        }


        /// <summary>
        /// used to store button presses
        /// </summary>
        /// <returns>2 (int)</returns>
        private int ClickedOnPaper()
        {
            return 2;
        }


        /// <summary>
        /// used to store button presses
        /// </summary>
        /// <returns>3 (int)</returns>
        private int ClickedOnScissors()
        {
            return 3;
        }
        

        /// <summary>
        /// Resets the application, to varying degrees, as indicated by the levelToReset.
        /// </summary>
        /// <param name="levelToReset">"Soft" or "Hard" (string)</param>
        /// <param name="autoThrowResultsPlayerOne">auto-game player 1 results (int[])</param>
        /// <param name="autoThrowResultsPlayerTwo">auto-game player 2 results (int[])</param>
        /// <param name="turn">turn counter (int)</param>
        /// <param name="result">throw results (string)</param>
        /// <param name="lblGamesPlayed_Output">games played counter (int)</param>
        private void Reset(string levelToReset, ref int[] autoThrowResultsPlayerOne, ref int[] autoThrowResultsPlayerTwo,
            ref int turn, ref string result, Control lblGamesPlayed_Output)
        {
            if (levelToReset == "Soft" || levelToReset == "Hard" || levelToReset == "Overall")
            {
                turn = 0;
                result = "";
                lblThrowResults.Text = result;
                autoThrowResultsPlayerOne = null;
                autoThrowResultsPlayerTwo = null;
                lblPlayerOneWins.Text = player1 + " has won:";
                lblPlayerTwoWins.Text = player2 + " has won:";
            }
            
            if (levelToReset == "Hard" || levelToReset == "Overall")
            {
                UpdateOverallPlayerWins(lblPlayerOneWins_Output, lblPlayerTwoWins_Output, lblGamesPlayed_Output);
            }

            if (levelToReset == "Overall")
            {

/*                  StreamWriter outputFile1 = null;
                     CreateText(outputFile1, "PlayerNames.txt", "");

                     //reset overall stats
                     // create a file to store player 1's wins
                     StreamWriter outputFile2 = null;
                     CreateText(outputFile2, "PlayerOneWins.txt", player1 + " wins:");

                     // create a file to store player 2's wins
                     StreamWriter outputFile3 = null;
                     CreateText(outputFile3, "PlayerTwoWins.txt", player2 + " wins:");

                     // create a file to store ties
                     StreamWriter outputFile4 = null;
                     CreateText(outputFile4, "GamesPlayed.txt", "Games Played:");
*/

                StreamWriter sw1;
                sw1 = File.CreateText("PlayerNames.txt");
                sw1.WriteLine(player1);
                sw1.WriteLine(player2);
                sw1.Close();

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
            }
        }



        // *************************** End of custom methods ******************************* //


        private void tabCtrlGameSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reset("Soft", ref autoThrowResultsPlayerOne, ref autoThrowResultsPlayerTwo, ref turn, ref result, lblGamesPlayed_Output);
        }

        private void tkbrAutomaticRPS_Scroll(object sender, EventArgs e)
        {
            lblAutomaticTrackBarPosition.Text = tkbrAutomaticRPS.Value.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e) // Reset everything to initial values.
        {
            Reset("Hard", ref autoThrowResultsPlayerOne, ref autoThrowResultsPlayerTwo, ref turn, ref result, lblGamesPlayed_Output);
        }

        private void btnQuit_Click(object sender, EventArgs e) // Close the application.
        {
            this.Close();
        }

        private void btnRenamePlayers_Click(object sender, EventArgs e)
        {
            var continueToRename = MessageBox.Show("Renaming the players will also reset all overall stats." + Environment.NewLine + Environment.NewLine + 
                "                      Continue to rename?", "Rename Players and Reset Statistics", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (continueToRename == DialogResult.Yes)
            {
                // hide this form.
                this.Hide();

                // open frmWelcomeForm
                frmWelcomeForm frmWelcomeForm = new frmWelcomeForm();
                frmWelcomeForm.ShowDialog();

                // close this form
                this.Close();
            }
        }

        private void frmRockPaperScissors_Load(object sender, EventArgs e)
        {
            //Reset everything
            Reset("Overall", ref autoThrowResultsPlayerOne, ref autoThrowResultsPlayerTwo, ref turn, ref result, lblGamesPlayed_Output);
            
            // Get player names from save file
            GetPlayerNames();
        }
        
        private void btnRockSingle_Click(object sender, EventArgs e)//single player
        {
            DoStuff(ClickedOnRock(), "Single Player");
        }

        private void btnPaperSingle_Click(object sender, EventArgs e)//single player
        {
            DoStuff(ClickedOnPaper(), "Single Player");
        }

        private void btnScissorsSingle_Click(object sender, EventArgs e)//single player
        {
            DoStuff(ClickedOnScissors(), "Single Player");
        }

        private void btnRockTwo_Click(object sender, EventArgs e)
        {
            DoStuff(ClickedOnRock(), "Two Player");
        }

        private void btnPaperTwo_Click(object sender, EventArgs e)
        {
            DoStuff(ClickedOnPaper(), "Two Player");
        }

        private void btnScissorsTwo_Click(object sender, EventArgs e)
        {
            DoStuff(ClickedOnScissors(), "Two Player");
        }

        private void btnPlayGamesAutomaticRPS_Click(object sender, EventArgs e)
        {
            DoStuff();
        }

        private void btnPrintResults_Click(object sender, EventArgs e)
        {
            UpdateOverallPlayerWins(lblPlayerOneWins_Output, lblPlayerTwoWins_Output, lblGamesPlayed_Output);

            // hide this form. unsure why this was necesary.
            this.Hide();

            // open frmRockPaperScissors
            frmOverallStats frmOverallStats = new frmOverallStats();
            frmOverallStats.ShowDialog();

            // close this form
            this.Close();
        }

        private void btnResetStats_Click(object sender, EventArgs e)
        {
            Reset("Overall", ref autoThrowResultsPlayerOne, ref autoThrowResultsPlayerTwo, ref turn, ref result, lblGamesPlayed_Output);
        }
    }
}
