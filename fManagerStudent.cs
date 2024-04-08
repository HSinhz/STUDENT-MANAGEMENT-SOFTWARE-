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


namespace Project_Windows
{
    public partial class fManagerStudent : Form
    {
        private long branchID;
        private long classID;
        public fManagerStudent()
        {
            InitializeComponent();
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fManagerStudent_Load(object sender, EventArgs e)
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
            using (var db = new EFDbContext())
            {
                cbClass.DataSource = db.Classes.Select(c => new
                {
                    c.ClassID,
                    c.NameClass
                }).ToList();
            }

            cbBranch.Text = null;
            cbClass.Text = null;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fManagerStudent_Activated(object sender, EventArgs e)
        {
            using( var db = new EFDbContext())
            {
                dataGridView1.DataSource = db.Students.ToList();
            }
        }

        private void cbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            using( var db = new EFDbContext() )
            {
                branchID = Convert.ToInt64(cbBranch.SelectedValue);
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
                }).ToList();
            }
        }

        private void cbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            classID = Convert.ToInt64(cbClass.SelectedValue);
            using( var db = new EFDbContext() )
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
                }).ToList();
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                dataGridView1.DataSource = db.Students.Where( c => c.NameStudent.Contains(txtStudentName.Text)).ToList();
            }
        }

        private void btnAddSV_Click(object sender, EventArgs e)
        {
            fNewStudent f = new fNewStudent();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
