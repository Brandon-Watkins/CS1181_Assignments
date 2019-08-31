namespace Memory
{
    partial class frmCustomSelection
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
            this.lblRows = new System.Windows.Forms.Label();
            this.tbNumberOfRows_Input = new System.Windows.Forms.TextBox();
            this.lblColumns = new System.Windows.Forms.Label();
            this.tbNumberOfColumns_Input = new System.Windows.Forms.TextBox();
            this.btnCustomPlay = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Location = new System.Drawing.Point(28, 9);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(89, 13);
            this.lblRows.TabIndex = 0;
            this.lblRows.Text = "Number of Rows:";
            // 
            // tbNumberOfRows_Input
            // 
            this.tbNumberOfRows_Input.Location = new System.Drawing.Point(128, 6);
            this.tbNumberOfRows_Input.MaximumSize = new System.Drawing.Size(100, 20);
            this.tbNumberOfRows_Input.Name = "tbNumberOfRows_Input";
            this.tbNumberOfRows_Input.Size = new System.Drawing.Size(100, 20);
            this.tbNumberOfRows_Input.TabIndex = 1;
            this.tbNumberOfRows_Input.TextChanged += new System.EventHandler(this.tbNumberOfRows_Input_TextChanged);
            // 
            // lblColumns
            // 
            this.lblColumns.AutoSize = true;
            this.lblColumns.Location = new System.Drawing.Point(15, 40);
            this.lblColumns.Name = "lblColumns";
            this.lblColumns.Size = new System.Drawing.Size(102, 13);
            this.lblColumns.TabIndex = 2;
            this.lblColumns.Text = "Number of Columns:";
            // 
            // tbNumberOfColumns_Input
            // 
            this.tbNumberOfColumns_Input.Location = new System.Drawing.Point(128, 37);
            this.tbNumberOfColumns_Input.MaximumSize = new System.Drawing.Size(100, 20);
            this.tbNumberOfColumns_Input.Name = "tbNumberOfColumns_Input";
            this.tbNumberOfColumns_Input.Size = new System.Drawing.Size(100, 20);
            this.tbNumberOfColumns_Input.TabIndex = 3;
            this.tbNumberOfColumns_Input.TextChanged += new System.EventHandler(this.tbNumberOfColumns_Input_TextChanged);
            // 
            // btnCustomPlay
            // 
            this.btnCustomPlay.Enabled = false;
            this.btnCustomPlay.Location = new System.Drawing.Point(18, 77);
            this.btnCustomPlay.Name = "btnCustomPlay";
            this.btnCustomPlay.Size = new System.Drawing.Size(210, 23);
            this.btnCustomPlay.TabIndex = 4;
            this.btnCustomPlay.Text = "Dimensions must have an even product.";
            this.btnCustomPlay.UseVisualStyleBackColor = true;
            this.btnCustomPlay.Click += new System.EventHandler(this.btnCustomPlay_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 116);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuit.Location = new System.Drawing.Point(160, 116);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 6;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // frmCustomSelection
            // 
            this.AcceptButton = this.btnCustomPlay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnQuit;
            this.ClientSize = new System.Drawing.Size(247, 147);
            this.ControlBox = false;
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCustomPlay);
            this.Controls.Add(this.tbNumberOfColumns_Input);
            this.Controls.Add(this.lblColumns);
            this.Controls.Add(this.tbNumberOfRows_Input);
            this.Controls.Add(this.lblRows);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximumSize = new System.Drawing.Size(263, 186);
            this.Name = "frmCustomSelection";
            this.Text = "Memory - Custom Dimensions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.TextBox tbNumberOfRows_Input;
        private System.Windows.Forms.Label lblColumns;
        private System.Windows.Forms.TextBox tbNumberOfColumns_Input;
        private System.Windows.Forms.Button btnCustomPlay;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnQuit;
    }
}