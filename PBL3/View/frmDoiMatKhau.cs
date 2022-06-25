using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.DTO;
using PBL3.BLL;

namespace PBL3.View
{
    public partial class frmDoiMatKhau : Form
    {
        string id = "";
        public frmDoiMatKhau(string a)
        {
            InitializeComponent();
            id = a;
        }
        private void iconButtonCapnhat_Click(object sender, EventArgs e)
        {
            NhanVien nv = BLLNhanVien.Instance.GetById(id);
            if (txtMKcu.Text == "" || txtMKmoi.Text == "" || txtNhaplai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                if (txtMKcu.Text != nv.Password)
                {
                    MessageBox.Show("Mật khẩu không chính xác!");
                }
                else
                {
                    if (txtMKmoi.Text != txtNhaplai.Text)
                    {
                        MessageBox.Show("Mật khẩu mới không khớp");
                    }
                    else
                    {
                        if (nv.Password == txtMKmoi.Text)
                        {
                            MessageBox.Show("Mật khẩu mới không được trùng với mật khẩu cũ");
                        }
                        else
                        {
                            MessageBox.Show("Đổi mật khẩu thành công");
                            nv.Password = txtMKmoi.Text;
                            if (BLLNhanVien.Instance.ExecuteAddUpdate(nv))
                            {
                                MessageBox.Show("Cập nhật cơ sở dữ liệu thành công!");
                            }
                            else
                            {
                                MessageBox.Show("Cập nhật cơ sở dữ liệu thất bại!");
                            }
                            this.Close();
                        }
                    }
                }
            }
        }

        private void iconButtonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butShowPassOld_Click(object sender, EventArgs e)
        {
            if (txtMKcu.Text != "")
            {
                if (txtMKcu.PasswordChar == '*')
                {
                    txtMKcu.PasswordChar = '\0';
                }
                else
                {
                    txtMKcu.PasswordChar = '*';
                }

            }
        }

        private void butShowPassNew_Click(object sender, EventArgs e)
        {
            if (txtMKmoi.Text != "")
            {
                if (txtMKmoi.PasswordChar == '*')
                {
                    txtMKmoi.PasswordChar = '\0';
                }
                else
                {
                    txtMKmoi.PasswordChar = '*';
                }

            }
        }

    }
}
