using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookieScoutsDatabase
{
    public partial class frmCookieCustomers : Form
    {
        public frmCookieCustomers()
        {
            InitializeComponent();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cookieScoutsDatabaseDataSet1);

        }

        private void frmCookieCustomers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cookieScoutsDatabaseDataSet1.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.cookieScoutsDatabaseDataSet1.Table);

        }

        private void btnLstNameSearch_Click(object sender, EventArgs e)
        {
            // fill records based on last name search in text box
            this.tableTableAdapter.FillByName(this.cookieScoutsDatabaseDataSet1.Table, txtSearch.Text);
        }

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            // fill records with full list
            this.tableTableAdapter.Fill(this.cookieScoutsDatabaseDataSet1.Table);
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            // makes sure user has selected a row
            if (tableDataGridView.SelectedRows.Count == 0)
            {
                // no record selected
                MessageBox.Show("Please select a record for detailed view.");
            }
            else // record is selected
            {
                // get unique id for row
                int intID = int.Parse(tableDataGridView.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show(intID.ToString());
                // create instance of second form
                frmDetailedView DetailsForm = new frmDetailedView();
                // pass unique id to second form
                DetailsForm.intID = intID;
                // display data for the record on the second form
                DetailsForm.ShowDialog();
                // refresh datagrid
                this.tableTableAdapter.Fill(this.cookieScoutsDatabaseDataSet1.Table);
            }
        }
    }
}
