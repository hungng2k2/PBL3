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
    public partial class frmDashBoard : Form
    {
        public frmDashBoard()
        {
            InitializeComponent();
        }

        private void frmDashBoard_Load(object sender, EventArgs e)
        {
            lbHoadon.Text = BLLHoaDon.Instance.GetSoHoaDon(DateTime.MinValue,DateTime.MaxValue).ToString();
            lbTongban.Text = BLLHoaDon.Instance.GetTongTien(DateTime.MinValue, DateTime.MaxValue).ToString();
            lbLoiNhuan.Text = BLLHoaDon.Instance.GetDoanhThu(DateTime.MinValue, DateTime.MaxValue).ToString();

            chartLoinhuan.DataSource = BLLHoaDon.Instance.ThongKeChart(DateTime.Today.AddMonths(-1), DateTime.Now);
            chartLoinhuan.Series[0].XValueMember = "Ngày";
            chartLoinhuan.Series[0].YValueMembers = "Tiền lời";
            chartLoinhuan.DataBind();

            //chartTop5.DataSource = BLLHoaDon.Instance.Top5();
            //chartTop5.Series[0].XValueMember = "Key";
            //chartTop5.Series[0].YValueMembers = "Value";
            //chartTop5.DataBind();

            dgvUnderStock.DataSource = BLLMonAn.Instance.GetUnderStock();
            dgvUnderStock.Columns["id_MonAn"].HeaderText = "Mã món ăn";
            dgvUnderStock.Columns["TenMonAn"].HeaderText = "Tên món ăn";

            lbKhachhang.Text = BLLKhachHang.Instance.TongKhachHang().ToString();
            lbMonAn.Text = BLLMonAn.Instance.TongMonAn().ToString();
        }
    }
    
}
