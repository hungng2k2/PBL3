using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            // TODO: This line of code loads data into the 'qlchtanDataSet2.Khachhang' table. You can move, or remove it, as needed.
            this.khachhangTableAdapter.Fill(this.qlchtanDataSet2.Khachhang);
            dgvDSKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSKhachHang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        public void XoaBinding()
        {
            txtMaKhachHang.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();
            txtSoDienThoai.DataBindings.Clear();
            txtTenKhachHang.DataBindings.Clear();
            cbGioiTinh.DataBindings.Clear();
            dpNgaySinh.DataBindings.Clear();
        }
        public void BindingText()
        {
            txtMaKhachHang.DataBindings.Add("Text", dgvDSKhachHang.DataSource, "MAKH");
            txtDiaChi.DataBindings.Add("Text", dgvDSKhachHang.DataSource, "DIACHI");
            txtSoDienThoai.DataBindings.Add("Text", dgvDSKhachHang.DataSource, "SDT");
            txtTenKhachHang.DataBindings.Add("Text", dgvDSKhachHang.DataSource, "TENKH");
            cbGioiTinh.DataBindings.Add("Text", dgvDSKhachHang.DataSource, "GIOITINH");
            dpNgaySinh.DataBindings.Add("Text", dgvDSKhachHang.DataSource, "NGAYSINH");
        }

        private void dgvDSKhachHang_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtDiaChi.Enabled = false;
            txtSoDienThoai.Enabled = false;
            txtTenKhachHang.Enabled = false;
            cbGioiTinh.Enabled = false;
            dpNgaySinh.Enabled = false;
            txtMaKhachHang.Enabled = false;
            XoaBinding();
            BindingText();
        }
    }
}
