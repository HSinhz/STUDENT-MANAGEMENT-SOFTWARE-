using Microsoft.EntityFrameworkCore;
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
    public partial class fManagerClass : Form
    {
        private long branchID;
        private long classID;
        
        public fManagerClass()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fManagerClass_Load(object sender, EventArgs e)
        {
            cbBranch.DisplayMember = "NameBranch";
            cbBranch.ValueMember = "BranchID";
            cbClass.DisplayMember = "NameClass";
            cbClass.ValueMember = "ClassID";
            using (var db = new EFDbContext())
            {
                cbBranch.DataSource = db.Branches.Select(p => new
                {
                    p.BranchID,
                    p.NameBranch
                }).ToList();

            }
            

            cbBranch.Text = null;
            cbClass.Text = null;
        }

        private void fManagerClass_Activated(object sender, EventArgs e)
        {
            using( var db = new EFDbContext())
            {
                db.Classes.Load();
                dataGridView1.DataSource = db.Classes.ToList();
            }
        }

        private void dataGridView1_AllowUserToAddRowsChanged(object sender, EventArgs e)
        {

        }

        

        private void cbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            branchID = Convert.ToInt64(cbBranch.SelectedValue);
            using (var db = new EFDbContext())
            {
                cbClass.DataSource = db.Classes.Where( p => p.BranchID == branchID).Select( p => new
                    {
                        p.ClassID,
                        p.NameClass,
                        
                    }).ToList();
            }
            cbClass.Text = null;
            using (var db = new EFDbContext())
            {
                
                dataGridView1.DataSource = db.Classes.Where(p => p.BranchID == branchID).Select(p => new
                {
                    p.ClassID,
                    p.NameClass,
                    p.BranchID
                }).ToList();
            }
        }
            
        private void cbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            classID = Convert.ToInt64(cbClass.SelectedValue);
            using (var db = new EFDbContext())
            {
                dataGridView1.DataSource = db.Classes.Where(p => p.ClassID == classID).Select(p => new
                {
                    p.ClassID,
                    p.NameClass,
                    p.BranchID
                }).ToList();
            }
        }
        private void btnAddClass_Click(object sender, EventArgs e)
        {
            fNewClass f = new fNewClass();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                try
                {
                    long classID = Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["ClassID"].Value);
                    using (var db = new EFDbContext())
                    {
                        Class class1 = db.Classes.Single(c => c.ClassID == classID);
                        if (MessageBox.Show("Bạn muốn xóa khách hàng " + class1.NameClass, "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            db.Classes.Remove(class1);
                            db.SaveChanges();
                            fManagerClass_Activated(sender, e);
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
                fEditClass f = new fEditClass(Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["ClassID"].Value));
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
        }
    }
}
