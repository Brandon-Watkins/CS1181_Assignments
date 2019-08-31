namespace Anagrams
{
    partial class frmDifficultySelection
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
            this.components = new System.ComponentModel.Container();
            this.btnQuit = new System.Windows.Forms.Button();
            this.tkbrDifficulty = new System.Windows.Forms.TrackBar();
            this.lblDifficultyDescription = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnResetScores = new System.Windows.Forms.Button();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.btnViewStats = new System.Windows.Forms.Button();
            this.tmrHint = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tkbrDifficulty)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuit
            // 
            this.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuit.FlatAppearance.BorderSize = 0;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(143, 167);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(72, 23);
            this.btnQuit.TabIndex = 0;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // tkbrDifficulty
            // 
            this.tkbrDifficulty.BackColor = System.Drawing.SystemColors.Control;
            this.tkbrDifficulty.LargeChange = 3;
            this.tkbrDifficulty.Location = new System.Drawing.Point(12, 12);
            this.tkbrDifficulty.Maximum = 11;
            this.tkbrDifficulty.Minimum = 4;
            this.tkbrDifficulty.Name = "tkbrDifficulty";
            this.tkbrDifficulty.Size = new System.Drawing.Size(204, 45);
            this.tkbrDifficulty.TabIndex = 1;
            this.tkbrDifficulty.Value = 10;
            this.tkbrDifficulty.Scroll += new System.EventHandler(this.tkbrDifficulty_Scroll);
            // 
            // lblDifficultyDescription
            // 
            this.lblDifficultyDescription.AutoSize = true;
            this.lblDifficultyDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDifficultyDescription.Location = new System.Drawing.Point(29, 51);
            this.lblDifficultyDescription.Name = "lblDifficultyDescription";
            this.lblDifficultyDescription.Size = new System.Drawing.Size(162, 16);
            this.lblDifficultyDescription.TabIndex = 2;
            this.lblDifficultyDescription.Text = "Hard : Bring on the big\'n\'s!";
            this.lblDifficultyDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.SystemColors.Control;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(66, 79);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(99, 41);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnResetScores
            // 
            this.btnResetScores.FlatAppearance.BorderSize = 0;
            this.btnResetScores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResetScores.Location = new System.Drawing.Point(12, 167);
            this.btnResetScores.Name = "btnResetScores";
            this.btnResetScores.Size = new System.Drawing.Size(107, 23);
            this.btnResetScores.TabIndex = 4;
            this.btnResetScores.Text = "Reset High Scores";
            this.btnResetScores.UseVisualStyleBackColor = true;
            this.btnResetScores.Click += new System.EventHandler(this.btnResetScores_Click);
            // 
            // tmrTime
            // 
            this.tmrTime.Interval = 1000;
            this.tmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
            // 
            // btnViewStats
            // 
            this.btnViewStats.FlatAppearance.BorderSize = 0;
            this.btnViewStats.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewStats.Location = new System.Drawing.Point(42, 126);
            this.btnViewStats.Name = "btnViewStats";
            this.btnViewStats.Size = new System.Drawing.Size(149, 23);
            this.btnViewStats.TabIndex = 5;
            this.btnViewStats.Text = "View Scores";
            this.btnViewStats.UseVisualStyleBackColor = true;
            this.btnViewStats.Click += new System.EventHandler(this.btnViewStats_Click);
            // 
            // tmrHint
            // 
            this.tmrHint.Interval = 500;
            this.tmrHint.Tick += new System.EventHandler(this.tmrHint_Tick);
            // 
            // frmDifficultySelection
            // 
            this.AcceptButton = this.btnPlay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnQuit;
            this.ClientSize = new System.Drawing.Size(227, 199);
            this.ControlBox = false;
            this.Controls.Add(this.btnViewStats);
            this.Controls.Add(this.btnResetScores);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblDifficultyDescription);
            this.Controls.Add(this.tkbrDifficulty);
            this.Controls.Add(this.btnQuit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmDifficultySelection";
            this.Text = "Anagrams : Choose Your Difficulty Level";
            this.Load += new System.EventHandler(this.frmDifficultySelection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tkbrDifficulty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.TrackBar tkbrDifficulty;
        private System.Windows.Forms.Label lblDifficultyDescription;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnResetScores;
        private System.Windows.Forms.Timer tmrTime;
        private System.Windows.Forms.Button btnViewStats;
        private System.Windows.Forms.Timer tmrHint;
    }
}

