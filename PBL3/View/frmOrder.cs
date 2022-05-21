using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.DTO;
using PBL3.BLL;

namespace PBL3.View
{
    public partial class frmOrder : Form
    {
        double sum = 0;
        List<MonAn> _list_orders;
        public frmOrder(List<MonAn> list_orders)
        {
            QLCHTAN db = new QLCHTAN();
            InitializeComponent();
            this._list_orders = list_orders;
            foreach (KhachHang i in db.KhachHang)
            {
                cbbKhachhang.Items.Add(new CBBItem
                {
                    Text = i.TenKhachHang,
                    Value = i.id_KhachHang
                });
            }
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            int i = 1;
            foreach (MonAn monAn in _list_orders)
            {
                var listviewItem = new ListViewItem(new string[] { i + ".", monAn.TenMonAn, monAn.SoLuong.ToString(), monAn.Gia.ToString("n0"), (monAn.SoLuong * monAn.Gia).ToString("n0") });
                i++;
                listView1.Items.Add(listviewItem);
                sum = sum + monAn.SoLuong * monAn.Gia;
            }
            label3.Text = sum.ToString();
        }

        private void butThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
