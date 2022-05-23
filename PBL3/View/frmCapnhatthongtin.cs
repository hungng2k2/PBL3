using PBL3.BLL;
using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.View
{
    public partial class frmCapNhatThongTin : Form
    {
        public string id { get; set; }
        public frmCapNhatThongTin(string _id)
        {
            InitializeComponent();
            id = _id;
        }
        private void frmCapnhatthongtin_Load(object sender, EventArgs e)
        {
            NhanVien nv = BLLNhanVien.Instance.GetById(id);
            txtID.Text = nv.id_NhanVien;
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
        }

        private void iconButtonCapnhat_Click(object sender, EventArgs e)
        {
            NhanVien nv = BLLNhanVien.Instance.GetById(id);
            BLLNhanVien.Instance.ExecuteAddUpdate(new NhanVien
            {
                id_NhanVien = nv.id_NhanVien,
                TenNhanVien = txtTen.Text,
                NgaySinh = dateTimePicker1.Value,
                GioiTinh = nv.GioiTinh,
                SoDienThoai = txtSdt.Text,
                DiaChi = txtDiachi.Text,
                Username = nv.Username,
                ChucVu = nv.ChucVu,
                Password = nv.Password,
            });
            MessageBox.Show("Cập nhật thông tin thành công");
            this.Close();
        }

        private void iconButtonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
