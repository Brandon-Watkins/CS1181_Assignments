namespace frmDescriptiveTips
{
    partial class frmDescriptiveTips
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
            this.lblMealCost = new System.Windows.Forms.Label();
            this.txtMealCost_Input = new System.Windows.Forms.TextBox();
            this.chkSeatedPromptly = new System.Windows.Forms.CheckBox();
            this.chkServerWasFriendly = new System.Windows.Forms.CheckBox();
            this.chkDrinksKeptFull = new System.Windows.Forms.CheckBox();
            this.chkFoodServedPromptly = new System.Windows.Forms.CheckBox();
            this.chkComplaintsHandledProfessionally = new System.Windows.Forms.CheckBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblTipPercent = new System.Windows.Forms.Label();
            this.lblTipAmount = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblTipPercent_Output = new System.Windows.Forms.Label();
            this.lblTipAmount_Output = new System.Windows.Forms.Label();
            this.lblTotalAmount_Output = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMealCost
            // 
            this.lblMealCost.AutoSize = true;
            this.lblMealCost.Location = new System.Drawing.Point(47, 29);
            this.lblMealCost.Name = "lblMealCost";
            this.lblMealCost.Size = new System.Drawing.Size(78, 13);
            this.lblMealCost.TabIndex = 0;
            this.lblMealCost.Text = "Meal Cost:     $";
            // 
            // txtMealCost_Input
            // 
            this.txtMealCost_Input.Location = new System.Drawing.Point(124, 26);
            this.txtMealCost_Input.Name = "txtMealCost_Input";
            this.txtMealCost_Input.Size = new System.Drawing.Size(143, 20);
            this.txtMealCost_Input.TabIndex = 1;
            this.txtMealCost_Input.Text = "Enter the cost of your meal";
            this.txtMealCost_Input.Enter += new System.EventHandler(this.txtMealCost_Input_Enter);
            this.txtMealCost_Input.Leave += new System.EventHandler(this.txtMealCost_Input_Leave);
            // 
            // chkSeatedPromptly
            // 
            this.chkSeatedPromptly.AutoSize = true;
            this.chkSeatedPromptly.Location = new System.Drawing.Point(25, 77);
            this.chkSeatedPromptly.Name = "chkSeatedPromptly";
            this.chkSeatedPromptly.Size = new System.Drawing.Size(125, 17);
            this.chkSeatedPromptly.TabIndex = 2;
            this.chkSeatedPromptly.Text = "Seated promptly (5%)";
            this.chkSeatedPromptly.UseVisualStyleBackColor = true;
            this.chkSeatedPromptly.CheckedChanged += new System.EventHandler(this.chkSeatedPromptly_CheckedChanged);
            // 
            // chkServerWasFriendly
            // 
            this.chkServerWasFriendly.AutoSize = true;
            this.chkServerWasFriendly.Location = new System.Drawing.Point(25, 117);
            this.chkServerWasFriendly.Name = "chkServerWasFriendly";
            this.chkServerWasFriendly.Size = new System.Drawing.Size(138, 17);
            this.chkServerWasFriendly.TabIndex = 3;
            this.chkServerWasFriendly.Text = "Server was friendly (5%)";
            this.chkServerWasFriendly.UseVisualStyleBackColor = true;
            this.chkServerWasFriendly.CheckedChanged += new System.EventHandler(this.chkServerWasFriendly_CheckedChanged);
            // 
            // chkDrinksKeptFull
            // 
            this.chkDrinksKeptFull.AutoSize = true;
            this.chkDrinksKeptFull.Location = new System.Drawing.Point(192, 77);
            this.chkDrinksKeptFull.Name = "chkDrinksKeptFull";
            this.chkDrinksKeptFull.Size = new System.Drawing.Size(119, 17);
            this.chkDrinksKeptFull.TabIndex = 4;
            this.chkDrinksKeptFull.Text = "Drinks kept full (5%)";
            this.chkDrinksKeptFull.UseVisualStyleBackColor = true;
            this.chkDrinksKeptFull.CheckedChanged += new System.EventHandler(this.chkDrinksKeptFull_CheckedChanged);
            // 
            // chkFoodServedPromptly
            // 
            this.chkFoodServedPromptly.AutoSize = true;
            this.chkFoodServedPromptly.Location = new System.Drawing.Point(192, 117);
            this.chkFoodServedPromptly.Name = "chkFoodServedPromptly";
            this.chkFoodServedPromptly.Size = new System.Drawing.Size(127, 17);
            this.chkFoodServedPromptly.TabIndex = 5;
            this.chkFoodServedPromptly.Text = "Food served promptly";
            this.chkFoodServedPromptly.UseVisualStyleBackColor = true;
            this.chkFoodServedPromptly.CheckedChanged += new System.EventHandler(this.chkFoodServedPromptly_CheckedChanged);
            // 
            // chkComplaintsHandledProfessionally
            // 
            this.chkComplaintsHandledProfessionally.AutoSize = true;
            this.chkComplaintsHandledProfessionally.Location = new System.Drawing.Point(25, 157);
            this.chkComplaintsHandledProfessionally.Name = "chkComplaintsHandledProfessionally";
            this.chkComplaintsHandledProfessionally.Size = new System.Drawing.Size(258, 17);
            this.chkComplaintsHandledProfessionally.TabIndex = 6;
            this.chkComplaintsHandledProfessionally.Text = "Complaints handled in a professional manner (5%)";
            this.chkComplaintsHandledProfessionally.UseVisualStyleBackColor = true;
            this.chkComplaintsHandledProfessionally.CheckedChanged += new System.EventHandler(this.chkComplaintsHandledProfessionally_CheckedChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalculate.Location = new System.Drawing.Point(50, 190);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(233, 23);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate Tip";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            this.btnCalculate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnCalculate_MouseDown);
            this.btnCalculate.MouseEnter += new System.EventHandler(this.btnCalculate_MouseEnter);
            this.btnCalculate.MouseLeave += new System.EventHandler(this.btnCalculate_MouseLeave);
            this.btnCalculate.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnCalculate_MouseUp);
            // 
            // lblTipPercent
            // 
            this.lblTipPercent.AutoSize = true;
            this.lblTipPercent.Location = new System.Drawing.Point(85, 230);
            this.lblTipPercent.Name = "lblTipPercent";
            this.lblTipPercent.Size = new System.Drawing.Size(65, 13);
            this.lblTipPercent.TabIndex = 8;
            this.lblTipPercent.Text = "Tip Percent:";
            // 
            // lblTipAmount
            // 
            this.lblTipAmount.AutoSize = true;
            this.lblTipAmount.Location = new System.Drawing.Point(71, 256);
            this.lblTipAmount.Name = "lblTipAmount";
            this.lblTipAmount.Size = new System.Drawing.Size(79, 13);
            this.lblTipAmount.TabIndex = 9;
            this.lblTipAmount.Text = "Tip Amount ($):";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(62, 284);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(88, 13);
            this.lblTotalAmount.TabIndex = 10;
            this.lblTotalAmount.Text = "Total Amount ($):";
            // 
            // lblTipPercent_Output
            // 
            this.lblTipPercent_Output.AutoSize = true;
            this.lblTipPercent_Output.Location = new System.Drawing.Point(170, 230);
            this.lblTipPercent_Output.Name = "lblTipPercent_Output";
            this.lblTipPercent_Output.Size = new System.Drawing.Size(0, 13);
            this.lblTipPercent_Output.TabIndex = 11;
            // 
            // lblTipAmount_Output
            // 
            this.lblTipAmount_Output.AutoSize = true;
            this.lblTipAmount_Output.Location = new System.Drawing.Point(170, 256);
            this.lblTipAmount_Output.Name = "lblTipAmount_Output";
            this.lblTipAmount_Output.Size = new System.Drawing.Size(0, 13);
            this.lblTipAmount_Output.TabIndex = 12;
            // 
            // lblTotalAmount_Output
            // 
            this.lblTotalAmount_Output.AutoSize = true;
            this.lblTotalAmount_Output.Location = new System.Drawing.Point(170, 284);
            this.lblTotalAmount_Output.Name = "lblTotalAmount_Output";
            this.lblTotalAmount_Output.Size = new System.Drawing.Size(0, 13);
            this.lblTotalAmount_Output.TabIndex = 13;
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Location = new System.Drawing.Point(192, 311);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnClose_MouseDown);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            this.btnClose.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnClose_MouseUp);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(50, 311);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            this.btnReset.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnReset_MouseDown);
            this.btnReset.MouseEnter += new System.EventHandler(this.btnReset_MouseEnter);
            this.btnReset.MouseLeave += new System.EventHandler(this.btnReset_MouseLeave);
            this.btnReset.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnReset_MouseUp);
            // 
            // frmDescriptiveTips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 360);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTotalAmount_Output);
            this.Controls.Add(this.lblTipAmount_Output);
            this.Controls.Add(this.lblTipPercent_Output);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblTipAmount);
            this.Controls.Add(this.lblTipPercent);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.chkComplaintsHandledProfessionally);
            this.Controls.Add(this.chkFoodServedPromptly);
            this.Controls.Add(this.chkDrinksKeptFull);
            this.Controls.Add(this.chkServerWasFriendly);
            this.Controls.Add(this.chkSeatedPromptly);
            this.Controls.Add(this.txtMealCost_Input);
            this.Controls.Add(this.lblMealCost);
            this.Name = "frmDescriptiveTips";
            this.Text = "Tip Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMealCost;
        private System.Windows.Forms.TextBox txtMealCost_Input;
        private System.Windows.Forms.CheckBox chkSeatedPromptly;
        private System.Windows.Forms.CheckBox chkServerWasFriendly;
        private System.Windows.Forms.CheckBox chkDrinksKeptFull;
        private System.Windows.Forms.CheckBox chkFoodServedPromptly;
        private System.Windows.Forms.CheckBox chkComplaintsHandledProfessionally;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblTipPercent;
        private System.Windows.Forms.Label lblTipAmount;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblTipPercent_Output;
        private System.Windows.Forms.Label lblTipAmount_Output;
        private System.Windows.Forms.Label lblTotalAmount_Output;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnReset;
    }
}

