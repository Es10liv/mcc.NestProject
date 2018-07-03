namespace FuelEconomy
{
    partial class frmMPGRatings
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
            this.lstRatings = new System.Windows.Forms.ListBox();
            this.lblMPGRatings = new System.Windows.Forms.Label();
            this.grpCurrent = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtCurrentMPG = new System.Windows.Forms.TextBox();
            this.numGallonsUsed = new System.Windows.Forms.NumericUpDown();
            this.numEnd = new System.Windows.Forms.NumericUpDown();
            this.numStart = new System.Windows.Forms.NumericUpDown();
            this.grpOverall = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHighestMPG = new System.Windows.Forms.TextBox();
            this.txtLowestMPG = new System.Windows.Forms.TextBox();
            this.txtOverallMPG = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpCurrent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGallonsUsed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStart)).BeginInit();
            this.grpOverall.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstRatings
            // 
            this.lstRatings.FormattingEnabled = true;
            this.lstRatings.Location = new System.Drawing.Point(12, 73);
            this.lstRatings.Name = "lstRatings";
            this.lstRatings.Size = new System.Drawing.Size(346, 368);
            this.lstRatings.TabIndex = 0;
            // 
            // lblMPGRatings
            // 
            this.lblMPGRatings.AutoSize = true;
            this.lblMPGRatings.BackColor = System.Drawing.Color.Transparent;
            this.lblMPGRatings.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMPGRatings.ForeColor = System.Drawing.Color.White;
            this.lblMPGRatings.Location = new System.Drawing.Point(12, 39);
            this.lblMPGRatings.Name = "lblMPGRatings";
            this.lblMPGRatings.Size = new System.Drawing.Size(194, 31);
            this.lblMPGRatings.TabIndex = 1;
            this.lblMPGRatings.Text = "MPG Ratings";
            // 
            // grpCurrent
            // 
            this.grpCurrent.Controls.Add(this.label5);
            this.grpCurrent.Controls.Add(this.label4);
            this.grpCurrent.Controls.Add(this.label3);
            this.grpCurrent.Controls.Add(this.label2);
            this.grpCurrent.Controls.Add(this.btnAdd);
            this.grpCurrent.Controls.Add(this.txtCurrentMPG);
            this.grpCurrent.Controls.Add(this.numGallonsUsed);
            this.grpCurrent.Controls.Add(this.numEnd);
            this.grpCurrent.Controls.Add(this.numStart);
            this.grpCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCurrent.Location = new System.Drawing.Point(380, 85);
            this.grpCurrent.Name = "grpCurrent";
            this.grpCurrent.Size = new System.Drawing.Size(347, 162);
            this.grpCurrent.TabIndex = 2;
            this.grpCurrent.TabStop = false;
            this.grpCurrent.Text = "Current Ratings";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Current MPG:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Gallons Used:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ending Mileage:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Starting Mileage:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(260, 123);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtCurrentMPG
            // 
            this.txtCurrentMPG.BackColor = System.Drawing.SystemColors.Control;
            this.txtCurrentMPG.Location = new System.Drawing.Point(195, 97);
            this.txtCurrentMPG.Name = "txtCurrentMPG";
            this.txtCurrentMPG.Size = new System.Drawing.Size(140, 20);
            this.txtCurrentMPG.TabIndex = 3;
            this.txtCurrentMPG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numGallonsUsed
            // 
            this.numGallonsUsed.DecimalPlaces = 2;
            this.numGallonsUsed.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numGallonsUsed.Location = new System.Drawing.Point(195, 71);
            this.numGallonsUsed.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numGallonsUsed.Name = "numGallonsUsed";
            this.numGallonsUsed.Size = new System.Drawing.Size(140, 20);
            this.numGallonsUsed.TabIndex = 2;
            this.numGallonsUsed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numEnd
            // 
            this.numEnd.DecimalPlaces = 2;
            this.numEnd.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numEnd.Location = new System.Drawing.Point(195, 45);
            this.numEnd.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numEnd.Name = "numEnd";
            this.numEnd.Size = new System.Drawing.Size(140, 20);
            this.numEnd.TabIndex = 1;
            this.numEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numStart
            // 
            this.numStart.DecimalPlaces = 2;
            this.numStart.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numStart.Location = new System.Drawing.Point(195, 19);
            this.numStart.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numStart.Name = "numStart";
            this.numStart.Size = new System.Drawing.Size(140, 20);
            this.numStart.TabIndex = 0;
            this.numStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grpOverall
            // 
            this.grpOverall.Controls.Add(this.label8);
            this.grpOverall.Controls.Add(this.label7);
            this.grpOverall.Controls.Add(this.label6);
            this.grpOverall.Controls.Add(this.txtHighestMPG);
            this.grpOverall.Controls.Add(this.txtLowestMPG);
            this.grpOverall.Controls.Add(this.txtOverallMPG);
            this.grpOverall.Location = new System.Drawing.Point(380, 295);
            this.grpOverall.Name = "grpOverall";
            this.grpOverall.Size = new System.Drawing.Size(347, 103);
            this.grpOverall.TabIndex = 3;
            this.grpOverall.TabStop = false;
            this.grpOverall.Text = "Overall Rating";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Highest MPG:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Lowest MPG:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Overall MPG:";
            // 
            // txtHighestMPG
            // 
            this.txtHighestMPG.BackColor = System.Drawing.SystemColors.Control;
            this.txtHighestMPG.Location = new System.Drawing.Point(195, 71);
            this.txtHighestMPG.Name = "txtHighestMPG";
            this.txtHighestMPG.Size = new System.Drawing.Size(140, 20);
            this.txtHighestMPG.TabIndex = 6;
            this.txtHighestMPG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLowestMPG
            // 
            this.txtLowestMPG.BackColor = System.Drawing.SystemColors.Control;
            this.txtLowestMPG.Location = new System.Drawing.Point(195, 45);
            this.txtLowestMPG.Name = "txtLowestMPG";
            this.txtLowestMPG.Size = new System.Drawing.Size(140, 20);
            this.txtLowestMPG.TabIndex = 5;
            this.txtLowestMPG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtOverallMPG
            // 
            this.txtOverallMPG.BackColor = System.Drawing.SystemColors.Control;
            this.txtOverallMPG.Location = new System.Drawing.Point(195, 19);
            this.txtOverallMPG.Name = "txtOverallMPG";
            this.txtOverallMPG.Size = new System.Drawing.Size(140, 20);
            this.txtOverallMPG.TabIndex = 4;
            this.txtOverallMPG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(652, 404);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMPGRatings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FuelEconomy.Properties.Resources.tires;
            this.ClientSize = new System.Drawing.Size(760, 506);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpOverall);
            this.Controls.Add(this.grpCurrent);
            this.Controls.Add(this.lblMPGRatings);
            this.Controls.Add(this.lstRatings);
            this.Name = "frmMPGRatings";
            this.Text = "MPG Ratings";
            this.grpCurrent.ResumeLayout(false);
            this.grpCurrent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGallonsUsed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStart)).EndInit();
            this.grpOverall.ResumeLayout(false);
            this.grpOverall.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstRatings;
        private System.Windows.Forms.Label lblMPGRatings;
        private System.Windows.Forms.GroupBox grpCurrent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtCurrentMPG;
        private System.Windows.Forms.NumericUpDown numGallonsUsed;
        private System.Windows.Forms.NumericUpDown numEnd;
        private System.Windows.Forms.NumericUpDown numStart;
        private System.Windows.Forms.GroupBox grpOverall;
        private System.Windows.Forms.TextBox txtHighestMPG;
        private System.Windows.Forms.TextBox txtLowestMPG;
        private System.Windows.Forms.TextBox txtOverallMPG;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

