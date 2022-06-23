﻿using PBL3.BLL;
using PBL3.DTO;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PBL3.View
{
    public partial class frmThucDon : Form
    {
        private string _imageSourceFile = "";
        public string ImageSourceFile
        {
            get
            {
                return _imageSourceFile;
            }
            set
            {
                _imageSourceFile = value;
                LoadImage(value);
            }
        }


        public frmThucDon()
        {
            InitializeComponent();
        }

        private void frmThucdon_Load(object sender, EventArgs e)
        {
            EditorEnable(false);
            txtMaMonAn.Enabled = false;
            Reload();
            dgvThucdon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThucdon.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        public void EditorEnable(bool b)
        {
            txtTenMon.Enabled = b;
            txtGiaBan.Enabled = b;
            txtGiaNhap.Enabled = b;
            btnLuu.Enabled = b;
            btnHuy.Enabled = b;
            btnChonAnh.Enabled = b;
            btnThem.Enabled = !b;
            btnSua.Enabled = !b;
            btnXoa.Enabled = !b;
            dgvThucdon.Enabled = !b;
        }

        public void EditorReset()
        {
            txtMaMonAn.Text = "";
            txtTenMon.Text = "";
            txtGiaBan.Text = "";
            txtGiaNhap.Text = "";
            ImageSourceFile = BLLMonAn.Instance.DefaultImage;
        }

        public void LoadImage(string path)
        {
            Image img;
            using (var bmpTemp = new Bitmap(path))
            {
                img = new Bitmap(bmpTemp);
            }
            AnhMinhHoa.Image = img;
        }

        public void Reload()
        {
            dgvThucdon.DataSource = BLLMonAn.Instance.GetAllMonAnViewThucDon();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            EditorReset();
            txtMaMonAn.Text = BLLMonAn.Instance.AutoGeneratedId();
            EditorEnable(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvThucdon.SelectedRows.Count == 1)
            {
                string id_MonAn = dgvThucdon.SelectedRows[0].Cells["id_MonAn"].Value.ToString();
                DialogResult dr = MessageBox.Show("Bạn muốn xóa món ăn có id '" + id_MonAn + "'?", "Xác nhận xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    BLLMonAn.Instance.Delete(id_MonAn);
                    Reload();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvThucdon.SelectedRows.Count == 1)
            {
                EditorEnable(true);
            }
        }

        private void dgvThucdon_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvThucdon.Columns["id_MonAn"].HeaderText = "Mã món ăn";
            dgvThucdon.Columns["TenMonAn"].HeaderText = "Tên món ăn";
            dgvThucdon.Columns["GiaBan"].HeaderText = "Giá bán";
            dgvThucdon.Columns["GiaNhap"].HeaderText = "Giá nhập";
        }

        private void dgvThucdon_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvThucdon.SelectedRows.Count == 1)
            {
                string id_MonAn = dgvThucdon.SelectedRows[0].Cells["id_MonAn"].Value.ToString();
                MonAn monAn = BLLMonAn.Instance.GetById(id_MonAn);
                txtTenMon.Text = monAn.TenMonAn;
                txtGiaNhap.Text = monAn.GiaNhap.ToString();
                txtGiaBan.Text = monAn.GiaBan.ToString();
                txtMaMonAn.Text = monAn.id_MonAn;
                ImageSourceFile = monAn.imagePath;
            }
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Select image(*.jpg; *.png; *.gif) | *.jpg; *.png; *.gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ImageSourceFile = openFileDialog1.FileName;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenMon.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập tên món ăn!");
                    return;
                }
                if(BLLValidation.Instance.CheckName(txtTenMon.Text) == false)
                {
                    MessageBox.Show("Tên món ăn không hợp lệ!");
                    return;
                }
                if (txtGiaBan.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập giá bán!");
                    return;
                }
                if (BLLValidation.Instance.CheckNumber(txtGiaBan.Text) == false)
                {
                    MessageBox.Show("Giá bán không hợp lệ!");
                    return;
                }
                if (txtGiaNhap.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập giá nhập!");
                    return;
                }
                if (BLLValidation.Instance.CheckNumber(txtGiaNhap.Text) == false)
                {
                    MessageBox.Show("Giá nhập không hợp lệ!");
                    return;
                }
                if (Convert.ToDouble(txtGiaBan.Text) < Convert.ToDouble(txtGiaNhap.Text))
                {
                    MessageBox.Show("Giá bán không thể bé hơn giá nhập!");
                    return;
                }
                BLLMonAn.Instance.ExecuteAddUpdate(new MonAn
                {
                    id_MonAn = txtMaMonAn.Text,
                    TenMonAn = txtTenMon.Text,
                    GiaNhap = Convert.ToDouble(txtGiaNhap.Text),
                    GiaBan = Convert.ToDouble(txtGiaBan.Text),
                    imagePath = ImageSourceFile,
                });
                EditorEnable(false);
                Reload();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            dgvThucdon_SelectionChanged(sender, e);
            EditorEnable(false);
        }

        private void butSearch_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            if (search.Length > 0)
            {
                dgvThucdon.DataSource = BLLMonAn.Instance.SearchMonAnViewThucDon(search);
            }
            else
            {
                Reload();
            }
        }
    }
}
