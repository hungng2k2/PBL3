using PBL3.DTO;
using PBL3.BLL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PBL3.View
{
    public partial class frmOrder : Form
    {
        public delegate void ReloadForm();
        public ReloadForm reloadForm;

        private string id_NhanVien = "";
        double sum = 0;
        List<MonAn> list_orders;
        List<CBBItem> listItem;
        List<CBBItem> listItemFilter;
        public frmOrder(List<MonAn> list_orders, string id_NhanVien)
        {
            QLCHTAN db = new QLCHTAN();
            InitializeComponent();
            this.id_NhanVien = id_NhanVien;
            this.list_orders = list_orders;
            this.listItem = new List<CBBItem>();
            this.listItemFilter = new List<CBBItem>();
            foreach (KhachHang i in db.KhachHang)
            {
                listItem.Add(new CBBItem
                {
                    Text = i.SoDienThoai + ", " + i.TenKhachHang,
                    Value = i.id_KhachHang
                });
            }
            cbbKhachhang.Items.AddRange(listItem.ToArray());
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            int i = 1;
            foreach (MonAn monAn in list_orders)
            {
                var listviewItem = new ListViewItem(new string[] { i + ".", monAn.TenMonAn, monAn.SoLuong.ToString(), monAn.Gia.ToString("n0"), (monAn.SoLuong * monAn.Gia).ToString("n0") });
                i++;
                listView1.Items.Add(listviewItem);
                sum = sum + monAn.SoLuong * monAn.Gia;
            }
            label3.Text = "₫" + sum.ToString("#,#");
        }

        private void butThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbKhachhang_TextUpdate(object sender, EventArgs e)
        {
            cbbKhachhang.Items.Clear();
            listItemFilter.Clear();
            string filter_param = cbbKhachhang.Text;
            foreach (CBBItem item in listItem)
            {
                if (item.Text.ToLower().Contains(filter_param.ToLower()))
                {
                    listItemFilter.Add(item);
                }
            }
            cbbKhachhang.Items.AddRange(listItemFilter.ToArray());
            cbbKhachhang.DroppedDown = true;
            cbbKhachhang.IntegralHeight = true;
            cbbKhachhang.SelectedIndex = -1;
            cbbKhachhang.Text = filter_param;
            cbbKhachhang.SelectionStart = filter_param.Length;
            cbbKhachhang.SelectionLength = 0;
        }

        private void butIn_Click(object sender, EventArgs e)
        {
            if (cbbKhachhang.SelectedIndex < 0)
                MessageBox.Show("Vui lòng chọn khách hàng!");
            else
            {
                string id_KhachHang = ((CBBItem)cbbKhachhang.SelectedItem).Value;
                BLLHoaDon.Instance.LapHoaDon(list_orders, id_NhanVien, id_KhachHang);
                MessageBox.Show("In hóa đơn thành công!");
                reloadForm();
                this.Close();
            }
        }
    }
}
