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
    public partial class frmKho : Form
    {
        public frmKho()
        {
            InitializeComponent();
        }

        private void frmKho_Load(object sender, EventArgs e)
        {
            Reload();
            dgvDSMonAn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSMonAn.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        public void Reload()
        {
            dgvDSMonAn.DataSource = BLLMonAn.Instance.GetAllMonAnViewKho();
        }

        private void dgvDSMonAn_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDSMonAn.SelectedRows.Count == 1)
            {
                string id_MonAn = dgvDSMonAn.SelectedRows[0].Cells[0].Value.ToString();
                MonAn monAn = BLLMonAn.Instance.GetById(id_MonAn);
                txtTenMon.Text = monAn.TenMonAn.ToString();
                txtSoLuong.Text = monAn.SoLuong.ToString();
                txtDonGia.Text = monAn.GiaBan.ToString();
                txtTong.Text = (monAn.SoLuong * monAn.GiaBan).ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            EditorEnable(false);
        }
        public void EditorEnable(bool b)
        {
            txtTenMon.Enabled = b;
            txtDonGia.Enabled = b;
            txtSoLuong.Enabled = !b;
            txtTong.Enabled = b;
            btnLuu.Enabled = !b;
            btnHuy.Enabled = !b;
            btnThem.Enabled = b;
            dgvDSMonAn.Enabled = b;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string id_MonAn = dgvDSMonAn.SelectedRows[0].Cells[0].Value.ToString();
            MonAn monAn = BLLMonAn.Instance.GetById(id_MonAn);
            monAn.SoLuong = Convert.ToInt32(txtSoLuong.Text);
            if (BLLMonAn.Instance.ExecuteAddUpdate(monAn))
            {
                MessageBox.Show("Cập nhật cơ sở dữ liệu thành công!");
            }
            else
            {
                MessageBox.Show("Cập nhật cơ sở dữ liệu thất bại!");
            }
            Reload();
            dgvDSMonAn_SelectionChanged(sender, e);
            EditorEnable(false);
            txtSoLuong.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            dgvDSMonAn.Enabled = true;

        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            dgvDSMonAn_SelectionChanged(sender, e);
            EditorEnable(false);
            txtSoLuong.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            dgvDSMonAn.Enabled = true;
        }

        private void dgvDSMonAn_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvDSMonAn.Columns["id_MonAn"].HeaderText = "Mã món ăn";
            dgvDSMonAn.Columns["TenMonAn"].HeaderText = "Tên món ăn";
            dgvDSMonAn.Columns["SoLuong"].HeaderText = "Số lượng";
            dgvDSMonAn.Columns["GiaNhap"].HeaderText = "Giá nhập";
            dgvDSMonAn.Columns["GiaBan"].HeaderText = "Giá bán";
        }

        private void butSearch_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            if (search.Length > 0)
            {
                dgvDSMonAn.DataSource = BLLMonAn.Instance.SearchMonAnViewKho(search);
            }
            else
            {
                Reload();
            }
        }
    }
}
