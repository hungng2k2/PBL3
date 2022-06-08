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
            lbTen.Text = nv.TenNhanVien;
            if (nv.ChucVu == "QuanLy")
                lbChucvu.Text = "Quản Lý";
            else
                lbChucvu.Text = "Nhân Viên";
            lbDc.Text = nv.DiaChi;
            lbSdt.Text = nv.SoDienThoai;
            lbDate.Text = nv.NgaySinh.ToString("dd/MM/yyyy");
            if ((bool)nv.GioiTinh)
            {
                lbGioitinh.Text = "Nam";
            }
            else
            {
                lbGioitinh.Text = "Nữ";
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
