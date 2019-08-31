namespace Memory
{
    partial class frmMemoryGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMemoryGame));
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnChangeDifficulty = new System.Windows.Forms.Button();
            this.tmrGameClock = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnQuit
            // 
            this.btnQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuit.Location = new System.Drawing.Point(314, 197);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 0;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnChangeDifficulty
            // 
            this.btnChangeDifficulty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnChangeDifficulty.Location = new System.Drawing.Point(17, 197);
            this.btnChangeDifficulty.Name = "btnChangeDifficulty";
            this.btnChangeDifficulty.Size = new System.Drawing.Size(120, 23);
            this.btnChangeDifficulty.TabIndex = 1;
            this.btnChangeDifficulty.Text = "Change Difficulty";
            this.btnChangeDifficulty.UseVisualStyleBackColor = true;
            this.btnChangeDifficulty.Click += new System.EventHandler(this.btnChangeDifficulty_Click);
            // 
            // tmrGameClock
            // 
            this.tmrGameClock.Tick += new System.EventHandler(this.tmrGameClock_Tick);
            // 
            // frmMemoryGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnQuit;
            this.ClientSize = new System.Drawing.Size(404, 227);
            this.ControlBox = false;
            this.Controls.Add(this.btnChangeDifficulty);
            this.Controls.Add(this.btnQuit);
            this.Name = "frmMemoryGame";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 35);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Memory";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnChangeDifficulty;
        private System.Windows.Forms.Timer tmrGameClock;
    }
}