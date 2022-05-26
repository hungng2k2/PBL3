using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using PBL3.BLL;
namespace PBL3.View
{
    public partial class frmDoanhthu : Form
    {
        public frmDoanhthu()
        {
            InitializeComponent();
        }

        private void frmDoanhthu_Load(object sender, EventArgs e)
        {
            dgvThongke.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThongke.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            labelThd.Text = BLLHoaDon.Instance.GetSoHoaDon().ToString();
            fillchart();
            dtpStartDate.Enabled = false;
            dtpEndDate.Enabled = false;
        }
        private void fillchart()
        {
            chart1.Series["Doanh thu"].Points.Clear();
            chart1.Series["Doanh thu"].ChartType = SeriesChartType.Column;
            chart1.Series["Doanh thu"].XValueMember = "Ngày";
            chart1.Series["Doanh thu"].YValueMembers = "Tiền Lời";
            chart1.Titles.Add("Thống kê doanh thu");
            chart1.Series["Doanh thu"].Points.AddXY("1", "100000");
            chart1.Series["Doanh thu"].Points.AddXY("2", "800000");
            chart1.Series["Doanh thu"].Points.AddXY("3", "300000");
            chart1.Series["Doanh thu"].Points.AddXY("4", "800000");
            chart1.Series["Doanh thu"].Points.AddXY("5", "500000");
            chart1.Series["Doanh thu"].Points.AddXY("6", "1000000");
            chart1.Series["Doanh thu"].Points.AddXY("7", "700000");
            chart1.Series["Doanh thu"].Points.AddXY("8", "800000");
            chart1.Series["Doanh thu"].Points.AddXY("9", "900000");
            chart1.Series["Doanh thu"].Points.AddXY("10", "1000000");
            chart1.Series["Doanh thu"].Points.AddXY("11", "500000");
            chart1.Series["Doanh thu"].Points.AddXY("12", "200000");
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvThongke.Columns["Ngay"].HeaderText = "Ngày";
            dgvThongke.Columns["SoLuongHoaDon"].HeaderText = "Số lượng hóa đơn";
            dgvThongke.Columns["TongNhap"].HeaderText = "Tổng nhập";
            dgvThongke.Columns["TongBan"].HeaderText = "Tổng bán";
            dgvThongke.Columns["TienLoi"].HeaderText = "Tiền lời";
        }

        private void butNgay_Click(object sender, EventArgs e)
        {
            dgvThongke.DataSource = BLLHoaDon.Instance.ThongKe(DateTime.Today, DateTime.Now);
            chart1.Series["Doanh thu"].Points.Clear();
            chart1.DataSource = BLLHoaDon.Instance.ThongKeChart(DateTime.Today, DateTime.Now);
        }

        private void butTuan_Click(object sender, EventArgs e)
        {
            dgvThongke.DataSource = BLLHoaDon.Instance.ThongKe(DateTime.Today.AddDays(-7), DateTime.Now);
            chart1.Series["Doanh thu"].Points.Clear();
            chart1.DataSource = BLLHoaDon.Instance.ThongKeChart(DateTime.Today.AddDays(-7), DateTime.Now);
        }

        private void butThang_Click(object sender, EventArgs e)
        {
            dgvThongke.DataSource = BLLHoaDon.Instance.ThongKe(DateTime.Today.AddMonths(-1), DateTime.Now);
            chart1.Series["Doanh thu"].Points.Clear();
            chart1.DataSource = BLLHoaDon.Instance.ThongKeChart(DateTime.Today.AddMonths(-1), DateTime.Now);
        }

        private void butNam_Click(object sender, EventArgs e)
        {
            dgvThongke.DataSource = BLLHoaDon.Instance.ThongKe(DateTime.Today.AddYears(-1), DateTime.Now);
            chart1.Series["Doanh thu"].Points.Clear();
            chart1.DataSource = BLLHoaDon.Instance.ThongKeChart(DateTime.Today.AddYears(-1), DateTime.Now);
        }

        private void butThongKe_Click(object sender, EventArgs e)
        {
            dtpStartDate.Enabled = false;
            dtpEndDate.Enabled = false;
            butNgay.Enabled = true;
            butTuan.Enabled = true;
            butThang.Enabled = true;
            butNam.Enabled = true;
            dgvThongke.DataSource = BLLHoaDon.Instance.ThongKe(dtpStartDate.Value, dtpEndDate.Value);
            chart1.Series["Doanh thu"].Points.Clear();
            chart1.DataSource = BLLHoaDon.Instance.ThongKeChart(dtpStartDate.Value, dtpEndDate.Value);
        }

        private void butCustom_Click(object sender, EventArgs e)
        {
            dtpStartDate.Enabled = true;
            dtpEndDate.Enabled = true;
            butNgay.Enabled = false;
            butTuan.Enabled = false;
            butThang.Enabled = false;
            butNam.Enabled = false;
        }
    }
}
