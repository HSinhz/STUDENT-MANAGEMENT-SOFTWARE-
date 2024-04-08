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
    public partial class fEditSubject : Form
    {
        Subject subject;
        long subjectID;
        EFDbContext db = new EFDbContext();
        public fEditSubject(long subjectID)
        {
            InitializeComponent();
            this.subjectID = subjectID;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fEditSubject_Load(object sender, EventArgs e)
        {
            subject = db.Subjects.Single( p => p.SubjectID == subjectID );
            Text += " - Mã môn học " + subject.SubjectID.ToString();
            txtNameSubject.Text = subject.SubjectName;
            mCreditSubject.Text = subject.SubjectCredit.ToString();
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
                toolTip1.Show("Vui lòng nhập số tín chủ", mCreditSubject, 0, 0, 1000);
                mCreditSubject.Focus();
                return;
            }

            int kiemtra = db.Subjects.Where(p => p.SubjectName == txtNameSubject.Text).Count();
            if (kiemtra > 0)
            {
                MessageBox.Show("Môn " + txtNameSubject.Text + " đã tồn tại");
                txtNameSubject.Text = "";
                mCreditSubject.Text = "";
                txtNameSubject.Focus();
            }
            else
            {
                subject.SubjectName = txtNameSubject.Text;
                subject.SubjectCredit = Convert.ToInt32(mCreditSubject.Text);
                
                db.SaveChanges();
                txtNameSubject.Text = "";
                mCreditSubject.Text = "";
                txtNameSubject.Focus();
                toolTip1.Show("Lưu thành công ", btnSave, 0, 0, 1000);
            }
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

        private void txtNameSubject_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNameSubject.Text))
            {
                toolTip1.Show("Vui lòng nhập tên môn học", txtNameSubject, 0, 0, 1000);
                e.Cancel = true;
            }
        }
    }
}
