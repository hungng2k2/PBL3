using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.View
{
    public partial class frmQLNhanvien : Form
    {
        public frmQLNhanvien()
        {
            InitializeComponent();
        }
        private void frmQLNhanvien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlchtanDataSet.Nhanvien' table. You can move, or remove it, as needed.
            this.nhanvienTableAdapter.Fill(this.qlchtanDataSet.Nhanvien);
            dgvDSNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;   

        }
    }
}
