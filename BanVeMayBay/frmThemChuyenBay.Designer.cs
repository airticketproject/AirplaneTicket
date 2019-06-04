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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sanBayTrungGian)).BeginInit();
            this.SuspendLayout();
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Location = new System.Drawing.Point(267, 9);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(130, 17);
            this.title_label.TabIndex = 0;
            this.title_label.Text = "LỊCH CHUYẾN BAY";
            // 
            // MaChuyenBay_label
            // 
            this.MaChuyenBay_label.AutoSize = true;
            this.MaChuyenBay_label.Location = new System.Drawing.Point(60, 60);
            this.MaChuyenBay_label.Name = "MaChuyenBay_label";
            this.MaChuyenBay_label.Size = new System.Drawing.Size(107, 17);
            this.MaChuyenBay_label.TabIndex = 1;
            this.MaChuyenBay_label.Text = "Mã Chuyến Bay";
            // 
            // SanBayDi_label
            // 
            this.SanBayDi_label.AutoSize = true;
            this.SanBayDi_label.Location = new System.Drawing.Point(61, 100);
            this.SanBayDi_label.Name = "SanBayDi_label";
            this.SanBayDi_label.Size = new System.Drawing.Size(78, 17);
            this.SanBayDi_label.TabIndex = 1;
            this.SanBayDi_label.Text = "Sân Bay Đi";
            // 
            // SanBayDen_label
            // 
            this.SanBayDen_label.AutoSize = true;
            this.SanBayDen_label.Location = new System.Drawing.Point(61, 143);
            this.SanBayDen_label.Name = "SanBayDen_label";
            this.SanBayDen_label.Size = new System.Drawing.Size(91, 17);
            this.SanBayDen_label.TabIndex = 1;
            this.SanBayDen_label.Text = "Sân Bay Đến";
            // 
            // NgayGio_label
            // 
            this.NgayGio_label.AutoSize = true;
            this.NgayGio_label.Location = new System.Drawing.Point(61, 186);
            this.NgayGio_label.Name = "NgayGio_label";
            this.NgayGio_label.Size = new System.Drawing.Size(76, 17);
            this.NgayGio_label.TabIndex = 1;
            this.NgayGio_label.Text = "Ngày - Giờ";
            // 
            // ThoiGianBay_label
            // 
            this.ThoiGianBay_label.AutoSize = true;
            this.ThoiGianBay_label.Location = new System.Drawing.Point(60, 226);
            this.ThoiGianBay_label.Name = "ThoiGianBay_label";
            this.ThoiGianBay_label.Size = new System.Drawing.Size(98, 17);
            this.ThoiGianBay_label.TabIndex = 1;
            this.ThoiGianBay_label.Text = "Thời Gian Bay";
            // 
            // SoLuongGheHang1_label
            // 
            this.SoLuongGheHang1_label.AutoSize = true;
            this.SoLuongGheHang1_label.Location = new System.Drawing.Point(61, 260);
            this.SoLuongGheHang1_label.Name = "SoLuongGheHang1_label";
            this.SoLuongGheHang1_label.Size = new System.Drawing.Size(150, 17);
            this.SoLuongGheHang1_label.TabIndex = 1;
            this.SoLuongGheHang1_label.Text = "Số Lượng Ghế Hạng 1";
            // 
            // SoLuongGheHang2_label
            // 
            this.SoLuongGheHang2_label.AutoSize = true;
            this.SoLuongGheHang2_label.Location = new System.Drawing.Point(61, 297);
            this.SoLuongGheHang2_label.Name = "SoLuongGheHang2_label";
            this.SoLuongGheHang2_label.Size = new System.Drawing.Size(150, 17);
            this.SoLuongGheHang2_label.TabIndex = 1;
            this.SoLuongGheHang2_label.Text = "Số Lượng Ghế Hạng 2";
            // 
            // cbbSanBayDi
            // 
            this.cbbSanBayDi.FormattingEnabled = true;
            this.cbbSanBayDi.Location = new System.Drawing.Point(314, 97);
            this.cbbSanBayDi.Name = "cbbSanBayDi";
            this.cbbSanBayDi.Size = new System.Drawing.Size(231, 24);
            this.cbbSanBayDi.TabIndex = 2;
            // 
            // ngayKhoiHanh
            // 
            this.ngayKhoiHanh.Location = new System.Drawing.Point(314, 186);
            this.ngayKhoiHanh.Name = "ngayKhoiHanh";
            this.ngayKhoiHanh.Size = new System.Drawing.Size(231, 22);
            this.ngayKhoiHanh.TabIndex = 3;
            // 
            // txbMaChuyenBay
            // 
            this.txbMaChuyenBay.Location = new System.Drawing.Point(314, 57);
            this.txbMaChuyenBay.Name = "txbMaChuyenBay";
            this.txbMaChuyenBay.Size = new System.Drawing.Size(231, 22);
            this.txbMaChuyenBay.TabIndex = 4;
            // 
            // cbbSanBayDen
            // 
            this.cbbSanBayDen.FormattingEnabled = true;
            this.cbbSanBayDen.Location = new System.Drawing.Point(314, 140);
            this.cbbSanBayDen.Name = "cbbSanBayDen";
            this.cbbSanBayDen.Size = new System.Drawing.Size(231, 24);
            this.cbbSanBayDen.TabIndex = 2;
            // 
            // txbThoiGianBay
            // 
            this.txbThoiGianBay.Location = new System.Drawing.Point(314, 223);
            this.txbThoiGianBay.Name = "txbThoiGianBay";
            this.txbThoiGianBay.Size = new System.Drawing.Size(231, 22);
            this.txbThoiGianBay.TabIndex = 4;
            // 
            // txbSLGheHang1
            // 
            this.txbSLGheHang1.Location = new System.Drawing.Point(314, 257);
            this.txbSLGheHang1.Name = "txbSLGheHang1";
            this.txbSLGheHang1.Size = new System.Drawing.Size(231, 22);
            this.txbSLGheHang1.TabIndex = 4;
            // 
            // txbSLGheHang2
            // 
            this.txbSLGheHang2.Location = new System.Drawing.Point(314, 294);
            this.txbSLGheHang2.Name = "txbSLGheHang2";
            this.txbSLGheHang2.Size = new System.Drawing.Size(231, 22);
            this.txbSLGheHang2.TabIndex = 4;
            // 
            // themChuyenBay
            // 
            this.themChuyenBay.Location = new System.Drawing.Point(270, 543);
            this.themChuyenBay.Name = "themChuyenBay";
            this.themChuyenBay.Size = new System.Drawing.Size(106, 40);
            this.themChuyenBay.TabIndex = 6;
            this.themChuyenBay.Text = "Lưu";
            this.themChuyenBay.UseVisualStyleBackColor = true;
            this.themChuyenBay.Click += new System.EventHandler(this.themChuyenBay_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonXoaSanBayTrungGian);
            this.groupBox1.Controls.Add(this.buttonThemSanBayTrungGian);
            this.groupBox1.Controls.Add(this.sanBayTrungGian);
            this.groupBox1.Location = new System.Drawing.Point(23, 333);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 204);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sân bay trung gian";
            // 
            // buttonXoaSanBayTrungGian
            // 
            this.buttonXoaSanBayTrungGian.Location = new System.Drawing.Point(402, 162);
            this.buttonXoaSanBayTrungGian.Name = "buttonXoaSanBayTrungGian";
            this.buttonXoaSanBayTrungGian.Size = new System.Drawing.Size(103, 36);
            this.buttonXoaSanBayTrungGian.TabIndex = 1;
            this.buttonXoaSanBayTrungGian.Text = "Xóa";
            this.buttonXoaSanBayTrungGian.UseVisualStyleBackColor = true;
            // 
            // buttonThemSanBayTrungGian
            // 
            this.buttonThemSanBayTrungGian.Location = new System.Drawing.Point(110, 162);
            this.buttonThemSanBayTrungGian.Name = "buttonThemSanBayTrungGian";
            this.buttonThemSanBayTrungGian.Size = new System.Drawing.Size(103, 36);
            this.buttonThemSanBayTrungGian.TabIndex = 1;
            this.buttonThemSanBayTrungGian.Text = "Thêm";
            this.buttonThemSanBayTrungGian.UseVisualStyleBackColor = true;
            this.buttonThemSanBayTrungGian.Click += new System.EventHandler(this.buttonThemSanBayTrungGian_Click);
            // 
            // sanBayTrungGian
            // 
            this.sanBayTrungGian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sanBayTrungGian.Location = new System.Drawing.Point(3, 18);
            this.sanBayTrungGian.Name = "sanBayTrungGian";
            this.sanBayTrungGian.RowTemplate.Height = 24;
            this.sanBayTrungGian.Size = new System.Drawing.Size(584, 138);
            this.sanBayTrungGian.TabIndex = 0;
            // 
            // frmThemChuyenBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 595);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.themChuyenBay);
            this.Controls.Add(this.txbSLGheHang2);
            this.Controls.Add(this.txbSLGheHang1);
            this.Controls.Add(this.txbThoiGianBay);
            this.Controls.Add(this.txbMaChuyenBay);
            this.Controls.Add(this.ngayKhoiHanh);
            this.Controls.Add(this.cbbSanBayDen);
            this.Controls.Add(this.cbbSanBayDi);
            this.Controls.Add(this.SoLuongGheHang2_label);
            this.Controls.Add(this.SoLuongGheHang1_label);
            this.Controls.Add(this.ThoiGianBay_label);
            this.Controls.Add(this.NgayGio_label);
            this.Controls.Add(this.SanBayDen_label);
            this.Controls.Add(this.SanBayDi_label);
            this.Controls.Add(this.MaChuyenBay_label);
            this.Controls.Add(this.title_label);
            this.Name = "frmThemChuyenBay";
            this.Text = "LichChuyenBay";
            this.Load += new System.EventHandler(this.frmLichChuyenBay_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sanBayTrungGian)).EndInit();
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
    }
}

