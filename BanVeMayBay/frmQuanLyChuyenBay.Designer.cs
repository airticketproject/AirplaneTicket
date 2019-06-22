namespace BanVeMayBay
{
    partial class frmQuanLyChuyenBay
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
            this.dtgvDsChuyenBay = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbDonGiaVe = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbSanBayDen = new System.Windows.Forms.ComboBox();
            this.cbbSanBayDi = new System.Windows.Forms.ComboBox();
            this.btnXoaChuyenBay = new System.Windows.Forms.Button();
            this.btnCapNhatChuyenBay = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbSuaSLGheHang2 = new System.Windows.Forms.TextBox();
            this.txbSuaSLGheHang1 = new System.Windows.Forms.TextBox();
            this.suaThoiGianKhoiHanh = new System.Windows.Forms.DateTimePicker();
            this.txbSuaThoiGianBay = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbMaChuyenBay = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDsChuyenBay)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvDsChuyenBay
            // 
            this.dtgvDsChuyenBay.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgvDsChuyenBay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDsChuyenBay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvDsChuyenBay.Location = new System.Drawing.Point(3, 275);
            this.dtgvDsChuyenBay.Name = "dtgvDsChuyenBay";
            this.dtgvDsChuyenBay.RowTemplate.Height = 24;
            this.dtgvDsChuyenBay.Size = new System.Drawing.Size(870, 308);
            this.dtgvDsChuyenBay.TabIndex = 0;
            this.dtgvDsChuyenBay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDsChuyenBay_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.txbDonGiaVe);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbbSanBayDen);
            this.groupBox1.Controls.Add(this.cbbSanBayDi);
            this.groupBox1.Controls.Add(this.btnXoaChuyenBay);
            this.groupBox1.Controls.Add(this.btnCapNhatChuyenBay);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txbSuaSLGheHang2);
            this.groupBox1.Controls.Add(this.txbSuaSLGheHang1);
            this.groupBox1.Controls.Add(this.suaThoiGianKhoiHanh);
            this.groupBox1.Controls.Add(this.txbSuaThoiGianBay);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txbMaChuyenBay);
            this.groupBox1.Controls.Add(this.dtgvDsChuyenBay);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(876, 586);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cập nhật chuyến bay";
            // 
            // txbDonGiaVe
            // 
            this.txbDonGiaVe.BackColor = System.Drawing.Color.White;
            this.txbDonGiaVe.Location = new System.Drawing.Point(676, 125);
            this.txbDonGiaVe.Name = "txbDonGiaVe";
            this.txbDonGiaVe.Size = new System.Drawing.Size(178, 32);
            this.txbDonGiaVe.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(470, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 26);
            this.label8.TabIndex = 21;
            this.label8.Text = "Đơn giá vé";
            // 
            // cbbSanBayDen
            // 
            this.cbbSanBayDen.FormattingEnabled = true;
            this.cbbSanBayDen.Location = new System.Drawing.Point(247, 128);
            this.cbbSanBayDen.Name = "cbbSanBayDen";
            this.cbbSanBayDen.Size = new System.Drawing.Size(200, 32);
            this.cbbSanBayDen.TabIndex = 20;
            // 
            // cbbSanBayDi
            // 
            this.cbbSanBayDi.FormattingEnabled = true;
            this.cbbSanBayDi.Location = new System.Drawing.Point(247, 88);
            this.cbbSanBayDi.Name = "cbbSanBayDi";
            this.cbbSanBayDi.Size = new System.Drawing.Size(200, 32);
            this.cbbSanBayDi.TabIndex = 19;
            // 
            // btnXoaChuyenBay
            // 
            this.btnXoaChuyenBay.Location = new System.Drawing.Point(702, 185);
            this.btnXoaChuyenBay.Name = "btnXoaChuyenBay";
            this.btnXoaChuyenBay.Size = new System.Drawing.Size(152, 55);
            this.btnXoaChuyenBay.TabIndex = 18;
            this.btnXoaChuyenBay.Text = "Xoá";
            this.btnXoaChuyenBay.UseVisualStyleBackColor = true;
            this.btnXoaChuyenBay.Click += new System.EventHandler(this.btnXoaChuyenBay_Click);
            // 
            // btnCapNhatChuyenBay
            // 
            this.btnCapNhatChuyenBay.Location = new System.Drawing.Point(495, 185);
            this.btnCapNhatChuyenBay.Name = "btnCapNhatChuyenBay";
            this.btnCapNhatChuyenBay.Size = new System.Drawing.Size(152, 55);
            this.btnCapNhatChuyenBay.TabIndex = 17;
            this.btnCapNhatChuyenBay.Text = "Cập nhật";
            this.btnCapNhatChuyenBay.UseVisualStyleBackColor = true;
            this.btnCapNhatChuyenBay.Click += new System.EventHandler(this.btnCapNhatChuyenBay_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(470, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 26);
            this.label7.TabIndex = 16;
            this.label7.Text = "Số lượng ghế hạng 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(470, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 26);
            this.label3.TabIndex = 15;
            this.label3.Text = "Số lượng ghế hạng 1";
            // 
            // txbSuaSLGheHang2
            // 
            this.txbSuaSLGheHang2.Location = new System.Drawing.Point(676, 85);
            this.txbSuaSLGheHang2.Name = "txbSuaSLGheHang2";
            this.txbSuaSLGheHang2.Size = new System.Drawing.Size(178, 32);
            this.txbSuaSLGheHang2.TabIndex = 14;
            // 
            // txbSuaSLGheHang1
            // 
            this.txbSuaSLGheHang1.Location = new System.Drawing.Point(676, 47);
            this.txbSuaSLGheHang1.Name = "txbSuaSLGheHang1";
            this.txbSuaSLGheHang1.Size = new System.Drawing.Size(178, 32);
            this.txbSuaSLGheHang1.TabIndex = 13;
            // 
            // suaThoiGianKhoiHanh
            // 
            this.suaThoiGianKhoiHanh.Location = new System.Drawing.Point(247, 170);
            this.suaThoiGianKhoiHanh.Name = "suaThoiGianKhoiHanh";
            this.suaThoiGianKhoiHanh.Size = new System.Drawing.Size(200, 32);
            this.suaThoiGianKhoiHanh.TabIndex = 12;
            // 
            // txbSuaThoiGianBay
            // 
            this.txbSuaThoiGianBay.Location = new System.Drawing.Point(247, 211);
            this.txbSuaThoiGianBay.Name = "txbSuaThoiGianBay";
            this.txbSuaThoiGianBay.Size = new System.Drawing.Size(200, 32);
            this.txbSuaThoiGianBay.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "Thời gian bay";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "Thời gian khởi hành";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sân bay đến";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sân bay đi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã chuyến bay";
            // 
            // txbMaChuyenBay
            // 
            this.txbMaChuyenBay.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txbMaChuyenBay.Enabled = false;
            this.txbMaChuyenBay.Location = new System.Drawing.Point(247, 47);
            this.txbMaChuyenBay.Name = "txbMaChuyenBay";
            this.txbMaChuyenBay.Size = new System.Drawing.Size(200, 32);
            this.txbMaChuyenBay.TabIndex = 1;
            // 
            // frmQuanLyChuyenBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BanVeMayBay.Properties.Resources._0;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(876, 586);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmQuanLyChuyenBay";
            this.Text = "Quản lý chuyến bay";
            this.Load += new System.EventHandler(this.frmQuanLyChuyenBay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDsChuyenBay)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvDsChuyenBay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbMaChuyenBay;
        private System.Windows.Forms.DateTimePicker suaThoiGianKhoiHanh;
        private System.Windows.Forms.TextBox txbSuaThoiGianBay;
        private System.Windows.Forms.TextBox txbSuaSLGheHang2;
        private System.Windows.Forms.TextBox txbSuaSLGheHang1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCapNhatChuyenBay;
        private System.Windows.Forms.Button btnXoaChuyenBay;
        private System.Windows.Forms.ComboBox cbbSanBayDen;
        private System.Windows.Forms.ComboBox cbbSanBayDi;
        private System.Windows.Forms.TextBox txbDonGiaVe;
        private System.Windows.Forms.Label label8;
    }
}