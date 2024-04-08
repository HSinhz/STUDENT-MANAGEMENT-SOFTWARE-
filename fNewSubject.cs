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
    public partial class fNewSubject : Form
    {
        Subject subject;
        public fNewSubject()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if( string.IsNullOrWhiteSpace(txtNameSubject.Text) )
            {
                toolTip1.Show("Vui lòng nhập tên môn học", txtNameSubject, 0, 0, 1000);
                txtNameSubject.Focus();
                return;
            }
            if( string.IsNullOrWhiteSpace(mCreditSubject.Text) )
            {
                toolTip1.Show("Vui lòng nhập số tín chỉ", mCreditSubject, 0, 0, 1000);
                mCreditSubject.Focus();
                return;
            }

            try
            {
                subject = new Subject();
                using( var db = new EFDbContext())
                {
                    int kiemtra = db.Subjects.Where( p => p.SubjectName == txtNameSubject.Text ).Count();
                    if( kiemtra > 0 )
                    {
                        MessageBox.Show("Môn " + txtNameSubject.Text + " đã tồn tại");
                        txtNameSubject.Text = "";
                        mCreditSubject.Text = "";
                        txtNameSubject.Focus();
                    } else
                    {
                        subject.SubjectName = txtNameSubject.Text;
                        subject.SubjectCredit = Convert.ToInt32(mCreditSubject.Text);
                        db.Subjects.Add(subject);
                        db.SaveChanges();
                        txtNameSubject.Text = "";
                        mCreditSubject.Text = "";
                        txtNameSubject.Focus();
                        toolTip1.Show("Lưu thành công ", btnSave, 0, 0, 1000);
                    }
                }
            } catch( Exception ex )
            {
                toolTip1.Show("Lưu không thành công " + ex, btnSave,0, 0, 1000);
            }
            txtNameSubject.Focus();
        }

        private void txtNameSubject_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtNameSubject.Text))
            {
                toolTip1.Show("Vui lòng nhập tên môn học", txtNameSubject, 0, 0, 1000);
                e.Cancel= true;
            }
        }

        private void txtCreditSubject_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void mCreditSubject_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput) //Nếu nhập sai kiểu
            {
                toolTip1.Show("Dữ liệu sai kiểu số nguyên?", mCreditSubject, 0, 0, 1000);
                e.Cancel = true;
            }
            else if ((UInt64)e.ReturnValue < 0 && (UInt64)e.ReturnValue > 7)
            { //Nếu giá trị âm
                toolTip1.Show("Số lượng phải >= 0 và < 7?", mCreditSubject, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void fNewSubject_Load(object sender, EventArgs e)
        {

        }
    }
}
