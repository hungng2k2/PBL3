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
            dgvDSMonAn.DataSource = BLLMonAn.Instance.GetMonAn();
        }

        private void dgvDSMonAn_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDSMonAn.SelectedRows.Count == 1)
            {
                string tenmon = dgvDSMonAn.SelectedRows[0].Cells[0].Value.ToString();
                MonAn monAn = BLLMonAn.Instance.GetmonByten(tenmon);
                txtTenMon.Text = monAn.TenMonAn.ToString();
                txtSoLuong.Text = monAn.SoLuong.ToString();
                txtDonGia.Text = monAn.Gia.ToString();
                txtTong.Text = (monAn.SoLuong * monAn.Gia).ToString();
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
            string tenmon = dgvDSMonAn.SelectedRows[0].Cells[0].Value.ToString();
            MonAn monAn = BLLMonAn.Instance.GetmonByten(tenmon);
            monAn.SoLuong = Convert.ToInt32(txtSoLuong.Text);
            BLLMonAn.Instance.ExecuteAddUpdate(monAn);
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
            dgvDSMonAn.Columns["TenMonAn"].HeaderText = "Tên món ăn";
            dgvDSMonAn.Columns["SoLuong"].HeaderText = "Số lượng";
            dgvDSMonAn.Columns["Gia"].HeaderText = "Giá";
        }
    }
}
