namespace RectangleCalculator
{
    partial class frmRectangleCalculator
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
            this.lblLength = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.lblLengthUnit = new System.Windows.Forms.Label();
            this.lblWidthUnit = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblAreaOutput = new System.Windows.Forms.Label();
            this.lblPerimeterOutput = new System.Windows.Forms.Label();
            this.lblDiagonalOutput = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.lblDiagonal = new System.Windows.Forms.Label();
            this.lblAreaUnit = new System.Windows.Forms.Label();
            this.lblPerimeterUnit = new System.Windows.Forms.Label();
            this.lblDiagonalUnit = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblSquared = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(59, 36);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(43, 13);
            this.lblLength.TabIndex = 0;
            this.lblLength.Text = "Length:";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(64, 73);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(38, 13);
            this.lblWidth.TabIndex = 1;
            this.lblWidth.Text = "Width:";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(119, 33);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(117, 20);
            this.txtLength.TabIndex = 0;
            this.txtLength.Text = "Enter the length here.";
            this.txtLength.Enter += new System.EventHandler(this.txtLength_Enter);
            this.txtLength.Leave += new System.EventHandler(this.txtLength_Leave);
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(119, 70);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(117, 20);
            this.txtWidth.TabIndex = 1;
            this.txtWidth.Text = "Enter the width here.";
            this.txtWidth.Enter += new System.EventHandler(this.txtWidth_Enter);
            this.txtWidth.Leave += new System.EventHandler(this.txtWidth_Leave);
            // 
            // lblLengthUnit
            // 
            this.lblLengthUnit.AutoSize = true;
            this.lblLengthUnit.Location = new System.Drawing.Point(242, 36);
            this.lblLengthUnit.Name = "lblLengthUnit";
            this.lblLengthUnit.Size = new System.Drawing.Size(21, 13);
            this.lblLengthUnit.TabIndex = 4;
            this.lblLengthUnit.Text = "cm";
            // 
            // lblWidthUnit
            // 
            this.lblWidthUnit.AutoSize = true;
            this.lblWidthUnit.Location = new System.Drawing.Point(242, 73);
            this.lblWidthUnit.Name = "lblWidthUnit";
            this.lblWidthUnit.Size = new System.Drawing.Size(21, 13);
            this.lblWidthUnit.TabIndex = 5;
            this.lblWidthUnit.Text = "cm";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCalculate.Location = new System.Drawing.Point(141, 110);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblAreaOutput
            // 
            this.lblAreaOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAreaOutput.Location = new System.Drawing.Point(116, 153);
            this.lblAreaOutput.Name = "lblAreaOutput";
            this.lblAreaOutput.Size = new System.Drawing.Size(120, 23);
            this.lblAreaOutput.TabIndex = 3;
            // 
            // lblPerimeterOutput
            // 
            this.lblPerimeterOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPerimeterOutput.Location = new System.Drawing.Point(116, 203);
            this.lblPerimeterOutput.Name = "lblPerimeterOutput";
            this.lblPerimeterOutput.Size = new System.Drawing.Size(120, 23);
            this.lblPerimeterOutput.TabIndex = 4;
            // 
            // lblDiagonalOutput
            // 
            this.lblDiagonalOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDiagonalOutput.Location = new System.Drawing.Point(116, 251);
            this.lblDiagonalOutput.Name = "lblDiagonalOutput";
            this.lblDiagonalOutput.Size = new System.Drawing.Size(120, 23);
            this.lblDiagonalOutput.TabIndex = 5;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(70, 153);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(32, 13);
            this.lblArea.TabIndex = 10;
            this.lblArea.Text = "Area:";
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Location = new System.Drawing.Point(48, 204);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(54, 13);
            this.lblPerimeter.TabIndex = 11;
            this.lblPerimeter.Text = "Perimeter:";
            // 
            // lblDiagonal
            // 
            this.lblDiagonal.AutoSize = true;
            this.lblDiagonal.Location = new System.Drawing.Point(14, 251);
            this.lblDiagonal.Name = "lblDiagonal";
            this.lblDiagonal.Size = new System.Drawing.Size(88, 13);
            this.lblDiagonal.TabIndex = 12;
            this.lblDiagonal.Text = "Diagonal Length:";
            // 
            // lblAreaUnit
            // 
            this.lblAreaUnit.AutoSize = true;
            this.lblAreaUnit.Location = new System.Drawing.Point(242, 154);
            this.lblAreaUnit.Name = "lblAreaUnit";
            this.lblAreaUnit.Size = new System.Drawing.Size(21, 13);
            this.lblAreaUnit.TabIndex = 13;
            this.lblAreaUnit.Text = "cm";
            // 
            // lblPerimeterUnit
            // 
            this.lblPerimeterUnit.AutoSize = true;
            this.lblPerimeterUnit.Location = new System.Drawing.Point(242, 204);
            this.lblPerimeterUnit.Name = "lblPerimeterUnit";
            this.lblPerimeterUnit.Size = new System.Drawing.Size(21, 13);
            this.lblPerimeterUnit.TabIndex = 14;
            this.lblPerimeterUnit.Text = "cm";
            // 
            // lblDiagonalUnit
            // 
            this.lblDiagonalUnit.AutoSize = true;
            this.lblDiagonalUnit.Location = new System.Drawing.Point(242, 252);
            this.lblDiagonalUnit.Name = "lblDiagonalUnit";
            this.lblDiagonalUnit.Size = new System.Drawing.Size(21, 13);
            this.lblDiagonalUnit.TabIndex = 15;
            this.lblDiagonalUnit.Text = "cm";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReset.Location = new System.Drawing.Point(51, 308);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(209, 308);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblSquared
            // 
            this.lblSquared.AutoSize = true;
            this.lblSquared.Location = new System.Drawing.Point(258, 150);
            this.lblSquared.Name = "lblSquared";
            this.lblSquared.Size = new System.Drawing.Size(13, 13);
            this.lblSquared.TabIndex = 16;
            this.lblSquared.Text = "2";
            // 
            // frmRectangleCalculator
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(344, 351);
            this.Controls.Add(this.lblSquared);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblDiagonalUnit);
            this.Controls.Add(this.lblPerimeterUnit);
            this.Controls.Add(this.lblAreaUnit);
            this.Controls.Add(this.lblDiagonal);
            this.Controls.Add(this.lblPerimeter);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblDiagonalOutput);
            this.Controls.Add(this.lblPerimeterOutput);
            this.Controls.Add(this.lblAreaOutput);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblWidthUnit);
            this.Controls.Add(this.lblLengthUnit);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblLength);
            this.Name = "frmRectangleCalculator";
            this.Text = "Rectangle Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label lblLengthUnit;
        private System.Windows.Forms.Label lblWidthUnit;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblAreaOutput;
        private System.Windows.Forms.Label lblPerimeterOutput;
        private System.Windows.Forms.Label lblDiagonalOutput;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.Label lblDiagonal;
        private System.Windows.Forms.Label lblAreaUnit;
        private System.Windows.Forms.Label lblPerimeterUnit;
        private System.Windows.Forms.Label lblDiagonalUnit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblSquared;
    }
}

