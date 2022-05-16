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
    public partial class frmThucdon : Form
    {
        public frmThucdon()
        {
            InitializeComponent();
        }

        private void frmThucdon_Load(object sender, EventArgs e)
        {
            Reload();
            dgvThucdon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThucdon.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        public void Reload()
        {
            dgvThucdon.DataSource = BLLMonAn.Instance.GetAll();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmChiTietMonAn frmChiTiet = new frmChiTietMonAn("");
            frmChiTiet.chiTietMonAnDel = new frmChiTietMonAn.ChiTietMonAnDel(Reload);
            frmChiTiet.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(dgvThucdon.SelectedRows.Count == 1)
            {
                string id_MonAn = dgvThucdon.SelectedRows[0].Cells["id_MonAn"].Value.ToString();
                BLLMonAn.Instance.Delete(id_MonAn);
                Reload();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(dgvThucdon.SelectedRows.Count == 1)
            {
                string id_MonAn = dgvThucdon.SelectedRows[0].Cells["id_MonAn"].Value.ToString();
                frmChiTietMonAn frmChiTiet = new frmChiTietMonAn(id_MonAn);
                frmChiTiet.chiTietMonAnDel = new frmChiTietMonAn.ChiTietMonAnDel(Reload);
                frmChiTiet.Show();
            }           
        }

        private void dgvThucdon_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvThucdon.Columns["id_MonAn"].HeaderText = "Mã món ăn";
            dgvThucdon.Columns["TenMonAn"].HeaderText = "Tên món ăn";
            dgvThucdon.Columns["Gia"].HeaderText = "Giá";
        }
    }
}
