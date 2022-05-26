namespace PBL3.View
{
    partial class frmDoanhthu
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel2 = new System.Windows.Forms.Panel();
            this.butThongKe = new Guna.UI2.WinForms.Guna2Button();
            this.butCustom = new Guna.UI2.WinForms.Guna2Button();
            this.butNam = new Guna.UI2.WinForms.Guna2Button();
            this.butThang = new Guna.UI2.WinForms.Guna2Button();
            this.butTuan = new Guna.UI2.WinForms.Guna2Button();
            this.butNgay = new Guna.UI2.WinForms.Guna2Button();
            this.labelThd = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvThongke = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongke)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.butThongKe);
            this.panel2.Controls.Add(this.butCustom);
            this.panel2.Controls.Add(this.butNam);
            this.panel2.Controls.Add(this.butThang);
            this.panel2.Controls.Add(this.butTuan);
            this.panel2.Controls.Add(this.butNgay);
            this.panel2.Controls.Add(this.labelThd);
            this.panel2.Controls.Add(this.chart1);
            this.panel2.Controls.Add(this.dtpEndDate);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.dtpStartDate);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1140, 371);
            this.panel2.TabIndex = 0;
            // 
            // butThongKe
            // 
            this.butThongKe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.butThongKe.BorderRadius = 10;
            this.butThongKe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butThongKe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butThongKe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butThongKe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butThongKe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.butThongKe.ForeColor = System.Drawing.Color.White;
            this.butThongKe.Location = new System.Drawing.Point(439, 122);
            this.butThongKe.Name = "butThongKe";
            this.butThongKe.Size = new System.Drawing.Size(112, 27);
            this.butThongKe.TabIndex = 19;
            this.butThongKe.Text = "Thống kê";
            this.butThongKe.Click += new System.EventHandler(this.butThongKe_Click);
            // 
            // butCustom
            // 
            this.butCustom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.butCustom.BorderRadius = 10;
            this.butCustom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butCustom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butCustom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butCustom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butCustom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.butCustom.ForeColor = System.Drawing.Color.White;
            this.butCustom.Location = new System.Drawing.Point(439, 73);
            this.butCustom.Name = "butCustom";
            this.butCustom.Size = new System.Drawing.Size(112, 27);
            this.butCustom.TabIndex = 19;
            this.butCustom.Text = "Tùy chỉnh";
            this.butCustom.Click += new System.EventHandler(this.butCustom_Click);
            // 
            // butNam
            // 
            this.butNam.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.butNam.BorderRadius = 10;
            this.butNam.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butNam.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butNam.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butNam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butNam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.butNam.ForeColor = System.Drawing.Color.White;
            this.butNam.Location = new System.Drawing.Point(427, 259);
            this.butNam.Name = "butNam";
            this.butNam.Size = new System.Drawing.Size(112, 45);
            this.butNam.TabIndex = 18;
            this.butNam.Text = "Năm này";
            this.butNam.Click += new System.EventHandler(this.butNam_Click);
            // 
            // butThang
            // 
            this.butThang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.butThang.BorderRadius = 10;
            this.butThang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butThang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butThang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butThang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butThang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.butThang.ForeColor = System.Drawing.Color.White;
            this.butThang.Location = new System.Drawing.Point(298, 259);
            this.butThang.Name = "butThang";
            this.butThang.Size = new System.Drawing.Size(112, 45);
            this.butThang.TabIndex = 18;
            this.butThang.Text = "Tháng này";
            this.butThang.Click += new System.EventHandler(this.butThang_Click);
            // 
            // butTuan
            // 
            this.butTuan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.butTuan.BorderRadius = 10;
            this.butTuan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butTuan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butTuan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butTuan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butTuan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.butTuan.ForeColor = System.Drawing.Color.White;
            this.butTuan.Location = new System.Drawing.Point(168, 259);
            this.butTuan.Name = "butTuan";
            this.butTuan.Size = new System.Drawing.Size(112, 45);
            this.butTuan.TabIndex = 18;
            this.butTuan.Text = "Tuần này";
            this.butTuan.Click += new System.EventHandler(this.butTuan_Click);
            // 
            // butNgay
            // 
            this.butNgay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.butNgay.BorderRadius = 10;
            this.butNgay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butNgay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butNgay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butNgay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butNgay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.butNgay.ForeColor = System.Drawing.Color.White;
            this.butNgay.Location = new System.Drawing.Point(39, 259);
            this.butNgay.Name = "butNgay";
            this.butNgay.Size = new System.Drawing.Size(112, 45);
            this.butNgay.TabIndex = 18;
            this.butNgay.Text = "Hôm nay";
            this.butNgay.Click += new System.EventHandler(this.butNgay_Click);
            // 
            // labelThd
            // 
            this.labelThd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelThd.AutoSize = true;
            this.labelThd.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThd.ForeColor = System.Drawing.Color.Red;
            this.labelThd.Location = new System.Drawing.Point(334, 167);
            this.labelThd.Name = "labelThd";
            this.labelThd.Size = new System.Drawing.Size(49, 54);
            this.labelThd.TabIndex = 17;
            this.labelThd.Text = "0";
            // 
            // chart1
            // 
            this.chart1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chart1.CausesValidation = false;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(567, 73);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Doanh thu";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(535, 252);
            this.chart1.TabIndex = 15;
            this.chart1.Text = "chart1";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpEndDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.CausesValidation = false;
            this.dtpEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Location = new System.Drawing.Point(168, 124);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(233, 27);
            this.dtpEndDate.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.CausesValidation = false;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(30, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Đến ngày";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpStartDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.CausesValidation = false;
            this.dtpStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Location = new System.Drawing.Point(168, 73);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(233, 27);
            this.dtpStartDate.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.CausesValidation = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(168, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tổng số hóa đơn";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.CausesValidation = false;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(30, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Từ ngày";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(462, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống kê doanh thu";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.groupBox1.Controls.Add(this.dgvThongke);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(0, 371);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1140, 133);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê doanh thu";
            // 
            // dgvThongke
            // 
            this.dgvThongke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongke.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThongke.Location = new System.Drawing.Point(3, 20);
            this.dgvThongke.Name = "dgvThongke";
            this.dgvThongke.RowHeadersWidth = 51;
            this.dgvThongke.RowTemplate.Height = 24;
            this.dgvThongke.Size = new System.Drawing.Size(1134, 110);
            this.dgvThongke.TabIndex = 0;
            this.dgvThongke.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // frmDoanhthu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1140, 504);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmDoanhthu";
            this.Text = "frmDoanhthu";
            this.Load += new System.EventHandler(this.frmDoanhthu_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongke)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvThongke;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelThd;
        private Guna.UI2.WinForms.Guna2Button butNam;
        private Guna.UI2.WinForms.Guna2Button butThang;
        private Guna.UI2.WinForms.Guna2Button butTuan;
        private Guna.UI2.WinForms.Guna2Button butNgay;
        private Guna.UI2.WinForms.Guna2Button butCustom;
        private Guna.UI2.WinForms.Guna2Button butThongKe;
    }
}