using Project_Windows.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Project_Windows
{
    public partial class fNewStudent : Form
    {
        Student student;
        public fNewStudent()
        {
            InitializeComponent();
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        private void fNewStudent_Load(object sender, EventArgs e)
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNameStudent.Text))
            {
                toolTip1.Show("Vui lòng ", txtNameStudent, 0, 0, 1000);
                txtNameStudent.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSex.Text))
            {
                toolTip1.Show("Vui lòng nhập giới tính", txtSex, 0, 0, 1000);
                txtSex.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                toolTip1.Show("Vui lòng nhập số điện thoại", txtPhone, 0, 0, 1000); 
                txtPhone.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                toolTip1.Show("Vui lòng nhập Email", txtEmail, 0, 0, 1000);
               txtEmail.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(cbBranch.Text))
            {
                toolTip1.Show("Vui lòng chọn ngành", cbBranch, 0, 0, 1000);
                cbBranch.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(cbClass.Text))
            {
                toolTip1.Show("Vui lòng chọn lớp", cbClass, 0, 0, 1000);
                cbClass.Focus();
                return;
            }
            try
            {
                student = new Student();
                
                student.NameStudent = txtNameStudent.Text;
                student.SexStudent = txtSex.Text;
                student.AddressStudent = txtAddressStudent.Text;
                student.BirthDay = dtBirthDay.Value.Date;
                student.Phone = txtPhone.Text;
                student.Email = txtEmail.Text;
                student.BranchID = Convert.ToInt32 (cbBranch.SelectedValue);
                student.ClassID = Convert.ToInt32(cbClass.SelectedValue);
                using( var db = new EFDbContext())
                {
                    db.Students.Add(student);
                    db.SaveChanges();
                }
                txtNameStudent.Text = " ";
                txtSex.Text = "";
                txtAddressStudent.Text = "";
                txtPhone.Text = "";
                cbBranch.Text = "";
                cbClass.Text = "";
                toolTip1.Show("Lưu thành công" , btnSave, 0, 0, 1000);
            
            } catch( Exception ex )
            {
                toolTip1.Show("Lưu thất bại? Error: " + ex.Message, btnSave, 0, 0, 1000);
            }
            txtNameStudent.Focus();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtBirthDay_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtNameStudent_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNameStudent.Text))
            {
                toolTip1.Show("Vui lòng nhập tên sinh viên", txtNameStudent, 0, 0, 1000);
                e.Cancel = true;
            } else if (txtNameStudent.Text.Length > 100)
            {
                toolTip1.Show("Tên sinh viên <= 100 ký tự?", txtNameStudent, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void txtSex_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSex.Text))
            {
                toolTip1.Show("Vui lòng nhập giới tính", txtSex, 0, 0, 1000);
                e.Cancel = true;
            } 
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
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
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                toolTip1.Show("Vui lòng nhập Email", txtEmail, 0, 0, 1000);
                e.Cancel= true;
            } else if (!Regex.IsMatch(txtEmail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
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
            if (string.IsNullOrWhiteSpace(txtAddressStudent.Text))
            {
                toolTip1.Show("Vui lòng nhập địa chỉ", txtAddressStudent, 0, 0, 1000);
                e.Cancel = true;
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

        private void cbBranch_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbBranch.Text))
            {
                toolTip1.Show("Vui lòng chọn ngành", cbBranch, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void cbClass_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbClass.Text))
            {
                toolTip1.Show("Vui lòng chọn lớp", cbClass, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void fNewStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
    }
}
