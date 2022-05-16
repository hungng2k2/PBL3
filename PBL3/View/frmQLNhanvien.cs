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
            txtTenNhanVien.Enabled = b;
            txtSoDienThoai.Enabled = b;
            txtDiaChi.Enabled = b;
            dpNgaySinh.Enabled = b;
            groupBox2.Enabled = b;
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
            rbMale.Checked = false;
            rbFemale.Checked = false;
            dpNgaySinh.Value = DateTime.Now;
        }

        private void dgvDSNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDSNhanVien.SelectedRows.Count == 1)
            {
                string id = dgvDSNhanVien.SelectedRows[0].Cells["id_NhanVien"].Value.ToString();
                NhanVien nv = BLLNhanVien.Instance.GetById(id);
                txtMaNhanVien.Text = nv.id_NhanVien;
                txtTenNhanVien.Text = nv.TenNhanVien;
                txtSoDienThoai.Text = nv.SoDienThoai;
                txtDiaChi.Text = nv.DiaChi;
                if ((bool)nv.GioiTinh)
                {
                    rbMale.Checked = true;
                }
                else
                {
                    rbFemale.Checked = true;
                }
                dpNgaySinh.Value = nv.NgaySinh;
            }
        }

        private void dgvDSNhanVien_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvDSNhanVien.Columns["id_NhanVien"].HeaderText = "Mã nhân viên";
            dgvDSNhanVien.Columns["TenNhanVien"].HeaderText = "Tên nhân viên";
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
            if (dgvDSNhanVien.SelectedRows.Count == 1)
            {
                EditorEnable(true);
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            BLLNhanVien.Instance.ExecuteAddUpdate(new NhanVien
            {
                id_NhanVien = txtMaNhanVien.Text,
                TenNhanVien = txtTenNhanVien.Text,
                NgaySinh = dpNgaySinh.Value,
                GioiTinh = rbMale.Checked,
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
                string id = dgvDSNhanVien.SelectedRows[0].Cells["id_NhanVien"].Value.ToString();
                DialogResult dr = MessageBox.Show("Bạn muốn xóa nhân viên có ID '" + id + "'?", "Xác nhận xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    BLLNhanVien.Instance.Delete(id);
                    Reload();
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            EditorReset();
            EditorEnable(false);
        }


    }
}
