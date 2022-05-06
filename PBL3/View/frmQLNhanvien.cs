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
            //cbGioiTinh.Enabled = b;
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
                string id = dgvDSNhanVien.SelectedRows[0].Cells["MANV"].Value.ToString();
                Nhanvien nv = BLLNhanVien.Instance.GetById(id);
                txtMaNhanVien.Text = nv.MANV;
                txtTenNhanVien.Text = nv.TENNV;
                txtSoDienThoai.Text = nv.SDT;
                txtDiaChi.Text = nv.DIACHI;
                if ((bool)nv.GIOITINH)
                {
                    rbMale.Checked = true;
                }
                else
                {
                    rbFemale.Checked = true;
                }
                dpNgaySinh.Value = nv.NGAYSINH.Value;
            }
        }

        private void dgvDSNhanVien_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvDSNhanVien.Columns["MANV"].HeaderText = "Mã nhân viên";
            dgvDSNhanVien.Columns["TENNV"].HeaderText = "Tên nhân viên";
            dgvDSNhanVien.Columns["NGAYSINH"].HeaderText = "Ngày sinh";
            dgvDSNhanVien.Columns["GIOITINH"].HeaderText = "Giới tính";
            dgvDSNhanVien.Columns["SDT"].HeaderText = "Số điện thoại";
            dgvDSNhanVien.Columns["DIACHI"].HeaderText = "Địa chỉ";
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
            BLLNhanVien.Instance.ExecuteAddUpdate(new Nhanvien
            {
                MANV = txtMaNhanVien.Text,
                TENNV = txtTenNhanVien.Text,
                NGAYSINH = dpNgaySinh.Value,
                GIOITINH = rbMale.Checked,
                SDT = txtSoDienThoai.Text,
                DIACHI = txtDiaChi.Text
            });
            EditorReset();
            EditorEnable(false);
            Reload();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDSNhanVien.SelectedRows.Count == 1)
            {
                string id = dgvDSNhanVien.SelectedRows[0].Cells["MANV"].Value.ToString();
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
