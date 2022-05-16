namespace PBL3.View
{
    partial class ItemFood
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSelected = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.btnMinus = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.pic_food = new System.Windows.Forms.PictureBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lblOutOfStock = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_food)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelected
            // 
            this.lblSelected.BackColor = System.Drawing.Color.Gray;
            this.lblSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelected.ForeColor = System.Drawing.Color.White;
            this.lblSelected.Location = new System.Drawing.Point(189, 235);
            this.lblSelected.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(43, 28);
            this.lblSelected.TabIndex = 9;
            this.lblSelected.Text = "0";
            this.lblSelected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_price.Location = new System.Drawing.Point(4, 275);
            this.lbl_price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(81, 21);
            this.lbl_price.TabIndex = 8;
            this.lbl_price.Text = "₫15,000";
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.Gainsboro;
            this.btnMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMinus.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnMinus.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMinus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinus.IconSize = 24;
            this.btnMinus.Location = new System.Drawing.Point(126, 267);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(49, 38);
            this.btnMinus.TabIndex = 11;
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Visible = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAdd.IconColor = System.Drawing.Color.Goldenrod;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.IconSize = 24;
            this.btnAdd.Location = new System.Drawing.Point(183, 267);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(49, 38);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pic_food
            // 
            this.pic_food.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_food.Dock = System.Windows.Forms.DockStyle.Top;
            this.pic_food.Location = new System.Drawing.Point(0, 0);
            this.pic_food.Name = "pic_food";
            this.pic_food.Size = new System.Drawing.Size(235, 184);
            this.pic_food.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_food.TabIndex = 12;
            this.pic_food.TabStop = false;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoEllipsis = true;
            this.lbl_name.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_name.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.Black;
            this.lbl_name.Location = new System.Drawing.Point(4, 187);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(227, 48);
            this.lbl_name.TabIndex = 13;
            this.lbl_name.Text = "Bánh mỳ tuấn mập\r\n";
            // 
            // lblOutOfStock
            // 
            this.lblOutOfStock.AutoSize = true;
            this.lblOutOfStock.BackColor = System.Drawing.Color.Transparent;
            this.lblOutOfStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutOfStock.ForeColor = System.Drawing.Color.Red;
            this.lblOutOfStock.Location = new System.Drawing.Point(49, 77);
            this.lblOutOfStock.Name = "lblOutOfStock";
            this.lblOutOfStock.Size = new System.Drawing.Size(137, 32);
            this.lblOutOfStock.TabIndex = 14;
            this.lblOutOfStock.Text = "Hết hàng";
            // 
            // ItemFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Controls.Add(this.lblOutOfStock);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.pic_food);
            this.Controls.Add(this.lblSelected);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnAdd);
            this.Name = "ItemFood";
            this.Size = new System.Drawing.Size(235, 315);
            ((System.ComponentModel.ISupportInitialize)(this.pic_food)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.Label lbl_price;
        private FontAwesome.Sharp.IconButton btnMinus;
        private FontAwesome.Sharp.IconButton btnAdd;
        private System.Windows.Forms.PictureBox pic_food;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lblOutOfStock;
    }
}
