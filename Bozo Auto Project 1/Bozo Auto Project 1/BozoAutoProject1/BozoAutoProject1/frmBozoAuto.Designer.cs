namespace BozoAutoProject1
{
    partial class frmBozoAuto
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMaxValue = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMonthlyIncome = new System.Windows.Forms.TextBox();
            this.txtHomePayment = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOtherPayments = new System.Windows.Forms.TextBox();
            this.lstYearsOfLoan = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rdoCreditGood = new System.Windows.Forms.RadioButton();
            this.rdoCreditOk = new System.Windows.Forms.RadioButton();
            this.rdoCreditBad = new System.Windows.Forms.RadioButton();
            this.lblAllowablePayment = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 79);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bozo Auto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Max Car Value: ";
            // 
            // lblMaxValue
            // 
            this.lblMaxValue.AutoSize = true;
            this.lblMaxValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxValue.Location = new System.Drawing.Point(223, 420);
            this.lblMaxValue.Name = "lblMaxValue";
            this.lblMaxValue.Size = new System.Drawing.Size(49, 20);
            this.lblMaxValue.TabIndex = 2;
            this.lblMaxValue.Text = "$0.00";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(493, 510);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(197, 510);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Monthly Income: ";
            // 
            // txtMonthlyIncome
            // 
            this.txtMonthlyIncome.Location = new System.Drawing.Point(172, 247);
            this.txtMonthlyIncome.Name = "txtMonthlyIncome";
            this.txtMonthlyIncome.Size = new System.Drawing.Size(100, 20);
            this.txtMonthlyIncome.TabIndex = 6;
            // 
            // txtHomePayment
            // 
            this.txtHomePayment.Location = new System.Drawing.Point(172, 286);
            this.txtHomePayment.Name = "txtHomePayment";
            this.txtHomePayment.Size = new System.Drawing.Size(100, 20);
            this.txtHomePayment.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Housing Expense: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Other Payments: ";
            // 
            // txtOtherPayments
            // 
            this.txtOtherPayments.Location = new System.Drawing.Point(172, 324);
            this.txtOtherPayments.Name = "txtOtherPayments";
            this.txtOtherPayments.Size = new System.Drawing.Size(100, 20);
            this.txtOtherPayments.TabIndex = 10;
            // 
            // lstYearsOfLoan
            // 
            this.lstYearsOfLoan.FormattingEnabled = true;
            this.lstYearsOfLoan.Items.AddRange(new object[] {
            "4",
            "5",
            "6"});
            this.lstYearsOfLoan.Location = new System.Drawing.Point(496, 247);
            this.lstYearsOfLoan.Name = "lstYearsOfLoan";
            this.lstYearsOfLoan.Size = new System.Drawing.Size(120, 43);
            this.lstYearsOfLoan.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(512, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Length of Loan:";
            // 
            // rdoCreditGood
            // 
            this.rdoCreditGood.AutoSize = true;
            this.rdoCreditGood.Checked = true;
            this.rdoCreditGood.Location = new System.Drawing.Point(496, 296);
            this.rdoCreditGood.Name = "rdoCreditGood";
            this.rdoCreditGood.Size = new System.Drawing.Size(81, 17);
            this.rdoCreditGood.TabIndex = 13;
            this.rdoCreditGood.TabStop = true;
            this.rdoCreditGood.Text = "Good Credit";
            this.rdoCreditGood.UseVisualStyleBackColor = true;
            // 
            // rdoCreditOk
            // 
            this.rdoCreditOk.AutoSize = true;
            this.rdoCreditOk.Location = new System.Drawing.Point(496, 319);
            this.rdoCreditOk.Name = "rdoCreditOk";
            this.rdoCreditOk.Size = new System.Drawing.Size(70, 17);
            this.rdoCreditOk.TabIndex = 14;
            this.rdoCreditOk.Text = "OK Credit";
            this.rdoCreditOk.UseVisualStyleBackColor = true;
            // 
            // rdoCreditBad
            // 
            this.rdoCreditBad.AutoSize = true;
            this.rdoCreditBad.Location = new System.Drawing.Point(496, 342);
            this.rdoCreditBad.Name = "rdoCreditBad";
            this.rdoCreditBad.Size = new System.Drawing.Size(74, 17);
            this.rdoCreditBad.TabIndex = 15;
            this.rdoCreditBad.Text = "Bad Credit";
            this.rdoCreditBad.UseVisualStyleBackColor = true;
            // 
            // lblAllowablePayment
            // 
            this.lblAllowablePayment.AutoSize = true;
            this.lblAllowablePayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllowablePayment.Location = new System.Drawing.Point(645, 420);
            this.lblAllowablePayment.Name = "lblAllowablePayment";
            this.lblAllowablePayment.Size = new System.Drawing.Size(49, 20);
            this.lblAllowablePayment.TabIndex = 17;
            this.lblAllowablePayment.Text = "$0.00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(485, 420);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Allowable Payment:  ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::BozoAutoProject1.Properties.Resources.clown_car;
            this.pictureBox2.Location = new System.Drawing.Point(240, 87);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(277, 139);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // frmBozoAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(801, 545);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblAllowablePayment);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rdoCreditBad);
            this.Controls.Add(this.rdoCreditOk);
            this.Controls.Add(this.rdoCreditGood);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstYearsOfLoan);
            this.Controls.Add(this.txtOtherPayments);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHomePayment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMonthlyIncome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblMaxValue);
            this.Controls.Add(this.label2);
            this.Name = "frmBozoAuto";
            this.Text = "Bozo Auto Loan Qualifier";
            this.Load += new System.EventHandler(this.frmBozoAuto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMaxValue;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMonthlyIncome;
        private System.Windows.Forms.TextBox txtHomePayment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOtherPayments;
        private System.Windows.Forms.ListBox lstYearsOfLoan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdoCreditGood;
        private System.Windows.Forms.RadioButton rdoCreditOk;
        private System.Windows.Forms.RadioButton rdoCreditBad;
        private System.Windows.Forms.Label lblAllowablePayment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

