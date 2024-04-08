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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace Project_Windows
{
    public partial class fNewClass : Form
    {
        Class class1;
        public fNewClass()
        {
            InitializeComponent();
        }

        private void fNewClass_Load(object sender, EventArgs e)
        {
            cbBranch.DisplayMember = "NameBranch";
            cbBranch.ValueMember = "BranchID";
            using (var db = new EFDbContext())
            {
                cbBranch.DataSource = db.Branches.Select(p => new
                {
                    p.BranchID,
                    p.NameBranch
                }).ToList();

            }
            cbBranch.Text = null;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbBranch_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cbBranch.Text))
            {
                toolTip1.Show("Vui lòng chọn ngành", cbBranch, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void txtClass_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtClass.Text))
            {
                toolTip1.Show("Vui lòng nhập tên lớp", txtClass, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void fNewClass_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                class1 = new Class();

                class1.BranchID = Convert.ToInt64(cbBranch.SelectedValue);
                class1.NameClass = txtClass.Text;
                using( var db = new EFDbContext())
                {
                    int kiemtra = db.Classes.Where(p => p.NameClass == txtClass.Text ).Count();
                    if( kiemtra > 0 )
                    {
                        MessageBox.Show("Đã tồn tại " + txtClass.Text);
                        cbBranch.Text = null;
                        txtClass.Text = null;
                        txtClass.Focus();
                        
                    } else {
                        db.Classes.Add(class1);
                        db.SaveChanges();
                        cbBranch.Text = null;
                        txtClass.Text = null;
                        toolTip1.Show("Lưu thành công", btnSave, 0, 0, 1000);
                    }
                    
                }
                
            } catch (Exception ex)
            {
                toolTip1.Show("Lưu không thành công" + ex, btnSave, 0, 0, 1000);
            }
        }
    }
}
