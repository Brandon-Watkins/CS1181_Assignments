namespace DateNightCalculator
{
    partial class frmDateNightCalculator
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
            this.grpTravel = new System.Windows.Forms.GroupBox();
            this.rbTravel_CarriageRide = new System.Windows.Forms.RadioButton();
            this.rbTravel_Car = new System.Windows.Forms.RadioButton();
            this.rbTravel_Bicycle = new System.Windows.Forms.RadioButton();
            this.rbTravel_Bus = new System.Windows.Forms.RadioButton();
            this.grpEntertainment = new System.Windows.Forms.GroupBox();
            this.rbEntertainment_MinatureGolf = new System.Windows.Forms.RadioButton();
            this.rbEntertainment_Movie = new System.Windows.Forms.RadioButton();
            this.rbEntertainment_Bowling = new System.Windows.Forms.RadioButton();
            this.rbEntertainment_TakeAWalk = new System.Windows.Forms.RadioButton();
            this.grpDinner = new System.Windows.Forms.GroupBox();
            this.rbDinner_SandPipers = new System.Windows.Forms.RadioButton();
            this.rbDinner_Applebees = new System.Windows.Forms.RadioButton();
            this.rbDinner_McDonalds = new System.Windows.Forms.RadioButton();
            this.rbDinner_None = new System.Windows.Forms.RadioButton();
            this.grpDessert = new System.Windows.Forms.GroupBox();
            this.rbDessert_Smores = new System.Windows.Forms.RadioButton();
            this.rbDessert_Shakes = new System.Windows.Forms.RadioButton();
            this.rbDessert_IceCreamCones = new System.Windows.Forms.RadioButton();
            this.rbDessert_None = new System.Windows.Forms.RadioButton();
            this.grpTip = new System.Windows.Forms.GroupBox();
            this.txtTipTotal = new System.Windows.Forms.TextBox();
            this.txtTipPercent = new System.Windows.Forms.TextBox();
            this.lblPercent_DontUse = new System.Windows.Forms.Label();
            this.rbTipTotal = new System.Windows.Forms.RadioButton();
            this.rbTipPercent = new System.Windows.Forms.RadioButton();
            this.tkbrTipPercent = new System.Windows.Forms.TrackBar();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblTaxRate = new System.Windows.Forms.Label();
            this.txtTaxRate = new System.Windows.Forms.TextBox();
            this.lblTaxPercent = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTotalCost_DontEdit = new System.Windows.Forms.Label();
            this.lblTotalCost_Output = new System.Windows.Forms.Label();
            this.lblTaxTotal = new System.Windows.Forms.Label();
            this.lblTaxTotal_Output = new System.Windows.Forms.Label();
            this.grpTravel.SuspendLayout();
            this.grpEntertainment.SuspendLayout();
            this.grpDinner.SuspendLayout();
            this.grpDessert.SuspendLayout();
            this.grpTip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbrTipPercent)).BeginInit();
            this.SuspendLayout();
            // 
            // grpTravel
            // 
            this.grpTravel.Controls.Add(this.rbTravel_CarriageRide);
            this.grpTravel.Controls.Add(this.rbTravel_Car);
            this.grpTravel.Controls.Add(this.rbTravel_Bicycle);
            this.grpTravel.Controls.Add(this.rbTravel_Bus);
            this.grpTravel.Location = new System.Drawing.Point(12, 16);
            this.grpTravel.Name = "grpTravel";
            this.grpTravel.Size = new System.Drawing.Size(146, 118);
            this.grpTravel.TabIndex = 0;
            this.grpTravel.TabStop = false;
            this.grpTravel.Text = "Travel";
            // 
            // rbTravel_CarriageRide
            // 
            this.rbTravel_CarriageRide.AutoSize = true;
            this.rbTravel_CarriageRide.Location = new System.Drawing.Point(6, 88);
            this.rbTravel_CarriageRide.Name = "rbTravel_CarriageRide";
            this.rbTravel_CarriageRide.Size = new System.Drawing.Size(116, 17);
            this.rbTravel_CarriageRide.TabIndex = 3;
            this.rbTravel_CarriageRide.TabStop = true;
            this.rbTravel_CarriageRide.Text = "Carriage Ride ($50)";
            this.rbTravel_CarriageRide.UseVisualStyleBackColor = true;
            this.rbTravel_CarriageRide.Click += new System.EventHandler(this.rbCarriageRide_Click);
            // 
            // rbTravel_Car
            // 
            this.rbTravel_Car.AutoSize = true;
            this.rbTravel_Car.Location = new System.Drawing.Point(6, 65);
            this.rbTravel_Car.Name = "rbTravel_Car";
            this.rbTravel_Car.Size = new System.Drawing.Size(62, 17);
            this.rbTravel_Car.TabIndex = 2;
            this.rbTravel_Car.TabStop = true;
            this.rbTravel_Car.Text = "Car ($5)";
            this.rbTravel_Car.UseVisualStyleBackColor = true;
            this.rbTravel_Car.Click += new System.EventHandler(this.rbCar_Click);
            // 
            // rbTravel_Bicycle
            // 
            this.rbTravel_Bicycle.AutoSize = true;
            this.rbTravel_Bicycle.Location = new System.Drawing.Point(6, 42);
            this.rbTravel_Bicycle.Name = "rbTravel_Bicycle";
            this.rbTravel_Bicycle.Size = new System.Drawing.Size(86, 17);
            this.rbTravel_Bicycle.TabIndex = 1;
            this.rbTravel_Bicycle.TabStop = true;
            this.rbTravel_Bicycle.Text = "Bicycle ($20)";
            this.rbTravel_Bicycle.UseVisualStyleBackColor = true;
            this.rbTravel_Bicycle.Click += new System.EventHandler(this.rbBicycle_Click);
            // 
            // rbTravel_Bus
            // 
            this.rbTravel_Bus.AutoSize = true;
            this.rbTravel_Bus.Location = new System.Drawing.Point(6, 19);
            this.rbTravel_Bus.Name = "rbTravel_Bus";
            this.rbTravel_Bus.Size = new System.Drawing.Size(64, 17);
            this.rbTravel_Bus.TabIndex = 0;
            this.rbTravel_Bus.TabStop = true;
            this.rbTravel_Bus.Text = "Bus ($1)";
            this.rbTravel_Bus.UseVisualStyleBackColor = true;
            this.rbTravel_Bus.Click += new System.EventHandler(this.rbBus_Click);
            // 
            // grpEntertainment
            // 
            this.grpEntertainment.Controls.Add(this.rbEntertainment_MinatureGolf);
            this.grpEntertainment.Controls.Add(this.rbEntertainment_Movie);
            this.grpEntertainment.Controls.Add(this.rbEntertainment_Bowling);
            this.grpEntertainment.Controls.Add(this.rbEntertainment_TakeAWalk);
            this.grpEntertainment.Location = new System.Drawing.Point(12, 140);
            this.grpEntertainment.Name = "grpEntertainment";
            this.grpEntertainment.Size = new System.Drawing.Size(146, 116);
            this.grpEntertainment.TabIndex = 0;
            this.grpEntertainment.TabStop = false;
            this.grpEntertainment.Text = "Entertainment";
            // 
            // rbEntertainment_MinatureGolf
            // 
            this.rbEntertainment_MinatureGolf.AutoSize = true;
            this.rbEntertainment_MinatureGolf.Location = new System.Drawing.Point(6, 89);
            this.rbEntertainment_MinatureGolf.Name = "rbEntertainment_MinatureGolf";
            this.rbEntertainment_MinatureGolf.Size = new System.Drawing.Size(117, 17);
            this.rbEntertainment_MinatureGolf.TabIndex = 3;
            this.rbEntertainment_MinatureGolf.TabStop = true;
            this.rbEntertainment_MinatureGolf.Text = "Miniature Golf ($10)";
            this.rbEntertainment_MinatureGolf.UseVisualStyleBackColor = true;
            this.rbEntertainment_MinatureGolf.Click += new System.EventHandler(this.rbMiniatureGolf_Click);
            // 
            // rbEntertainment_Movie
            // 
            this.rbEntertainment_Movie.AutoSize = true;
            this.rbEntertainment_Movie.Location = new System.Drawing.Point(6, 66);
            this.rbEntertainment_Movie.Name = "rbEntertainment_Movie";
            this.rbEntertainment_Movie.Size = new System.Drawing.Size(81, 17);
            this.rbEntertainment_Movie.TabIndex = 2;
            this.rbEntertainment_Movie.TabStop = true;
            this.rbEntertainment_Movie.Text = "Movie ($26)";
            this.rbEntertainment_Movie.UseVisualStyleBackColor = true;
            this.rbEntertainment_Movie.Click += new System.EventHandler(this.rbMovie_Click);
            // 
            // rbEntertainment_Bowling
            // 
            this.rbEntertainment_Bowling.AutoSize = true;
            this.rbEntertainment_Bowling.Cursor = System.Windows.Forms.Cursors.Default;
            this.rbEntertainment_Bowling.Location = new System.Drawing.Point(6, 43);
            this.rbEntertainment_Bowling.Name = "rbEntertainment_Bowling";
            this.rbEntertainment_Bowling.Size = new System.Drawing.Size(83, 17);
            this.rbEntertainment_Bowling.TabIndex = 1;
            this.rbEntertainment_Bowling.TabStop = true;
            this.rbEntertainment_Bowling.Text = "Bowling ($6)";
            this.rbEntertainment_Bowling.UseVisualStyleBackColor = true;
            this.rbEntertainment_Bowling.Click += new System.EventHandler(this.rbBowling_Click);
            // 
            // rbEntertainment_TakeAWalk
            // 
            this.rbEntertainment_TakeAWalk.AutoSize = true;
            this.rbEntertainment_TakeAWalk.Location = new System.Drawing.Point(6, 20);
            this.rbEntertainment_TakeAWalk.Name = "rbEntertainment_TakeAWalk";
            this.rbEntertainment_TakeAWalk.Size = new System.Drawing.Size(109, 17);
            this.rbEntertainment_TakeAWalk.TabIndex = 0;
            this.rbEntertainment_TakeAWalk.TabStop = true;
            this.rbEntertainment_TakeAWalk.Text = "Take A Walk ($0)";
            this.rbEntertainment_TakeAWalk.UseVisualStyleBackColor = true;
            this.rbEntertainment_TakeAWalk.Click += new System.EventHandler(this.rbTakeAWalk_Click);
            // 
            // grpDinner
            // 
            this.grpDinner.Controls.Add(this.rbDinner_SandPipers);
            this.grpDinner.Controls.Add(this.rbDinner_Applebees);
            this.grpDinner.Controls.Add(this.rbDinner_McDonalds);
            this.grpDinner.Controls.Add(this.rbDinner_None);
            this.grpDinner.Location = new System.Drawing.Point(164, 16);
            this.grpDinner.Name = "grpDinner";
            this.grpDinner.Size = new System.Drawing.Size(146, 118);
            this.grpDinner.TabIndex = 0;
            this.grpDinner.TabStop = false;
            this.grpDinner.Text = "Dinner";
            // 
            // rbDinner_SandPipers
            // 
            this.rbDinner_SandPipers.AutoSize = true;
            this.rbDinner_SandPipers.Location = new System.Drawing.Point(7, 88);
            this.rbDinner_SandPipers.Name = "rbDinner_SandPipers";
            this.rbDinner_SandPipers.Size = new System.Drawing.Size(108, 17);
            this.rbDinner_SandPipers.TabIndex = 3;
            this.rbDinner_SandPipers.TabStop = true;
            this.rbDinner_SandPipers.Text = "SandPiper\'s ($50)";
            this.rbDinner_SandPipers.UseVisualStyleBackColor = true;
            this.rbDinner_SandPipers.Click += new System.EventHandler(this.rbSandPipers_Click);
            // 
            // rbDinner_Applebees
            // 
            this.rbDinner_Applebees.AutoSize = true;
            this.rbDinner_Applebees.Location = new System.Drawing.Point(7, 65);
            this.rbDinner_Applebees.Name = "rbDinner_Applebees";
            this.rbDinner_Applebees.Size = new System.Drawing.Size(104, 17);
            this.rbDinner_Applebees.TabIndex = 2;
            this.rbDinner_Applebees.TabStop = true;
            this.rbDinner_Applebees.Text = "Applebee\'s ($25)";
            this.rbDinner_Applebees.UseVisualStyleBackColor = true;
            this.rbDinner_Applebees.Click += new System.EventHandler(this.rbAppleBees_Click);
            // 
            // rbDinner_McDonalds
            // 
            this.rbDinner_McDonalds.AutoSize = true;
            this.rbDinner_McDonalds.Location = new System.Drawing.Point(7, 42);
            this.rbDinner_McDonalds.Name = "rbDinner_McDonalds";
            this.rbDinner_McDonalds.Size = new System.Drawing.Size(106, 17);
            this.rbDinner_McDonalds.TabIndex = 1;
            this.rbDinner_McDonalds.TabStop = true;
            this.rbDinner_McDonalds.Text = "McDonalds ($10)";
            this.rbDinner_McDonalds.UseVisualStyleBackColor = true;
            this.rbDinner_McDonalds.Click += new System.EventHandler(this.rbMcDonalds_Click);
            // 
            // rbDinner_None
            // 
            this.rbDinner_None.AutoSize = true;
            this.rbDinner_None.Location = new System.Drawing.Point(7, 20);
            this.rbDinner_None.Name = "rbDinner_None";
            this.rbDinner_None.Size = new System.Drawing.Size(72, 17);
            this.rbDinner_None.TabIndex = 0;
            this.rbDinner_None.TabStop = true;
            this.rbDinner_None.Text = "None ($0)";
            this.rbDinner_None.UseVisualStyleBackColor = true;
            this.rbDinner_None.Click += new System.EventHandler(this.rbNone_Click);
            // 
            // grpDessert
            // 
            this.grpDessert.Controls.Add(this.rbDessert_Smores);
            this.grpDessert.Controls.Add(this.rbDessert_Shakes);
            this.grpDessert.Controls.Add(this.rbDessert_IceCreamCones);
            this.grpDessert.Controls.Add(this.rbDessert_None);
            this.grpDessert.Location = new System.Drawing.Point(316, 16);
            this.grpDessert.Name = "grpDessert";
            this.grpDessert.Size = new System.Drawing.Size(145, 118);
            this.grpDessert.TabIndex = 0;
            this.grpDessert.TabStop = false;
            this.grpDessert.Text = "Dessert";
            // 
            // rbDessert_Smores
            // 
            this.rbDessert_Smores.AutoSize = true;
            this.rbDessert_Smores.Location = new System.Drawing.Point(7, 88);
            this.rbDessert_Smores.Name = "rbDessert_Smores";
            this.rbDessert_Smores.Size = new System.Drawing.Size(83, 17);
            this.rbDessert_Smores.TabIndex = 3;
            this.rbDessert_Smores.TabStop = true;
            this.rbDessert_Smores.Text = "S\'mores ($4)";
            this.rbDessert_Smores.UseVisualStyleBackColor = true;
            this.rbDessert_Smores.Click += new System.EventHandler(this.rbSmores_Click);
            // 
            // rbDessert_Shakes
            // 
            this.rbDessert_Shakes.AutoSize = true;
            this.rbDessert_Shakes.Location = new System.Drawing.Point(7, 65);
            this.rbDessert_Shakes.Name = "rbDessert_Shakes";
            this.rbDessert_Shakes.Size = new System.Drawing.Size(82, 17);
            this.rbDessert_Shakes.TabIndex = 2;
            this.rbDessert_Shakes.TabStop = true;
            this.rbDessert_Shakes.Text = "Shakes ($8)";
            this.rbDessert_Shakes.UseVisualStyleBackColor = true;
            this.rbDessert_Shakes.Click += new System.EventHandler(this.rbShakes_Click);
            // 
            // rbDessert_IceCreamCones
            // 
            this.rbDessert_IceCreamCones.AutoSize = true;
            this.rbDessert_IceCreamCones.Location = new System.Drawing.Point(7, 42);
            this.rbDessert_IceCreamCones.Name = "rbDessert_IceCreamCones";
            this.rbDessert_IceCreamCones.Size = new System.Drawing.Size(127, 17);
            this.rbDessert_IceCreamCones.TabIndex = 1;
            this.rbDessert_IceCreamCones.TabStop = true;
            this.rbDessert_IceCreamCones.Text = "Ice Cream Cones ($3)";
            this.rbDessert_IceCreamCones.UseVisualStyleBackColor = true;
            this.rbDessert_IceCreamCones.Click += new System.EventHandler(this.rbIceCreamCones_Click);
            // 
            // rbDessert_None
            // 
            this.rbDessert_None.AutoSize = true;
            this.rbDessert_None.Location = new System.Drawing.Point(6, 19);
            this.rbDessert_None.Name = "rbDessert_None";
            this.rbDessert_None.Size = new System.Drawing.Size(72, 17);
            this.rbDessert_None.TabIndex = 0;
            this.rbDessert_None.TabStop = true;
            this.rbDessert_None.Text = "None ($0)";
            this.rbDessert_None.UseVisualStyleBackColor = true;
            this.rbDessert_None.Click += new System.EventHandler(this.rbNone2_Click);
            // 
            // grpTip
            // 
            this.grpTip.Controls.Add(this.txtTipTotal);
            this.grpTip.Controls.Add(this.txtTipPercent);
            this.grpTip.Controls.Add(this.lblPercent_DontUse);
            this.grpTip.Controls.Add(this.rbTipTotal);
            this.grpTip.Controls.Add(this.rbTipPercent);
            this.grpTip.Controls.Add(this.tkbrTipPercent);
            this.grpTip.Location = new System.Drawing.Point(165, 140);
            this.grpTip.Name = "grpTip";
            this.grpTip.Size = new System.Drawing.Size(296, 116);
            this.grpTip.TabIndex = 1;
            this.grpTip.TabStop = false;
            this.grpTip.Text = "Tip";
            // 
            // txtTipTotal
            // 
            this.txtTipTotal.Location = new System.Drawing.Point(83, 88);
            this.txtTipTotal.Name = "txtTipTotal";
            this.txtTipTotal.Size = new System.Drawing.Size(120, 20);
            this.txtTipTotal.TabIndex = 4;
            this.txtTipTotal.Text = "0.00";
            this.txtTipTotal.Click += new System.EventHandler(this.txtTipTotal_Click);
            this.txtTipTotal.TextChanged += new System.EventHandler(this.txtTipTotal_TextChanged);
            // 
            // txtTipPercent
            // 
            this.txtTipPercent.Location = new System.Drawing.Point(83, 65);
            this.txtTipPercent.Name = "txtTipPercent";
            this.txtTipPercent.Size = new System.Drawing.Size(120, 20);
            this.txtTipPercent.TabIndex = 2;
            this.txtTipPercent.Text = "5.0";
            this.txtTipPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTipPercent.Click += new System.EventHandler(this.txtTipPercent_Click);
            this.txtTipPercent.TextChanged += new System.EventHandler(this.txtTipPercent_TextChanged);
            // 
            // lblPercent_DontUse
            // 
            this.lblPercent_DontUse.AutoSize = true;
            this.lblPercent_DontUse.Location = new System.Drawing.Point(201, 68);
            this.lblPercent_DontUse.Name = "lblPercent_DontUse";
            this.lblPercent_DontUse.Size = new System.Drawing.Size(15, 13);
            this.lblPercent_DontUse.TabIndex = 7;
            this.lblPercent_DontUse.Text = "%";
            // 
            // rbTipTotal
            // 
            this.rbTipTotal.AutoSize = true;
            this.rbTipTotal.Location = new System.Drawing.Point(6, 89);
            this.rbTipTotal.Name = "rbTipTotal";
            this.rbTipTotal.Size = new System.Drawing.Size(79, 17);
            this.rbTipTotal.TabIndex = 6;
            this.rbTipTotal.Text = "Tip Total: $";
            this.rbTipTotal.UseVisualStyleBackColor = true;
            this.rbTipTotal.CheckedChanged += new System.EventHandler(this.rbTipTotal_CheckedChanged);
            this.rbTipTotal.Click += new System.EventHandler(this.rbTipTotal_Click);
            // 
            // rbTipPercent
            // 
            this.rbTipPercent.AutoSize = true;
            this.rbTipPercent.Checked = true;
            this.rbTipPercent.Location = new System.Drawing.Point(6, 66);
            this.rbTipPercent.Name = "rbTipPercent";
            this.rbTipPercent.Size = new System.Drawing.Size(83, 17);
            this.rbTipPercent.TabIndex = 5;
            this.rbTipPercent.TabStop = true;
            this.rbTipPercent.Text = "Tip Percent:";
            this.rbTipPercent.UseVisualStyleBackColor = true;
            this.rbTipPercent.CheckedChanged += new System.EventHandler(this.rbTipPercent_CheckedChanged);
            this.rbTipPercent.Click += new System.EventHandler(this.rbTipPercent_Click);
            // 
            // tkbrTipPercent
            // 
            this.tkbrTipPercent.Location = new System.Drawing.Point(6, 24);
            this.tkbrTipPercent.Maximum = 35;
            this.tkbrTipPercent.Minimum = 5;
            this.tkbrTipPercent.Name = "tkbrTipPercent";
            this.tkbrTipPercent.Size = new System.Drawing.Size(284, 45);
            this.tkbrTipPercent.TabIndex = 0;
            this.tkbrTipPercent.Value = 5;
            this.tkbrTipPercent.ValueChanged += new System.EventHandler(this.tkbrTipValue_ValueChanged);
            this.tkbrTipPercent.Enter += new System.EventHandler(this.tkbrTipPercent_Enter);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(178, 313);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(101, 36);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "&Calculate Cost";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblTaxRate
            // 
            this.lblTaxRate.AutoSize = true;
            this.lblTaxRate.Location = new System.Drawing.Point(15, 268);
            this.lblTaxRate.Name = "lblTaxRate";
            this.lblTaxRate.Size = new System.Drawing.Size(54, 13);
            this.lblTaxRate.TabIndex = 3;
            this.lblTaxRate.Text = "Tax Rate:";
            // 
            // txtTaxRate
            // 
            this.txtTaxRate.Location = new System.Drawing.Point(69, 265);
            this.txtTaxRate.Name = "txtTaxRate";
            this.txtTaxRate.Size = new System.Drawing.Size(77, 20);
            this.txtTaxRate.TabIndex = 4;
            this.txtTaxRate.Text = "0.0";
            this.txtTaxRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTaxRate.TextChanged += new System.EventHandler(this.txtTaxRate_TextChanged);
            // 
            // lblTaxPercent
            // 
            this.lblTaxPercent.AutoSize = true;
            this.lblTaxPercent.Location = new System.Drawing.Point(143, 268);
            this.lblTaxPercent.Name = "lblTaxPercent";
            this.lblTaxPercent.Size = new System.Drawing.Size(15, 13);
            this.lblTaxPercent.TabIndex = 5;
            this.lblTaxPercent.Text = "%";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(18, 320);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(380, 320);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Clos&e";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTotalCost_DontEdit
            // 
            this.lblTotalCost_DontEdit.AutoSize = true;
            this.lblTotalCost_DontEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost_DontEdit.Location = new System.Drawing.Point(121, 290);
            this.lblTotalCost_DontEdit.Name = "lblTotalCost_DontEdit";
            this.lblTotalCost_DontEdit.Size = new System.Drawing.Size(96, 20);
            this.lblTotalCost_DontEdit.TabIndex = 8;
            this.lblTotalCost_DontEdit.Text = "Total Cost:";
            // 
            // lblTotalCost_Output
            // 
            this.lblTotalCost_Output.AutoSize = true;
            this.lblTotalCost_Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost_Output.Location = new System.Drawing.Point(219, 290);
            this.lblTotalCost_Output.Name = "lblTotalCost_Output";
            this.lblTotalCost_Output.Size = new System.Drawing.Size(24, 20);
            this.lblTotalCost_Output.TabIndex = 10;
            this.lblTotalCost_Output.Text = "...";
            // 
            // lblTaxTotal
            // 
            this.lblTaxTotal.AutoSize = true;
            this.lblTaxTotal.Location = new System.Drawing.Point(202, 268);
            this.lblTaxTotal.Name = "lblTaxTotal";
            this.lblTaxTotal.Size = new System.Drawing.Size(55, 13);
            this.lblTaxTotal.TabIndex = 11;
            this.lblTaxTotal.Text = "Tax Total:";
            // 
            // lblTaxTotal_Output
            // 
            this.lblTaxTotal_Output.AutoSize = true;
            this.lblTaxTotal_Output.Location = new System.Drawing.Point(263, 268);
            this.lblTaxTotal_Output.Name = "lblTaxTotal_Output";
            this.lblTaxTotal_Output.Size = new System.Drawing.Size(16, 13);
            this.lblTaxTotal_Output.TabIndex = 12;
            this.lblTaxTotal_Output.Text = "...";
            // 
            // frmDateNightCalculator
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(475, 355);
            this.Controls.Add(this.lblTaxTotal_Output);
            this.Controls.Add(this.lblTaxTotal);
            this.Controls.Add(this.lblTotalCost_Output);
            this.Controls.Add(this.lblTotalCost_DontEdit);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtTaxRate);
            this.Controls.Add(this.grpDessert);
            this.Controls.Add(this.grpDinner);
            this.Controls.Add(this.lblTaxRate);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.grpTip);
            this.Controls.Add(this.grpEntertainment);
            this.Controls.Add(this.grpTravel);
            this.Controls.Add(this.lblTaxPercent);
            this.Name = "frmDateNightCalculator";
            this.Text = "Date Night Calculator";
            this.Load += new System.EventHandler(this.frmDateNightCalculator_Load);
            this.Click += new System.EventHandler(this.frmDateNightCalculator_Click);
            this.grpTravel.ResumeLayout(false);
            this.grpTravel.PerformLayout();
            this.grpEntertainment.ResumeLayout(false);
            this.grpEntertainment.PerformLayout();
            this.grpDinner.ResumeLayout(false);
            this.grpDinner.PerformLayout();
            this.grpDessert.ResumeLayout(false);
            this.grpDessert.PerformLayout();
            this.grpTip.ResumeLayout(false);
            this.grpTip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbrTipPercent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTravel;
        private System.Windows.Forms.GroupBox grpEntertainment;
        private System.Windows.Forms.GroupBox grpDinner;
        private System.Windows.Forms.GroupBox grpDessert;
        private System.Windows.Forms.GroupBox grpTip;
        private System.Windows.Forms.RadioButton rbTravel_CarriageRide;
        private System.Windows.Forms.RadioButton rbTravel_Car;
        private System.Windows.Forms.RadioButton rbTravel_Bicycle;
        private System.Windows.Forms.RadioButton rbTravel_Bus;
        private System.Windows.Forms.RadioButton rbEntertainment_MinatureGolf;
        private System.Windows.Forms.RadioButton rbEntertainment_Movie;
        private System.Windows.Forms.RadioButton rbEntertainment_Bowling;
        private System.Windows.Forms.RadioButton rbEntertainment_TakeAWalk;
        private System.Windows.Forms.RadioButton rbDinner_SandPipers;
        private System.Windows.Forms.RadioButton rbDinner_Applebees;
        private System.Windows.Forms.RadioButton rbDinner_McDonalds;
        private System.Windows.Forms.RadioButton rbDinner_None;
        private System.Windows.Forms.RadioButton rbDessert_Smores;
        private System.Windows.Forms.RadioButton rbDessert_Shakes;
        private System.Windows.Forms.RadioButton rbDessert_IceCreamCones;
        private System.Windows.Forms.RadioButton rbDessert_None;
        private System.Windows.Forms.TextBox txtTipPercent;
        private System.Windows.Forms.TrackBar tkbrTipPercent;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblTaxRate;
        private System.Windows.Forms.TextBox txtTaxRate;
        private System.Windows.Forms.Label lblTaxPercent;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTotalCost_DontEdit;
        private System.Windows.Forms.Label lblTotalCost_Output;
        private System.Windows.Forms.TextBox txtTipTotal;
        private System.Windows.Forms.Label lblTaxTotal;
        private System.Windows.Forms.Label lblTaxTotal_Output;
        private System.Windows.Forms.RadioButton rbTipTotal;
        private System.Windows.Forms.RadioButton rbTipPercent;
        private System.Windows.Forms.Label lblPercent_DontUse;
    }
}

