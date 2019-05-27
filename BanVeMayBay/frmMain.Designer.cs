namespace BanVeMayBay
{
    partial class frmMain
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.btnQuanLyChuyenBay = new System.Windows.Forms.Button();
            this.btnBanVe = new System.Windows.Forms.Button();
            this.btnDatVe = new System.Windows.Forms.Button();
            this.btnSanBay = new System.Windows.Forms.Button();
            this.btnBaoCaoThang = new System.Windows.Forms.Button();
            this.btnThemChuyenBay = new System.Windows.Forms.Button();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.btnBaoCaoNam = new System.Windows.Forms.Button();
            this.btnThongTin = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(163, 34);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(264, 17);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "PHẦN MỀM QUẢN LÝ BÁN VÉ MÁY BAY";
            // 
            // btnQuanLyChuyenBay
            // 
            this.btnQuanLyChuyenBay.Location = new System.Drawing.Point(351, 88);
            this.btnQuanLyChuyenBay.Name = "btnQuanLyChuyenBay";
            this.btnQuanLyChuyenBay.Size = new System.Drawing.Size(182, 76);
            this.btnQuanLyChuyenBay.TabIndex = 1;
            this.btnQuanLyChuyenBay.Text = "QUẢN LÝ CHUYẾN BAY";
            this.btnQuanLyChuyenBay.UseVisualStyleBackColor = true;
            this.btnQuanLyChuyenBay.Click += new System.EventHandler(this.btnQuanLyChuyenBay_Click);
            // 
            // btnBanVe
            // 
            this.btnBanVe.Location = new System.Drawing.Point(48, 186);
            this.btnBanVe.Name = "btnBanVe";
            this.btnBanVe.Size = new System.Drawing.Size(182, 76);
            this.btnBanVe.TabIndex = 1;
            this.btnBanVe.Text = "BÁN VÉ";
            this.btnBanVe.UseVisualStyleBackColor = true;
            this.btnBanVe.Click += new System.EventHandler(this.btnBanVe_Click);
            // 
            // btnDatVe
            // 
            this.btnDatVe.Location = new System.Drawing.Point(48, 286);
            this.btnDatVe.Name = "btnDatVe";
            this.btnDatVe.Size = new System.Drawing.Size(182, 76);
            this.btnDatVe.TabIndex = 1;
            this.btnDatVe.Text = "ĐẶT VÉ";
            this.btnDatVe.UseVisualStyleBackColor = true;
            this.btnDatVe.Click += new System.EventHandler(this.btnDatVe_Click);
            // 
            // btnSanBay
            // 
            this.btnSanBay.Location = new System.Drawing.Point(351, 186);
            this.btnSanBay.Name = "btnSanBay";
            this.btnSanBay.Size = new System.Drawing.Size(182, 76);
            this.btnSanBay.TabIndex = 1;
            this.btnSanBay.Text = "QUẢN LÝ SÂN BAY";
            this.btnSanBay.UseVisualStyleBackColor = true;
            this.btnSanBay.Click += new System.EventHandler(this.btnSanBay_Click);
            // 
            // btnBaoCaoThang
            // 
            this.btnBaoCaoThang.Location = new System.Drawing.Point(48, 385);
            this.btnBaoCaoThang.Name = "btnBaoCaoThang";
            this.btnBaoCaoThang.Size = new System.Drawing.Size(182, 76);
            this.btnBaoCaoThang.TabIndex = 1;
            this.btnBaoCaoThang.Text = "BÁO CÁO DOANH THU THÁNG";
            this.btnBaoCaoThang.UseVisualStyleBackColor = true;
            this.btnBaoCaoThang.Click += new System.EventHandler(this.btnBaoCaoThang_Click);
            // 
            // btnThemChuyenBay
            // 
            this.btnThemChuyenBay.Location = new System.Drawing.Point(48, 88);
            this.btnThemChuyenBay.Name = "btnThemChuyenBay";
            this.btnThemChuyenBay.Size = new System.Drawing.Size(182, 76);
            this.btnThemChuyenBay.TabIndex = 1;
            this.btnThemChuyenBay.Text = "THÊM CHUYẾN BAY";
            this.btnThemChuyenBay.UseVisualStyleBackColor = true;
            this.btnThemChuyenBay.Click += new System.EventHandler(this.btnThemChuyenBay_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Location = new System.Drawing.Point(351, 286);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(182, 76);
            this.btnKhachHang.TabIndex = 1;
            this.btnKhachHang.Text = "QUẢN LÝ KHÁCH HÀNG";
            this.btnKhachHang.UseVisualStyleBackColor = true;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnBaoCaoNam
            // 
            this.btnBaoCaoNam.Location = new System.Drawing.Point(351, 385);
            this.btnBaoCaoNam.Name = "btnBaoCaoNam";
            this.btnBaoCaoNam.Size = new System.Drawing.Size(182, 76);
            this.btnBaoCaoNam.TabIndex = 1;
            this.btnBaoCaoNam.Text = "BÁO CÁO DOANH THU NĂM";
            this.btnBaoCaoNam.UseVisualStyleBackColor = true;
            this.btnBaoCaoNam.Click += new System.EventHandler(this.btnBaoCaoNam_Click);
            // 
            // btnThongTin
            // 
            this.btnThongTin.Location = new System.Drawing.Point(48, 479);
            this.btnThongTin.Name = "btnThongTin";
            this.btnThongTin.Size = new System.Drawing.Size(182, 76);
            this.btnThongTin.TabIndex = 1;
            this.btnThongTin.Text = "THÔNG TIN PHẦN MỀM";
            this.btnThongTin.UseVisualStyleBackColor = true;
            this.btnThongTin.Click += new System.EventHandler(this.btnThongTin_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(351, 479);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(182, 76);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 588);
            this.Controls.Add(this.btnThongTin);
            this.Controls.Add(this.btnKhachHang);
            this.Controls.Add(this.btnDatVe);
            this.Controls.Add(this.btnBanVe);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThemChuyenBay);
            this.Controls.Add(this.btnBaoCaoNam);
            this.Controls.Add(this.btnBaoCaoThang);
            this.Controls.Add(this.btnSanBay);
            this.Controls.Add(this.btnQuanLyChuyenBay);
            this.Controls.Add(this.labelTitle);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button btnQuanLyChuyenBay;
        private System.Windows.Forms.Button btnBanVe;
        private System.Windows.Forms.Button btnDatVe;
        private System.Windows.Forms.Button btnSanBay;
        private System.Windows.Forms.Button btnBaoCaoThang;
        private System.Windows.Forms.Button btnThemChuyenBay;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.Button btnBaoCaoNam;
        private System.Windows.Forms.Button btnThongTin;
        private System.Windows.Forms.Button btnThoat;
    }
}