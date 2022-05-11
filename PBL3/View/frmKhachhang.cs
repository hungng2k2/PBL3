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
    public partial class frmKhachhang : Form
    {
        public frmKhachhang()
        {
            InitializeComponent();
        }

        private void frmKhachhang_Load(object sender, EventArgs e)
        {
            txtMaKhachHang.Enabled = false;
            EditorEnable(false);
            Reload();
            dgvDSKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSKhachHang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        public void EditorEnable(bool b)
        {
            txtTenKhachHang.Enabled = b;
            txtSoDienThoai.Enabled = b;
            txtDiaChi.Enabled = b;
            dpNgaySinh.Enabled = b;
            btnLuu.Enabled = b;
            btnHuy.Enabled = b;
            btnThem.Enabled = !b;
            btnSua.Enabled = !b;
            btnXoa.Enabled = !b;
            dgvDSKhachHang.Enabled = !b;
        }
        public void EditorReset()
        {
            txtMaKhachHang.Text = "";
            txtDiaChi.Text = "";
            txtSoDienThoai.Text = "";
            txtTenKhachHang.Text = "";
            rbMale.Checked = false;
            rbFemale.Checked = false;
            dpNgaySinh.Value = DateTime.Now;
        }
        private void dgvDSKhachHang_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDSKhachHang.SelectedRows.Count == 1)
            {
                string id = dgvDSKhachHang.SelectedRows[0].Cells["id_KhachHang"].Value.ToString();
                KhachHang kh = BLLKhachHang.Instance.GetById(id);
                txtMaKhachHang.Text = kh.id_KhachHang;
                txtTenKhachHang.Text = kh.TenKhachHang;
                txtSoDienThoai.Text = kh.SoDienThoai;
                txtDiaChi.Text = kh.DiaChi;
                if (kh.GioiTinh)
                {
                    rbMale.Checked = true;
                }
                else
                {
                    rbFemale.Checked = true;
                }
                dpNgaySinh.Value = kh.NgaySinh;
            }
        }
        private void dgvDSKhachHang_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvDSKhachHang.Columns["id_KhachHang"].HeaderText = "Mã khách hàng";
            dgvDSKhachHang.Columns["TenKhachHang"].HeaderText = "Tên khách hàng";
            dgvDSKhachHang.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dgvDSKhachHang.Columns["GioiTinh"].HeaderText = "Giới tính";
            dgvDSKhachHang.Columns["SoDienThoai"].HeaderText = "Số điện thoại";
            dgvDSKhachHang.Columns["DiaChi"].HeaderText = "Địa chỉ";
        }
        private void Reload()
        {
            dgvDSKhachHang.DataSource = BLLKhachHang.Instance.GetAll();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            EditorReset();
            EditorEnable(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDSKhachHang.SelectedRows.Count == 1)
            {
                string id = dgvDSKhachHang.SelectedRows[0].Cells["id_KhachHang"].Value.ToString();
                DialogResult dr = MessageBox.Show("Bạn muốn xóa khách hàng có ID '" + id + "'?", "Xác nhận xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    BLLKhachHang.Instance.Delete(id);
                    Reload();
                }
            }
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if (dgvDSKhachHang.SelectedRows.Count == 1)
            {
                EditorEnable(true);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            BLLKhachHang.Instance.ExecuteAddUpdate(new KhachHang
            {
                id_KhachHang = txtMaKhachHang.Text,
                TenKhachHang = txtTenKhachHang.Text,
                NgaySinh = dpNgaySinh.Value,
                GioiTinh = rbMale.Checked,
                SoDienThoai = txtSoDienThoai.Text,
                DiaChi = txtDiaChi.Text
            });
            EditorReset();
            EditorEnable(false);
            Reload();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            EditorReset();
            EditorEnable(false);
        }
    }
}
