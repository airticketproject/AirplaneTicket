namespace BanVeMayBay
{
    partial class frmDanhSachChuyenBay
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaChuyenBay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SanBayDi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SanBayDen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhoiHanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianBay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoGheTrong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoGheDaDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimKiem_button = new System.Windows.Forms.Button();
            this.Thoat_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH CHUYẾN BAY";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaChuyenBay,
            this.SanBayDi,
            this.SanBayDen,
            this.KhoiHanh,
            this.ThoiGianBay,
            this.SoGheTrong,
            this.SoGheDaDat});
            this.dataGridView1.Location = new System.Drawing.Point(12, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(843, 359);
            this.dataGridView1.TabIndex = 1;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // MaChuyenBay
            // 
            this.MaChuyenBay.HeaderText = "Mã Chuyến Bay";
            this.MaChuyenBay.Name = "MaChuyenBay";
            // 
            // SanBayDi
            // 
            this.SanBayDi.HeaderText = "Sân Bay Đi";
            this.SanBayDi.Name = "SanBayDi";
            // 
            // SanBayDen
            // 
            this.SanBayDen.HeaderText = "Sân Bay Đến";
            this.SanBayDen.Name = "SanBayDen";
            // 
            // KhoiHanh
            // 
            this.KhoiHanh.HeaderText = "Khởi Hành";
            this.KhoiHanh.Name = "KhoiHanh";
            // 
            // ThoiGianBay
            // 
            this.ThoiGianBay.HeaderText = "Thời Gian Bay";
            this.ThoiGianBay.Name = "ThoiGianBay";
            // 
            // SoGheTrong
            // 
            this.SoGheTrong.HeaderText = "Số Ghế Trống";
            this.SoGheTrong.Name = "SoGheTrong";
            // 
            // SoGheDaDat
            // 
            this.SoGheDaDat.HeaderText = "Số Ghế Đã Đặt";
            this.SoGheDaDat.Name = "SoGheDaDat";
            // 
            // TimKiem_button
            // 
            this.TimKiem_button.Location = new System.Drawing.Point(130, 468);
            this.TimKiem_button.Name = "TimKiem_button";
            this.TimKiem_button.Size = new System.Drawing.Size(133, 53);
            this.TimKiem_button.TabIndex = 2;
            this.TimKiem_button.Text = "Tìm kiếm";
            this.TimKiem_button.UseVisualStyleBackColor = true;
            // 
            // Thoat_button
            // 
            this.Thoat_button.Location = new System.Drawing.Point(578, 468);
            this.Thoat_button.Name = "Thoat_button";
            this.Thoat_button.Size = new System.Drawing.Size(133, 53);
            this.Thoat_button.TabIndex = 2;
            this.Thoat_button.Text = "Thoát";
            this.Thoat_button.UseVisualStyleBackColor = true;
            // 
            // DanhSachChuyenBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 533);
            this.Controls.Add(this.Thoat_button);
            this.Controls.Add(this.TimKiem_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "DanhSachChuyenBay";
            this.Text = "Danh Sách Chuyến Bay";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChuyenBay;
        private System.Windows.Forms.DataGridViewTextBoxColumn SanBayDi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SanBayDen;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhoiHanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianBay;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoGheTrong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoGheDaDat;
        private System.Windows.Forms.Button TimKiem_button;
        private System.Windows.Forms.Button Thoat_button;
    }
}