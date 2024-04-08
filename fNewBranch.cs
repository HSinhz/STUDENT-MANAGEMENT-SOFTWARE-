using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Windows
{
    public partial class fNewBranch : Form
    {
        public fNewBranch()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fNewBranch_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void txtBranchID_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtBranchID.Text))
            {

            }
        }
    }
}
