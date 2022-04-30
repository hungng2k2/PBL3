using PBL3.BLL;
using PBL3.DTO;
using System;
using System.Windows.Forms;

namespace PBL3.View
{
    public partial class frmQLNhanvien : Form
    {
        public frmQLNhanvien()
        {
            InitializeComponent();
        }
        private void frmQLNhanvien_Load(object sender, EventArgs e)
        {
            dgvDSNhanVien.DataSource = BLLNhanVien.Instance.GetAll();
            dgvDSNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSNhanVien.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }

        private void dgvDSNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvDSNhanVien.SelectedRows.Count == 1)
            {
                string id = dgvDSNhanVien.SelectedRows[0].Cells["Id"].Value.ToString();
                NhanVien nv = BLLNhanVien.Instance.GetById(id);
                txtMaNhanVien.Text = nv.Id;
                txtTenNhanVien.Text = nv.Ten;
                txtSoDienThoai.Text = nv.SoDienThoai;
                txtDiaChi.Text = nv.DiaChi;
                cbGioiTinh.Text = nv.GioiTinh;
                dpNgaySinh.Value = nv.NgaySinh;
            }
        }

        private void dgvDSNhanVien_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvDSNhanVien.Columns["Id"].HeaderText = "Mã nhân viên";
            dgvDSNhanVien.Columns["Ten"].HeaderText = "Tên nhân viên";
            dgvDSNhanVien.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dgvDSNhanVien.Columns["GioiTinh"].HeaderText = "Giới tính";
            dgvDSNhanVien.Columns["SoDienThoai"].HeaderText = "Số điện thoại";
            dgvDSNhanVien.Columns["DiaChi"].HeaderText = "Địa chỉ";
        }
    }
}
