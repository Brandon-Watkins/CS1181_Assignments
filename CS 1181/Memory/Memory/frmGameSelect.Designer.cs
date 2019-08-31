namespace Memory
{
    partial class frmGameSelect
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
            this.lblHighScoreEasy = new System.Windows.Forms.Label();
            this.btnEasy = new System.Windows.Forms.Button();
            this.btnMedium = new System.Windows.Forms.Button();
            this.btnHard = new System.Windows.Forms.Button();
            this.btnCustom = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnSurpriseMe = new System.Windows.Forms.Button();
            this.lblHighScores_DontUse = new System.Windows.Forms.Label();
            this.lblHighScoreMedium = new System.Windows.Forms.Label();
            this.lblHighScoreHard = new System.Windows.Forms.Label();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.btnResetScores = new System.Windows.Forms.Button();
            this.lblHighScoreCustom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHighScoreEasy
            // 
            this.lblHighScoreEasy.AutoSize = true;
            this.lblHighScoreEasy.Location = new System.Drawing.Point(100, 39);
            this.lblHighScoreEasy.MaximumSize = new System.Drawing.Size(80, 13);
            this.lblHighScoreEasy.Name = "lblHighScoreEasy";
            this.lblHighScoreEasy.Size = new System.Drawing.Size(33, 13);
            this.lblHighScoreEasy.TabIndex = 7;
            this.lblHighScoreEasy.Text = "0 sec";
            // 
            // btnEasy
            // 
            this.btnEasy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEasy.Location = new System.Drawing.Point(103, 12);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(75, 23);
            this.btnEasy.TabIndex = 0;
            this.btnEasy.Text = "Easy";
            this.btnEasy.UseVisualStyleBackColor = true;
            this.btnEasy.Click += new System.EventHandler(this.btnEasy_Click);
            // 
            // btnMedium
            // 
            this.btnMedium.Location = new System.Drawing.Point(209, 12);
            this.btnMedium.Name = "btnMedium";
            this.btnMedium.Size = new System.Drawing.Size(75, 23);
            this.btnMedium.TabIndex = 1;
            this.btnMedium.Text = "Medium";
            this.btnMedium.UseVisualStyleBackColor = true;
            this.btnMedium.Click += new System.EventHandler(this.btnMedium_Click);
            // 
            // btnHard
            // 
            this.btnHard.Location = new System.Drawing.Point(311, 12);
            this.btnHard.Name = "btnHard";
            this.btnHard.Size = new System.Drawing.Size(75, 23);
            this.btnHard.TabIndex = 2;
            this.btnHard.Text = "Hard";
            this.btnHard.UseVisualStyleBackColor = true;
            this.btnHard.Click += new System.EventHandler(this.btnHard_Click);
            // 
            // btnCustom
            // 
            this.btnCustom.Location = new System.Drawing.Point(266, 60);
            this.btnCustom.Name = "btnCustom";
            this.btnCustom.Size = new System.Drawing.Size(75, 23);
            this.btnCustom.TabIndex = 3;
            this.btnCustom.Text = "Custom";
            this.btnCustom.UseVisualStyleBackColor = true;
            this.btnCustom.Click += new System.EventHandler(this.btnCustom_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(311, 105);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 4;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnSurpriseMe
            // 
            this.btnSurpriseMe.Location = new System.Drawing.Point(164, 60);
            this.btnSurpriseMe.Name = "btnSurpriseMe";
            this.btnSurpriseMe.Size = new System.Drawing.Size(75, 23);
            this.btnSurpriseMe.TabIndex = 5;
            this.btnSurpriseMe.Text = "Surprise Me";
            this.btnSurpriseMe.UseVisualStyleBackColor = true;
            this.btnSurpriseMe.Click += new System.EventHandler(this.btnSurpriseMe_Click);
            // 
            // lblHighScores_DontUse
            // 
            this.lblHighScores_DontUse.AutoSize = true;
            this.lblHighScores_DontUse.Location = new System.Drawing.Point(12, 39);
            this.lblHighScores_DontUse.Name = "lblHighScores_DontUse";
            this.lblHighScores_DontUse.Size = new System.Drawing.Size(68, 13);
            this.lblHighScores_DontUse.TabIndex = 6;
            this.lblHighScores_DontUse.Text = "High Scores:";
            // 
            // lblHighScoreMedium
            // 
            this.lblHighScoreMedium.AutoSize = true;
            this.lblHighScoreMedium.Location = new System.Drawing.Point(206, 39);
            this.lblHighScoreMedium.MaximumSize = new System.Drawing.Size(80, 13);
            this.lblHighScoreMedium.Name = "lblHighScoreMedium";
            this.lblHighScoreMedium.Size = new System.Drawing.Size(33, 13);
            this.lblHighScoreMedium.TabIndex = 8;
            this.lblHighScoreMedium.Text = "0 sec";
            // 
            // lblHighScoreHard
            // 
            this.lblHighScoreHard.AutoSize = true;
            this.lblHighScoreHard.Location = new System.Drawing.Point(308, 39);
            this.lblHighScoreHard.MaximumSize = new System.Drawing.Size(80, 13);
            this.lblHighScoreHard.Name = "lblHighScoreHard";
            this.lblHighScoreHard.Size = new System.Drawing.Size(33, 13);
            this.lblHighScoreHard.TabIndex = 9;
            this.lblHighScoreHard.Text = "0 sec";
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Location = new System.Drawing.Point(30, 17);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(50, 13);
            this.lblDifficulty.TabIndex = 10;
            this.lblDifficulty.Text = "Difficulty:";
            // 
            // btnResetScores
            // 
            this.btnResetScores.Location = new System.Drawing.Point(15, 89);
            this.btnResetScores.Name = "btnResetScores";
            this.btnResetScores.Size = new System.Drawing.Size(75, 39);
            this.btnResetScores.TabIndex = 11;
            this.btnResetScores.Text = "Reset High Scores";
            this.btnResetScores.UseVisualStyleBackColor = true;
            this.btnResetScores.Click += new System.EventHandler(this.btnResetScores_Click);
            // 
            // lblHighScoreCustom
            // 
            this.lblHighScoreCustom.AutoSize = true;
            this.lblHighScoreCustom.Location = new System.Drawing.Point(266, 89);
            this.lblHighScoreCustom.Name = "lblHighScoreCustom";
            this.lblHighScoreCustom.Size = new System.Drawing.Size(33, 13);
            this.lblHighScoreCustom.TabIndex = 12;
            this.lblHighScoreCustom.Text = "0 sec";
            // 
            // frmGameSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 141);
            this.ControlBox = false;
            this.Controls.Add(this.lblHighScoreCustom);
            this.Controls.Add(this.btnResetScores);
            this.Controls.Add(this.lblDifficulty);
            this.Controls.Add(this.lblHighScoreHard);
            this.Controls.Add(this.lblHighScoreMedium);
            this.Controls.Add(this.lblHighScoreEasy);
            this.Controls.Add(this.lblHighScores_DontUse);
            this.Controls.Add(this.btnSurpriseMe);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnCustom);
            this.Controls.Add(this.btnHard);
            this.Controls.Add(this.btnMedium);
            this.Controls.Add(this.btnEasy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmGameSelect";
            this.Text = "Memory - Difficulty Selection";
            this.Load += new System.EventHandler(this.frmGameSelect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEasy;
        private System.Windows.Forms.Button btnMedium;
        private System.Windows.Forms.Button btnHard;
        private System.Windows.Forms.Button btnCustom;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnSurpriseMe;
        private System.Windows.Forms.Label lblHighScores_DontUse;
        private System.Windows.Forms.Label lblHighScoreMedium;
        private System.Windows.Forms.Label lblHighScoreHard;
        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.Button btnResetScores;
        private System.Windows.Forms.Label lblHighScoreCustom;
        private System.Windows.Forms.Label lblHighScoreEasy;
    }
}

