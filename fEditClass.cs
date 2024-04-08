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
using System.Text.RegularExpressions;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Project_Windows
{
    public partial class fEditClass : Form
    {
        Branch branch;
        Class classmain;
        long classID;
        EFDbContext db = new EFDbContext();
        public fEditClass(long classID)
        {
            InitializeComponent();
            this.classID = classID;
        }

        private void fEditClass_Load(object sender, EventArgs e)
        {
            classmain = db.Classes.Single(p => p.ClassID == classID);
            Text += " - Mã ngành " + classmain.ClassID.ToString();
            txtClass.Text = classmain.NameClass.ToString();

            cbBranch.DisplayMember = "NameBranch";
            cbBranch.ValueMember = "BranchID";
            long idbranch = classmain.BranchID;
            cbBranch.DataSource = db.Branches.Select(p => new
            {
                p.BranchID,
                p.NameBranch
            }).ToList();
            branch = db.Branches.Single(p => p.BranchID == idbranch);
            cbBranch.Text = branch.NameBranch.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
               
                int kiemtra = db.Classes.Where(p => p.NameClass == txtClass.Text).Count();
                if (kiemtra > 0)
                {
                    MessageBox.Show("Đã tồn tại " + txtClass.Text);
                    cbBranch.Text = null;
                    txtClass.Text = null;
                    txtClass.Focus();
                } else {
                    classmain.BranchID = Convert.ToInt64(cbBranch.SelectedValue);
                    classmain.NameClass = txtClass.Text;
                    db.SaveChanges();
                    cbBranch.Text = null;
                    txtClass.Text = null;
                    toolTip1.Show("Lưu thành công", btnSave, 0, 0, 1000);
                }
            } catch(Exception ex)
            {
                toolTip1.Show("Lưu thất bại " + ex, btnSave , 0, 0, 1000);
            }
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
    }
}
