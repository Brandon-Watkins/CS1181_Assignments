namespace WindowsFormsApp3
{
    partial class frmWelcomeForm
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
            this.btnLoadfrmRockPaperScissors = new System.Windows.Forms.Button();
            this.txtPlayerOneName = new System.Windows.Forms.TextBox();
            this.txtPlayerTwoName = new System.Windows.Forms.TextBox();
            this.lblPlayerOneName = new System.Windows.Forms.Label();
            this.lblPlayerTwoName = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoadfrmRockPaperScissors
            // 
            this.btnLoadfrmRockPaperScissors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadfrmRockPaperScissors.Location = new System.Drawing.Point(163, 149);
            this.btnLoadfrmRockPaperScissors.Name = "btnLoadfrmRockPaperScissors";
            this.btnLoadfrmRockPaperScissors.Size = new System.Drawing.Size(148, 59);
            this.btnLoadfrmRockPaperScissors.TabIndex = 0;
            this.btnLoadfrmRockPaperScissors.Text = "Play";
            this.btnLoadfrmRockPaperScissors.UseVisualStyleBackColor = true;
            this.btnLoadfrmRockPaperScissors.Click += new System.EventHandler(this.btnLoadfrmRockPaperScissors_Click);
            // 
            // txtPlayerOneName
            // 
            this.txtPlayerOneName.Location = new System.Drawing.Point(88, 85);
            this.txtPlayerOneName.Name = "txtPlayerOneName";
            this.txtPlayerOneName.Size = new System.Drawing.Size(100, 20);
            this.txtPlayerOneName.TabIndex = 1;
            this.txtPlayerOneName.Text = "Player One";
            this.txtPlayerOneName.Enter += new System.EventHandler(this.txtPlayerOneName_Enter);
            this.txtPlayerOneName.Leave += new System.EventHandler(this.txtPlayerOneName_Leave);
            // 
            // txtPlayerTwoName
            // 
            this.txtPlayerTwoName.Location = new System.Drawing.Point(300, 85);
            this.txtPlayerTwoName.Name = "txtPlayerTwoName";
            this.txtPlayerTwoName.Size = new System.Drawing.Size(100, 20);
            this.txtPlayerTwoName.TabIndex = 2;
            this.txtPlayerTwoName.Text = "Player Two";
            this.txtPlayerTwoName.Enter += new System.EventHandler(this.txtPlayerTwoName_Enter);
            this.txtPlayerTwoName.Leave += new System.EventHandler(this.txtPlayerTwoName_Leave);
            // 
            // lblPlayerOneName
            // 
            this.lblPlayerOneName.AutoSize = true;
            this.lblPlayerOneName.Location = new System.Drawing.Point(45, 59);
            this.lblPlayerOneName.Name = "lblPlayerOneName";
            this.lblPlayerOneName.Size = new System.Drawing.Size(100, 13);
            this.lblPlayerOneName.TabIndex = 3;
            this.lblPlayerOneName.Text = "Player One\'s Name:";
            // 
            // lblPlayerTwoName
            // 
            this.lblPlayerTwoName.AutoSize = true;
            this.lblPlayerTwoName.Location = new System.Drawing.Point(257, 59);
            this.lblPlayerTwoName.Name = "lblPlayerTwoName";
            this.lblPlayerTwoName.Size = new System.Drawing.Size(101, 13);
            this.lblPlayerTwoName.TabIndex = 4;
            this.lblPlayerTwoName.Text = "Player Two\'s Name:";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(116, 250);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(256, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Nevermind, this game looks way too cool for me.";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmWelcomeForm
            // 
            this.AcceptButton = this.btnLoadfrmRockPaperScissors;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(475, 285);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblPlayerTwoName);
            this.Controls.Add(this.lblPlayerOneName);
            this.Controls.Add(this.txtPlayerTwoName);
            this.Controls.Add(this.txtPlayerOneName);
            this.Controls.Add(this.btnLoadfrmRockPaperScissors);
            this.Name = "frmWelcomeForm";
            this.Text = "Rock, Paper, Scissors!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadfrmRockPaperScissors;
        private System.Windows.Forms.TextBox txtPlayerOneName;
        private System.Windows.Forms.TextBox txtPlayerTwoName;
        private System.Windows.Forms.Label lblPlayerOneName;
        private System.Windows.Forms.Label lblPlayerTwoName;
        private System.Windows.Forms.Button btnClose;
    }
}