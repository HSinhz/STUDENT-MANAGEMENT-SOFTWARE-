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
    public partial class fEditScore : Form
    {
        long studentID;
        int subjectID;
        Student student;
        SubjectScoreDetail subjectScoreDetail;
        Subject subject;
        EFDbContext db = new EFDbContext();
        public fEditScore(long studentID, int subjectID)
        {
            InitializeComponent();
            this.studentID = studentID; 
            this.subjectID = subjectID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fEditScore_Load(object sender, EventArgs e)
        {
            student =  db.Students.Single( p => p.StudentID == studentID );
            Text += " - Mã Sinh viên " + student.StudentID.ToString();
            txtStudentId.Text = student.StudentID.ToString();   
            txtNameStudent.Text = student.NameStudent.ToString();
            
            subject =  db.Subjects.Single( p => p.SubjectID== subjectID );
            txtNameSubject.Text = subject.SubjectName.ToString();

            subjectScoreDetail = db.SubjectScoreDetails.Single( p=> p.SubjectID == subjectID && p.StudentID == studentID );
            txtScore1.Text = subjectScoreDetail.Score1.ToString();
            txtScore2.Text = subjectScoreDetail.Score2.ToString();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtScore1.Text != "")
            {
                subjectScoreDetail.Score1 = Convert.ToDecimal(txtScore1.Text);
            }
            else
            {
                subjectScoreDetail.Score1 = Convert.ToDecimal(0);
            }

            if (txtScore2.Text != "")
            {
                subjectScoreDetail.Score2 = Convert.ToDecimal(txtScore2.Text);
            }
            else
            {
                subjectScoreDetail.Score2 = Convert.ToDecimal(0);
            }

            db.SaveChanges();
            toolTip1.Show("Cập nhật thành công thành công", btnSave, 0, 0, 1000);
        }

        private void txtScore1_Validating(object sender, CancelEventArgs e)
        {

            if( string.IsNullOrWhiteSpace(txtScore1.Text))
            {
                
            } else
            {
                if (Convert.ToDecimal(txtScore1.Text) < 0)
                {
                    toolTip1.Show("Điểm phải lớn hơn 0 và bé hơn 10", txtScore1, 0, 0, 1000);
                    e.Cancel = true;
                }
                else if (Convert.ToDecimal(txtScore1.Text) > 10)
                {
                    toolTip1.Show("Điểm phải lớn hơn 0 và bé hơn 10", txtScore1, 0, 0, 1000);
                    e.Cancel = true;
                }
            }
            
        }

        private void fEditScore_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void txtScore2_Validating(object sender, CancelEventArgs e)
        {

            if( string.IsNullOrWhiteSpace(txtScore2.Text) )
            {
                
            } else
            {
                if (Convert.ToDecimal(txtScore2.Text) < 0)
                {
                    toolTip1.Show("Điểm phải lớn hơn 0 và bé hơn 10", txtScore2, 0, 0, 1000);
                    e.Cancel = true;
                }
                else if (Convert.ToDecimal(txtScore2.Text) > 10)
                {
                    toolTip1.Show("Điểm phải lớn hơn 0 và bé hơn 10", txtScore2, 0, 0, 1000);
                    e.Cancel = true;
                }
            }
           
        }
    }
}
