namespace BanVeMayBay
{
    partial class frmLichChuyenBay
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SanBayTrungGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SanBayTrungGian_label = new System.Windows.Forms.Label();
            this.themChuyenBay = new System.Windows.Forms.Button();
            this.Xoa_button = new System.Windows.Forms.Button();
            this.Sua_button = new System.Windows.Forms.Button();
            this.Thoat_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Location = new System.Drawing.Point(229, 19);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(130, 17);
            this.title_label.TabIndex = 0;
            this.title_label.Text = "LỊCH CHUYẾN BAY";
            // 
            // MaChuyenBay_label
            // 
            this.MaChuyenBay_label.AutoSize = true;
            this.MaChuyenBay_label.Location = new System.Drawing.Point(27, 63);
            this.MaChuyenBay_label.Name = "MaChuyenBay_label";
            this.MaChuyenBay_label.Size = new System.Drawing.Size(107, 17);
            this.MaChuyenBay_label.TabIndex = 1;
            this.MaChuyenBay_label.Text = "Mã Chuyến Bay";
            // 
            // SanBayDi_label
            // 
            this.SanBayDi_label.AutoSize = true;
            this.SanBayDi_label.Location = new System.Drawing.Point(27, 117);
            this.SanBayDi_label.Name = "SanBayDi_label";
            this.SanBayDi_label.Size = new System.Drawing.Size(78, 17);
            this.SanBayDi_label.TabIndex = 1;
            this.SanBayDi_label.Text = "Sân Bay Đi";
            // 
            // SanBayDen_label
            // 
            this.SanBayDen_label.AutoSize = true;
            this.SanBayDen_label.Location = new System.Drawing.Point(27, 169);
            this.SanBayDen_label.Name = "SanBayDen_label";
            this.SanBayDen_label.Size = new System.Drawing.Size(91, 17);
            this.SanBayDen_label.TabIndex = 1;
            this.SanBayDen_label.Text = "Sân Bay Đến";
            // 
            // NgayGio_label
            // 
            this.NgayGio_label.AutoSize = true;
            this.NgayGio_label.Location = new System.Drawing.Point(27, 227);
            this.NgayGio_label.Name = "NgayGio_label";
            this.NgayGio_label.Size = new System.Drawing.Size(76, 17);
            this.NgayGio_label.TabIndex = 1;
            this.NgayGio_label.Text = "Ngày - Giờ";
            // 
            // ThoiGianBay_label
            // 
            this.ThoiGianBay_label.AutoSize = true;
            this.ThoiGianBay_label.Location = new System.Drawing.Point(27, 281);
            this.ThoiGianBay_label.Name = "ThoiGianBay_label";
            this.ThoiGianBay_label.Size = new System.Drawing.Size(98, 17);
            this.ThoiGianBay_label.TabIndex = 1;
            this.ThoiGianBay_label.Text = "Thời Gian Bay";
            // 
            // SoLuongGheHang1_label
            // 
            this.SoLuongGheHang1_label.AutoSize = true;
            this.SoLuongGheHang1_label.Location = new System.Drawing.Point(27, 333);
            this.SoLuongGheHang1_label.Name = "SoLuongGheHang1_label";
            this.SoLuongGheHang1_label.Size = new System.Drawing.Size(150, 17);
            this.SoLuongGheHang1_label.TabIndex = 1;
            this.SoLuongGheHang1_label.Text = "Số Lượng Ghế Hạng 1";
            // 
            // SoLuongGheHang2_label
            // 
            this.SoLuongGheHang2_label.AutoSize = true;
            this.SoLuongGheHang2_label.Location = new System.Drawing.Point(27, 373);
            this.SoLuongGheHang2_label.Name = "SoLuongGheHang2_label";
            this.SoLuongGheHang2_label.Size = new System.Drawing.Size(150, 17);
            this.SoLuongGheHang2_label.TabIndex = 1;
            this.SoLuongGheHang2_label.Text = "Số Lượng Ghế Hạng 2";
            // 
            // cbbSanBayDi
            // 
            this.cbbSanBayDi.FormattingEnabled = true;
            this.cbbSanBayDi.Location = new System.Drawing.Point(280, 114);
            this.cbbSanBayDi.Name = "cbbSanBayDi";
            this.cbbSanBayDi.Size = new System.Drawing.Size(231, 24);
            this.cbbSanBayDi.TabIndex = 2;
            // 
            // ngayKhoiHanh
            // 
            this.ngayKhoiHanh.Location = new System.Drawing.Point(280, 227);
            this.ngayKhoiHanh.Name = "ngayKhoiHanh";
            this.ngayKhoiHanh.Size = new System.Drawing.Size(231, 22);
            this.ngayKhoiHanh.TabIndex = 3;
            // 
            // txbMaChuyenBay
            // 
            this.txbMaChuyenBay.Location = new System.Drawing.Point(280, 60);
            this.txbMaChuyenBay.Name = "txbMaChuyenBay";
            this.txbMaChuyenBay.Size = new System.Drawing.Size(231, 22);
            this.txbMaChuyenBay.TabIndex = 4;
            // 
            // cbbSanBayDen
            // 
            this.cbbSanBayDen.FormattingEnabled = true;
            this.cbbSanBayDen.Location = new System.Drawing.Point(280, 166);
            this.cbbSanBayDen.Name = "cbbSanBayDen";
            this.cbbSanBayDen.Size = new System.Drawing.Size(231, 24);
            this.cbbSanBayDen.TabIndex = 2;
            // 
            // txbThoiGianBay
            // 
            this.txbThoiGianBay.Location = new System.Drawing.Point(280, 278);
            this.txbThoiGianBay.Name = "txbThoiGianBay";
            this.txbThoiGianBay.Size = new System.Drawing.Size(231, 22);
            this.txbThoiGianBay.TabIndex = 4;
            // 
            // txbSLGheHang1
            // 
            this.txbSLGheHang1.Location = new System.Drawing.Point(280, 330);
            this.txbSLGheHang1.Name = "txbSLGheHang1";
            this.txbSLGheHang1.Size = new System.Drawing.Size(231, 22);
            this.txbSLGheHang1.TabIndex = 4;
            // 
            // txbSLGheHang2
            // 
            this.txbSLGheHang2.Location = new System.Drawing.Point(280, 368);
            this.txbSLGheHang2.Name = "txbSLGheHang2";
            this.txbSLGheHang2.Size = new System.Drawing.Size(231, 22);
            this.txbSLGheHang2.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.SanBayTrungGian,
            this.ThoiGianDung,
            this.GhiChu});
            this.dataGridView1.Location = new System.Drawing.Point(30, 451);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(569, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // SanBayTrungGian
            // 
            this.SanBayTrungGian.HeaderText = "Sân Bay Trung Gian";
            this.SanBayTrungGian.Name = "SanBayTrungGian";
            // 
            // ThoiGianDung
            // 
            this.ThoiGianDung.HeaderText = "Thời Gian Dừng";
            this.ThoiGianDung.Name = "ThoiGianDung";
            // 
            // GhiChu
            // 
            this.GhiChu.HeaderText = "Ghi Chú";
            this.GhiChu.Name = "GhiChu";
            // 
            // SanBayTrungGian_label
            // 
            this.SanBayTrungGian_label.AutoSize = true;
            this.SanBayTrungGian_label.Location = new System.Drawing.Point(27, 418);
            this.SanBayTrungGian_label.Name = "SanBayTrungGian_label";
            this.SanBayTrungGian_label.Size = new System.Drawing.Size(137, 17);
            this.SanBayTrungGian_label.TabIndex = 1;
            this.SanBayTrungGian_label.Text = "Sân Bay Trung Gian";
            // 
            // themChuyenBay
            // 
            this.themChuyenBay.Location = new System.Drawing.Point(28, 633);
            this.themChuyenBay.Name = "themChuyenBay";
            this.themChuyenBay.Size = new System.Drawing.Size(106, 40);
            this.themChuyenBay.TabIndex = 6;
            this.themChuyenBay.Text = "Thêm";
            this.themChuyenBay.UseVisualStyleBackColor = true;
            this.themChuyenBay.Click += new System.EventHandler(this.themChuyenBay_Click);
            // 
            // Xoa_button
            // 
            this.Xoa_button.Location = new System.Drawing.Point(181, 633);
            this.Xoa_button.Name = "Xoa_button";
            this.Xoa_button.Size = new System.Drawing.Size(106, 40);
            this.Xoa_button.TabIndex = 6;
            this.Xoa_button.Text = "Xóa";
            this.Xoa_button.UseVisualStyleBackColor = true;
            // 
            // Sua_button
            // 
            this.Sua_button.Location = new System.Drawing.Point(339, 633);
            this.Sua_button.Name = "Sua_button";
            this.Sua_button.Size = new System.Drawing.Size(106, 40);
            this.Sua_button.TabIndex = 6;
            this.Sua_button.Text = "Sửa";
            this.Sua_button.UseVisualStyleBackColor = true;
            // 
            // Thoat_button
            // 
            this.Thoat_button.Location = new System.Drawing.Point(493, 633);
            this.Thoat_button.Name = "Thoat_button";
            this.Thoat_button.Size = new System.Drawing.Size(106, 40);
            this.Thoat_button.TabIndex = 6;
            this.Thoat_button.Text = "Thoát";
            this.Thoat_button.UseVisualStyleBackColor = true;
            // 
            // frmLichChuyenBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 685);
            this.Controls.Add(this.Thoat_button);
            this.Controls.Add(this.Sua_button);
            this.Controls.Add(this.Xoa_button);
            this.Controls.Add(this.themChuyenBay);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txbSLGheHang2);
            this.Controls.Add(this.txbSLGheHang1);
            this.Controls.Add(this.txbThoiGianBay);
            this.Controls.Add(this.txbMaChuyenBay);
            this.Controls.Add(this.ngayKhoiHanh);
            this.Controls.Add(this.cbbSanBayDen);
            this.Controls.Add(this.cbbSanBayDi);
            this.Controls.Add(this.SanBayTrungGian_label);
            this.Controls.Add(this.SoLuongGheHang2_label);
            this.Controls.Add(this.SoLuongGheHang1_label);
            this.Controls.Add(this.ThoiGianBay_label);
            this.Controls.Add(this.NgayGio_label);
            this.Controls.Add(this.SanBayDen_label);
            this.Controls.Add(this.SanBayDi_label);
            this.Controls.Add(this.MaChuyenBay_label);
            this.Controls.Add(this.title_label);
            this.Name = "frmLichChuyenBay";
            this.Text = "LichChuyenBay";
            this.Load += new System.EventHandler(this.frmLichChuyenBay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label SanBayTrungGian_label;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SanBayTrungGian;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.Button themChuyenBay;
        private System.Windows.Forms.Button Xoa_button;
        private System.Windows.Forms.Button Sua_button;
        private System.Windows.Forms.Button Thoat_button;
    }
}

