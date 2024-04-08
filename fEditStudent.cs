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
using System.Text.RegularExpressions;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_Windows
{
    public partial class fEditStudent : Form
    {
        Student student;
        Branch branch;
        Class lop;
        long StudentID;
        EFDbContext db = new EFDbContext();
        public fEditStudent(long StudentID)
        {
            InitializeComponent( );
            this.StudentID = StudentID;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fEditStudent_Load(object sender, EventArgs e)
        {
            student = db.Students.Single( p => p.StudentID == StudentID );
            Text += " - Mã Sinh viên " + student.StudentID.ToString();
            txtNameStudent.Text = student.NameStudent;
            txtSex.Text = student.SexStudent;
            dtBirthDay.Text = student.BirthDay.ToString(); 
            txtPhone.Text= student.Phone;
            txtEmail.Text = student.Email;
            txtAddressStudent.Text = student.AddressStudent;

            // Xử lý đổ dữ liệu vào cbBranch
            cbBranch.DisplayMember = "NameBranch";
            cbBranch.ValueMember = "BranchID";
            int idbranch = student.BranchID;
            cbBranch.DataSource = db.Branches.Select( p => new
            {
                p.BranchID,
                p.NameBranch
            }).ToList();
            branch = db.Branches.Single( p => p.BranchID == idbranch );
            cbBranch.Text = branch.NameBranch.ToString();

            // Xử lý đổ dữ liệu vào cbClass
            cbClass.DisplayMember = "NameClass";
            cbClass.ValueMember = "ClassID";
            int idclass = student.ClassID;
            cbClass.DataSource = db.Classes.Select(p => new
            {
                p.ClassID,
                p.NameClass
            }).ToList();
            lop = db.Classes.Single( p => p.ClassID == idclass );
            cbClass.Text = lop.NameClass.ToString();
        }

        private void fEditStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                student.NameStudent = txtNameStudent.Text;
                student.SexStudent = txtSex.Text;
                student.AddressStudent = txtAddressStudent.Text;
                student.BirthDay = dtBirthDay.Value.Date;
                student.Phone = txtPhone.Text;
                student.Email = txtEmail.Text;
                student.BranchID = Convert.ToInt32(cbBranch.SelectedValue);
                student.ClassID = Convert.ToInt32(cbClass.SelectedValue);
                
                
                db.SaveChanges();
                
                txtNameStudent.Clear();
                txtSex.Clear();
                txtAddressStudent.Clear();
                txtPhone.Clear();
                txtEmail.Clear();
                cbBranch.Text = null;
                cbClass.Text = null;
                toolTip1.Show("Lưu thành công", btnSave, 0, 0, 1000);

            }
            catch (Exception ex)
            {
                toolTip1.Show("Lưu thất bại? Error: " + ex.Message, btnSave, 0, 0, 1000);
            }
        }

        private void txtNameStudent_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNameStudent.Text))
            {
                toolTip1.Show("Vui lòng nhập mã sinh viên", txtNameStudent, 0, 0, 1000);
                e.Cancel = true;
            }
            else if (txtNameStudent.Text.Length > 100)
            {
                toolTip1.Show("Tên khách hàng <= 100 ký tự?", txtNameStudent, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void txtSex_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSex.Text))
            {
                toolTip1.Show("Vui lòng nhập giới tính", txtSex, 0, 0, 1000);
                e.Cancel= true;
            } else if ( txtSex.Text != "Nam" || txtSex.Text != "Nữ" || txtSex.Text != "Khác")
            {
                toolTip1.Show("Giới tính là Nam, Nữ hoặc Khác", txtSex, 0 , 0, 1000);
                e.Cancel= true;
            }
        }

        private void dtBirthDay_Validating(object sender, CancelEventArgs e)
        {
            if (dtBirthDay.Value.Date > DateTime.Now.Date)
            {
                toolTip1.Show("Ngày/tháng/năm <= hiện tại?", dtBirthDay, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPhone.Text))
            {
                toolTip1.Show("Vui lòng nhập số điện thoại", txtPhone, 0, 0, 1000); txtPhone.Focus();
                e.Cancel = true;
            }
            if (Regex.IsMatch(txtPhone.Text, @"\d{10}") && txtPhone.Text.Length == 10)
                return;
            if (Regex.IsMatch(txtPhone.Text, @"\d{11}") && txtPhone.Text.Length == 11)
                return;
            toolTip1.Show("Không đúng dạng số điện thoại?", txtPhone, 0, 0, 1000);
            e.Cancel = true;
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                toolTip1.Show("Vui lòng nhập Email", txtEmail, 0, 0, 1000);
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(txtEmail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                toolTip1.Show("Không đúng dạng địa chỉ email?", txtEmail, 0, 0,
               1000);
                e.Cancel = true;
            }
            else if (txtEmail.Text.Length > 100)
            {
                toolTip1.Show("Địa chỉ email <= 100 ký tự?", txtEmail, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void txtAddressStudent_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtAddressStudent.Text))
            {
                toolTip1.Show("Vui lòng nhập địa chỉ", txtAddressStudent, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void cbBranch_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cbBranch.Text))
            {
                toolTip1.Show("Vui lòng chọn ngành", cbBranch, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void cbClass_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cbClass.Text))
            {
                toolTip1.Show("Vui lòng chọn lớp", cbClass, 0, 0, 1000);
                e.Cancel = true;
            }
        }
    }
}
