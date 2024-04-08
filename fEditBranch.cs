using Project_Windows.Models;
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
    public partial class fEditBranch : Form
    {
        Branch branch;
        long branchID;
        EFDbContext db = new EFDbContext();
        public fEditBranch(long branchID)
        {
            InitializeComponent();
            this.branchID = branchID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fEditBranch_Load(object sender, EventArgs e)
        {
            branch = db.Branches.Single( p => p.BranchID == branchID );
            Text += " - Mã ngành " + branch.BranchID.ToString();
            txtNameBranch.Text = branch.NameBranch.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try { 
                branch.NameBranch = txtNameBranch.Text;
                db.SaveChanges();
                txtNameBranch.Clear();
                toolTip1.Show("Cập nhật thành công", btnSave, 0, 0, 1000);
            } catch(Exception ex) 
            {
                toolTip1.Show("Cập nhật thất bại" + ex, btnSave, 0, 0, 1000); 
            }

        }
    }
}
