using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmusementParkTickets
{
    public partial class frmPinePenTickets : Form
    {
        public frmPinePenTickets()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void frmPinePenTickets_Load(object sender, EventArgs e)
        {
            lstAdult.SelectedIndex = 0;
            lstChildren.SelectedIndex = 0;
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // create variables
            int intAdult = int.Parse(lstAdult.SelectedItem.ToString());
            int intChildren = int.Parse(lstChildren.SelectedItem.ToString());
            double dblAdultPrice = intAdult * 49.00;
            double dblChildrenPrice = intChildren * 42.00;
            double dblSecondDayPrice = (intAdult + intChildren) * (25.00);
            double dblParkingPrice = 15.00;
            // create single day calculations
            if (btnAdvance.BackColor == Color.Green)
            {
                // create single day calculations
                if (rdoSingle.Checked)
                {
                    if (chkParking.Checked)
                    {
                        double dblFinalPrice = dblAdultPrice + dblChildrenPrice + dblParkingPrice;
                        double dblDiscountPercent = dblFinalPrice * 0.1;
                        dblFinalPrice = dblFinalPrice - dblDiscountPercent;
                        lblTotal.Text = string.Format("{0:C}", dblFinalPrice);
                    }
                    else
                    {
                        double dblFinalPrice = dblAdultPrice + dblChildrenPrice;
                        double dblDiscountPercent = dblFinalPrice * 0.1;
                        dblFinalPrice = dblFinalPrice - dblDiscountPercent;
                        lblTotal.Text = string.Format("{0:C}", dblFinalPrice);
                    }

                }
                // create two day calculations
                else if (rdoTwo.Checked)
                {
                    if (chkParking.Checked)
                    {
                        dblParkingPrice = 30.00;
                        double dblFinalPrice = dblAdultPrice + dblChildrenPrice + dblParkingPrice + dblSecondDayPrice;
                        double dblDiscountPercent = dblFinalPrice * 0.1;
                        dblFinalPrice = dblFinalPrice - dblDiscountPercent;
                        lblTotal.Text = string.Format("{0:C}", dblFinalPrice);
                    }
                    else
                    {
                        double dblFinalPrice = dblAdultPrice + dblChildrenPrice + dblSecondDayPrice;
                        double dblDiscountPercent = dblFinalPrice * 0.1;
                        dblFinalPrice = dblFinalPrice - dblDiscountPercent;
                        lblTotal.Text = string.Format("{0:C}", dblFinalPrice);
                    }
                }
            }
            else if (btnAdvance.BackColor == Color.Red)
            {
                if (rdoSingle.Checked)
                {
                    if (chkParking.Checked)
                    {
                        double dblFinalPrice = dblAdultPrice + dblChildrenPrice + dblParkingPrice;
                        lblTotal.Text = string.Format("{0:C}", dblFinalPrice);
                    }
                    else
                    {
                        double dblFinalPrice = dblAdultPrice + dblChildrenPrice;
                        lblTotal.Text = string.Format("{0:C}", dblFinalPrice);
                    }
                }
                // create two day calculations
                else if (rdoTwo.Checked)
                {
                    if (chkParking.Checked)
                    {
                        dblParkingPrice = 30.00;
                        double dblFinalPrice = dblAdultPrice + dblChildrenPrice + dblParkingPrice + dblSecondDayPrice;
                        lblTotal.Text = string.Format("{0:C}", dblFinalPrice);
                    }
                    else
                    {
                        double dblFinalPrice = dblAdultPrice + dblChildrenPrice + dblSecondDayPrice;
                        lblTotal.Text = string.Format("{0:C}", dblFinalPrice);
                    }
                }
            }
            
        }

       private void lstAdult_SelectedIndexChanged(object sender, EventArgs e)
        {
     
        }

        private void btnAdvance_Click(object sender, EventArgs e)
        {
            // change color on click for advanced pay
            if (btnAdvance.BackColor == Color.Green)
            { 
                MessageBox.Show("You are not paying in advance");
                btnAdvance.BackColor = Color.Red;
            }
            else
            { //
                MessageBox.Show("You are paying in advance.");
                // change back color
                btnAdvance.BackColor = Color.Green;
            }
        }
    }
}
