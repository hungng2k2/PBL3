﻿using PBL3.DTO;
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
            txtMaHD.Text = BLLHoaDon.Instance.AutoGeneratedId();
            txtMaNV.Text = id_NhanVien;
            txtThoigian.Text = DateTime.Now.ToString();
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
            if (cbbKhachhang.SelectedIndex < 0 && txtTenKH.Text == "")
                MessageBox.Show("Vui lòng nhập thông tin khách hàng!");
            else
            {
                string idKH;
                if (cbbKhachhang.SelectedItem != null)
                {
                    idKH = ((CBBItem)cbbKhachhang.SelectedItem).Value;
                }
                else
                {
                    idKH = BLLKhachHang.Instance.AutoGeneratedId();
                    BLLKhachHang.Instance.ExecuteAddUpdate(new KhachHang
                    {
                        id_KhachHang = idKH,
                        TenKhachHang = txtTenKH.Text,
                        SoDienThoai = txtSDT.Text,
                        NgaySinh = DateTime.Now,
                        GioiTinh = true,
                        DiaChi = ""
                    });
                }
                
                BLLHoaDon.Instance.LapHoaDon(list_orders, id_NhanVien, idKH);
                MessageBox.Show("In hóa đơn thành công!");
                reloadForm();
                this.Close();
            }
        }
    }
}
