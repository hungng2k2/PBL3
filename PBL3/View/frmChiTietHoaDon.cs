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
    public partial class frmChiTietHoaDon : Form
    {
        private string id_HoaDon = "";
        public frmChiTietHoaDon(string id_HoaDon)
        {
            this.id_HoaDon = id_HoaDon;
            InitializeComponent();
        }
        private void frmChiTietHoaDon_Load(object sender, EventArgs e)
        {
            GUI();
            dgvDSMonAn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSMonAn.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        public void GUI()
        {
            HoaDon hd = BLLHoaDon.Instance.GetById(id_HoaDon);
            dgvDSMonAn.DataSource = BLLChiTietOrder.Instance.GetByIdOrder(hd.id_Order);
            lblKhachHang.Text = BLLKhachHang.Instance.GetById(BLLOrder.Instance.GetById(hd.id_Order).id_KhachHang).TenKhachHang;
            lblTongTien.Text = BLLOrder.Instance.GetById(hd.id_Order).TongTien.ToString();
        }

        private void dgvDSMonAn_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvDSMonAn.Columns["TenMonAn"].HeaderText = "Tên món ăn";
            dgvDSMonAn.Columns["SoLuong"].HeaderText = "Số lượng";
            dgvDSMonAn.Columns["DonGia"].HeaderText = "Đơn giá";
            dgvDSMonAn.Columns["ThanhTien"].HeaderText = "Thành tiền";
        }
    }
}
