using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.BLL;
using PBL3.DTO;

namespace PBL3.View
{
    public partial class frmThongtintk : Form
    {
        string id = "";
        public frmThongtintk(string a)
        {
            InitializeComponent();
            id = a;
        }

        private void frmThongtintk_Load(object sender, EventArgs e)
        {
            // get id from login form and show information of user
            //MessageBox.Show(id);
            NhanVien nv = BLLNhanVien.Instance.GetById(id);
            txtTen.Text = nv.TenNhanVien;
            txtChucvu.Text = nv.ChucVu;
            txtDiachi.Text = nv.DiaChi;
            txtSdt.Text = nv.SoDienThoai;
            dateTimePicker1.Value = nv.NgaySinh;
            if ((bool)nv.GioiTinh)
            {
                txtGioitinh.Text = "Nam";
            }
            else
            {
                txtGioitinh.Text = "Nữ";
            }
            txtUsername.Text = nv.Username;
            txtPassword.Text = nv.Password;

        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            frmDoiMK frm = new frmDoiMK(id);
            frm.ShowDialog();
        }

        private void butCapnhat_Click(object sender, EventArgs e)
        {
            frmCapnhatthongtin frm = new frmCapnhatthongtin(id);
            frm.ShowDialog();
        }
        
    }
}
