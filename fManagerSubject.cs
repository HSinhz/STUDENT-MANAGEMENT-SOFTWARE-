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
    public partial class fManagerSubject : Form
    {
        public fManagerSubject()
        {
            InitializeComponent();
        }

        private void fManagerSubject_Activated(object sender, EventArgs e)
        {
            using( var db = new EFDbContext())
            {
                db.Subjects.Load();
                dataGridView1.DataSource = db.Subjects.ToList();
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            using( var db = new EFDbContext() )
            {
                dataGridView1.DataSource = db.Subjects.Where(c => c.SubjectName.Contains(txtNameSubject.Text)).ToList();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                try
                {
                    long subjectID = Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["SubjectID"].Value);
                    using (var db = new EFDbContext())
                    {
                        Subject subject = db.Subjects.Single(c => c.SubjectID == subjectID);
                        if (MessageBox.Show("Bạn muốn xóa khách hàng " + subject.SubjectName, "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            db.Subjects.Remove(subject);
                            db.SaveChanges();
                            fManagerSubject_Activated(sender, e);
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
                fEditSubject f = new fEditSubject(Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["SubjectID"].Value));
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            fNewSubject f = new fNewSubject();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnAddSTinTerm_Click(object sender, EventArgs e)
        {
            fNewStudentInSubject f = new fNewStudentInSubject();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
