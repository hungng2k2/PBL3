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
                string id = dgvDSKhachHang.SelectedRows[0].Cells["MAKH"].Value.ToString();
                Khachhang nv = BLLKhachHang.Instance.GetById(id);
                txtMaKhachHang.Text = nv.MAKH;
                txtTenKhachHang.Text = nv.TENKH;
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
        private void dgvDSKhachHang_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvDSKhachHang.Columns["MAKH"].HeaderText = "Mã khách hàng";
            dgvDSKhachHang.Columns["TENKH"].HeaderText = "Tên khách hàng";
            dgvDSKhachHang.Columns["NGAYSINH"].HeaderText = "Ngày sinh";
            dgvDSKhachHang.Columns["GIOITINH"].HeaderText = "Giới tính";
            dgvDSKhachHang.Columns["SDT"].HeaderText = "Số điện thoại";
            dgvDSKhachHang.Columns["DIACHI"].HeaderText = "Địa chỉ";
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
                string id = dgvDSKhachHang.SelectedRows[0].Cells["MAKH"].Value.ToString();
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
            BLLKhachHang.Instance.ExecuteAddUpdate(new Khachhang
            {
                MAKH = txtMaKhachHang.Text,
                TENKH = txtTenKhachHang.Text,
                NGAYSINH = dpNgaySinh.Value,
                GIOITINH = rbMale.Checked,
                SDT = txtSoDienThoai.Text,
                DIACHI = txtDiaChi.Text
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
