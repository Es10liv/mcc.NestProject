using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelEconomy
{
    public partial class frmMPGRatings : Form
    {
        // initialize list of empty ratings
        List<decimal> dclRatings = new List<decimal>();

        

        public frmMPGRatings()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // declare variables to be used across methods
            decimal dclStart = numStart.Value;
            decimal dclEnd = numEnd.Value;
            decimal dclGallons = numGallonsUsed.Value;

            if (dclStart >= dclEnd)
            {
                MessageBox.Show("The ending mpg must be higher than the starting mpg.");
            }
            else
            {
                CalcMPG(dclStart, dclEnd, dclGallons);

                GetResults();
                
            }
        }

        private void CalcMPG(decimal dclStart, decimal dclEnd, decimal dclGallons)
        {
            // try and catch to prevent the number of gallons being 0
            try
            {
                // subtract starting mpg from the ending mpg then divide by the number of gallons used
                decimal dclMpg = (dclEnd - dclStart) / dclGallons;
                txtCurrentMPG.Text = dclMpg.ToString("N2");
                lstRatings.Items.Add(dclMpg.ToString("N2"));
                dclRatings.Add(dclMpg);
            }
            catch
            {
                // display to the user that the number of gallons must be higher than 0
                MessageBox.Show("The number of gallons must be higher than 0");
            }
        }
        
        private void GetResults()
        {
            // get the results for overall mpg, highest mpg, and lowest mpg
            decimal dclCurrent = (decimal.Parse(txtCurrentMPG.Text));
            decimal dclHighest = 0;
            decimal dclLowest = 999999;
            decimal dclOverall = 0;
            dclHighest = dclRatings.Max();
            txtHighestMPG.Text = dclHighest.ToString("N2");
            dclLowest = dclRatings.Min();
            txtLowestMPG.Text = dclLowest.ToString("N2");
            dclOverall = dclRatings.Average();
            txtOverallMPG.Text = dclOverall.ToString("N2");

            
        }

    }
}
