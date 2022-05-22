namespace PBL3.View
{
    partial class frmDoiMK
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNhaplai = new System.Windows.Forms.TextBox();
            this.txtMKcu = new System.Windows.Forms.TextBox();
            this.txtMKmoi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iconButtonHuy = new FontAwesome.Sharp.IconButton();
            this.iconButtonCapnhat = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNhaplai
            // 
            this.txtNhaplai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhaplai.Location = new System.Drawing.Point(415, 210);
            this.txtNhaplai.Name = "txtNhaplai";
            this.txtNhaplai.PasswordChar = '*';
            this.txtNhaplai.Size = new System.Drawing.Size(253, 28);
            this.txtNhaplai.TabIndex = 3;
            this.txtNhaplai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMKcu
            // 
            this.txtMKcu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMKcu.Location = new System.Drawing.Point(415, 111);
            this.txtMKcu.Name = "txtMKcu";
            this.txtMKcu.Size = new System.Drawing.Size(253, 28);
            this.txtMKcu.TabIndex = 1;
            this.txtMKcu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMKmoi
            // 
            this.txtMKmoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMKmoi.Location = new System.Drawing.Point(415, 159);
            this.txtMKmoi.Name = "txtMKmoi";
            this.txtMKmoi.Size = new System.Drawing.Size(253, 28);
            this.txtMKmoi.TabIndex = 2;
            this.txtMKmoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(138, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập lại mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(138, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mật khẩu cũ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(138, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật khẩu mới";
            // 
            // iconButtonHuy
            // 
            this.iconButtonHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonHuy.ForeColor = System.Drawing.Color.Black;
            this.iconButtonHuy.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.iconButtonHuy.IconColor = System.Drawing.Color.Black;
            this.iconButtonHuy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonHuy.Location = new System.Drawing.Point(444, 284);
            this.iconButtonHuy.Name = "iconButtonHuy";
            this.iconButtonHuy.Size = new System.Drawing.Size(180, 70);
            this.iconButtonHuy.TabIndex = 5;
            this.iconButtonHuy.Text = "Hủy bỏ";
            this.iconButtonHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButtonHuy.UseVisualStyleBackColor = true;
            this.iconButtonHuy.Click += new System.EventHandler(this.iconButtonHuy_Click);
            // 
            // iconButtonCapnhat
            // 
            this.iconButtonCapnhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonCapnhat.ForeColor = System.Drawing.Color.Black;
            this.iconButtonCapnhat.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.iconButtonCapnhat.IconColor = System.Drawing.Color.Black;
            this.iconButtonCapnhat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonCapnhat.Location = new System.Drawing.Point(170, 284);
            this.iconButtonCapnhat.Name = "iconButtonCapnhat";
            this.iconButtonCapnhat.Size = new System.Drawing.Size(180, 70);
            this.iconButtonCapnhat.TabIndex = 4;
            this.iconButtonCapnhat.Text = "Cập nhật";
            this.iconButtonCapnhat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButtonCapnhat.UseVisualStyleBackColor = true;
            this.iconButtonCapnhat.Click += new System.EventHandler(this.iconButtonCapnhat_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(287, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 32);
            this.label4.TabIndex = 49;
            this.label4.Text = "ĐỔI MẬT KHẨU";
            // 
            // frmDoiMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(793, 426);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.iconButtonHuy);
            this.Controls.Add(this.iconButtonCapnhat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNhaplai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMKcu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMKmoi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDoiMK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNhaplai;
        private System.Windows.Forms.TextBox txtMKmoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMKcu;
        private FontAwesome.Sharp.IconButton iconButtonHuy;
        private FontAwesome.Sharp.IconButton iconButtonCapnhat;
        private System.Windows.Forms.Label label4;
    }
}