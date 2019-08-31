namespace BrandonsFirstDrawing_HowCute
{
    partial class frmBrandonsFirstDrawing
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
            this.btnNewPainting = new System.Windows.Forms.Button();
            this.tkbrGrass = new System.Windows.Forms.TrackBar();
            this.gbControls = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.lblSun = new System.Windows.Forms.Label();
            this.tkbrSun = new System.Windows.Forms.TrackBar();
            this.tkbrHouse = new System.Windows.Forms.TrackBar();
            this.lblHouse = new System.Windows.Forms.Label();
            this.tkbrSnow = new System.Windows.Forms.TrackBar();
            this.lblSnow = new System.Windows.Forms.Label();
            this.lblMountains = new System.Windows.Forms.Label();
            this.tkbrMountains = new System.Windows.Forms.TrackBar();
            this.lblGrass = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tkbrGrass)).BeginInit();
            this.gbControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbrSun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbrHouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbrSnow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbrMountains)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewPainting
            // 
            this.btnNewPainting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPainting.Location = new System.Drawing.Point(12, 6);
            this.btnNewPainting.Name = "btnNewPainting";
            this.btnNewPainting.Size = new System.Drawing.Size(66, 42);
            this.btnNewPainting.TabIndex = 0;
            this.btnNewPainting.Text = "New Painting";
            this.btnNewPainting.UseVisualStyleBackColor = true;
            this.btnNewPainting.Click += new System.EventHandler(this.btnNewPainting_Click);
            // 
            // tkbrGrass
            // 
            this.tkbrGrass.Location = new System.Drawing.Point(0, 37);
            this.tkbrGrass.Maximum = 200;
            this.tkbrGrass.Name = "tkbrGrass";
            this.tkbrGrass.Size = new System.Drawing.Size(76, 45);
            this.tkbrGrass.TabIndex = 1;
            this.tkbrGrass.TickFrequency = 5;
            this.tkbrGrass.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tkbrGrass.Value = 2;
            this.tkbrGrass.Scroll += new System.EventHandler(this.tkbrGrass_Scroll);
            // 
            // gbControls
            // 
            this.gbControls.Controls.Add(this.btnReset);
            this.gbControls.Controls.Add(this.btnHide);
            this.gbControls.Controls.Add(this.lblSun);
            this.gbControls.Controls.Add(this.tkbrSun);
            this.gbControls.Controls.Add(this.tkbrHouse);
            this.gbControls.Controls.Add(this.lblHouse);
            this.gbControls.Controls.Add(this.tkbrSnow);
            this.gbControls.Controls.Add(this.lblSnow);
            this.gbControls.Controls.Add(this.lblMountains);
            this.gbControls.Controls.Add(this.tkbrMountains);
            this.gbControls.Controls.Add(this.lblGrass);
            this.gbControls.Controls.Add(this.tkbrGrass);
            this.gbControls.Location = new System.Drawing.Point(12, 54);
            this.gbControls.Name = "gbControls";
            this.gbControls.Size = new System.Drawing.Size(76, 411);
            this.gbControls.TabIndex = 2;
            this.gbControls.TabStop = false;
            this.gbControls.Text = "Controls";
            this.gbControls.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(6, 349);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(64, 23);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnHide
            // 
            this.btnHide.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHide.Location = new System.Drawing.Point(5, 378);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(65, 23);
            this.btnHide.TabIndex = 10;
            this.btnHide.Text = "Hide";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // lblSun
            // 
            this.lblSun.AutoSize = true;
            this.lblSun.Location = new System.Drawing.Point(6, 301);
            this.lblSun.Name = "lblSun";
            this.lblSun.Size = new System.Drawing.Size(56, 13);
            this.lblSun.TabIndex = 9;
            this.lblSun.Text = "Scale Sun";
            // 
            // tkbrSun
            // 
            this.tkbrSun.LargeChange = 1;
            this.tkbrSun.Location = new System.Drawing.Point(1, 317);
            this.tkbrSun.Maximum = 2;
            this.tkbrSun.Name = "tkbrSun";
            this.tkbrSun.Size = new System.Drawing.Size(75, 45);
            this.tkbrSun.TabIndex = 8;
            this.tkbrSun.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tkbrSun.Value = 1;
            this.tkbrSun.Scroll += new System.EventHandler(this.tkbrSun_Scroll);
            // 
            // tkbrHouse
            // 
            this.tkbrHouse.Location = new System.Drawing.Point(1, 253);
            this.tkbrHouse.Maximum = 15;
            this.tkbrHouse.Minimum = 5;
            this.tkbrHouse.Name = "tkbrHouse";
            this.tkbrHouse.Size = new System.Drawing.Size(75, 45);
            this.tkbrHouse.TabIndex = 7;
            this.tkbrHouse.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tkbrHouse.Value = 10;
            this.tkbrHouse.Scroll += new System.EventHandler(this.tkbrHouse_Scroll);
            // 
            // lblHouse
            // 
            this.lblHouse.AutoSize = true;
            this.lblHouse.Location = new System.Drawing.Point(2, 236);
            this.lblHouse.Name = "lblHouse";
            this.lblHouse.Size = new System.Drawing.Size(68, 13);
            this.lblHouse.TabIndex = 6;
            this.lblHouse.Text = "Scale House";
            // 
            // tkbrSnow
            // 
            this.tkbrSnow.LargeChange = 1;
            this.tkbrSnow.Location = new System.Drawing.Point(0, 179);
            this.tkbrSnow.Maximum = 5;
            this.tkbrSnow.Name = "tkbrSnow";
            this.tkbrSnow.Size = new System.Drawing.Size(70, 45);
            this.tkbrSnow.TabIndex = 5;
            this.tkbrSnow.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tkbrSnow.Value = 1;
            this.tkbrSnow.Scroll += new System.EventHandler(this.tkbrSnow_Scroll);
            // 
            // lblSnow
            // 
            this.lblSnow.AutoSize = true;
            this.lblSnow.Location = new System.Drawing.Point(6, 162);
            this.lblSnow.Name = "lblSnow";
            this.lblSnow.Size = new System.Drawing.Size(64, 13);
            this.lblSnow.TabIndex = 3;
            this.lblSnow.Text = "Scale Snow";
            // 
            // lblMountains
            // 
            this.lblMountains.AutoSize = true;
            this.lblMountains.Location = new System.Drawing.Point(6, 92);
            this.lblMountains.Name = "lblMountains";
            this.lblMountains.Size = new System.Drawing.Size(60, 13);
            this.lblMountains.TabIndex = 4;
            this.lblMountains.Text = "Scale Mtns";
            // 
            // tkbrMountains
            // 
            this.tkbrMountains.LargeChange = 1;
            this.tkbrMountains.Location = new System.Drawing.Point(0, 108);
            this.tkbrMountains.Maximum = 3;
            this.tkbrMountains.Name = "tkbrMountains";
            this.tkbrMountains.Size = new System.Drawing.Size(76, 45);
            this.tkbrMountains.TabIndex = 3;
            this.tkbrMountains.TickFrequency = 0;
            this.tkbrMountains.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tkbrMountains.Value = 1;
            this.tkbrMountains.Scroll += new System.EventHandler(this.tkbrMountains_Scroll);
            // 
            // lblGrass
            // 
            this.lblGrass.AutoSize = true;
            this.lblGrass.Location = new System.Drawing.Point(6, 21);
            this.lblGrass.Name = "lblGrass";
            this.lblGrass.Size = new System.Drawing.Size(64, 13);
            this.lblGrass.TabIndex = 2;
            this.lblGrass.Text = "Scale Grass";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(12, 54);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(66, 42);
            this.btnShow.TabIndex = 3;
            this.btnShow.Text = "Show Controls";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // frmBrandonsFirstDrawing
            // 
            this.AcceptButton = this.btnNewPainting;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnHide;
            this.ClientSize = new System.Drawing.Size(1036, 578);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.gbControls);
            this.Controls.Add(this.btnNewPainting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(100, 100);
            this.Name = "frmBrandonsFirstDrawing";
            this.Text = "Brandon\'s First Drawing";
            this.ResizeEnd += new System.EventHandler(this.frmBrandonsFirstDrawing_ResizeEnd);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmBrandonsFirstDrawing_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.tkbrGrass)).EndInit();
            this.gbControls.ResumeLayout(false);
            this.gbControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbrSun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbrHouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbrSnow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbrMountains)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewPainting;
        private System.Windows.Forms.TrackBar tkbrGrass;
        private System.Windows.Forms.GroupBox gbControls;
        private System.Windows.Forms.Label lblGrass;
        private System.Windows.Forms.TrackBar tkbrMountains;
        private System.Windows.Forms.Label lblMountains;
        private System.Windows.Forms.TrackBar tkbrSnow;
        private System.Windows.Forms.Label lblSnow;
        private System.Windows.Forms.TrackBar tkbrHouse;
        private System.Windows.Forms.Label lblHouse;
        private System.Windows.Forms.Label lblSun;
        private System.Windows.Forms.TrackBar tkbrSun;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnReset;
    }
}

