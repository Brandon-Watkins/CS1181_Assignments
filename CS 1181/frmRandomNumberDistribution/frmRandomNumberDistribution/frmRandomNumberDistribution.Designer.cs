namespace frmRandomNumberDistribution
{
    partial class frmRandomNumberDistribution
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
            this.lblSeedNumber = new System.Windows.Forms.Label();
            this.lblNumberOfValuesToGenerate = new System.Windows.Forms.Label();
            this.txtSeedNumber_Input = new System.Windows.Forms.TextBox();
            this.txtNumberOfValuesToGenerate_Input = new System.Windows.Forms.TextBox();
            this.lblNumbersBetween = new System.Windows.Forms.Label();
            this.txtGenerateNumbersBetween_Input = new System.Windows.Forms.TextBox();
            this.btnGenerateRandomNumbers = new System.Windows.Forms.Button();
            this.tkbrValueAtIndex = new System.Windows.Forms.TrackBar();
            this.lblError = new System.Windows.Forms.Label();
            this.btnSaveResults = new System.Windows.Forms.Button();
            this.btnOtherStats = new System.Windows.Forms.Button();
            this.lblValueAtIndex_Output = new System.Windows.Forms.Label();
            this.lblIndexPosition_Output = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lbNumbersGenerated_Output = new System.Windows.Forms.ListBox();
            this.lbNumberDistribution_Output = new System.Windows.Forms.ListBox();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.tkbrValueAtIndex)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSeedNumber
            // 
            this.lblSeedNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSeedNumber.AutoSize = true;
            this.lblSeedNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeedNumber.Location = new System.Drawing.Point(175, 16);
            this.lblSeedNumber.Name = "lblSeedNumber";
            this.lblSeedNumber.Size = new System.Drawing.Size(210, 16);
            this.lblSeedNumber.TabIndex = 1;
            this.lblSeedNumber.Text = "Random Number Generator Seed";
            // 
            // lblNumberOfValuesToGenerate
            // 
            this.lblNumberOfValuesToGenerate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNumberOfValuesToGenerate.AutoSize = true;
            this.lblNumberOfValuesToGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfValuesToGenerate.Location = new System.Drawing.Point(420, 16);
            this.lblNumberOfValuesToGenerate.Name = "lblNumberOfValuesToGenerate";
            this.lblNumberOfValuesToGenerate.Size = new System.Drawing.Size(243, 16);
            this.lblNumberOfValuesToGenerate.TabIndex = 2;
            this.lblNumberOfValuesToGenerate.Text = "Number of Random Values to Generate";
            // 
            // txtSeedNumber_Input
            // 
            this.txtSeedNumber_Input.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSeedNumber_Input.Location = new System.Drawing.Point(163, 35);
            this.txtSeedNumber_Input.Name = "txtSeedNumber_Input";
            this.txtSeedNumber_Input.Size = new System.Drawing.Size(241, 20);
            this.txtSeedNumber_Input.TabIndex = 3;
            this.txtSeedNumber_Input.TextChanged += new System.EventHandler(this.txtSeedNumber_Input_TextChanged);
            this.txtSeedNumber_Input.Enter += new System.EventHandler(this.txtSeedNumber_Input_Enter);
            this.txtSeedNumber_Input.Leave += new System.EventHandler(this.txtSeedNumber_Input_Leave);
            // 
            // txtNumberOfValuesToGenerate_Input
            // 
            this.txtNumberOfValuesToGenerate_Input.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNumberOfValuesToGenerate_Input.Location = new System.Drawing.Point(411, 35);
            this.txtNumberOfValuesToGenerate_Input.Name = "txtNumberOfValuesToGenerate_Input";
            this.txtNumberOfValuesToGenerate_Input.Size = new System.Drawing.Size(268, 20);
            this.txtNumberOfValuesToGenerate_Input.TabIndex = 4;
            this.txtNumberOfValuesToGenerate_Input.TextChanged += new System.EventHandler(this.txtNumberOfValuesToGenerate_Input_TextChanged);
            this.txtNumberOfValuesToGenerate_Input.Enter += new System.EventHandler(this.txtNumberOfValuesToGenerate_Input_Enter);
            this.txtNumberOfValuesToGenerate_Input.Leave += new System.EventHandler(this.txtNumberOfValuesToGenerate_Input_Leave);
            // 
            // lblNumbersBetween
            // 
            this.lblNumbersBetween.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNumbersBetween.AutoSize = true;
            this.lblNumbersBetween.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumbersBetween.Location = new System.Drawing.Point(205, 68);
            this.lblNumbersBetween.Name = "lblNumbersBetween";
            this.lblNumbersBetween.Size = new System.Drawing.Size(212, 16);
            this.lblNumbersBetween.TabIndex = 5;
            this.lblNumbersBetween.Text = "Generate numbers between 1 and ";
            // 
            // txtGenerateNumbersBetween_Input
            // 
            this.txtGenerateNumbersBetween_Input.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtGenerateNumbersBetween_Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenerateNumbersBetween_Input.Location = new System.Drawing.Point(411, 65);
            this.txtGenerateNumbersBetween_Input.Name = "txtGenerateNumbersBetween_Input";
            this.txtGenerateNumbersBetween_Input.Size = new System.Drawing.Size(204, 22);
            this.txtGenerateNumbersBetween_Input.TabIndex = 6;
            this.txtGenerateNumbersBetween_Input.TextChanged += new System.EventHandler(this.txtGenerateNumbersBetween_Input_TextChanged);
            this.txtGenerateNumbersBetween_Input.Enter += new System.EventHandler(this.txtGenerateNumbersBetween_Input_Enter);
            this.txtGenerateNumbersBetween_Input.Leave += new System.EventHandler(this.txtGenerateNumbersBetween_Input_Leave);
            // 
            // btnGenerateRandomNumbers
            // 
            this.btnGenerateRandomNumbers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGenerateRandomNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateRandomNumbers.Location = new System.Drawing.Point(357, 103);
            this.btnGenerateRandomNumbers.Name = "btnGenerateRandomNumbers";
            this.btnGenerateRandomNumbers.Size = new System.Drawing.Size(114, 40);
            this.btnGenerateRandomNumbers.TabIndex = 7;
            this.btnGenerateRandomNumbers.Text = "Generate";
            this.btnGenerateRandomNumbers.UseVisualStyleBackColor = true;
            this.btnGenerateRandomNumbers.Click += new System.EventHandler(this.btnGenerateRandomNumbers_Click);
            // 
            // tkbrValueAtIndex
            // 
            this.tkbrValueAtIndex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tkbrValueAtIndex.Location = new System.Drawing.Point(163, 178);
            this.tkbrValueAtIndex.Name = "tkbrValueAtIndex";
            this.tkbrValueAtIndex.Size = new System.Drawing.Size(516, 45);
            this.tkbrValueAtIndex.TabIndex = 8;
            this.tkbrValueAtIndex.Scroll += new System.EventHandler(this.tkbrValueAtIndex_Scroll);
            // 
            // lblError
            // 
            this.lblError.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblError.Location = new System.Drawing.Point(160, 102);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(196, 70);
            this.lblError.TabIndex = 13;
            this.lblError.Text = "ERROR";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblError.Visible = false;
            // 
            // btnSaveResults
            // 
            this.btnSaveResults.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSaveResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveResults.Location = new System.Drawing.Point(511, 132);
            this.btnSaveResults.Name = "btnSaveResults";
            this.btnSaveResults.Size = new System.Drawing.Size(104, 40);
            this.btnSaveResults.TabIndex = 12;
            this.btnSaveResults.Text = "Save Results";
            this.btnSaveResults.UseVisualStyleBackColor = true;
            this.btnSaveResults.Click += new System.EventHandler(this.btnSaveResults_Click);
            // 
            // btnOtherStats
            // 
            this.btnOtherStats.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOtherStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtherStats.Location = new System.Drawing.Point(208, 132);
            this.btnOtherStats.Name = "btnOtherStats";
            this.btnOtherStats.Size = new System.Drawing.Size(111, 40);
            this.btnOtherStats.TabIndex = 11;
            this.btnOtherStats.Text = "Show Additional Stats";
            this.btnOtherStats.UseVisualStyleBackColor = true;
            this.btnOtherStats.Click += new System.EventHandler(this.btnOtherStats_Click);
            // 
            // lblValueAtIndex_Output
            // 
            this.lblValueAtIndex_Output.AutoSize = true;
            this.lblValueAtIndex_Output.BackColor = System.Drawing.SystemColors.Control;
            this.lblValueAtIndex_Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueAtIndex_Output.Location = new System.Drawing.Point(368, 236);
            this.lblValueAtIndex_Output.Name = "lblValueAtIndex_Output";
            this.lblValueAtIndex_Output.Size = new System.Drawing.Size(17, 16);
            this.lblValueAtIndex_Output.TabIndex = 10;
            this.lblValueAtIndex_Output.Text = "...";
            // 
            // lblIndexPosition_Output
            // 
            this.lblIndexPosition_Output.AutoSize = true;
            this.lblIndexPosition_Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndexPosition_Output.Location = new System.Drawing.Point(293, 216);
            this.lblIndexPosition_Output.Name = "lblIndexPosition_Output";
            this.lblIndexPosition_Output.Size = new System.Drawing.Size(92, 16);
            this.lblIndexPosition_Output.TabIndex = 9;
            this.lblIndexPosition_Output.Text = "Value at index";
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(36, 728);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(89, 38);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(562, 728);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(91, 38);
            this.btnQuit.TabIndex = 12;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lbNumbersGenerated_Output
            // 
            this.lbNumbersGenerated_Output.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbNumbersGenerated_Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumbersGenerated_Output.FormattingEnabled = true;
            this.lbNumbersGenerated_Output.ItemHeight = 15;
            this.lbNumbersGenerated_Output.Location = new System.Drawing.Point(13, 13);
            this.lbNumbersGenerated_Output.Name = "lbNumbersGenerated_Output";
            this.lbNumbersGenerated_Output.ScrollAlwaysVisible = true;
            this.lbNumbersGenerated_Output.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbNumbersGenerated_Output.Size = new System.Drawing.Size(131, 709);
            this.lbNumbersGenerated_Output.TabIndex = 13;
            // 
            // lbNumberDistribution_Output
            // 
            this.lbNumberDistribution_Output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNumberDistribution_Output.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumberDistribution_Output.FormattingEnabled = true;
            this.lbNumberDistribution_Output.HorizontalScrollbar = true;
            this.lbNumberDistribution_Output.ItemHeight = 15;
            this.lbNumberDistribution_Output.Location = new System.Drawing.Point(163, 268);
            this.lbNumberDistribution_Output.Name = "lbNumberDistribution_Output";
            this.lbNumberDistribution_Output.ScrollAlwaysVisible = true;
            this.lbNumberDistribution_Output.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbNumberDistribution_Output.Size = new System.Drawing.Size(516, 454);
            this.lbNumberDistribution_Output.TabIndex = 14;
            // 
            // frmRandomNumberDistribution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(693, 774);
            this.Controls.Add(this.lblValueAtIndex_Output);
            this.Controls.Add(this.btnSaveResults);
            this.Controls.Add(this.lblIndexPosition_Output);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.tkbrValueAtIndex);
            this.Controls.Add(this.btnOtherStats);
            this.Controls.Add(this.lbNumberDistribution_Output);
            this.Controls.Add(this.lbNumbersGenerated_Output);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtGenerateNumbersBetween_Input);
            this.Controls.Add(this.lblNumbersBetween);
            this.Controls.Add(this.txtNumberOfValuesToGenerate_Input);
            this.Controls.Add(this.txtSeedNumber_Input);
            this.Controls.Add(this.lblNumberOfValuesToGenerate);
            this.Controls.Add(this.lblSeedNumber);
            this.Controls.Add(this.btnGenerateRandomNumbers);
            this.MinimumSize = new System.Drawing.Size(680, 425);
            this.Name = "frmRandomNumberDistribution";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "1";
            this.Load += new System.EventHandler(this.frmRandomNumberDistribution_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tkbrValueAtIndex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSeedNumber;
        private System.Windows.Forms.Label lblNumberOfValuesToGenerate;
        private System.Windows.Forms.TextBox txtSeedNumber_Input;
        private System.Windows.Forms.TextBox txtNumberOfValuesToGenerate_Input;
        private System.Windows.Forms.Label lblNumbersBetween;
        private System.Windows.Forms.TextBox txtGenerateNumbersBetween_Input;
        private System.Windows.Forms.Button btnGenerateRandomNumbers;
        private System.Windows.Forms.TrackBar tkbrValueAtIndex;
        private System.Windows.Forms.Label lblIndexPosition_Output;
        private System.Windows.Forms.Label lblValueAtIndex_Output;
        private System.Windows.Forms.Button btnSaveResults;
        private System.Windows.Forms.Button btnOtherStats;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.ListBox lbNumbersGenerated_Output;
        private System.Windows.Forms.ListBox lbNumberDistribution_Output;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.SaveFileDialog saveFile;
    }
}

