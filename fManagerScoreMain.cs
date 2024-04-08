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
    public partial class fManagerScoreMain : Form
    {
        private long subjectID;
        private string name;
        EFDbContext db = new EFDbContext();
        public fManagerScoreMain()
        {
            InitializeComponent();
        }

        private void fManagerScoreMain_Load(object sender, EventArgs e)
        {
            cbNameSubject.DisplayMember = "SubjectName";
            cbNameSubject.ValueMember = "SubjectID";

            cbNameSubject.DataSource = db.Subjects.Select(p => new
            {
                p.SubjectID,
                p.SubjectName
            }).ToList();


            cbNameSubject.Text = null;
        }

        private void btnAddScore_Click(object sender, EventArgs e)
        {
            fIputScore f = new fIputScore();
            this.Hide();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void loadSubjectScore()
        {
            var details = db.SubjectScoreDetails.Where(d => d.SubjectID == subjectID).Select(d => new
            {
                d.SubjectID,
                d.StudentID,
                d.Subject.SubjectName,
                d.Student.NameStudent,
                d.Score1,
                d.Score2,

            }).ToList();
            List<SubjectScoreDetailAndStudent> list = new List<SubjectScoreDetailAndStudent>();
            foreach (var d in details)
            {
                SubjectScoreDetailAndStudent detail = new SubjectScoreDetailAndStudent();
                detail.SubjectID = d.SubjectID;
                detail.SubjectName = d.SubjectName;
                detail.StudentID = d.StudentID;
                detail.NameStudent = d.NameStudent;
                detail.Score1 = d.Score1;
                detail.Score2 = d.Score2;
                decimal xeploai = (d.Score1 + d.Score2) / 2 ;
                if (xeploai >= Convert.ToDecimal(3.5) && xeploai < 5)
                {
                    detail.Xeploai = "Yếu";
                }
                else if (xeploai >= 5 && xeploai <  Convert.ToDecimal(6.5))
                {
                    detail.Xeploai = "Trung bình";
                } else if( xeploai >= Convert.ToDecimal(6.5) && xeploai < 8)
                {
                    detail.Xeploai = "Khá";
                } else if( xeploai >= 8)
                {
                    detail.Xeploai = "Giỏi";
                } else if( xeploai < Convert.ToDecimal(3.5))
                {
                    detail.Xeploai = "Kém";
                }
                
                list.Add(detail);
            }
            dataGridView1.DataSource = list;
            cbNameSubject.Focus();
        }

        private void cbNameSubject_SelectionChangeCommitted(object sender, EventArgs e)
        {
            subjectID = Convert.ToInt64(cbNameSubject.SelectedValue);
            loadSubjectScore();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            name = txtNameStudent.Text;
            var details = db.SubjectScoreDetails.Where(d => d.Student.NameStudent.Contains(name)).Select(d => new
            {
                d.SubjectID,
                d.StudentID,
                d.Subject.SubjectName,
                d.Student.NameStudent,
                d.Score1,
                d.Score2,

            }).ToList();
            List<SubjectScoreDetailAndStudent> list = new List<SubjectScoreDetailAndStudent>();
            foreach (var d in details)
            {
                SubjectScoreDetailAndStudent detail = new SubjectScoreDetailAndStudent();
                detail.SubjectID = d.SubjectID;
                detail.SubjectName = d.SubjectName;
                detail.StudentID = d.StudentID;
                detail.NameStudent = d.NameStudent;
                detail.Score1 = d.Score1;
                detail.Score2 = d.Score2;
                decimal xeploai = (d.Score1 + d.Score2) / 2 ;
                if (xeploai >= Convert.ToDecimal(3.5) && xeploai < 5)
                {
                    detail.Xeploai = "Yếu";
                }
                else if (xeploai >= 5 && xeploai < Convert.ToDecimal(6.5))
                {
                    detail.Xeploai = "Trung bình";
                }
                else if (xeploai >= Convert.ToDecimal(6.5) && xeploai < 8)
                {
                    detail.Xeploai = "Khá";
                }
                else if (xeploai >= 8)
                {
                    detail.Xeploai = "Giỏi";
                }
                else if (xeploai < Convert.ToDecimal(3.5))
                {
                    detail.Xeploai = "Kém";
             
                }
                list.Add(detail);
            }
            dataGridView1.DataSource = list; 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
            {
                fEditScore f = new fEditScore(Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["StudentID"].Value), Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["SubjectID"].Value));
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cbNameSubject_SelectionChangeCommitted(sender, e);
        }
    }
}
