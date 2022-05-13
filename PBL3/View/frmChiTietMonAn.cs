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
using PBL3.DTO;

namespace PBL3.View
{
    public partial class frmChiTietMonAn : Form
    {
        public delegate void ChiTietMonAnDel();
        public ChiTietMonAnDel chiTietMonAnDel;
        private string id_MonAn;
        private string imageSourceFile = "";
        private string defaultImage = @".\image\default.jpg";
        public frmChiTietMonAn(string id_MonAn)
        {
            InitializeComponent();
            this.id_MonAn = id_MonAn;
            GUI();
        }

        public void GUI()
        {
            if(id_MonAn != "")
            {
                MonAn ma = BLLMonAn.Instance.GetById(id_MonAn);
                txtMaMonAn.Text = ma.id_MonAn;
                txtTenMon.Text = ma.TenMonAn;
                txtGiaTien.Text = ma.Gia.ToString();
                imageSourceFile = ma.imagePath;
                AnhMinhHoa.Image = Image.FromFile(imageSourceFile);
            }
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Select image(*.jpg; *.png; *.gif) | *.jpg; *.png; *.gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                AnhMinhHoa.Image = Image.FromFile(openFileDialog1.FileName);
                imageSourceFile = openFileDialog1.FileName;
                MessageBox.Show(imageSourceFile);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (imageSourceFile == "")
            {
                imageSourceFile = defaultImage;
            }
            BLLMonAn.Instance.ExecuteAddUpdate(new MonAn {
                id_MonAn = txtMaMonAn.Text,
                TenMonAn = txtTenMon.Text,
                Gia = Convert.ToInt32(txtGiaTien.Text),
                imagePath = imageSourceFile,
            });
            chiTietMonAnDel();
            this.Dispose();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
