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
    public partial class fNewStudentInSubject : Form
    {
        Term term;
        public fNewStudentInSubject()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

                if( string.IsNullOrWhiteSpace( cbNameSubject.Text ) )
                {
                    toolTip1.Show("Vui lòng chọn lớp học", cbNameSubject, 0, 0, 1000);
                    cbNameSubject.Focus();
                    return;
                }
            if (string.IsNullOrWhiteSpace(cbNameStudent.Text))
            {
                toolTip1.Show("Vui lòng chọn sinh viên", cbNameStudent, 0, 0, 1000);
                cbNameStudent.Focus();
                return;
            }


            term = new Term();
                term.SubjectID = Convert.ToInt32(cbNameSubject.SelectedValue);
                term.StudentID = Convert.ToInt64(cbNameStudent.SelectedValue);
                term.NameStudent = cbNameStudent.Text;
                using( var db = new EFDbContext())
                {
                    if( db.Terms.SingleOrDefault(o => o.SubjectID == term.SubjectID && o.StudentID == term.StudentID ) != null)
                    {
                        toolTip1.Show("Sinh viên đã có trong lớp học này ", cbNameStudent, 0, 0, 1000);
                        cbNameStudent.Focus();
                        return;
                    } 
                    db.Terms.Add(term);
                    db.SaveChanges();
                }
                toolTip1.Show("Thêm thành công " , btnSave, 0, 0, 1000);
                cbNameStudent.Text = null;
                cbNameSubject.Text = null;
            
        }

        private void fNewStudentInSubject_Load(object sender, EventArgs e)
        {
            cbNameSubject.DisplayMember = "SubjectName";
            cbNameSubject.ValueMember = "SubjectID";
            using (var db = new EFDbContext())
            {
                cbNameSubject.DataSource = db.Subjects.Select(p => new
                {
                    p.SubjectID,
                    p.SubjectName
                }).ToList();
            }
            cbNameStudent.DisplayMember = "NameStudent";
            cbNameStudent.ValueMember = "StudentID";
            using (var db = new EFDbContext())
            {
                cbNameStudent.DataSource = db.Students.Select(p => new
                {
                    p.StudentID,
                    p.NameStudent
                }).ToList();
            }
            cbNameSubject.Text = null;
            cbNameStudent.Text = null;
        }
    }
}
