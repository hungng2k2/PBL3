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
            txtMaNhanVien.Enabled = false;
            EditorEnable(false);
            Reload();
            dgvDSNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSNhanVien.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }

        private void Reload()
        {
            dgvDSNhanVien.DataSource = BLLNhanVien.Instance.GetAll();
        }

        public void EditorEnable(bool b)
        {
            txtTenNhanVien.Enabled=b;
            txtSoDienThoai.Enabled=b;
            txtDiaChi.Enabled = b;
            dpNgaySinh.Enabled=b;
            cbGioiTinh.Enabled=b;
            btnLuu.Enabled = b;
            btnHuy.Enabled = b;
            btnThem.Enabled = !b;
            btnSua.Enabled = !b;
            btnXoa.Enabled = !b;
            dgvDSNhanVien.Enabled = !b;
        }

        public void EditorReset()
        {
            txtMaNhanVien.Text = "";
            txtDiaChi.Text = "";
            txtSoDienThoai.Text = "";
            txtTenNhanVien.Text = "";
            cbGioiTinh.Text = "";
            dpNgaySinh.Value = DateTime.Now;
        }

        private void dgvDSNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDSNhanVien.SelectedRows.Count == 1)
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            EditorReset();
            EditorEnable(true);
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if(dgvDSNhanVien.SelectedRows.Count == 1)
            {
                EditorEnable(true);
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            BLLNhanVien.Instance.ExecuteAddUpdate(new NhanVien
            {
                Id = txtMaNhanVien.Text,
                Ten = txtTenNhanVien.Text,
                NgaySinh = dpNgaySinh.Value,
                GioiTinh = cbGioiTinh.SelectedItem.ToString(),
                SoDienThoai = txtSoDienThoai.Text,
                DiaChi = txtDiaChi.Text
            });
            EditorReset();
            EditorEnable(false);
            Reload();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDSNhanVien.SelectedRows.Count == 1)
            {
                string id = dgvDSNhanVien.SelectedRows[0].Cells["Id"].Value.ToString();
                BLLNhanVien.Instance.Delete(id);
                Reload();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            EditorReset();
            EditorEnable(false);
        }

        
    }
}
