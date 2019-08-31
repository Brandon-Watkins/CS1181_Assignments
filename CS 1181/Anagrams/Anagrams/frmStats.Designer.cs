namespace Anagrams
{
    partial class frmStats
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
            this.btnClose = new System.Windows.Forms.Button();
            this.gbWinStreak = new System.Windows.Forms.GroupBox();
            this.lblWinStreak = new System.Windows.Forms.Label();
            this.gbWinStreakHighScore = new System.Windows.Forms.GroupBox();
            this.lblWinStreakHighScore = new System.Windows.Forms.Label();
            this.gbAverageTime = new System.Windows.Forms.GroupBox();
            this.lblAverageTime = new System.Windows.Forms.Label();
            this.gbAverageTimeHighScore = new System.Windows.Forms.GroupBox();
            this.lblAverageTimeHighScore = new System.Windows.Forms.Label();
            this.gbCorrectGuesses = new System.Windows.Forms.GroupBox();
            this.lblCorrectGuesses = new System.Windows.Forms.Label();
            this.gbIncorrectGuesses = new System.Windows.Forms.GroupBox();
            this.lblIncorrectGuesses = new System.Windows.Forms.Label();
            this.gbCorrectIncorrectRatio = new System.Windows.Forms.GroupBox();
            this.lblCorrectIncorrectRatio = new System.Windows.Forms.Label();
            this.gbWinStreak.SuspendLayout();
            this.gbWinStreakHighScore.SuspendLayout();
            this.gbAverageTime.SuspendLayout();
            this.gbAverageTimeHighScore.SuspendLayout();
            this.gbCorrectGuesses.SuspendLayout();
            this.gbIncorrectGuesses.SuspendLayout();
            this.gbCorrectIncorrectRatio.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(969, 430);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(95, 42);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gbWinStreak
            // 
            this.gbWinStreak.Controls.Add(this.lblWinStreak);
            this.gbWinStreak.Location = new System.Drawing.Point(783, 12);
            this.gbWinStreak.Name = "gbWinStreak";
            this.gbWinStreak.Size = new System.Drawing.Size(250, 60);
            this.gbWinStreak.TabIndex = 1;
            this.gbWinStreak.TabStop = false;
            this.gbWinStreak.Text = "Your Max Win Streak:";
            // 
            // lblWinStreak
            // 
            this.lblWinStreak.AutoSize = true;
            this.lblWinStreak.Location = new System.Drawing.Point(181, 27);
            this.lblWinStreak.Name = "lblWinStreak";
            this.lblWinStreak.Size = new System.Drawing.Size(30, 25);
            this.lblWinStreak.TabIndex = 0;
            this.lblWinStreak.Text = "...";
            // 
            // gbWinStreakHighScore
            // 
            this.gbWinStreakHighScore.Controls.Add(this.lblWinStreakHighScore);
            this.gbWinStreakHighScore.Location = new System.Drawing.Point(666, 263);
            this.gbWinStreakHighScore.Name = "gbWinStreakHighScore";
            this.gbWinStreakHighScore.Size = new System.Drawing.Size(270, 60);
            this.gbWinStreakHighScore.TabIndex = 3;
            this.gbWinStreakHighScore.TabStop = false;
            this.gbWinStreakHighScore.Text = "High Score - Win Streak:";
            // 
            // lblWinStreakHighScore
            // 
            this.lblWinStreakHighScore.AutoSize = true;
            this.lblWinStreakHighScore.Location = new System.Drawing.Point(202, 27);
            this.lblWinStreakHighScore.Name = "lblWinStreakHighScore";
            this.lblWinStreakHighScore.Size = new System.Drawing.Size(30, 25);
            this.lblWinStreakHighScore.TabIndex = 0;
            this.lblWinStreakHighScore.Text = "...";
            // 
            // gbAverageTime
            // 
            this.gbAverageTime.Controls.Add(this.lblAverageTime);
            this.gbAverageTime.Location = new System.Drawing.Point(399, 112);
            this.gbAverageTime.Name = "gbAverageTime";
            this.gbAverageTime.Size = new System.Drawing.Size(320, 60);
            this.gbAverageTime.TabIndex = 4;
            this.gbAverageTime.TabStop = false;
            this.gbAverageTime.Text = "Your Average Time Per Word:";
            // 
            // lblAverageTime
            // 
            this.lblAverageTime.AutoSize = true;
            this.lblAverageTime.Location = new System.Drawing.Point(167, 27);
            this.lblAverageTime.Name = "lblAverageTime";
            this.lblAverageTime.Size = new System.Drawing.Size(30, 25);
            this.lblAverageTime.TabIndex = 0;
            this.lblAverageTime.Text = "...";
            // 
            // gbAverageTimeHighScore
            // 
            this.gbAverageTimeHighScore.Controls.Add(this.lblAverageTimeHighScore);
            this.gbAverageTimeHighScore.Location = new System.Drawing.Point(150, 275);
            this.gbAverageTimeHighScore.Name = "gbAverageTimeHighScore";
            this.gbAverageTimeHighScore.Size = new System.Drawing.Size(390, 60);
            this.gbAverageTimeHighScore.TabIndex = 5;
            this.gbAverageTimeHighScore.TabStop = false;
            this.gbAverageTimeHighScore.Text = "High Score - Average Time Per Word:";
            // 
            // lblAverageTimeHighScore
            // 
            this.lblAverageTimeHighScore.AutoSize = true;
            this.lblAverageTimeHighScore.Location = new System.Drawing.Point(225, 27);
            this.lblAverageTimeHighScore.Name = "lblAverageTimeHighScore";
            this.lblAverageTimeHighScore.Size = new System.Drawing.Size(30, 25);
            this.lblAverageTimeHighScore.TabIndex = 0;
            this.lblAverageTimeHighScore.Text = "...";
            // 
            // gbCorrectGuesses
            // 
            this.gbCorrectGuesses.Controls.Add(this.lblCorrectGuesses);
            this.gbCorrectGuesses.Location = new System.Drawing.Point(479, 359);
            this.gbCorrectGuesses.Name = "gbCorrectGuesses";
            this.gbCorrectGuesses.Size = new System.Drawing.Size(250, 60);
            this.gbCorrectGuesses.TabIndex = 6;
            this.gbCorrectGuesses.TabStop = false;
            this.gbCorrectGuesses.Text = "Your Correct Guesses:";
            // 
            // lblCorrectGuesses
            // 
            this.lblCorrectGuesses.AutoSize = true;
            this.lblCorrectGuesses.Location = new System.Drawing.Point(143, 27);
            this.lblCorrectGuesses.Name = "lblCorrectGuesses";
            this.lblCorrectGuesses.Size = new System.Drawing.Size(30, 25);
            this.lblCorrectGuesses.TabIndex = 0;
            this.lblCorrectGuesses.Text = "...";
            // 
            // gbIncorrectGuesses
            // 
            this.gbIncorrectGuesses.Controls.Add(this.lblIncorrectGuesses);
            this.gbIncorrectGuesses.Location = new System.Drawing.Point(42, 199);
            this.gbIncorrectGuesses.Name = "gbIncorrectGuesses";
            this.gbIncorrectGuesses.Size = new System.Drawing.Size(270, 60);
            this.gbIncorrectGuesses.TabIndex = 7;
            this.gbIncorrectGuesses.TabStop = false;
            this.gbIncorrectGuesses.Text = "Your Incorrect Guesses:";
            // 
            // lblIncorrectGuesses
            // 
            this.lblIncorrectGuesses.AutoSize = true;
            this.lblIncorrectGuesses.Location = new System.Drawing.Point(167, 27);
            this.lblIncorrectGuesses.Name = "lblIncorrectGuesses";
            this.lblIncorrectGuesses.Size = new System.Drawing.Size(30, 25);
            this.lblIncorrectGuesses.TabIndex = 0;
            this.lblIncorrectGuesses.Text = "...";
            // 
            // gbCorrectIncorrectRatio
            // 
            this.gbCorrectIncorrectRatio.Controls.Add(this.lblCorrectIncorrectRatio);
            this.gbCorrectIncorrectRatio.Location = new System.Drawing.Point(12, 43);
            this.gbCorrectIncorrectRatio.Name = "gbCorrectIncorrectRatio";
            this.gbCorrectIncorrectRatio.Size = new System.Drawing.Size(270, 60);
            this.gbCorrectIncorrectRatio.TabIndex = 8;
            this.gbCorrectIncorrectRatio.TabStop = false;
            this.gbCorrectIncorrectRatio.Text = "Correct : Incorrect Ratio:";
            // 
            // lblCorrectIncorrectRatio
            // 
            this.lblCorrectIncorrectRatio.AutoSize = true;
            this.lblCorrectIncorrectRatio.Location = new System.Drawing.Point(172, 27);
            this.lblCorrectIncorrectRatio.Name = "lblCorrectIncorrectRatio";
            this.lblCorrectIncorrectRatio.Size = new System.Drawing.Size(30, 25);
            this.lblCorrectIncorrectRatio.TabIndex = 0;
            this.lblCorrectIncorrectRatio.Text = "...";
            // 
            // frmStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 484);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbCorrectIncorrectRatio);
            this.Controls.Add(this.gbIncorrectGuesses);
            this.Controls.Add(this.gbCorrectGuesses);
            this.Controls.Add(this.gbAverageTimeHighScore);
            this.Controls.Add(this.gbAverageTime);
            this.Controls.Add(this.gbWinStreakHighScore);
            this.Controls.Add(this.gbWinStreak);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmStats";
            this.Text = "Stats";
            this.Load += new System.EventHandler(this.frmStats_Load);
            this.gbWinStreak.ResumeLayout(false);
            this.gbWinStreak.PerformLayout();
            this.gbWinStreakHighScore.ResumeLayout(false);
            this.gbWinStreakHighScore.PerformLayout();
            this.gbAverageTime.ResumeLayout(false);
            this.gbAverageTime.PerformLayout();
            this.gbAverageTimeHighScore.ResumeLayout(false);
            this.gbAverageTimeHighScore.PerformLayout();
            this.gbCorrectGuesses.ResumeLayout(false);
            this.gbCorrectGuesses.PerformLayout();
            this.gbIncorrectGuesses.ResumeLayout(false);
            this.gbIncorrectGuesses.PerformLayout();
            this.gbCorrectIncorrectRatio.ResumeLayout(false);
            this.gbCorrectIncorrectRatio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox gbWinStreak;
        private System.Windows.Forms.Label lblWinStreak;
        private System.Windows.Forms.GroupBox gbWinStreakHighScore;
        private System.Windows.Forms.Label lblWinStreakHighScore;
        private System.Windows.Forms.GroupBox gbAverageTime;
        private System.Windows.Forms.Label lblAverageTime;
        private System.Windows.Forms.GroupBox gbAverageTimeHighScore;
        private System.Windows.Forms.Label lblAverageTimeHighScore;
        private System.Windows.Forms.GroupBox gbCorrectGuesses;
        private System.Windows.Forms.Label lblCorrectGuesses;
        private System.Windows.Forms.GroupBox gbIncorrectGuesses;
        private System.Windows.Forms.Label lblIncorrectGuesses;
        private System.Windows.Forms.GroupBox gbCorrectIncorrectRatio;
        private System.Windows.Forms.Label lblCorrectIncorrectRatio;
    }
}