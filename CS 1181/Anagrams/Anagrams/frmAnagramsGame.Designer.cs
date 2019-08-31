namespace Anagrams
{
    partial class frmAnagramsGame
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
            this.btnQuit = new System.Windows.Forms.Button();
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.btnSkip = new System.Windows.Forms.Button();
            this.btnHint = new System.Windows.Forms.Button();
            this.btnChangeDifficulty = new System.Windows.Forms.Button();
            this.lblCorrectGuesses = new System.Windows.Forms.Label();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.lblIncorrectGuesses = new System.Windows.Forms.Label();
            this.lblIncorrect = new System.Windows.Forms.Label();
            this.btnStats = new System.Windows.Forms.Button();
            this.lblWinStreak = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnQuit
            // 
            this.btnQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(634, 252);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(5);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(80, 34);
            this.btnQuit.TabIndex = 0;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // tbAnswer
            // 
            this.tbAnswer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAnswer.Location = new System.Drawing.Point(105, 112);
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.Size = new System.Drawing.Size(533, 35);
            this.tbAnswer.TabIndex = 1;
            this.tbAnswer.Text = "Unscramble the word and type your answer here!";
            this.tbAnswer.TextChanged += new System.EventHandler(this.tbAnswer_TextChanged);
            this.tbAnswer.Enter += new System.EventHandler(this.tbAnswer_Enter);
            this.tbAnswer.Leave += new System.EventHandler(this.tbAnswer_Leave);
            // 
            // btnSkip
            // 
            this.btnSkip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSkip.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkip.Location = new System.Drawing.Point(536, 183);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(117, 46);
            this.btnSkip.TabIndex = 2;
            this.btnSkip.Text = "Skip";
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // btnHint
            // 
            this.btnHint.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHint.Location = new System.Drawing.Point(342, 183);
            this.btnHint.Name = "btnHint";
            this.btnHint.Size = new System.Drawing.Size(114, 46);
            this.btnHint.TabIndex = 3;
            this.btnHint.Text = "Hint";
            this.btnHint.UseVisualStyleBackColor = true;
            this.btnHint.Click += new System.EventHandler(this.btnHint_Click);
            // 
            // btnChangeDifficulty
            // 
            this.btnChangeDifficulty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnChangeDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeDifficulty.Location = new System.Drawing.Point(13, 252);
            this.btnChangeDifficulty.Name = "btnChangeDifficulty";
            this.btnChangeDifficulty.Size = new System.Drawing.Size(175, 36);
            this.btnChangeDifficulty.TabIndex = 4;
            this.btnChangeDifficulty.Text = "Change Difficulty";
            this.btnChangeDifficulty.UseVisualStyleBackColor = true;
            this.btnChangeDifficulty.Click += new System.EventHandler(this.btnChangeDifficulty_Click);
            // 
            // lblCorrectGuesses
            // 
            this.lblCorrectGuesses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCorrectGuesses.AutoSize = true;
            this.lblCorrectGuesses.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrectGuesses.Location = new System.Drawing.Point(210, 252);
            this.lblCorrectGuesses.Name = "lblCorrectGuesses";
            this.lblCorrectGuesses.Size = new System.Drawing.Size(126, 18);
            this.lblCorrectGuesses.TabIndex = 5;
            this.lblCorrectGuesses.Text = "Correct Guesses:";
            // 
            // lblCorrect
            // 
            this.lblCorrect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrect.Location = new System.Drawing.Point(213, 274);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(0, 18);
            this.lblCorrect.TabIndex = 6;
            // 
            // lblIncorrectGuesses
            // 
            this.lblIncorrectGuesses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIncorrectGuesses.AutoSize = true;
            this.lblIncorrectGuesses.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncorrectGuesses.Location = new System.Drawing.Point(438, 252);
            this.lblIncorrectGuesses.Name = "lblIncorrectGuesses";
            this.lblIncorrectGuesses.Size = new System.Drawing.Size(134, 18);
            this.lblIncorrectGuesses.TabIndex = 7;
            this.lblIncorrectGuesses.Text = "Incorrect Guesses:";
            // 
            // lblIncorrect
            // 
            this.lblIncorrect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIncorrect.AutoSize = true;
            this.lblIncorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncorrect.Location = new System.Drawing.Point(441, 274);
            this.lblIncorrect.Name = "lblIncorrect";
            this.lblIncorrect.Size = new System.Drawing.Size(0, 18);
            this.lblIncorrect.TabIndex = 8;
            // 
            // btnStats
            // 
            this.btnStats.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStats.Location = new System.Drawing.Point(105, 183);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(145, 46);
            this.btnStats.TabIndex = 9;
            this.btnStats.Text = "View Scores";
            this.btnStats.UseVisualStyleBackColor = true;
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // lblWinStreak
            // 
            this.lblWinStreak.AutoSize = true;
            this.lblWinStreak.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinStreak.Location = new System.Drawing.Point(285, 150);
            this.lblWinStreak.Name = "lblWinStreak";
            this.lblWinStreak.Size = new System.Drawing.Size(120, 24);
            this.lblWinStreak.TabIndex = 10;
            this.lblWinStreak.Text = "Win Streak: 0";
            // 
            // frmAnagramsGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(37F, 73F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 300);
            this.ControlBox = false;
            this.Controls.Add(this.lblWinStreak);
            this.Controls.Add(this.btnStats);
            this.Controls.Add(this.lblIncorrect);
            this.Controls.Add(this.lblIncorrectGuesses);
            this.Controls.Add(this.lblCorrect);
            this.Controls.Add(this.lblCorrectGuesses);
            this.Controls.Add(this.btnChangeDifficulty);
            this.Controls.Add(this.btnHint);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.tbAnswer);
            this.Controls.Add(this.btnQuit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(18);
            this.Name = "frmAnagramsGame";
            this.Text = "Anagrams";
            this.Load += new System.EventHandler(this.frmAnagramsGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.TextBox tbAnswer;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Button btnHint;
        private System.Windows.Forms.Button btnChangeDifficulty;
        private System.Windows.Forms.Label lblCorrectGuesses;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.Label lblIncorrectGuesses;
        private System.Windows.Forms.Label lblIncorrect;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.Label lblWinStreak;
    }
}