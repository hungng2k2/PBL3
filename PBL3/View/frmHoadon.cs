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
    public partial class frmHoadon : Form
    {
        public frmHoadon()
        {
            InitializeComponent();
        }

        private void frmHoadon_Load(object sender, EventArgs e)
        {
            EditorEnable(false);
            Reload();
            dgvDSHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSHoaDon.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        public void Reload()
        {
            dgvDSHoaDon.DataSource = BLLHoaDon.Instance.GetAll();
        }

        private void dgvDSHoaDon_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvDSHoaDon.Columns["id_HoaDon"].HeaderText = "Mã hóa đơn";
            dgvDSHoaDon.Columns["TenNhanVien"].HeaderText = "Tên nhân viên";
            dgvDSHoaDon.Columns["TenKhachHang"].HeaderText = "Tên khách hàng";
            dgvDSHoaDon.Columns["NgayLap"].HeaderText = "Ngày lập";
            dgvDSHoaDon.Columns["TongTien"].HeaderText = "Tổng tiền";
        }

        private void butDetail_Click(object sender, EventArgs e)
        {
            if(dgvDSHoaDon.SelectedRows.Count == 1)
            {
                string id_HoaDon = dgvDSHoaDon.SelectedRows[0].Cells["id_HoaDon"].Value.ToString();
                frmChiTietHoaDon frm = new frmChiTietHoaDon(id_HoaDon);
                frm.Show();
            }
        }
        public void EditorEnable(bool b)
        {
            txtMahoadon.Enabled = b;
            txtmaKhachhang.Enabled = b;
            txtNhanvienlap.Enabled = b;
            dateTimePicker1.Enabled = b;
        }

        private void dgvDSHoaDon_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDSHoaDon.SelectedRows.Count == 1)
            {
                string id = dgvDSHoaDon.SelectedRows[0].Cells["id_HoaDon"].Value.ToString();
                HoaDon hd = BLLHoaDon.Instance.GetById(id);
                txtMahoadon.Text = hd.id_HoaDon;
                txtmaKhachhang.Text = BLLOrder.Instance.GetById(hd.id_Order).id_KhachHang;
                txtNhanvienlap.Text = BLLNhanVien.Instance.GetById(BLLOrder.Instance.GetById(hd.id_Order).id_NhanVien).TenNhanVien;
                dateTimePicker1.Value = hd.NgayLap;
            }
        }
    }
}
