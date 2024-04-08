using Project_Windows.Models;

namespace Project_Windows
{
    public partial class fLogin : Form
    {
        Account account;

        public fLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if( string.IsNullOrEmpty(txtUserName.Text) ) 
            {
                toolTip1.Show("Vui lòng nhập tên đăng nhập", txtUserName, 0, 0, 1000);
                txtUserName.Focus();
                return;
            } else if(string.IsNullOrEmpty(txtPassword.Text)) 
            {
                toolTip1.Show("Vui lòng nhập mật khẩu", txtPassword , 0, 0, 1000);
                txtPassword.Focus();
                return;
            } else
            {
                using( var db = new EFDbContext())
                {
                    int kiemtra = db.Account.Where( p => p.Username== txtUserName.Text && p.Password == txtPassword.Text).Count();
                    //int kiemrtramatkhau = db.Account.Where( p => p.Password== txtPassword.Text ).Count();
                    if( kiemtra > 0 )
                    {
                        int RoleID = db.Account.Where(p => p.Username == txtUserName.Text ).Select( p => p.RoleID ).FirstOrDefault();
                        getRoleID( RoleID );
                        Form1 f = new Form1(RoleID);
                        this.Hide();
                        f.ShowDialog();
                        this.Show();
                        txtUserName.Clear();
                        txtPassword.Clear();
                        txtUserName.Focus();
                    } else
                    {

                        MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                        //toolTip1.Show("Sai tên đăng nhập hoặc mật khẩu", txtUserName, 0 , 0, 1000);
                        txtUserName.Clear();
                        txtPassword.Clear();
                        txtUserName.Focus();
                    }
                }
            }




            

        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Xác nhận thoát chương trình", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnsignin_Click(object sender, EventArgs e)
        {
            fSignin f = new fSignin();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        public int getRoleID( int roleid)
        {
            return roleid;
        }
    }
}