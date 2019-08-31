namespace WindowsFormsApp3
{
    partial class frmRockPaperScissors
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabctrlGameSelection = new System.Windows.Forms.TabControl();
            this.tabpgSinglePlayer = new System.Windows.Forms.TabPage();
            this.btnScissorsSingle = new System.Windows.Forms.Button();
            this.btnPaperSingle = new System.Windows.Forms.Button();
            this.btnRockSingle = new System.Windows.Forms.Button();
            this.tabpgTwoPlayer = new System.Windows.Forms.TabPage();
            this.lblTwoPlayerTurn = new System.Windows.Forms.Label();
            this.btnScissorsTwo = new System.Windows.Forms.Button();
            this.btnPaperTwo = new System.Windows.Forms.Button();
            this.btnRockTwo = new System.Windows.Forms.Button();
            this.tabpgAutomaticRPS = new System.Windows.Forms.TabPage();
            this.btnPlayGamesAutomaticRPS = new System.Windows.Forms.Button();
            this.lblAutomaticTrackBarPosition = new System.Windows.Forms.Label();
            this.tkbrAutomaticRPS = new System.Windows.Forms.TrackBar();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblPlayerOneWins = new System.Windows.Forms.Label();
            this.lblPlayerTwoWins = new System.Windows.Forms.Label();
            this.lblPlayerOneWins_Output = new System.Windows.Forms.Label();
            this.lblPlayerTwoWins_Output = new System.Windows.Forms.Label();
            this.lblThrowResults = new System.Windows.Forms.Label();
            this.lblGamesPlayed = new System.Windows.Forms.Label();
            this.lblGamesPlayed_Output = new System.Windows.Forms.Label();
            this.btnRenamePlayers = new System.Windows.Forms.Button();
            this.btnPrintResults = new System.Windows.Forms.Button();
            this.btnResetStats = new System.Windows.Forms.Button();
            this.tabctrlGameSelection.SuspendLayout();
            this.tabpgSinglePlayer.SuspendLayout();
            this.tabpgTwoPlayer.SuspendLayout();
            this.tabpgAutomaticRPS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbrAutomaticRPS)).BeginInit();
            this.SuspendLayout();
            // 
            // tabctrlGameSelection
            // 
            this.tabctrlGameSelection.Controls.Add(this.tabpgSinglePlayer);
            this.tabctrlGameSelection.Controls.Add(this.tabpgTwoPlayer);
            this.tabctrlGameSelection.Controls.Add(this.tabpgAutomaticRPS);
            this.tabctrlGameSelection.Location = new System.Drawing.Point(13, 12);
            this.tabctrlGameSelection.Name = "tabctrlGameSelection";
            this.tabctrlGameSelection.SelectedIndex = 0;
            this.tabctrlGameSelection.Size = new System.Drawing.Size(483, 246);
            this.tabctrlGameSelection.TabIndex = 0;
            this.tabctrlGameSelection.SelectedIndexChanged += new System.EventHandler(this.tabCtrlGameSelection_SelectedIndexChanged);
            // 
            // tabpgSinglePlayer
            // 
            this.tabpgSinglePlayer.Controls.Add(this.btnScissorsSingle);
            this.tabpgSinglePlayer.Controls.Add(this.btnPaperSingle);
            this.tabpgSinglePlayer.Controls.Add(this.btnRockSingle);
            this.tabpgSinglePlayer.Location = new System.Drawing.Point(4, 22);
            this.tabpgSinglePlayer.Name = "tabpgSinglePlayer";
            this.tabpgSinglePlayer.Padding = new System.Windows.Forms.Padding(3);
            this.tabpgSinglePlayer.Size = new System.Drawing.Size(475, 220);
            this.tabpgSinglePlayer.TabIndex = 0;
            this.tabpgSinglePlayer.Text = "Single Player";
            this.tabpgSinglePlayer.UseVisualStyleBackColor = true;
            // 
            // btnScissorsSingle
            // 
            this.btnScissorsSingle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScissorsSingle.Location = new System.Drawing.Point(325, 25);
            this.btnScissorsSingle.Name = "btnScissorsSingle";
            this.btnScissorsSingle.Size = new System.Drawing.Size(125, 125);
            this.btnScissorsSingle.TabIndex = 2;
            this.btnScissorsSingle.Text = "Scissors";
            this.btnScissorsSingle.UseVisualStyleBackColor = true;
            this.btnScissorsSingle.Click += new System.EventHandler(this.btnScissorsSingle_Click);
            // 
            // btnPaperSingle
            // 
            this.btnPaperSingle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaperSingle.Location = new System.Drawing.Point(175, 25);
            this.btnPaperSingle.Name = "btnPaperSingle";
            this.btnPaperSingle.Size = new System.Drawing.Size(125, 125);
            this.btnPaperSingle.TabIndex = 1;
            this.btnPaperSingle.Text = "Paper";
            this.btnPaperSingle.UseVisualStyleBackColor = true;
            this.btnPaperSingle.Click += new System.EventHandler(this.btnPaperSingle_Click);
            // 
            // btnRockSingle
            // 
            this.btnRockSingle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRockSingle.Location = new System.Drawing.Point(25, 25);
            this.btnRockSingle.Name = "btnRockSingle";
            this.btnRockSingle.Size = new System.Drawing.Size(125, 125);
            this.btnRockSingle.TabIndex = 0;
            this.btnRockSingle.Text = "Rock";
            this.btnRockSingle.UseVisualStyleBackColor = true;
            this.btnRockSingle.Click += new System.EventHandler(this.btnRockSingle_Click);
            // 
            // tabpgTwoPlayer
            // 
            this.tabpgTwoPlayer.Controls.Add(this.lblTwoPlayerTurn);
            this.tabpgTwoPlayer.Controls.Add(this.btnScissorsTwo);
            this.tabpgTwoPlayer.Controls.Add(this.btnPaperTwo);
            this.tabpgTwoPlayer.Controls.Add(this.btnRockTwo);
            this.tabpgTwoPlayer.Location = new System.Drawing.Point(4, 22);
            this.tabpgTwoPlayer.Name = "tabpgTwoPlayer";
            this.tabpgTwoPlayer.Padding = new System.Windows.Forms.Padding(3);
            this.tabpgTwoPlayer.Size = new System.Drawing.Size(475, 220);
            this.tabpgTwoPlayer.TabIndex = 1;
            this.tabpgTwoPlayer.Text = "Two Player";
            this.tabpgTwoPlayer.UseVisualStyleBackColor = true;
            // 
            // lblTwoPlayerTurn
            // 
            this.lblTwoPlayerTurn.AutoSize = true;
            this.lblTwoPlayerTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTwoPlayerTurn.Location = new System.Drawing.Point(145, 179);
            this.lblTwoPlayerTurn.Name = "lblTwoPlayerTurn";
            this.lblTwoPlayerTurn.Size = new System.Drawing.Size(185, 20);
            this.lblTwoPlayerTurn.TabIndex = 3;
            this.lblTwoPlayerTurn.Text = "It\'s Player One\'s Turn!";
            // 
            // btnScissorsTwo
            // 
            this.btnScissorsTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScissorsTwo.Location = new System.Drawing.Point(325, 25);
            this.btnScissorsTwo.Name = "btnScissorsTwo";
            this.btnScissorsTwo.Size = new System.Drawing.Size(125, 125);
            this.btnScissorsTwo.TabIndex = 2;
            this.btnScissorsTwo.Text = "Scissors";
            this.btnScissorsTwo.UseVisualStyleBackColor = true;
            this.btnScissorsTwo.Click += new System.EventHandler(this.btnScissorsTwo_Click);
            // 
            // btnPaperTwo
            // 
            this.btnPaperTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaperTwo.Location = new System.Drawing.Point(175, 25);
            this.btnPaperTwo.Name = "btnPaperTwo";
            this.btnPaperTwo.Size = new System.Drawing.Size(125, 125);
            this.btnPaperTwo.TabIndex = 1;
            this.btnPaperTwo.Text = "Paper";
            this.btnPaperTwo.UseVisualStyleBackColor = true;
            this.btnPaperTwo.Click += new System.EventHandler(this.btnPaperTwo_Click);
            // 
            // btnRockTwo
            // 
            this.btnRockTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRockTwo.Location = new System.Drawing.Point(25, 25);
            this.btnRockTwo.Name = "btnRockTwo";
            this.btnRockTwo.Size = new System.Drawing.Size(125, 125);
            this.btnRockTwo.TabIndex = 0;
            this.btnRockTwo.Text = "Rock";
            this.btnRockTwo.UseVisualStyleBackColor = true;
            this.btnRockTwo.Click += new System.EventHandler(this.btnRockTwo_Click);
            // 
            // tabpgAutomaticRPS
            // 
            this.tabpgAutomaticRPS.Controls.Add(this.btnPlayGamesAutomaticRPS);
            this.tabpgAutomaticRPS.Controls.Add(this.lblAutomaticTrackBarPosition);
            this.tabpgAutomaticRPS.Controls.Add(this.tkbrAutomaticRPS);
            this.tabpgAutomaticRPS.Location = new System.Drawing.Point(4, 22);
            this.tabpgAutomaticRPS.Name = "tabpgAutomaticRPS";
            this.tabpgAutomaticRPS.Size = new System.Drawing.Size(475, 220);
            this.tabpgAutomaticRPS.TabIndex = 2;
            this.tabpgAutomaticRPS.Text = "Automatic";
            this.tabpgAutomaticRPS.UseVisualStyleBackColor = true;
            // 
            // btnPlayGamesAutomaticRPS
            // 
            this.btnPlayGamesAutomaticRPS.Location = new System.Drawing.Point(190, 103);
            this.btnPlayGamesAutomaticRPS.Name = "btnPlayGamesAutomaticRPS";
            this.btnPlayGamesAutomaticRPS.Size = new System.Drawing.Size(103, 46);
            this.btnPlayGamesAutomaticRPS.TabIndex = 2;
            this.btnPlayGamesAutomaticRPS.Text = "Play Games";
            this.btnPlayGamesAutomaticRPS.UseVisualStyleBackColor = true;
            this.btnPlayGamesAutomaticRPS.Click += new System.EventHandler(this.btnPlayGamesAutomaticRPS_Click);
            // 
            // lblAutomaticTrackBarPosition
            // 
            this.lblAutomaticTrackBarPosition.AutoSize = true;
            this.lblAutomaticTrackBarPosition.Location = new System.Drawing.Point(229, 77);
            this.lblAutomaticTrackBarPosition.Name = "lblAutomaticTrackBarPosition";
            this.lblAutomaticTrackBarPosition.Size = new System.Drawing.Size(13, 13);
            this.lblAutomaticTrackBarPosition.TabIndex = 1;
            this.lblAutomaticTrackBarPosition.Text = "1";
            // 
            // tkbrAutomaticRPS
            // 
            this.tkbrAutomaticRPS.LargeChange = 50;
            this.tkbrAutomaticRPS.Location = new System.Drawing.Point(25, 25);
            this.tkbrAutomaticRPS.Maximum = 10000;
            this.tkbrAutomaticRPS.Minimum = 1;
            this.tkbrAutomaticRPS.Name = "tkbrAutomaticRPS";
            this.tkbrAutomaticRPS.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tkbrAutomaticRPS.Size = new System.Drawing.Size(425, 45);
            this.tkbrAutomaticRPS.TabIndex = 0;
            this.tkbrAutomaticRPS.Value = 1;
            this.tkbrAutomaticRPS.Scroll += new System.EventHandler(this.tkbrAutomaticRPS_Scroll);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(13, 369);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuit.Location = new System.Drawing.Point(421, 369);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 2;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblPlayerOneWins
            // 
            this.lblPlayerOneWins.AutoSize = true;
            this.lblPlayerOneWins.Location = new System.Drawing.Point(14, 261);
            this.lblPlayerOneWins.Name = "lblPlayerOneWins";
            this.lblPlayerOneWins.Size = new System.Drawing.Size(89, 13);
            this.lblPlayerOneWins.TabIndex = 3;
            this.lblPlayerOneWins.Text = "Player One Wins:";
            // 
            // lblPlayerTwoWins
            // 
            this.lblPlayerTwoWins.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPlayerTwoWins.AutoSize = true;
            this.lblPlayerTwoWins.Location = new System.Drawing.Point(389, 261);
            this.lblPlayerTwoWins.Name = "lblPlayerTwoWins";
            this.lblPlayerTwoWins.Size = new System.Drawing.Size(90, 13);
            this.lblPlayerTwoWins.TabIndex = 4;
            this.lblPlayerTwoWins.Text = "Player Two Wins:";
            this.lblPlayerTwoWins.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPlayerOneWins_Output
            // 
            this.lblPlayerOneWins_Output.AutoSize = true;
            this.lblPlayerOneWins_Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerOneWins_Output.Location = new System.Drawing.Point(30, 278);
            this.lblPlayerOneWins_Output.Name = "lblPlayerOneWins_Output";
            this.lblPlayerOneWins_Output.Size = new System.Drawing.Size(19, 20);
            this.lblPlayerOneWins_Output.TabIndex = 5;
            this.lblPlayerOneWins_Output.Text = "0";
            // 
            // lblPlayerTwoWins_Output
            // 
            this.lblPlayerTwoWins_Output.AutoSize = true;
            this.lblPlayerTwoWins_Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerTwoWins_Output.Location = new System.Drawing.Point(421, 278);
            this.lblPlayerTwoWins_Output.Name = "lblPlayerTwoWins_Output";
            this.lblPlayerTwoWins_Output.Size = new System.Drawing.Size(19, 20);
            this.lblPlayerTwoWins_Output.TabIndex = 6;
            this.lblPlayerTwoWins_Output.Text = "0";
            // 
            // lblThrowResults
            // 
            this.lblThrowResults.AutoSize = true;
            this.lblThrowResults.Location = new System.Drawing.Point(190, 272);
            this.lblThrowResults.Name = "lblThrowResults";
            this.lblThrowResults.Size = new System.Drawing.Size(75, 13);
            this.lblThrowResults.TabIndex = 7;
            this.lblThrowResults.Text = "Throw Results";
            this.lblThrowResults.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblGamesPlayed
            // 
            this.lblGamesPlayed.AutoSize = true;
            this.lblGamesPlayed.Location = new System.Drawing.Point(190, 341);
            this.lblGamesPlayed.Name = "lblGamesPlayed";
            this.lblGamesPlayed.Size = new System.Drawing.Size(78, 13);
            this.lblGamesPlayed.TabIndex = 8;
            this.lblGamesPlayed.Text = "Games Played:";
            // 
            // lblGamesPlayed_Output
            // 
            this.lblGamesPlayed_Output.AutoSize = true;
            this.lblGamesPlayed_Output.Location = new System.Drawing.Point(274, 341);
            this.lblGamesPlayed_Output.Name = "lblGamesPlayed_Output";
            this.lblGamesPlayed_Output.Size = new System.Drawing.Size(13, 13);
            this.lblGamesPlayed_Output.TabIndex = 9;
            this.lblGamesPlayed_Output.Text = "0";
            // 
            // btnRenamePlayers
            // 
            this.btnRenamePlayers.Location = new System.Drawing.Point(215, 369);
            this.btnRenamePlayers.Name = "btnRenamePlayers";
            this.btnRenamePlayers.Size = new System.Drawing.Size(94, 23);
            this.btnRenamePlayers.TabIndex = 12;
            this.btnRenamePlayers.Text = "Rename Players";
            this.btnRenamePlayers.UseVisualStyleBackColor = true;
            this.btnRenamePlayers.Click += new System.EventHandler(this.btnRenamePlayers_Click);
            // 
            // btnPrintResults
            // 
            this.btnPrintResults.Location = new System.Drawing.Point(316, 369);
            this.btnPrintResults.Name = "btnPrintResults";
            this.btnPrintResults.Size = new System.Drawing.Size(99, 23);
            this.btnPrintResults.TabIndex = 13;
            this.btnPrintResults.Text = "Print Overall Stats";
            this.btnPrintResults.UseVisualStyleBackColor = true;
            this.btnPrintResults.Click += new System.EventHandler(this.btnPrintResults_Click);
            // 
            // btnResetStats
            // 
            this.btnResetStats.Location = new System.Drawing.Point(94, 369);
            this.btnResetStats.Name = "btnResetStats";
            this.btnResetStats.Size = new System.Drawing.Size(115, 23);
            this.btnResetStats.TabIndex = 14;
            this.btnResetStats.Text = "Reset Overall Stats";
            this.btnResetStats.UseVisualStyleBackColor = true;
            this.btnResetStats.Click += new System.EventHandler(this.btnResetStats_Click);
            // 
            // frmRockPaperScissors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnQuit;
            this.ClientSize = new System.Drawing.Size(508, 404);
            this.Controls.Add(this.btnResetStats);
            this.Controls.Add(this.btnPrintResults);
            this.Controls.Add(this.btnRenamePlayers);
            this.Controls.Add(this.lblGamesPlayed_Output);
            this.Controls.Add(this.lblGamesPlayed);
            this.Controls.Add(this.lblThrowResults);
            this.Controls.Add(this.lblPlayerTwoWins_Output);
            this.Controls.Add(this.lblPlayerOneWins_Output);
            this.Controls.Add(this.lblPlayerTwoWins);
            this.Controls.Add(this.lblPlayerOneWins);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.tabctrlGameSelection);
            this.Name = "frmRockPaperScissors";
            this.Text = "Rock, Paper, Scissors!";
            this.Load += new System.EventHandler(this.frmRockPaperScissors_Load);
            this.tabctrlGameSelection.ResumeLayout(false);
            this.tabpgSinglePlayer.ResumeLayout(false);
            this.tabpgTwoPlayer.ResumeLayout(false);
            this.tabpgTwoPlayer.PerformLayout();
            this.tabpgAutomaticRPS.ResumeLayout(false);
            this.tabpgAutomaticRPS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbrAutomaticRPS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabctrlGameSelection;
        private System.Windows.Forms.TabPage tabpgSinglePlayer;
        private System.Windows.Forms.Button btnScissorsSingle;
        private System.Windows.Forms.Button btnPaperSingle;
        private System.Windows.Forms.Button btnRockSingle;
        private System.Windows.Forms.TabPage tabpgTwoPlayer;
        private System.Windows.Forms.Label lblTwoPlayerTurn;
        private System.Windows.Forms.Button btnScissorsTwo;
        private System.Windows.Forms.Button btnPaperTwo;
        private System.Windows.Forms.Button btnRockTwo;
        private System.Windows.Forms.TabPage tabpgAutomaticRPS;
        private System.Windows.Forms.Button btnPlayGamesAutomaticRPS;
        private System.Windows.Forms.Label lblAutomaticTrackBarPosition;
        private System.Windows.Forms.TrackBar tkbrAutomaticRPS;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblPlayerOneWins;
        private System.Windows.Forms.Label lblPlayerTwoWins;
        private System.Windows.Forms.Label lblPlayerOneWins_Output;
        private System.Windows.Forms.Label lblPlayerTwoWins_Output;
        private System.Windows.Forms.Label lblThrowResults;
        private System.Windows.Forms.Label lblGamesPlayed;
        private System.Windows.Forms.Label lblGamesPlayed_Output;
        private System.Windows.Forms.Button btnRenamePlayers;
        private System.Windows.Forms.Button btnPrintResults;
        private System.Windows.Forms.Button btnResetStats;
    }
}

