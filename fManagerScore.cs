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
    public partial class fManagerScore : Form
    {
        private long subjectID;
        EFDbContext db = new EFDbContext();
        public fManagerScore()
        {
            InitializeComponent();
        }

        private void btnAddScore_Click(object sender, EventArgs e)
        {
            fIputScore f = new fIputScore();
            this.Hide();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void fManagerScore_Load(object sender, EventArgs e)
        {
            cbNameSubject.DisplayMember= "SubjectName";
            cbNameSubject.ValueMember= "SubjectID";
           
            cbNameSubject.DataSource = db.Subjects.Select(p => new
            {
                p.SubjectID,
                p.SubjectName
            }).ToList();

           
            cbNameSubject.Text = null;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbNameSubject_SelectionChangeCommitted(object sender, EventArgs e)
        {
            subjectID = Convert.ToInt64(cbNameSubject.SelectedValue);
            loadSubjectScore();
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
            foreach( var d in details)
            {
                SubjectScoreDetailAndStudent detail = new SubjectScoreDetailAndStudent();
                detail.SubjectID = d.SubjectID;
                detail.SubjectName = d.SubjectName;
                detail.StudentID = d.StudentID;
                detail.NameStudent = d.NameStudent;
                detail.Score1= d.Score1;
                detail.Score2= d.Score2;
                list.Add(detail);
            }
            dt123.DataSource = list;
            cbNameSubject.Focus();
        }
    }
}
