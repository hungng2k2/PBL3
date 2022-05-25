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
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            fillchart();
        }

        private void butThongke_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLLHoaDon.Instance.ThongKe(dtbTungay.Value,dtbDenngay.Value);
            chart1.Series["Doanh thu"].Points.Clear();
            chart1.DataSource = BLLHoaDon.Instance.ThongKeChart(dtbTungay.Value, dtbDenngay.Value);
        }
        private void fillchart()
        {
            chart1.Series["Doanh thu"].Points.Clear();
            chart1.Series["Doanh thu"].ChartType = SeriesChartType.Column;
            chart1.Series["Doanh thu"].XValueMember = "Ngày";
            chart1.Series["Doanh thu"].YValueMembers = "Tiền Lời";
            chart1.Titles.Add("Thống kê doanh thu");
            chart1.Series["Doanh thu"].Points.AddXY("1", "100000");
            chart1.Series["Doanh thu"].Points.AddXY("2", "200000");
            chart1.Series["Doanh thu"].Points.AddXY("3", "300000");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
                // thong ke trong ngay
            {
                dataGridView1.DataSource = BLLHoaDon.Instance.ThongKe(DateTime.Now, DateTime.Now);
                chart1.Series["Doanh thu"].Points.Clear();
                chart1.DataSource = BLLHoaDon.Instance.ThongKeChart(DateTime.Now, DateTime.Now);
            }
            else if (comboBox1.SelectedIndex == 1)
                // thong ke theo thang
            {
                dataGridView1.DataSource = BLLHoaDon.Instance.ThongKe(DateTime.Now.AddMonths(-1), DateTime.Now);
                chart1.Series["Doanh thu"].Points.Clear();
                chart1.DataSource = BLLHoaDon.Instance.ThongKeChart(DateTime.Now.AddMonths(-1), DateTime.Now);
            }
            else if (comboBox1.SelectedIndex == 2)
            // thong ke theo nam
            {
                dataGridView1.DataSource = BLLHoaDon.Instance.ThongKe(DateTime.Now.AddYears(-1), DateTime.Now);
                chart1.Series["Doanh thu"].Points.Clear();
                chart1.DataSource = BLLHoaDon.Instance.ThongKeChart(DateTime.Now.AddYears(-1), DateTime.Now);
            }
        }
    }
}
