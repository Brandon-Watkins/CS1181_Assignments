namespace frm.FactorialFinder
{
    partial class frmFactorialFinder
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
            this.btnGenerateFactorials = new System.Windows.Forms.Button();
            this.tkbrFactorialTrackBar_Input = new System.Windows.Forms.TrackBar();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblFactorialsUpTo_Output = new System.Windows.Forms.Label();
            this.txtNFactorialsLong_Output = new System.Windows.Forms.TextBox();
            this.txtNFactorialsInt_Output = new System.Windows.Forms.TextBox();
            this.txtFactorialsLong_Output = new System.Windows.Forms.TextBox();
            this.txtFactorialsInt_Output = new System.Windows.Forms.TextBox();
            this.lblTrackBarZeroPosition = new System.Windows.Forms.Label();
            this.lblTrackBarTwentyPosition = new System.Windows.Forms.Label();
            this.lblTrackBarTenPosition = new System.Windows.Forms.Label();
            this.lblTrackBarFivePosition = new System.Windows.Forms.Label();
            this.btnGenerateRandomFactorials = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblTrackBarFifteenPosition = new System.Windows.Forms.Label();
            this.lblOutputsStoredInLong = new System.Windows.Forms.Label();
            this.lblOutputsStoredInInt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tkbrFactorialTrackBar_Input)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerateFactorials
            // 
            this.btnGenerateFactorials.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGenerateFactorials.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGenerateFactorials.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGenerateFactorials.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerateFactorials.Location = new System.Drawing.Point(472, 98);
            this.btnGenerateFactorials.Name = "btnGenerateFactorials";
            this.btnGenerateFactorials.Size = new System.Drawing.Size(110, 23);
            this.btnGenerateFactorials.TabIndex = 0;
            this.btnGenerateFactorials.Text = "Generate &Factorials";
            this.btnGenerateFactorials.UseVisualStyleBackColor = true;
            this.btnGenerateFactorials.Click += new System.EventHandler(this.btnGenerateFactorials_Click);
            // 
            // tkbrFactorialTrackBar_Input
            // 
            this.tkbrFactorialTrackBar_Input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tkbrFactorialTrackBar_Input.AutoSize = false;
            this.tkbrFactorialTrackBar_Input.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tkbrFactorialTrackBar_Input.LargeChange = 2;
            this.tkbrFactorialTrackBar_Input.Location = new System.Drawing.Point(12, 33);
            this.tkbrFactorialTrackBar_Input.Maximum = 20;
            this.tkbrFactorialTrackBar_Input.Minimum = 1;
            this.tkbrFactorialTrackBar_Input.Name = "tkbrFactorialTrackBar_Input";
            this.tkbrFactorialTrackBar_Input.Size = new System.Drawing.Size(1030, 45);
            this.tkbrFactorialTrackBar_Input.TabIndex = 1;
            this.tkbrFactorialTrackBar_Input.Value = 1;
            this.tkbrFactorialTrackBar_Input.Scroll += new System.EventHandler(this.tkbrFactorialTrackbar_Input_Scroll);
            this.tkbrFactorialTrackBar_Input.ValueChanged += new System.EventHandler(this.tkbrFactorialTrackbar_Input_ValueChanged);
            // 
            // lblInstructions
            // 
            this.lblInstructions.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(314, 17);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(372, 13);
            this.lblInstructions.TabIndex = 2;
            this.lblInstructions.Text = "Drag the slider to calculate the factorials between 1 and the selected number.";
            // 
            // lblFactorialsUpTo_Output
            // 
            this.lblFactorialsUpTo_Output.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFactorialsUpTo_Output.AutoSize = true;
            this.lblFactorialsUpTo_Output.Location = new System.Drawing.Point(480, 81);
            this.lblFactorialsUpTo_Output.Name = "lblFactorialsUpTo_Output";
            this.lblFactorialsUpTo_Output.Size = new System.Drawing.Size(97, 13);
            this.lblFactorialsUpTo_Output.TabIndex = 3;
            this.lblFactorialsUpTo_Output.Text = "Factorials up to:   0";
            // 
            // txtNFactorialsLong_Output
            // 
            this.txtNFactorialsLong_Output.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNFactorialsLong_Output.Location = new System.Drawing.Point(12, 132);
            this.txtNFactorialsLong_Output.Multiline = true;
            this.txtNFactorialsLong_Output.Name = "txtNFactorialsLong_Output";
            this.txtNFactorialsLong_Output.ReadOnly = true;
            this.txtNFactorialsLong_Output.Size = new System.Drawing.Size(55, 285);
            this.txtNFactorialsLong_Output.TabIndex = 4;
            this.txtNFactorialsLong_Output.Text = "1!";
            this.txtNFactorialsLong_Output.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNFactorialsInt_Output
            // 
            this.txtNFactorialsInt_Output.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNFactorialsInt_Output.Location = new System.Drawing.Point(12, 423);
            this.txtNFactorialsInt_Output.Multiline = true;
            this.txtNFactorialsInt_Output.Name = "txtNFactorialsInt_Output";
            this.txtNFactorialsInt_Output.ReadOnly = true;
            this.txtNFactorialsInt_Output.Size = new System.Drawing.Size(55, 285);
            this.txtNFactorialsInt_Output.TabIndex = 5;
            this.txtNFactorialsInt_Output.Text = "1!";
            this.txtNFactorialsInt_Output.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtFactorialsLong_Output
            // 
            this.txtFactorialsLong_Output.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFactorialsLong_Output.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFactorialsLong_Output.Location = new System.Drawing.Point(74, 132);
            this.txtFactorialsLong_Output.Multiline = true;
            this.txtFactorialsLong_Output.Name = "txtFactorialsLong_Output";
            this.txtFactorialsLong_Output.ReadOnly = true;
            this.txtFactorialsLong_Output.Size = new System.Drawing.Size(968, 285);
            this.txtFactorialsLong_Output.TabIndex = 6;
            this.txtFactorialsLong_Output.WordWrap = false;
            // 
            // txtFactorialsInt_Output
            // 
            this.txtFactorialsInt_Output.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFactorialsInt_Output.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFactorialsInt_Output.Location = new System.Drawing.Point(74, 423);
            this.txtFactorialsInt_Output.Multiline = true;
            this.txtFactorialsInt_Output.Name = "txtFactorialsInt_Output";
            this.txtFactorialsInt_Output.ReadOnly = true;
            this.txtFactorialsInt_Output.Size = new System.Drawing.Size(969, 285);
            this.txtFactorialsInt_Output.TabIndex = 7;
            this.txtFactorialsInt_Output.WordWrap = false;
            // 
            // lblTrackBarZeroPosition
            // 
            this.lblTrackBarZeroPosition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTrackBarZeroPosition.AutoSize = true;
            this.lblTrackBarZeroPosition.Location = new System.Drawing.Point(19, 60);
            this.lblTrackBarZeroPosition.Name = "lblTrackBarZeroPosition";
            this.lblTrackBarZeroPosition.Size = new System.Drawing.Size(13, 13);
            this.lblTrackBarZeroPosition.TabIndex = 8;
            this.lblTrackBarZeroPosition.Text = "1";
            // 
            // lblTrackBarTwentyPosition
            // 
            this.lblTrackBarTwentyPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTrackBarTwentyPosition.AutoSize = true;
            this.lblTrackBarTwentyPosition.Location = new System.Drawing.Point(1020, 60);
            this.lblTrackBarTwentyPosition.Name = "lblTrackBarTwentyPosition";
            this.lblTrackBarTwentyPosition.Size = new System.Drawing.Size(19, 13);
            this.lblTrackBarTwentyPosition.TabIndex = 9;
            this.lblTrackBarTwentyPosition.Text = "20";
            // 
            // lblTrackBarTenPosition
            // 
            this.lblTrackBarTenPosition.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTrackBarTenPosition.AutoSize = true;
            this.lblTrackBarTenPosition.Location = new System.Drawing.Point(492, 60);
            this.lblTrackBarTenPosition.Name = "lblTrackBarTenPosition";
            this.lblTrackBarTenPosition.Size = new System.Drawing.Size(19, 13);
            this.lblTrackBarTenPosition.TabIndex = 10;
            this.lblTrackBarTenPosition.Text = "10";
            // 
            // lblTrackBarFivePosition
            // 
            this.lblTrackBarFivePosition.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTrackBarFivePosition.AutoSize = true;
            this.lblTrackBarFivePosition.Location = new System.Drawing.Point(231, 60);
            this.lblTrackBarFivePosition.Name = "lblTrackBarFivePosition";
            this.lblTrackBarFivePosition.Size = new System.Drawing.Size(13, 13);
            this.lblTrackBarFivePosition.TabIndex = 11;
            this.lblTrackBarFivePosition.Text = "5";
            // 
            // btnGenerateRandomFactorials
            // 
            this.btnGenerateRandomFactorials.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerateRandomFactorials.Location = new System.Drawing.Point(74, 98);
            this.btnGenerateRandomFactorials.Name = "btnGenerateRandomFactorials";
            this.btnGenerateRandomFactorials.Size = new System.Drawing.Size(145, 23);
            this.btnGenerateRandomFactorials.TabIndex = 12;
            this.btnGenerateRandomFactorials.Text = "Generate &Random Factorial";
            this.btnGenerateRandomFactorials.UseVisualStyleBackColor = true;
            this.btnGenerateRandomFactorials.Click += new System.EventHandler(this.btnGenerateRandomFactorials_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuit.Location = new System.Drawing.Point(967, 98);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 13;
            this.btnQuit.Text = "&Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblTrackBarFifteenPosition
            // 
            this.lblTrackBarFifteenPosition.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTrackBarFifteenPosition.AutoSize = true;
            this.lblTrackBarFifteenPosition.Location = new System.Drawing.Point(757, 60);
            this.lblTrackBarFifteenPosition.Name = "lblTrackBarFifteenPosition";
            this.lblTrackBarFifteenPosition.Size = new System.Drawing.Size(19, 13);
            this.lblTrackBarFifteenPosition.TabIndex = 14;
            this.lblTrackBarFifteenPosition.Text = "15";
            // 
            // lblOutputsStoredInLong
            // 
            this.lblOutputsStoredInLong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOutputsStoredInLong.AutoSize = true;
            this.lblOutputsStoredInLong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutputsStoredInLong.Location = new System.Drawing.Point(929, 132);
            this.lblOutputsStoredInLong.Name = "lblOutputsStoredInLong";
            this.lblOutputsStoredInLong.Size = new System.Drawing.Size(112, 15);
            this.lblOutputsStoredInLong.TabIndex = 15;
            this.lblOutputsStoredInLong.Text = "Outputs stored in long";
            // 
            // lblOutputsStoredInInt
            // 
            this.lblOutputsStoredInInt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOutputsStoredInInt.AutoSize = true;
            this.lblOutputsStoredInInt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutputsStoredInInt.Location = new System.Drawing.Point(939, 423);
            this.lblOutputsStoredInInt.Name = "lblOutputsStoredInInt";
            this.lblOutputsStoredInInt.Size = new System.Drawing.Size(103, 15);
            this.lblOutputsStoredInInt.TabIndex = 16;
            this.lblOutputsStoredInInt.Text = "Outputs stored in int";
            // 
            // frmFactorialFinder
            // 
            this.AcceptButton = this.btnGenerateFactorials;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.CancelButton = this.btnQuit;
            this.ClientSize = new System.Drawing.Size(1054, 720);
            this.Controls.Add(this.lblOutputsStoredInInt);
            this.Controls.Add(this.lblOutputsStoredInLong);
            this.Controls.Add(this.lblTrackBarFifteenPosition);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnGenerateRandomFactorials);
            this.Controls.Add(this.lblTrackBarFivePosition);
            this.Controls.Add(this.txtFactorialsInt_Output);
            this.Controls.Add(this.txtNFactorialsInt_Output);
            this.Controls.Add(this.lblTrackBarTenPosition);
            this.Controls.Add(this.txtFactorialsLong_Output);
            this.Controls.Add(this.lblTrackBarTwentyPosition);
            this.Controls.Add(this.txtNFactorialsLong_Output);
            this.Controls.Add(this.lblTrackBarZeroPosition);
            this.Controls.Add(this.lblFactorialsUpTo_Output);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.tkbrFactorialTrackBar_Input);
            this.Controls.Add(this.btnGenerateFactorials);
            this.MinimumSize = new System.Drawing.Size(620, 500);
            this.Name = "frmFactorialFinder";
            this.Text = "Factorial Finder";
            this.ResizeBegin += new System.EventHandler(this.frmFactorialFinder_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.frmFactorialFinderResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.tkbrFactorialTrackBar_Input)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerateFactorials;
        private System.Windows.Forms.TrackBar tkbrFactorialTrackBar_Input;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblFactorialsUpTo_Output;
        private System.Windows.Forms.TextBox txtNFactorialsLong_Output;
        private System.Windows.Forms.TextBox txtNFactorialsInt_Output;
        private System.Windows.Forms.TextBox txtFactorialsLong_Output;
        private System.Windows.Forms.TextBox txtFactorialsInt_Output;
        private System.Windows.Forms.Label lblTrackBarZeroPosition;
        private System.Windows.Forms.Label lblTrackBarTwentyPosition;
        private System.Windows.Forms.Label lblTrackBarTenPosition;
        private System.Windows.Forms.Label lblTrackBarFivePosition;
        private System.Windows.Forms.Button btnGenerateRandomFactorials;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblTrackBarFifteenPosition;
        private System.Windows.Forms.Label lblOutputsStoredInLong;
        private System.Windows.Forms.Label lblOutputsStoredInInt;
    }
}

