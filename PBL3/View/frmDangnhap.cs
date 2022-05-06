using System;
using System.Windows.Forms;

namespace PBL3.View
{
    public partial class frmDangnhap : Form
    {
        public frmDangnhap()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (QLCH.checkLogin(txtUsername.Text, txtPassword.Text) == "QuanLy")
            {
                frmQuanly f = new frmQuanly();
                f.Show();
                this.Hide();
            }
            else if (QLCH.checkLogin(txtUsername.Text, txtPassword.Text) == "NhanVien")
            {
                new frmNhanvien().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                btnLogin_Click(sender,e);
            }
        }
    }
}
