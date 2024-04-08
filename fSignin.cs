using Project_Windows;
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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project_Windows
{
    public partial class fSignin : Form
    {
        Account account;
        
        //DBConnect database = new DBConnect();
        public fSignin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                toolTip1.Show("Vui lòng nhập tên đăng nhập", txtUserName, 0, 0, 1000);
                txtUserName.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                toolTip1.Show("Vui lòng nhập mật khẩu", txtPassword, 0, 0, 1000);
                txtPassword.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtConfirmPass.Text))
            {
                toolTip1.Show("Vui lòng nhập lại mật khẩu", txtConfirmPass, 0, 0, 1000);
                txtConfirmPass.Focus();
                return;
            }
            else if (txtConfirmPass.Text != txtPassword.Text)
            {
                toolTip1.Show("Mật khẩu không trùng khớp", txtConfirmPass, 0,0 , 1000);
                txtConfirmPass.Focus();
                return;
            }
            else
            {
                using ( var db = new EFDbContext())
                {
                    int kiemtrataikhoan = db.Account.Where( p => p.Username == txtUserName.Text ).Count();
                    //int kiemtramatkhau = db.Account.Where( p => p.Password== txtPassword.Text ).Count();
                    if( kiemtrataikhoan > 0)
                    {
                        txtUserName.Text = null;
                        txtPassword.Text = null;
                        txtConfirmPass.Text = null;
                        toolTip1.Show("Tên đăng nhập đã tồn tại ", txtUserName, 0, 0, 1000);
                        txtUserName.Focus();
                        return;
                    } else
                    {
                        try
                        {
                            account = new Account();
                            account.Username = txtUserName.Text;
                            account.Password = txtPassword.Text;
                            
                            db.Account.Add(account);
                            db.SaveChanges();
                            
                            txtUserName.Text = null;
                            txtPassword.Text = null;
                            txtConfirmPass.Text = null;
                            toolTip1.Show("Đăng kí thành công ", btnSignin, 0, 0, 1000);
                        }
                        catch (Exception ex)
                        {
                            toolTip1.Show("Đăng kí không thành công " + ex.Message, btnSignin, 0, 0, 1000);
                        }
                        txtUserName.Focus();
                    }
                }
                        

            }
        }
                           
    }
    
}

/* try
{
    account = new Account();
    account.Username = txtUserName.Text;
    account.Password = txtPassword.Text;
    using (var db = new EFDbContext())
    {
        db.Account.Add(account);
        db.SaveChanges();
    }
    txtUserName.Text = null;
    txtPassword.Text = null;
    txtConfirmPass.Text = null;
    toolTip1.Show("Đăng kí thành công ", btnSignin, 0, 0, 1000);
}
catch (Exception ex)
{
    toolTip1.Show("Đăng kí không thành công " + ex.Message, btnSignin, 0, 0, 1000);
}
txtUserName.Focus(); */
