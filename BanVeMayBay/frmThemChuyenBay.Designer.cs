namespace BanVeMayBay
{
    partial class frmThemChuyenBay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemChuyenBay));
            this.title_label = new System.Windows.Forms.Label();
            this.MaChuyenBay_label = new System.Windows.Forms.Label();
            this.SanBayDi_label = new System.Windows.Forms.Label();
            this.SanBayDen_label = new System.Windows.Forms.Label();
            this.NgayGio_label = new System.Windows.Forms.Label();
            this.ThoiGianBay_label = new System.Windows.Forms.Label();
            this.SoLuongGheHang1_label = new System.Windows.Forms.Label();
            this.SoLuongGheHang2_label = new System.Windows.Forms.Label();
            this.cbbSanBayDi = new System.Windows.Forms.ComboBox();
            this.ngayKhoiHanh = new System.Windows.Forms.DateTimePicker();
            this.txbMaChuyenBay = new System.Windows.Forms.TextBox();
            this.cbbSanBayDen = new System.Windows.Forms.ComboBox();
            this.txbThoiGianBay = new System.Windows.Forms.TextBox();
            this.txbSLGheHang1 = new System.Windows.Forms.TextBox();
            this.txbSLGheHang2 = new System.Windows.Forms.TextBox();
            this.themChuyenBay = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonXoaSanBayTrungGian = new System.Windows.Forms.Button();
            this.buttonThemSanBayTrungGian = new System.Windows.Forms.Button();
            this.sanBayTrungGian = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txbDonGiaVe = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sanBayTrungGian)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.BackColor = System.Drawing.Color.Transparent;
            this.title_label.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.title_label.Location = new System.Drawing.Point(498, 9);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(399, 51);
            this.title_label.TabIndex = 0;
            this.title_label.Text = "THÊM CHUYẾN BAY";
            // 
            // MaChuyenBay_label
            // 
            this.MaChuyenBay_label.AutoSize = true;
            this.MaChuyenBay_label.Location = new System.Drawing.Point(45, 62);
            this.MaChuyenBay_label.Name = "MaChuyenBay_label";
            this.MaChuyenBay_label.Size = new System.Drawing.Size(156, 26);
            this.MaChuyenBay_label.TabIndex = 1;
            this.MaChuyenBay_label.Text = "Mã Chuyến Bay";
            // 
            // SanBayDi_label
            // 
            this.SanBayDi_label.AutoSize = true;
            this.SanBayDi_label.Location = new System.Drawing.Point(45, 110);
            this.SanBayDi_label.Name = "SanBayDi_label";
            this.SanBayDi_label.Size = new System.Drawing.Size(112, 26);
            this.SanBayDi_label.TabIndex = 1;
            this.SanBayDi_label.Text = "Sân Bay Đi";
            // 
            // SanBayDen_label
            // 
            this.SanBayDen_label.AutoSize = true;
            this.SanBayDen_label.Location = new System.Drawing.Point(45, 160);
            this.SanBayDen_label.Name = "SanBayDen_label";
            this.SanBayDen_label.Size = new System.Drawing.Size(128, 26);
            this.SanBayDen_label.TabIndex = 1;
            this.SanBayDen_label.Text = "Sân Bay Đến";
            // 
            // NgayGio_label
            // 
            this.NgayGio_label.AutoSize = true;
            this.NgayGio_label.Location = new System.Drawing.Point(45, 215);
            this.NgayGio_label.Name = "NgayGio_label";
            this.NgayGio_label.Size = new System.Drawing.Size(109, 26);
            this.NgayGio_label.TabIndex = 1;
            this.NgayGio_label.Text = "Ngày - Giờ";
            // 
            // ThoiGianBay_label
            // 
            this.ThoiGianBay_label.AutoSize = true;
            this.ThoiGianBay_label.Location = new System.Drawing.Point(45, 269);
            this.ThoiGianBay_label.Name = "ThoiGianBay_label";
            this.ThoiGianBay_label.Size = new System.Drawing.Size(142, 26);
            this.ThoiGianBay_label.TabIndex = 1;
            this.ThoiGianBay_label.Text = "Thời Gian Bay";
            // 
            // SoLuongGheHang1_label
            // 
            this.SoLuongGheHang1_label.AutoSize = true;
            this.SoLuongGheHang1_label.Location = new System.Drawing.Point(45, 328);
            this.SoLuongGheHang1_label.Name = "SoLuongGheHang1_label";
            this.SoLuongGheHang1_label.Size = new System.Drawing.Size(211, 26);
            this.SoLuongGheHang1_label.TabIndex = 1;
            this.SoLuongGheHang1_label.Text = "Số Lượng Ghế Hạng 1";
            // 
            // SoLuongGheHang2_label
            // 
            this.SoLuongGheHang2_label.AutoSize = true;
            this.SoLuongGheHang2_label.Location = new System.Drawing.Point(45, 383);
            this.SoLuongGheHang2_label.Name = "SoLuongGheHang2_label";
            this.SoLuongGheHang2_label.Size = new System.Drawing.Size(211, 26);
            this.SoLuongGheHang2_label.TabIndex = 1;
            this.SoLuongGheHang2_label.Text = "Số Lượng Ghế Hạng 2";
            // 
            // cbbSanBayDi
            // 
            this.cbbSanBayDi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSanBayDi.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSanBayDi.FormattingEnabled = true;
            this.cbbSanBayDi.Location = new System.Drawing.Point(281, 107);
            this.cbbSanBayDi.Name = "cbbSanBayDi";
            this.cbbSanBayDi.Size = new System.Drawing.Size(231, 32);
            this.cbbSanBayDi.TabIndex = 1;
            // 
            // ngayKhoiHanh
            // 
            this.ngayKhoiHanh.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngayKhoiHanh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngayKhoiHanh.Location = new System.Drawing.Point(281, 209);
            this.ngayKhoiHanh.Name = "ngayKhoiHanh";
            this.ngayKhoiHanh.Size = new System.Drawing.Size(231, 32);
            this.ngayKhoiHanh.TabIndex = 3;
            // 
            // txbMaChuyenBay
            // 
            this.txbMaChuyenBay.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMaChuyenBay.Location = new System.Drawing.Point(281, 59);
            this.txbMaChuyenBay.Name = "txbMaChuyenBay";
            this.txbMaChuyenBay.Size = new System.Drawing.Size(231, 32);
            this.txbMaChuyenBay.TabIndex = 0;
            this.txbMaChuyenBay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbMaChuyenBay_KeyPress);
            // 
            // cbbSanBayDen
            // 
            this.cbbSanBayDen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSanBayDen.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSanBayDen.FormattingEnabled = true;
            this.cbbSanBayDen.Location = new System.Drawing.Point(281, 157);
            this.cbbSanBayDen.Name = "cbbSanBayDen";
            this.cbbSanBayDen.Size = new System.Drawing.Size(231, 32);
            this.cbbSanBayDen.TabIndex = 2;
            // 
            // txbThoiGianBay
            // 
            this.txbThoiGianBay.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbThoiGianBay.Location = new System.Drawing.Point(281, 266);
            this.txbThoiGianBay.Name = "txbThoiGianBay";
            this.txbThoiGianBay.Size = new System.Drawing.Size(231, 32);
            this.txbThoiGianBay.TabIndex = 4;
            this.txbThoiGianBay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbThoiGianBay_KeyPress);
            // 
            // txbSLGheHang1
            // 
            this.txbSLGheHang1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSLGheHang1.Location = new System.Drawing.Point(281, 325);
            this.txbSLGheHang1.Name = "txbSLGheHang1";
            this.txbSLGheHang1.Size = new System.Drawing.Size(231, 32);
            this.txbSLGheHang1.TabIndex = 5;
            this.txbSLGheHang1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSLGheHang1_KeyPress);
            // 
            // txbSLGheHang2
            // 
            this.txbSLGheHang2.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSLGheHang2.Location = new System.Drawing.Point(281, 380);
            this.txbSLGheHang2.Name = "txbSLGheHang2";
            this.txbSLGheHang2.Size = new System.Drawing.Size(231, 32);
            this.txbSLGheHang2.TabIndex = 6;
            this.txbSLGheHang2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSLGheHang2_KeyPress);
            // 
            // themChuyenBay
            // 
            this.themChuyenBay.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themChuyenBay.ForeColor = System.Drawing.Color.Navy;
            this.themChuyenBay.Location = new System.Drawing.Point(839, 486);
            this.themChuyenBay.Name = "themChuyenBay";
            this.themChuyenBay.Size = new System.Drawing.Size(106, 40);
            this.themChuyenBay.TabIndex = 6;
            this.themChuyenBay.Text = "Lưu";
            this.themChuyenBay.UseVisualStyleBackColor = true;
            this.themChuyenBay.Click += new System.EventHandler(this.themChuyenBay_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.buttonXoaSanBayTrungGian);
            this.groupBox1.Controls.Add(this.buttonThemSanBayTrungGian);
            this.groupBox1.Controls.Add(this.sanBayTrungGian);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(707, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 354);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sân bay trung gian";
            // 
            // buttonXoaSanBayTrungGian
            // 
            this.buttonXoaSanBayTrungGian.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoaSanBayTrungGian.Location = new System.Drawing.Point(391, 287);
            this.buttonXoaSanBayTrungGian.Name = "buttonXoaSanBayTrungGian";
            this.buttonXoaSanBayTrungGian.Size = new System.Drawing.Size(103, 36);
            this.buttonXoaSanBayTrungGian.TabIndex = 1;
            this.buttonXoaSanBayTrungGian.Text = "Xóa";
            this.buttonXoaSanBayTrungGian.UseVisualStyleBackColor = true;
            // 
            // buttonThemSanBayTrungGian
            // 
            this.buttonThemSanBayTrungGian.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThemSanBayTrungGian.Location = new System.Drawing.Point(132, 287);
            this.buttonThemSanBayTrungGian.Name = "buttonThemSanBayTrungGian";
            this.buttonThemSanBayTrungGian.Size = new System.Drawing.Size(103, 36);
            this.buttonThemSanBayTrungGian.TabIndex = 1;
            this.buttonThemSanBayTrungGian.Text = "Thêm";
            this.buttonThemSanBayTrungGian.UseVisualStyleBackColor = true;
            this.buttonThemSanBayTrungGian.Click += new System.EventHandler(this.buttonThemSanBayTrungGian_Click);
            // 
            // sanBayTrungGian
            // 
            this.sanBayTrungGian.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.sanBayTrungGian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sanBayTrungGian.Dock = System.Windows.Forms.DockStyle.Top;
            this.sanBayTrungGian.Location = new System.Drawing.Point(3, 28);
            this.sanBayTrungGian.Name = "sanBayTrungGian";
            this.sanBayTrungGian.RowTemplate.Height = 24;
            this.sanBayTrungGian.Size = new System.Drawing.Size(571, 239);
            this.sanBayTrungGian.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 441);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đơn giá vé";
            // 
            // txbDonGiaVe
            // 
            this.txbDonGiaVe.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDonGiaVe.Location = new System.Drawing.Point(281, 438);
            this.txbDonGiaVe.Name = "txbDonGiaVe";
            this.txbDonGiaVe.Size = new System.Drawing.Size(231, 32);
            this.txbDonGiaVe.TabIndex = 7;
            this.txbDonGiaVe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbDonGiaVe_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.MaChuyenBay_label);
            this.groupBox2.Controls.Add(this.SanBayDi_label);
            this.groupBox2.Controls.Add(this.SanBayDen_label);
            this.groupBox2.Controls.Add(this.txbDonGiaVe);
            this.groupBox2.Controls.Add(this.NgayGio_label);
            this.groupBox2.Controls.Add(this.txbSLGheHang2);
            this.groupBox2.Controls.Add(this.cbbSanBayDi);
            this.groupBox2.Controls.Add(this.txbSLGheHang1);
            this.groupBox2.Controls.Add(this.cbbSanBayDen);
            this.groupBox2.Controls.Add(this.txbThoiGianBay);
            this.groupBox2.Controls.Add(this.ngayKhoiHanh);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txbMaChuyenBay);
            this.groupBox2.Controls.Add(this.SoLuongGheHang2_label);
            this.groupBox2.Controls.Add(this.ThoiGianBay_label);
            this.groupBox2.Controls.Add(this.SoLuongGheHang1_label);
            this.groupBox2.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Navy;
            this.groupBox2.Location = new System.Drawing.Point(12, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(680, 523);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chuyến bay";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.ForeColor = System.Drawing.Color.Navy;
            this.btn_Thoat.Location = new System.Drawing.Point(1095, 486);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(106, 40);
            this.btn_Thoat.TabIndex = 6;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // frmThemChuyenBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::BanVeMayBay.Properties.Resources._0;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1299, 625);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.themChuyenBay);
            this.Controls.Add(this.title_label);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmThemChuyenBay";
            this.Text = "Thêm Chuyến Bay";
            this.Load += new System.EventHandler(this.frmLichChuyenBay_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sanBayTrungGian)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Label MaChuyenBay_label;
        private System.Windows.Forms.Label SanBayDi_label;
        private System.Windows.Forms.Label SanBayDen_label;
        private System.Windows.Forms.Label NgayGio_label;
        private System.Windows.Forms.Label ThoiGianBay_label;
        private System.Windows.Forms.Label SoLuongGheHang1_label;
        private System.Windows.Forms.Label SoLuongGheHang2_label;
        private System.Windows.Forms.ComboBox cbbSanBayDi;
        private System.Windows.Forms.DateTimePicker ngayKhoiHanh;
        private System.Windows.Forms.TextBox txbMaChuyenBay;
        private System.Windows.Forms.ComboBox cbbSanBayDen;
        private System.Windows.Forms.TextBox txbThoiGianBay;
        private System.Windows.Forms.TextBox txbSLGheHang1;
        private System.Windows.Forms.TextBox txbSLGheHang2;
        private System.Windows.Forms.Button themChuyenBay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonXoaSanBayTrungGian;
        private System.Windows.Forms.Button buttonThemSanBayTrungGian;
        private System.Windows.Forms.DataGridView sanBayTrungGian;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbDonGiaVe;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Thoat;
    }
}

