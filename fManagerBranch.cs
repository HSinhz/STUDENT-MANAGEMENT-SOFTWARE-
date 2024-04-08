using Project_Windows.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Windows
{
    public partial class fManagerBranch : Form
    {
        private long branchID;
        Branch branch;
        public fManagerBranch()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fManagerBranch_Activated(object sender, EventArgs e)
        {
            using( var db = new EFDbContext())
            {
                dataGridView1.DataSource = db.Branches.ToList();
            }
            
        }

        private void fManagerBranch_Load(object sender, EventArgs e)
        {
            cbBranch.DisplayMember= "NameBranch";
            cbBranch.ValueMember = "BranchID";
            using( var db = new EFDbContext())
            {
                cbBranch.DataSource = db.Branches.Select(p => new
                {
                    p.BranchID,
                    p.NameBranch
                }).ToList();
            }
            cbBranch.Text = "";
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

        }

        private void cbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            branchID = Convert.ToInt64(cbBranch.SelectedValue);
            using( var db = new EFDbContext()) 
            {
                dataGridView1.DataSource = db.Branches.Where( p => p.BranchID == branchID ).Select( p => new
                {
                    p.BranchID,
                    p.NameBranch
                }).ToList();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                try
                {
                    long branchID = Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["BranchID"].Value);
                    using (var db = new EFDbContext())
                    {
                        Branch branch = db.Branches.Single(c => c.BranchID == branchID);
                        if (MessageBox.Show("Bạn muốn xóa khách hàng " + branch.NameBranch, "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            db.Branches.Remove(branch);
                            db.SaveChanges();
                            fManagerBranch_Activated(sender, e);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi, chưa xóa được? Error: " + ex.Message);
                }
            }

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
                {
                    fEditBranch f = new fEditBranch(Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["BranchID"].Value));
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
            }
        }

        private void btnAddBranch_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtNameBranch.Text))
            {
                toolTip1.Show("Vui lòng nhập tên ngành ", txtNameBranch, 0, 0, 1000);
                return;
            }

            try
            {
                branch = new Branch();
                branch.NameBranch = txtNameBranch.Text;
                using( var db = new EFDbContext())
                {
                    db.Branches.Add(branch);
                    db.SaveChanges();
                }
                fManagerBranch_Activated(sender, e);
                
                txtNameBranch.Clear();
                toolTip1.Show("Thêm thành công", btnAddBranch, 0, 0, 1000);
                
            }
            catch (Exception ex)
            {
                toolTip1.Show("Thêm không thành công" + ex, btnAddBranch, 0, 0, 1000);
            }
            
        }
    }
}
