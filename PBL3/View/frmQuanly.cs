using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.View
{
    public partial class frmQuanly : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm = null;
        string idnv = "";
        public frmQuanly(string id)
        {
            idnv = id;
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            // open full-screen mode
            this.FormBorderStyle = FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnNV_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(255, 163, 26));
            OpenChildForm(new frmQLNhanvien());
        }

        private void btnKH_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(255, 163, 26));
            OpenChildForm(new frmKhachhang());
        }

        private void btnTD_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(255, 163, 26));
            OpenChildForm(new frmThucdon());
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(255, 163, 26));
            new frmDangnhap().Show();
            this.Dispose();
        }

        private void btnHD_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(255, 163, 26));
            OpenChildForm(new frmHoadon());
        }

        private void btnKHO_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(255, 163, 26));
            OpenChildForm(new frmKho());
        }

        private void btnDT_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(255, 163, 26));
            OpenChildForm(new frmDoanhthu());
        }

        private void frmQuanly_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //private void iconButton1_Click(object sender, EventArgs e)
        //{
        //    OpenChildForm(new frmThongtintk(idnv));
        //}
    }
}
