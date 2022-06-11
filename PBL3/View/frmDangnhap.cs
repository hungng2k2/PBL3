using System;
using System.Windows.Forms;
using PBL3.BLL;

namespace PBL3.View
{
    public partial class frmDangnhap : Form
    {
        public frmDangnhap()
        {
            InitializeComponent();
        }

        public void btnLogin_Click(object sender, EventArgs e)
        {
            string id = "";
            if (BLLNhanVien.Instance.checkLogin(txtUsername.Text, txtPassword.Text) == "QuanLy")
            {
                id = BLLNhanVien.Instance.GetIDByUsername(txtUsername.Text);
                frmQuanly f = new frmQuanly(id);
                f.Show();
                this.Hide();
            }
            else if (BLLNhanVien.Instance.checkLogin(txtUsername.Text, txtPassword.Text) == "NhanVien")
            {
                id = BLLNhanVien.Instance.GetIDByUsername(txtUsername.Text);
                new frmNhanvien(id).Show();
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
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void butShowpass_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != "")
            {
                if (txtPassword.PasswordChar == '*')
                {
                    txtPassword.PasswordChar = '\0';
                }
                else
                {
                    txtPassword.PasswordChar = '*';
                }

            }
        }
    }
}
