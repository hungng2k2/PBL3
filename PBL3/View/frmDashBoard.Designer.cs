﻿namespace PBL3.View
{
    partial class frmDashBoard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.chartTop5 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartLoinhuan = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbLoiNhuan = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbTongban = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvUnderStock = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbMonAn = new System.Windows.Forms.Label();
            this.lbKhachhang = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbHoadon = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartTop5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLoinhuan)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnderStock)).BeginInit();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartTop5
            // 
            this.chartTop5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            chartArea3.Name = "ChartArea1";
            this.chartTop5.ChartAreas.Add(chartArea3);
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend3.Name = "Legend1";
            this.chartTop5.Legends.Add(legend3);
            this.chartTop5.Location = new System.Drawing.Point(570, 79);
            this.chartTop5.Name = "chartTop5";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.IsValueShownAsLabel = true;
            series3.LabelForeColor = System.Drawing.Color.White;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartTop5.Series.Add(series3);
            this.chartTop5.Size = new System.Drawing.Size(353, 463);
            this.chartTop5.TabIndex = 7;
            this.chartTop5.Text = "chart1";
            title3.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.Name = "Title1";
            title3.Text = "5 món ăn bán chạy nhất";
            this.chartTop5.Titles.Add(title3);
            // 
            // chartLoinhuan
            // 
            this.chartLoinhuan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            chartArea4.Name = "ChartArea1";
            this.chartLoinhuan.ChartAreas.Add(chartArea4);
            legend4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend4.Name = "Legend1";
            this.chartLoinhuan.Legends.Add(legend4);
            this.chartLoinhuan.Location = new System.Drawing.Point(39, 79);
            this.chartLoinhuan.Name = "chartLoinhuan";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartLoinhuan.Series.Add(series4);
            this.chartLoinhuan.Size = new System.Drawing.Size(525, 300);
            this.chartLoinhuan.TabIndex = 8;
            this.chartLoinhuan.Text = "chart1";
            title4.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title4.Name = "Title1";
            title4.Text = "Lợi nhuận";
            this.chartLoinhuan.Titles.Add(title4);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2Panel2.BackColor = System.Drawing.Color.White;
            this.guna2Panel2.Controls.Add(this.lbLoiNhuan);
            this.guna2Panel2.Controls.Add(this.label7);
            this.guna2Panel2.Location = new System.Drawing.Point(538, 18);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(385, 46);
            this.guna2Panel2.TabIndex = 2;
            // 
            // lbLoiNhuan
            // 
            this.lbLoiNhuan.AutoSize = true;
            this.lbLoiNhuan.ForeColor = System.Drawing.Color.Black;
            this.lbLoiNhuan.Location = new System.Drawing.Point(50, 23);
            this.lbLoiNhuan.Name = "lbLoiNhuan";
            this.lbLoiNhuan.Size = new System.Drawing.Size(42, 16);
            this.lbLoiNhuan.TabIndex = 0;
            this.lbLoiNhuan.Text = "10000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(29, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tổng lợi nhuận";
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2Panel4.BackColor = System.Drawing.Color.White;
            this.guna2Panel4.Controls.Add(this.lbTongban);
            this.guna2Panel4.Controls.Add(this.label5);
            this.guna2Panel4.Location = new System.Drawing.Point(239, 18);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(278, 46);
            this.guna2Panel4.TabIndex = 3;
            // 
            // lbTongban
            // 
            this.lbTongban.AutoSize = true;
            this.lbTongban.ForeColor = System.Drawing.Color.Black;
            this.lbTongban.Location = new System.Drawing.Point(42, 23);
            this.lbTongban.Name = "lbTongban";
            this.lbTongban.Size = new System.Drawing.Size(42, 16);
            this.lbTongban.TabIndex = 0;
            this.lbTongban.Text = "10000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(24, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tổng bán ra";
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2Panel5.BackColor = System.Drawing.Color.White;
            this.guna2Panel5.Controls.Add(this.dgvUnderStock);
            this.guna2Panel5.Controls.Add(this.label15);
            this.guna2Panel5.Location = new System.Drawing.Point(206, 394);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(358, 151);
            this.guna2Panel5.TabIndex = 4;
            // 
            // dgvUnderStock
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvUnderStock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUnderStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUnderStock.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvUnderStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUnderStock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUnderStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUnderStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvUnderStock.ColumnHeadersHeight = 30;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUnderStock.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvUnderStock.EnableHeadersVisualStyles = false;
            this.dgvUnderStock.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvUnderStock.Location = new System.Drawing.Point(10, 22);
            this.dgvUnderStock.Name = "dgvUnderStock";
            this.dgvUnderStock.RowHeadersVisible = false;
            this.dgvUnderStock.RowHeadersWidth = 51;
            this.dgvUnderStock.RowTemplate.Height = 24;
            this.dgvUnderStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUnderStock.Size = new System.Drawing.Size(335, 126);
            this.dgvUnderStock.TabIndex = 1;
            this.dgvUnderStock.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvUnderStock.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvUnderStock.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvUnderStock.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvUnderStock.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvUnderStock.ThemeStyle.BackColor = System.Drawing.Color.LightGray;
            this.dgvUnderStock.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvUnderStock.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvUnderStock.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvUnderStock.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvUnderStock.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvUnderStock.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvUnderStock.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvUnderStock.ThemeStyle.ReadOnly = false;
            this.dgvUnderStock.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvUnderStock.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUnderStock.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvUnderStock.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvUnderStock.ThemeStyle.RowsStyle.Height = 24;
            this.dgvUnderStock.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvUnderStock.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(16, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(120, 16);
            this.label15.TabIndex = 0;
            this.label15.Text = "Món ăn hết hàng";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2Panel3.BackColor = System.Drawing.Color.White;
            this.guna2Panel3.Controls.Add(this.lbMonAn);
            this.guna2Panel3.Controls.Add(this.lbKhachhang);
            this.guna2Panel3.Controls.Add(this.label10);
            this.guna2Panel3.Controls.Add(this.label9);
            this.guna2Panel3.Location = new System.Drawing.Point(39, 394);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(161, 148);
            this.guna2Panel3.TabIndex = 5;
            // 
            // lbMonAn
            // 
            this.lbMonAn.AutoSize = true;
            this.lbMonAn.ForeColor = System.Drawing.Color.Black;
            this.lbMonAn.Location = new System.Drawing.Point(35, 74);
            this.lbMonAn.Name = "lbMonAn";
            this.lbMonAn.Size = new System.Drawing.Size(42, 16);
            this.lbMonAn.TabIndex = 0;
            this.lbMonAn.Text = "10000";
            // 
            // lbKhachhang
            // 
            this.lbKhachhang.AutoSize = true;
            this.lbKhachhang.ForeColor = System.Drawing.Color.Black;
            this.lbKhachhang.Location = new System.Drawing.Point(35, 22);
            this.lbKhachhang.Name = "lbKhachhang";
            this.lbKhachhang.Size = new System.Drawing.Size(42, 16);
            this.lbKhachhang.TabIndex = 0;
            this.lbKhachhang.Text = "10000";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(15, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tổng số món ăn";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(15, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tổng số khách hàng";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.lbHoadon);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Location = new System.Drawing.Point(39, 18);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(175, 46);
            this.guna2Panel1.TabIndex = 6;
            // 
            // lbHoadon
            // 
            this.lbHoadon.AutoSize = true;
            this.lbHoadon.ForeColor = System.Drawing.Color.Black;
            this.lbHoadon.Location = new System.Drawing.Point(49, 23);
            this.lbHoadon.Name = "lbHoadon";
            this.lbHoadon.Size = new System.Drawing.Size(42, 16);
            this.lbHoadon.TabIndex = 0;
            this.lbHoadon.Text = "10000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(24, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tổng số hóa đơn";
            // 
            // frmDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(992, 562);
            this.Controls.Add(this.chartTop5);
            this.Controls.Add(this.chartLoinhuan);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.guna2Panel5);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "frmDashBoard";
            this.Text = "frmDashBoard";
            this.Load += new System.EventHandler(this.frmDashBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartTop5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLoinhuan)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnderStock)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartTop5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLoinhuan;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label lbLoiNhuan;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private System.Windows.Forms.Label lbTongban;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2DataGridView dgvUnderStock;
        private System.Windows.Forms.Label label15;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label lbMonAn;
        private System.Windows.Forms.Label lbKhachhang;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lbHoadon;
        private System.Windows.Forms.Label label2;
    }
}