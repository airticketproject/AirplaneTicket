namespace BanVeMayBay
{
    partial class frmThemSanBayTrungGian
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbThoiGianDung = new System.Windows.Forms.TextBox();
            this.txbGhiChu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbMaSanBay = new System.Windows.Forms.ComboBox();
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.cbbMaChuyenBay = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbMaChiTietTrungGian = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÊM SÂN BAY TRUNG GIAN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Sân Bay";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã Chuyến Bay";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Thời Gian Dừng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ghi Chú";
            // 
            // txbThoiGianDung
            // 
            this.txbThoiGianDung.Location = new System.Drawing.Point(242, 224);
            this.txbThoiGianDung.Name = "txbThoiGianDung";
            this.txbThoiGianDung.Size = new System.Drawing.Size(181, 22);
            this.txbThoiGianDung.TabIndex = 2;
            this.txbThoiGianDung.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbThoiGianDung_KeyPress);
            // 
            // txbGhiChu
            // 
            this.txbGhiChu.Location = new System.Drawing.Point(242, 275);
            this.txbGhiChu.Multiline = true;
            this.txbGhiChu.Name = "txbGhiChu";
            this.txbGhiChu.Size = new System.Drawing.Size(260, 113);
            this.txbGhiChu.TabIndex = 3;
            this.txbGhiChu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbGhiChu_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(445, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "(phút)";
            // 
            // cbbMaSanBay
            // 
            this.cbbMaSanBay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaSanBay.FormattingEnabled = true;
            this.cbbMaSanBay.Location = new System.Drawing.Point(242, 121);
            this.cbbMaSanBay.Name = "cbbMaSanBay";
            this.cbbMaSanBay.Size = new System.Drawing.Size(260, 24);
            this.cbbMaSanBay.TabIndex = 0;
            // 
            // buttonThem
            // 
            this.buttonThem.Location = new System.Drawing.Point(144, 444);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(94, 39);
            this.buttonThem.TabIndex = 4;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // buttonThoat
            // 
            this.buttonThoat.Location = new System.Drawing.Point(382, 444);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(85, 39);
            this.buttonThoat.TabIndex = 5;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // cbbMaChuyenBay
            // 
            this.cbbMaChuyenBay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaChuyenBay.FormattingEnabled = true;
            this.cbbMaChuyenBay.Location = new System.Drawing.Point(242, 172);
            this.cbbMaChuyenBay.Name = "cbbMaChuyenBay";
            this.cbbMaChuyenBay.Size = new System.Drawing.Size(260, 24);
            this.cbbMaChuyenBay.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(101, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Mã Chi Tiết";
            // 
            // txbMaChiTietTrungGian
            // 
            this.txbMaChiTietTrungGian.Location = new System.Drawing.Point(242, 73);
            this.txbMaChiTietTrungGian.Name = "txbMaChiTietTrungGian";
            this.txbMaChiTietTrungGian.Size = new System.Drawing.Size(260, 22);
            this.txbMaChiTietTrungGian.TabIndex = 8;
            // 
            // frmThemSanBayTrungGian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 532);
            this.Controls.Add(this.txbMaChiTietTrungGian);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbbMaChuyenBay);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.cbbMaSanBay);
            this.Controls.Add(this.txbGhiChu);
            this.Controls.Add(this.txbThoiGianDung);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmThemSanBayTrungGian";
            this.Text = "ThemSanBayTrungGian";
            this.Load += new System.EventHandler(this.frmThemSanBayTrungGian_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbThoiGianDung;
        private System.Windows.Forms.TextBox txbGhiChu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbMaSanBay;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.ComboBox cbbMaChuyenBay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbMaChiTietTrungGian;
    }
}