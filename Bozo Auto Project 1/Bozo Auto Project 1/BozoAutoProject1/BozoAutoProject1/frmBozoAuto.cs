using System;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BozoAutoProject1
{
    public partial class frmBozoAuto : Form
    {
        public frmBozoAuto()
        {
            InitializeComponent();
        }

        private void frmBozoAuto_Load(object sender, EventArgs e)
        {
            lstYearsOfLoan.SelectedIndex = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            

            // Create a try statement follow all calculation at the end with the catch statement
            try
            {
                // Create the variables for user input from text boxes, list box, and radio button.
                int intYears = int.Parse(lstYearsOfLoan.SelectedItem.ToString());
                double dblMonthlyIncome = double.Parse(txtMonthlyIncome.Text);
                double dblHomePayment = double.Parse(txtHomePayment.Text);
                double dblOtherPayments = double.Parse(txtOtherPayments.Text);
                // Create variables for output
                double dblAllowablePayment;
                double dblMaxValue;
                // Create if statements for the radio buttons.
                if (rdoCreditGood.Checked)
                {
                    // do calculations for good credit
                    dblAllowablePayment = dblMonthlyIncome * 0.36;
                    dblAllowablePayment = dblAllowablePayment - dblHomePayment - dblOtherPayments;
                    dblMaxValue = Financial.PV((0.08/12), (intYears * 12), dblAllowablePayment);
                    dblMaxValue = -1 * dblMaxValue;
                    lblAllowablePayment.Text = string.Format("{0:C}", dblAllowablePayment);
                    lblMaxValue.Text = string.Format("{0:C}", dblMaxValue);
                }
                else if (rdoCreditOk.Checked)
                {
                    // do calculations for ok credit
                    dblAllowablePayment = dblMonthlyIncome * 0.36;
                    dblAllowablePayment = dblAllowablePayment - dblHomePayment - dblOtherPayments;
                    dblMaxValue = Financial.PV((0.16 / 12), (intYears * 12), dblAllowablePayment);
                    dblMaxValue = -1 * dblMaxValue;
                    lblAllowablePayment.Text = string.Format("{0:C}", dblAllowablePayment);
                    lblMaxValue.Text = string.Format("{0:C}", dblMaxValue);
                }
                else if (rdoCreditBad.Checked)
                {
                    // do calculations for bad credit
                    dblAllowablePayment = dblMonthlyIncome * 0.36;
                    dblAllowablePayment = dblAllowablePayment - dblHomePayment - dblOtherPayments;
                    dblMaxValue = Financial.PV((0.19 / 12), (intYears * 12), dblAllowablePayment);
                    dblMaxValue = -1 * dblMaxValue;
                    lblAllowablePayment.Text = string.Format("{0:C}", dblAllowablePayment);
                    lblMaxValue.Text = string.Format("{0:C}", dblMaxValue);
                }
            }
            // Create Catch Statement
            catch
            {
                // throw error message
                MessageBox.Show("Something went wrong. Try again.");
                // reset text boxes and output
                txtMonthlyIncome.Clear();
                txtHomePayment.Clear();
                txtOtherPayments.Clear();
                lblAllowablePayment.Text = "$0.00";
                lblMaxValue.Text = "$0.00";
            }
        }
    }
}
