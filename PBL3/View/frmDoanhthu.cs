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
        }

        private void butThongke_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLLDoanhThu.Instance.ThongKe(dtbTungay.Value,dtbDenngay.Value);

        }
    }
}
