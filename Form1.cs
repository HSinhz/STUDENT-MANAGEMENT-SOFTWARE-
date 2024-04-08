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
    public partial class Form1 : Form
    {
        private int RoleID;
        public Form1(int roleID)
        {
            InitializeComponent();
            RoleID = roleID;
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            fManagerStudentMain f = new fManagerStudentMain();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            fManagerClass f = new fManagerClass();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fManagerBranch f = new fManagerBranch();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Xác nhận thoát chương trình", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSubject_Click(object sender, EventArgs e)
        {
            fManagerSubject f = new fManagerSubject();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnManagerScore_Click(object sender, EventArgs e)
        {
            fManagerScoreMain f = new fManagerScoreMain();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
                if ( RoleID == 0)
                {
                    btnManager.Enabled= false;
                    button1.Enabled = false;
                    btnClass.Enabled = false;
                    btnSubject.Enabled = false;
                }
               
        }
    }
}
