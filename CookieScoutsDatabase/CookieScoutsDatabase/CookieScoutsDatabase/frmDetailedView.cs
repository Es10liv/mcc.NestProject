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
    public partial class frmDetailedView : Form
    {
        // public variable to get id
        public int intID = 0;
        public frmDetailedView()
        {
            InitializeComponent();
        }

        private void frmDetailedView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cookieScoutsDatabaseDataSet1.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.FillByID(this.cookieScoutsDatabaseDataSet1.Table, intID);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // close the form
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // update database
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cookieScoutsDatabaseDataSet1);
            // close the form
            Close();
        }
    }
}
