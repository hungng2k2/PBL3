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
    public partial class frmThongTinTaiKhoan : Form
    {
        public string id { get; set; }
        public frmThongTinTaiKhoan(string a)
        {
            InitializeComponent();
            id = a;
        }

        private void frmThongTinTaiKhoan_Load(object sender, EventArgs e)
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
            frmDoiMatKhau frm = new frmDoiMatKhau(id);
            frm.ShowDialog();
        }

        private void butCapnhat_Click(object sender, EventArgs e)
        {
            frmCapNhatThongTin frm = new frmCapNhatThongTin(id);
            frm.ShowDialog();
        }
        
    }
}
