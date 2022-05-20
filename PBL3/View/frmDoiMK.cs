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
    public partial class frmDoiMK : Form
    {
        string id = "";
        public frmDoiMK(string a)
        {
            InitializeComponent();
            id = a;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NhanVien nv = BLLNhanVien.Instance.GetById(id);
            if (txtMKcu.Text == "" || txtMKmoi.Text == "" || txtNhaplai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                if (txtMKmoi.Text != txtNhaplai.Text)
                {
                    MessageBox.Show("Mật khẩu mới không khớp");
                }
                else
                {
                    if (txtMKcu.Text == txtMKmoi.Text)
                    {
                        MessageBox.Show("Mật khẩu mới không được trùng với mật khẩu cũ");
                    }
                    else
                    {
                        MessageBox.Show("Đổi mật khẩu thành công");
                        nv.Password = txtMKmoi.Text;
                        this.Close();
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
