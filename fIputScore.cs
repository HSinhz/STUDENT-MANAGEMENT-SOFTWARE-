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
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace Project_Windows
{
    public partial class fIputScore : Form
    {
        SubjectScoreDetail subjectScore;
        private int idsubject;
        EFDbContext db = new EFDbContext();
        public fIputScore()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fIputScore_Load(object sender, EventArgs e)
        {
            
            cbNameSubject.DisplayMember = "SubjectName";
            cbNameSubject.ValueMember = "SubjectID";
            cbNameStudent.DisplayMember = "NameStudent";
            cbNameStudent.ValueMember = "StudentID";
            
                cbNameSubject.DataSource = db.Subjects.Select(p => new
                {
                    p.SubjectID,
                    p.SubjectName
                }).ToList();
   
            cbNameSubject.Text = null;
            cbNameStudent.Text = null;
        }

        private void loadListStudent( int idsubject)
        {

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if( string.IsNullOrWhiteSpace(cbNameSubject.Text) )
            {
                toolTip1.Show("Vui lòng chọn môn học", cbNameSubject, 0, 0, 1000);
                cbNameSubject.Focus();
                return;
            }
            if( string.IsNullOrWhiteSpace(cbNameStudent.Text) )
            {
                toolTip1.Show("Vui lòng chọn sinh viên", cbNameStudent, 0, 0, 1000);
                cbNameStudent.Focus();
                return;
            }
            try
            {


                subjectScore = new SubjectScoreDetail();
                subjectScore.SubjectID = Convert.ToInt32(cbNameSubject.SelectedValue);
                subjectScore.StudentID = Convert.ToInt64(cbNameStudent.SelectedValue);
                subjectScore.NameStudent = cbNameStudent.Text;
                if(txtScore1.Text != "")
                {
                    subjectScore.Score1 = Convert.ToDecimal(txtScore1.Text);
                } else
                {
                    subjectScore.Score1 = Convert.ToDecimal(0);
                }

                if(txtScore2.Text != "")
                {
                    subjectScore.Score2 = Convert.ToDecimal(txtScore2.Text);
                } else
                {
                    subjectScore.Score2 = Convert.ToDecimal(0);
                }
               
                
                
                using( var db = new EFDbContext())
                {
                    if( db.SubjectScoreDetails.SingleOrDefault( o => o.SubjectID == subjectScore.SubjectID && o.StudentID == subjectScore.StudentID ) != null)
                    {
                        toolTip1.Show("Sinh viên đã được nhập điểm", cbNameStudent, 0, 0, 1000);
                        cbNameStudent.Focus();
                        return;
                    } 
                    db.SubjectScoreDetails.Add(subjectScore);
                    db.SaveChanges();
                }
                
                toolTip1.Show("Lưu thành công", btnSave, 0, 0, 1000);

            } catch(Exception ex)
            {
                toolTip1.Show("Lưu thất bại " + ex, btnSave, 0, 0, 1000);
            }
        }

        private void mScore1_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            
           
        }

        private void mScore2_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            
        }

        private void fIputScore_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void txtScore2_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtScore2.Text))
            {
                
            }
            else
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

        private void txtScore1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtScore1.Text))
            {
                
            }
            else
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

        private void cbNameSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbNameStudent.DataSource = db.Terms.Where(p => p.SubjectID == Convert.ToInt32(cbNameSubject.SelectedValue)).Select(p => new
            {
                p.StudentID,
                p.NameStudent
            }).ToList();
            cbNameStudent.Text = null;
        }

        private void cbNameStudent_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
