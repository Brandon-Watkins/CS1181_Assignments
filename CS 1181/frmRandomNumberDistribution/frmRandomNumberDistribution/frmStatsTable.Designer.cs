namespace frmRandomNumberDistribution
{
    partial class frmStatsTable
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
            this.btnClose = new System.Windows.Forms.Button();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.btnSaveResults = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.lbPrintedResults = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(686, 402);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // saveFile
            // 
            this.saveFile.InitialDirectory = "C://Desktop";
            this.saveFile.Title = "Save File Location";
            // 
            // btnSaveResults
            // 
            this.btnSaveResults.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSaveResults.Location = new System.Drawing.Point(358, 393);
            this.btnSaveResults.Name = "btnSaveResults";
            this.btnSaveResults.Size = new System.Drawing.Size(100, 41);
            this.btnSaveResults.TabIndex = 1;
            this.btnSaveResults.Text = "Save Results";
            this.btnSaveResults.UseVisualStyleBackColor = true;
            this.btnSaveResults.Click += new System.EventHandler(this.btnSaveResults_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // lbPrintedResults
            // 
            this.lbPrintedResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPrintedResults.ColumnWidth = 12;
            this.lbPrintedResults.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrintedResults.FormattingEnabled = true;
            this.lbPrintedResults.HorizontalScrollbar = true;
            this.lbPrintedResults.ItemHeight = 16;
            this.lbPrintedResults.Location = new System.Drawing.Point(13, 13);
            this.lbPrintedResults.Name = "lbPrintedResults";
            this.lbPrintedResults.ScrollAlwaysVisible = true;
            this.lbPrintedResults.Size = new System.Drawing.Size(775, 356);
            this.lbPrintedResults.TabIndex = 2;
            // 
            // frmStatsTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.lbPrintedResults);
            this.Controls.Add(this.btnSaveResults);
            this.Controls.Add(this.btnClose);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "frmStatsTable";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Statistics Table";
            this.Load += new System.EventHandler(this.frmStatsTable_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.Button btnSaveResults;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ListBox lbPrintedResults;
    }
}