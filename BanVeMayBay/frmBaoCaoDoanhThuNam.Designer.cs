namespace BanVeMayBay
{
    partial class frmBaoCaoDoanhThuNam
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
            this.Nam_label = new System.Windows.Forms.Label();
            this.Nam_comboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoChuyenBay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoanhThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiLe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Nam_label
            // 
            this.Nam_label.AutoSize = true;
            this.Nam_label.Location = new System.Drawing.Point(194, 116);
            this.Nam_label.Name = "Nam_label";
            this.Nam_label.Size = new System.Drawing.Size(37, 17);
            this.Nam_label.TabIndex = 0;
            this.Nam_label.Text = "Năm";
            this.Nam_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // Nam_comboBox
            // 
            this.Nam_comboBox.FormattingEnabled = true;
            this.Nam_comboBox.Location = new System.Drawing.Point(250, 116);
            this.Nam_comboBox.Name = "Nam_comboBox";
            this.Nam_comboBox.Size = new System.Drawing.Size(190, 24);
            this.Nam_comboBox.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Thang,
            this.SoChuyenBay,
            this.DoanhThu,
            this.TiLe});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 351);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1043, 373);
            this.dataGridView1.TabIndex = 3;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // Thang
            // 
            this.Thang.HeaderText = "Tháng";
            this.Thang.Name = "Thang";
            // 
            // SoChuyenBay
            // 
            this.SoChuyenBay.HeaderText = "Số Chuyến Bay";
            this.SoChuyenBay.Name = "SoChuyenBay";
            // 
            // DoanhThu
            // 
            this.DoanhThu.HeaderText = "Doanh Thu";
            this.DoanhThu.Name = "DoanhThu";
            // 
            // TiLe
            // 
            this.TiLe.HeaderText = "Tỉ Lệ";
            this.TiLe.Name = "TiLe";
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Location = new System.Drawing.Point(505, 108);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(110, 38);
            this.btnBaoCao.TabIndex = 4;
            this.btnBaoCao.Text = "Xem";
            this.btnBaoCao.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(646, 108);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(110, 38);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Nam_comboBox);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnBaoCao);
            this.groupBox1.Controls.Add(this.Nam_label);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1043, 351);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Báo cáo doanh thu năm";
            // 
            // frmBaoCaoDoanhThuNam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 724);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBaoCaoDoanhThuNam";
            this.Text = "BaoCaoDoanhThuNam";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Nam_label;
        private System.Windows.Forms.ComboBox Nam_comboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoChuyenBay;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoanhThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiLe;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}