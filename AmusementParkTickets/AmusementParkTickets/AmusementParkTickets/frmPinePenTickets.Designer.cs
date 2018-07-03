namespace AmusementParkTickets
{
    partial class frmPinePenTickets
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lstAdult = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblChildren = new System.Windows.Forms.Label();
            this.lstChildren = new System.Windows.Forms.ListBox();
            this.rdoSingle = new System.Windows.Forms.RadioButton();
            this.rdoTwo = new System.Windows.Forms.RadioButton();
            this.chkParking = new System.Windows.Forms.CheckBox();
            this.btnAdvance = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AmusementParkTickets.Properties.Resources._2_5_18;
            this.pictureBox1.Location = new System.Drawing.Point(26, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(445, 263);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lstAdult
            // 
            this.lstAdult.FormattingEnabled = true;
            this.lstAdult.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.lstAdult.Location = new System.Drawing.Point(32, 340);
            this.lstAdult.Name = "lstAdult";
            this.lstAdult.Size = new System.Drawing.Size(174, 43);
            this.lstAdult.TabIndex = 1;
            this.lstAdult.SelectedIndexChanged += new System.EventHandler(this.lstAdult_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adults:";
            // 
            // lblChildren
            // 
            this.lblChildren.AutoSize = true;
            this.lblChildren.Location = new System.Drawing.Point(275, 312);
            this.lblChildren.Name = "lblChildren";
            this.lblChildren.Size = new System.Drawing.Size(48, 13);
            this.lblChildren.TabIndex = 3;
            this.lblChildren.Text = "Children:";
            // 
            // lstChildren
            // 
            this.lstChildren.FormattingEnabled = true;
            this.lstChildren.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.lstChildren.Location = new System.Drawing.Point(278, 340);
            this.lstChildren.Name = "lstChildren";
            this.lstChildren.Size = new System.Drawing.Size(173, 43);
            this.lstChildren.TabIndex = 4;
            // 
            // rdoSingle
            // 
            this.rdoSingle.AutoSize = true;
            this.rdoSingle.Checked = true;
            this.rdoSingle.Location = new System.Drawing.Point(564, 308);
            this.rdoSingle.Name = "rdoSingle";
            this.rdoSingle.Size = new System.Drawing.Size(126, 17);
            this.rdoSingle.TabIndex = 5;
            this.rdoSingle.TabStop = true;
            this.rdoSingle.Text = "Single Day Admission";
            this.rdoSingle.UseVisualStyleBackColor = true;
            // 
            // rdoTwo
            // 
            this.rdoTwo.AutoSize = true;
            this.rdoTwo.Location = new System.Drawing.Point(564, 340);
            this.rdoTwo.Name = "rdoTwo";
            this.rdoTwo.Size = new System.Drawing.Size(118, 17);
            this.rdoTwo.TabIndex = 6;
            this.rdoTwo.Text = "Two Day Admission";
            this.rdoTwo.UseVisualStyleBackColor = true;
            // 
            // chkParking
            // 
            this.chkParking.AutoSize = true;
            this.chkParking.Location = new System.Drawing.Point(738, 308);
            this.chkParking.Name = "chkParking";
            this.chkParking.Size = new System.Drawing.Size(88, 17);
            this.chkParking.TabIndex = 7;
            this.chkParking.Text = "Parking Pass";
            this.chkParking.UseVisualStyleBackColor = true;
            // 
            // btnAdvance
            // 
            this.btnAdvance.BackColor = System.Drawing.Color.Green;
            this.btnAdvance.Location = new System.Drawing.Point(39, 483);
            this.btnAdvance.Name = "btnAdvance";
            this.btnAdvance.Size = new System.Drawing.Size(166, 45);
            this.btnAdvance.TabIndex = 8;
            this.btnAdvance.Text = "Advanced Order";
            this.btnAdvance.UseVisualStyleBackColor = false;
            this.btnAdvance.Click += new System.EventHandler(this.btnAdvance_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(211, 483);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(166, 45);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(383, 483);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(166, 45);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(733, 499);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(62, 29);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "0.00";
            // 
            // frmPinePenTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 554);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnAdvance);
            this.Controls.Add(this.chkParking);
            this.Controls.Add(this.rdoTwo);
            this.Controls.Add(this.rdoSingle);
            this.Controls.Add(this.lstChildren);
            this.Controls.Add(this.lblChildren);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstAdult);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmPinePenTickets";
            this.Text = "Pine Peninsula Amusement Park Tickets";
            this.Load += new System.EventHandler(this.frmPinePenTickets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lstAdult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblChildren;
        private System.Windows.Forms.ListBox lstChildren;
        private System.Windows.Forms.RadioButton rdoSingle;
        private System.Windows.Forms.RadioButton rdoTwo;
        private System.Windows.Forms.CheckBox chkParking;
        private System.Windows.Forms.Button btnAdvance;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTotal;
    }
}

