namespace ClassRoster
{
    partial class frmClass
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
            this.lbStudentNames = new System.Windows.Forms.ListBox();
            this.lblStudents = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblMajor = new System.Windows.Forms.Label();
            this.lblStudentMajor = new System.Windows.Forms.Label();
            this.lblAssignments = new System.Windows.Forms.Label();
            this.lblStudentAssignments = new System.Windows.Forms.Label();
            this.lblTest = new System.Windows.Forms.Label();
            this.lblStudentTests = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblStudentGrade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbStudentNames
            // 
            this.lbStudentNames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbStudentNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudentNames.FormattingEnabled = true;
            this.lbStudentNames.ItemHeight = 15;
            this.lbStudentNames.Location = new System.Drawing.Point(17, 31);
            this.lbStudentNames.Name = "lbStudentNames";
            this.lbStudentNames.Size = new System.Drawing.Size(172, 364);
            this.lbStudentNames.TabIndex = 0;
            this.lbStudentNames.SelectedIndexChanged += new System.EventHandler(this.lbStudentNames_SelectedIndexChanged);
            // 
            // lblStudents
            // 
            this.lblStudents.AutoSize = true;
            this.lblStudents.Location = new System.Drawing.Point(14, 10);
            this.lblStudents.Name = "lblStudents";
            this.lblStudents.Size = new System.Drawing.Size(55, 15);
            this.lblStudents.TabIndex = 1;
            this.lblStudents.Text = "Students";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(218, 67);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 15);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.Location = new System.Drawing.Point(236, 94);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(17, 16);
            this.lblStudentName.TabIndex = 3;
            this.lblStudentName.Text = "...";
            // 
            // lblMajor
            // 
            this.lblMajor.AutoSize = true;
            this.lblMajor.Location = new System.Drawing.Point(218, 133);
            this.lblMajor.Name = "lblMajor";
            this.lblMajor.Size = new System.Drawing.Size(39, 15);
            this.lblMajor.TabIndex = 4;
            this.lblMajor.Text = "Major";
            // 
            // lblStudentMajor
            // 
            this.lblStudentMajor.AutoSize = true;
            this.lblStudentMajor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentMajor.Location = new System.Drawing.Point(236, 158);
            this.lblStudentMajor.Name = "lblStudentMajor";
            this.lblStudentMajor.Size = new System.Drawing.Size(17, 16);
            this.lblStudentMajor.TabIndex = 5;
            this.lblStudentMajor.Text = "...";
            // 
            // lblAssignments
            // 
            this.lblAssignments.AutoSize = true;
            this.lblAssignments.Location = new System.Drawing.Point(218, 198);
            this.lblAssignments.Name = "lblAssignments";
            this.lblAssignments.Size = new System.Drawing.Size(77, 15);
            this.lblAssignments.TabIndex = 6;
            this.lblAssignments.Text = "Assignments";
            // 
            // lblStudentAssignments
            // 
            this.lblStudentAssignments.AutoSize = true;
            this.lblStudentAssignments.Location = new System.Drawing.Point(236, 222);
            this.lblStudentAssignments.Name = "lblStudentAssignments";
            this.lblStudentAssignments.Size = new System.Drawing.Size(16, 15);
            this.lblStudentAssignments.TabIndex = 7;
            this.lblStudentAssignments.Text = "...";
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(218, 263);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(30, 15);
            this.lblTest.TabIndex = 8;
            this.lblTest.Text = "Test";
            // 
            // lblStudentTests
            // 
            this.lblStudentTests.AutoSize = true;
            this.lblStudentTests.Location = new System.Drawing.Point(236, 287);
            this.lblStudentTests.Name = "lblStudentTests";
            this.lblStudentTests.Size = new System.Drawing.Size(16, 15);
            this.lblStudentTests.TabIndex = 9;
            this.lblStudentTests.Text = "...";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(218, 326);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(41, 15);
            this.lblGrade.TabIndex = 10;
            this.lblGrade.Text = "Grade";
            // 
            // lblStudentGrade
            // 
            this.lblStudentGrade.AutoSize = true;
            this.lblStudentGrade.Location = new System.Drawing.Point(236, 350);
            this.lblStudentGrade.Name = "lblStudentGrade";
            this.lblStudentGrade.Size = new System.Drawing.Size(16, 15);
            this.lblStudentGrade.TabIndex = 11;
            this.lblStudentGrade.Text = "...";
            // 
            // frmClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 422);
            this.Controls.Add(this.lblStudentGrade);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.lblStudentTests);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.lblStudentAssignments);
            this.Controls.Add(this.lblAssignments);
            this.Controls.Add(this.lblStudentMajor);
            this.Controls.Add(this.lblMajor);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblStudents);
            this.Controls.Add(this.lbStudentNames);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmClass";
            this.Text = "Class Roster";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbStudentNames;
        private System.Windows.Forms.Label lblStudents;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblMajor;
        private System.Windows.Forms.Label lblStudentMajor;
        private System.Windows.Forms.Label lblAssignments;
        private System.Windows.Forms.Label lblStudentAssignments;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Label lblStudentTests;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label lblStudentGrade;
    }
}

