using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
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
    
    public partial class fManagerStudentMain : Form
    {
        private long branchID;
        private long classID;
        public fManagerStudentMain()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fManagerStudentMain_Load(object sender, EventArgs e)
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

        private void fManagerStudentMain_Activated(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                db.Students.Load();
                dataGridView1.DataSource = db.Students.ToList();
            }
        } 

        private void cbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            branchID = Convert.ToInt64(cbBranch.SelectedValue);
            cbClass.DisplayMember = "NameClass";
            cbClass.ValueMember = "ClassID";

            using (var db = new EFDbContext())
            {
                
                cbClass.DataSource = db.Classes.Where(p => p.BranchID == branchID).Select(p => new
                {
                    p.ClassID,
                    p.NameClass
                }).ToList();
                dataGridView1.DataSource = db.Students.Where(p => p.BranchID == branchID).Select(p => new
                {
                    p.StudentID,
                    p.NameStudent,
                    p.SexStudent,
                    p.AddressStudent,
                    p.BirthDay,
                    p.Phone,
                    p.Email,
                    p.ClassID,
                    p.BranchID
                }).ToList();
               
            }
            
            
            cbClass.Text = null;
        }

        private void cbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            classID = Convert.ToInt64(cbClass.SelectedValue);
            using (var db = new EFDbContext())
            {
                dataGridView1.DataSource = db.Students.Where(p => p.ClassID == classID).Select(p => new
                {
                    p.StudentID,
                    p.NameStudent,
                    p.SexStudent,
                    p.AddressStudent,
                    p.BirthDay,
                    p.Phone,
                    p.Email,
                    p.BranchID,
                    p.ClassID
                }).ToList();
            }

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                
                dataGridView1.DataSource = db.Students.Where(c => c.NameStudent.Contains(txtStudentName.Text)).ToList();
            }
        }

        private void btnAddSV_Click(object sender, EventArgs e)
        {
            fNewStudent f = new fNewStudent();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit123")
            {
                fEditStudent f = new fEditStudent(Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["IDStudent"].Value));
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
        }
    }
}
