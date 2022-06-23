using PBL3.BLL;
using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PBL3.View
{
    public partial class frmMenu : Form
    {
        public string id_NhanVien { get; set; }
        private double total = 0;
        private int totalNumOrder = 0;
        public List<ItemFood> itemFoods;
        public frmMenu(string id_NhanVien)
        {
            this.id_NhanVien = id_NhanVien;
            itemFoods = new List<ItemFood>();
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            Reload();
        }
        private void Reload()
        {
            itemFoods.Clear();
            var data = BLLMonAn.Instance.GetAll();
            foreach (var item in data)
            {
                itemFoods.Add(new ItemFood(item.id_MonAn));
                itemFoods[itemFoods.Count-1].itemValueChanged += frmMenu_itemValueChanged;
            }
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.AddRange(itemFoods.ToArray());
            lbl_Tongtien.Text = "₫0";
            lbl_numOrder.Text = "0";
            totalNumOrder = 0;
            total = 0;
        }

        private void frmMenu_itemValueChanged(object sender, ItemFood.ItemValueChangedEventArgs e)
        {

            if (e.IsAdd)
            {
                total += e.Value;
                totalNumOrder += 1;
            }
            else
            {
                total -= e.Value;
                totalNumOrder -= 1;
            }
            if (total == 0)
            {
                lbl_Tongtien.Text = "₫0";
                lbl_numOrder.Text = "0";
            }
            else
            {
                lbl_numOrder.Text = totalNumOrder.ToString();
                lbl_Tongtien.Text = "₫" + total.ToString("#,#");
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lbl_numOrder.Text) > 0)
            {
                List<ChiTietOrder> list_order = new List<ChiTietOrder>();
                int i = 1;
                foreach (ItemFood item in flowLayoutPanel1.Controls)
                {
                    if (item.CountAdded > 0)
                    {
                        list_order.Add(new ChiTietOrder
                        {
                            id_MonAn = item.monAn.id_MonAn,
                            SoLuong = item.CountAdded,
                            GiaNhap = item.monAn.GiaNhap,
                            GiaBan = item.monAn.GiaBan,
                        });
                        i++;
                    }
                }
                frmOrder frm = new frmOrder(list_order, id_NhanVien);
                frm.reloadForm += Reload;
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn món ăn.");
            }
        }
    }
}
