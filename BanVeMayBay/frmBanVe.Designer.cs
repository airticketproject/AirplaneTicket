﻿namespace BanVeMayBay
{
    partial class frmBanVe
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
            this.label = new System.Windows.Forms.Label();
            this.Thoat_button = new System.Windows.Forms.Button();
            this.Luu_button = new System.Windows.Forms.Button();
            this.txbGiaTien = new System.Windows.Forms.TextBox();
            this.HangVe_comboBox = new System.Windows.Forms.ComboBox();
            this.MaHanhKhach_comboBox = new System.Windows.Forms.ComboBox();
            this.MaChuyenBay_comboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbThoiGianBay = new System.Windows.Forms.TextBox();
            this.txbSanBayDen = new System.Windows.Forms.TextBox();
            this.txbSanBayDi = new System.Windows.Forms.TextBox();
            this.SanBayDi_label = new System.Windows.Forms.Label();
            this.txbNgayGio = new System.Windows.Forms.TextBox();
            this.SanBayDen_label = new System.Windows.Forms.Label();
            this.NgayGio_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbCMND = new System.Windows.Forms.TextBox();
            this.txbTenKhachHang = new System.Windows.Forms.TextBox();
            this.DienThoai_label = new System.Windows.Forms.Label();
            this.CMND_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TenHanhKhach_label = new System.Windows.Forms.Label();
            this.MaHanhKhach_label = new System.Windows.Forms.Label();
            this.MaChuyenBay_label = new System.Windows.Forms.Label();
            this.txbDienThoai = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ThemHanhKhach_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(334, 31);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(150, 17);
            this.label.TabIndex = 0;
            this.label.Text = "BÁN VÉ CHUYẾN BAY";
            // 
            // Thoat_button
            // 
            this.Thoat_button.Location = new System.Drawing.Point(460, 483);
            this.Thoat_button.Name = "Thoat_button";
            this.Thoat_button.Size = new System.Drawing.Size(138, 40);
            this.Thoat_button.TabIndex = 19;
            this.Thoat_button.Text = "Thoát";
            this.Thoat_button.UseVisualStyleBackColor = true;
            this.Thoat_button.Click += new System.EventHandler(this.Thoat_button_Click);
            // 
            // Luu_button
            // 
            this.Luu_button.Location = new System.Drawing.Point(160, 483);
            this.Luu_button.Name = "Luu_button";
            this.Luu_button.Size = new System.Drawing.Size(146, 40);
            this.Luu_button.TabIndex = 20;
            this.Luu_button.Text = "Xuất vé";
            this.Luu_button.UseVisualStyleBackColor = true;
            this.Luu_button.Click += new System.EventHandler(this.Luu_button_Click);
            // 
            // txbGiaTien
            // 
            this.txbGiaTien.BackColor = System.Drawing.Color.White;
            this.txbGiaTien.Enabled = false;
            this.txbGiaTien.Location = new System.Drawing.Point(182, 432);
            this.txbGiaTien.Name = "txbGiaTien";
            this.txbGiaTien.Size = new System.Drawing.Size(201, 22);
            this.txbGiaTien.TabIndex = 17;
            // 
            // HangVe_comboBox
            // 
            this.HangVe_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HangVe_comboBox.FormattingEnabled = true;
            this.HangVe_comboBox.Location = new System.Drawing.Point(183, 393);
            this.HangVe_comboBox.Name = "HangVe_comboBox";
            this.HangVe_comboBox.Size = new System.Drawing.Size(200, 24);
            this.HangVe_comboBox.TabIndex = 14;
            this.HangVe_comboBox.SelectedIndexChanged += new System.EventHandler(this.HangVe_comboBox_SelectedIndexChanged);
            // 
            // MaHanhKhach_comboBox
            // 
            this.MaHanhKhach_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MaHanhKhach_comboBox.FormattingEnabled = true;
            this.MaHanhKhach_comboBox.Location = new System.Drawing.Point(185, 233);
            this.MaHanhKhach_comboBox.Name = "MaHanhKhach_comboBox";
            this.MaHanhKhach_comboBox.Size = new System.Drawing.Size(200, 24);
            this.MaHanhKhach_comboBox.TabIndex = 15;
            this.MaHanhKhach_comboBox.SelectedIndexChanged += new System.EventHandler(this.MaHanhKhach_comboBox_SelectedIndexChanged);
            // 
            // MaChuyenBay_comboBox
            // 
            this.MaChuyenBay_comboBox.AllowDrop = true;
            this.MaChuyenBay_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MaChuyenBay_comboBox.FormattingEnabled = true;
            this.MaChuyenBay_comboBox.Location = new System.Drawing.Point(183, 65);
            this.MaChuyenBay_comboBox.Name = "MaChuyenBay_comboBox";
            this.MaChuyenBay_comboBox.Size = new System.Drawing.Size(200, 24);
            this.MaChuyenBay_comboBox.TabIndex = 16;
            this.MaChuyenBay_comboBox.SelectedIndexChanged += new System.EventHandler(this.MaChuyenBay_comboBox_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txbThoiGianBay);
            this.groupBox2.Controls.Add(this.txbSanBayDen);
            this.groupBox2.Controls.Add(this.txbSanBayDi);
            this.groupBox2.Controls.Add(this.SanBayDi_label);
            this.groupBox2.Controls.Add(this.txbNgayGio);
            this.groupBox2.Controls.Add(this.SanBayDen_label);
            this.groupBox2.Controls.Add(this.NgayGio_label);
            this.groupBox2.Location = new System.Drawing.Point(27, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(727, 105);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chuyến bay";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(397, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Thời gian bay";
            // 
            // txbThoiGianBay
            // 
            this.txbThoiGianBay.BackColor = System.Drawing.Color.White;
            this.txbThoiGianBay.Enabled = false;
            this.txbThoiGianBay.ForeColor = System.Drawing.SystemColors.Window;
            this.txbThoiGianBay.Location = new System.Drawing.Point(515, 64);
            this.txbThoiGianBay.Name = "txbThoiGianBay";
            this.txbThoiGianBay.Size = new System.Drawing.Size(200, 22);
            this.txbThoiGianBay.TabIndex = 7;
            // 
            // txbSanBayDen
            // 
            this.txbSanBayDen.BackColor = System.Drawing.Color.White;
            this.txbSanBayDen.Enabled = false;
            this.txbSanBayDen.ForeColor = System.Drawing.SystemColors.Window;
            this.txbSanBayDen.Location = new System.Drawing.Point(515, 27);
            this.txbSanBayDen.Name = "txbSanBayDen";
            this.txbSanBayDen.Size = new System.Drawing.Size(200, 22);
            this.txbSanBayDen.TabIndex = 6;
            // 
            // txbSanBayDi
            // 
            this.txbSanBayDi.BackColor = System.Drawing.Color.White;
            this.txbSanBayDi.Enabled = false;
            this.txbSanBayDi.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txbSanBayDi.Location = new System.Drawing.Point(158, 21);
            this.txbSanBayDi.Name = "txbSanBayDi";
            this.txbSanBayDi.Size = new System.Drawing.Size(200, 22);
            this.txbSanBayDi.TabIndex = 5;
            // 
            // SanBayDi_label
            // 
            this.SanBayDi_label.AutoSize = true;
            this.SanBayDi_label.Location = new System.Drawing.Point(6, 30);
            this.SanBayDi_label.Name = "SanBayDi_label";
            this.SanBayDi_label.Size = new System.Drawing.Size(78, 17);
            this.SanBayDi_label.TabIndex = 1;
            this.SanBayDi_label.Text = "Sân Bay Đi";
            // 
            // txbNgayGio
            // 
            this.txbNgayGio.BackColor = System.Drawing.Color.White;
            this.txbNgayGio.Enabled = false;
            this.txbNgayGio.ForeColor = System.Drawing.SystemColors.Window;
            this.txbNgayGio.Location = new System.Drawing.Point(158, 64);
            this.txbNgayGio.Name = "txbNgayGio";
            this.txbNgayGio.Size = new System.Drawing.Size(200, 22);
            this.txbNgayGio.TabIndex = 2;
            // 
            // SanBayDen_label
            // 
            this.SanBayDen_label.AutoSize = true;
            this.SanBayDen_label.Location = new System.Drawing.Point(400, 30);
            this.SanBayDen_label.Name = "SanBayDen_label";
            this.SanBayDen_label.Size = new System.Drawing.Size(91, 17);
            this.SanBayDen_label.TabIndex = 1;
            this.SanBayDen_label.Text = "Sân Bay Đến";
            // 
            // NgayGio_label
            // 
            this.NgayGio_label.AutoSize = true;
            this.NgayGio_label.Location = new System.Drawing.Point(6, 69);
            this.NgayGio_label.Name = "NgayGio_label";
            this.NgayGio_label.Size = new System.Drawing.Size(76, 17);
            this.NgayGio_label.TabIndex = 1;
            this.NgayGio_label.Text = "Ngày - Giờ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 435);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Giá Tiền";
            // 
            // txbCMND
            // 
            this.txbCMND.BackColor = System.Drawing.Color.White;
            this.txbCMND.Enabled = false;
            this.txbCMND.Location = new System.Drawing.Point(158, 66);
            this.txbCMND.Name = "txbCMND";
            this.txbCMND.Size = new System.Drawing.Size(200, 22);
            this.txbCMND.TabIndex = 2;
            // 
            // txbTenKhachHang
            // 
            this.txbTenKhachHang.BackColor = System.Drawing.Color.White;
            this.txbTenKhachHang.Enabled = false;
            this.txbTenKhachHang.Location = new System.Drawing.Point(155, 27);
            this.txbTenKhachHang.Name = "txbTenKhachHang";
            this.txbTenKhachHang.Size = new System.Drawing.Size(200, 22);
            this.txbTenKhachHang.TabIndex = 2;
            // 
            // DienThoai_label
            // 
            this.DienThoai_label.AutoSize = true;
            this.DienThoai_label.Location = new System.Drawing.Point(400, 30);
            this.DienThoai_label.Name = "DienThoai_label";
            this.DienThoai_label.Size = new System.Drawing.Size(77, 17);
            this.DienThoai_label.TabIndex = 1;
            this.DienThoai_label.Text = "Điện Thoại";
            // 
            // CMND_label
            // 
            this.CMND_label.AutoSize = true;
            this.CMND_label.Location = new System.Drawing.Point(6, 69);
            this.CMND_label.Name = "CMND_label";
            this.CMND_label.Size = new System.Drawing.Size(48, 17);
            this.CMND_label.TabIndex = 1;
            this.CMND_label.Text = "CMND";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hạng Vé";
            // 
            // TenHanhKhach_label
            // 
            this.TenHanhKhach_label.AutoSize = true;
            this.TenHanhKhach_label.Location = new System.Drawing.Point(6, 30);
            this.TenHanhKhach_label.Name = "TenHanhKhach_label";
            this.TenHanhKhach_label.Size = new System.Drawing.Size(115, 17);
            this.TenHanhKhach_label.TabIndex = 1;
            this.TenHanhKhach_label.Text = "Tên Hành Khách";
            // 
            // MaHanhKhach_label
            // 
            this.MaHanhKhach_label.AutoSize = true;
            this.MaHanhKhach_label.Location = new System.Drawing.Point(24, 235);
            this.MaHanhKhach_label.Name = "MaHanhKhach_label";
            this.MaHanhKhach_label.Size = new System.Drawing.Size(109, 17);
            this.MaHanhKhach_label.TabIndex = 10;
            this.MaHanhKhach_label.Text = "Mã Hành Khách";
            // 
            // MaChuyenBay_label
            // 
            this.MaChuyenBay_label.AutoSize = true;
            this.MaChuyenBay_label.Location = new System.Drawing.Point(24, 68);
            this.MaChuyenBay_label.Name = "MaChuyenBay_label";
            this.MaChuyenBay_label.Size = new System.Drawing.Size(107, 17);
            this.MaChuyenBay_label.TabIndex = 11;
            this.MaChuyenBay_label.Text = "Mã Chuyến Bay";
            // 
            // txbDienThoai
            // 
            this.txbDienThoai.BackColor = System.Drawing.Color.White;
            this.txbDienThoai.Enabled = false;
            this.txbDienThoai.Location = new System.Drawing.Point(515, 27);
            this.txbDienThoai.Name = "txbDienThoai";
            this.txbDienThoai.Size = new System.Drawing.Size(200, 22);
            this.txbDienThoai.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TenHanhKhach_label);
            this.groupBox1.Controls.Add(this.txbDienThoai);
            this.groupBox1.Controls.Add(this.txbCMND);
            this.groupBox1.Controls.Add(this.txbTenKhachHang);
            this.groupBox1.Controls.Add(this.DienThoai_label);
            this.groupBox1.Controls.Add(this.CMND_label);
            this.groupBox1.Location = new System.Drawing.Point(27, 263);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(727, 105);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hành khách";
            // 
            // ThemHanhKhach_button
            // 
            this.ThemHanhKhach_button.Location = new System.Drawing.Point(542, 226);
            this.ThemHanhKhach_button.Name = "ThemHanhKhach_button";
            this.ThemHanhKhach_button.Size = new System.Drawing.Size(161, 36);
            this.ThemHanhKhach_button.TabIndex = 27;
            this.ThemHanhKhach_button.Text = "Thêm Hành Khách";
            this.ThemHanhKhach_button.UseVisualStyleBackColor = true;
            this.ThemHanhKhach_button.Click += new System.EventHandler(this.ThemHanhKhach_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(427, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "hoặc";
            // 
            // frmBanVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 552);
            this.Controls.Add(this.ThemHanhKhach_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Thoat_button);
            this.Controls.Add(this.Luu_button);
            this.Controls.Add(this.txbGiaTien);
            this.Controls.Add(this.HangVe_comboBox);
            this.Controls.Add(this.MaHanhKhach_comboBox);
            this.Controls.Add(this.MaChuyenBay_label);
            this.Controls.Add(this.MaChuyenBay_comboBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MaHanhKhach_label);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label);
            this.Name = "frmBanVe";
            this.Text = "Ban Ve Chuyen Bay";
            this.Load += new System.EventHandler(this.frmBanVe_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button Thoat_button;
        private System.Windows.Forms.Button Luu_button;
        private System.Windows.Forms.TextBox txbGiaTien;
        private System.Windows.Forms.ComboBox HangVe_comboBox;
        private System.Windows.Forms.ComboBox MaHanhKhach_comboBox;
        private System.Windows.Forms.ComboBox MaChuyenBay_comboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label SanBayDi_label;
        private System.Windows.Forms.TextBox txbNgayGio;
        private System.Windows.Forms.Label SanBayDen_label;
        private System.Windows.Forms.Label NgayGio_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbCMND;
        private System.Windows.Forms.TextBox txbTenKhachHang;
        private System.Windows.Forms.Label DienThoai_label;
        private System.Windows.Forms.Label CMND_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label TenHanhKhach_label;
        private System.Windows.Forms.Label MaHanhKhach_label;
        private System.Windows.Forms.Label MaChuyenBay_label;
        private System.Windows.Forms.TextBox txbDienThoai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ThemHanhKhach_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbSanBayDen;
        private System.Windows.Forms.TextBox txbSanBayDi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbThoiGianBay;
    }
}