namespace BanVeMayBay
{
    partial class frmBaoCaoDoanhThuThang
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
            this.Thang_label = new System.Windows.Forms.Label();
            this.Thang_comboBox = new System.Windows.Forms.ComboBox();
            this.Nam_label = new System.Windows.Forms.Label();
            this.Nam_comboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChuyenBay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoanhThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiLe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Thang_label
            // 
            this.Thang_label.AutoSize = true;
            this.Thang_label.Location = new System.Drawing.Point(189, 78);
            this.Thang_label.Name = "Thang_label";
            this.Thang_label.Size = new System.Drawing.Size(49, 17);
            this.Thang_label.TabIndex = 0;
            this.Thang_label.Text = "Tháng";
            // 
            // Thang_comboBox
            // 
            this.Thang_comboBox.FormattingEnabled = true;
            this.Thang_comboBox.Location = new System.Drawing.Point(279, 75);
            this.Thang_comboBox.Name = "Thang_comboBox";
            this.Thang_comboBox.Size = new System.Drawing.Size(196, 24);
            this.Thang_comboBox.TabIndex = 2;
            // 
            // Nam_label
            // 
            this.Nam_label.AutoSize = true;
            this.Nam_label.Location = new System.Drawing.Point(189, 124);
            this.Nam_label.Name = "Nam_label";
            this.Nam_label.Size = new System.Drawing.Size(37, 17);
            this.Nam_label.TabIndex = 0;
            this.Nam_label.Text = "Năm";
            // 
            // Nam_comboBox
            // 
            this.Nam_comboBox.FormattingEnabled = true;
            this.Nam_comboBox.Location = new System.Drawing.Point(279, 124);
            this.Nam_comboBox.Name = "Nam_comboBox";
            this.Nam_comboBox.Size = new System.Drawing.Size(196, 24);
            this.Nam_comboBox.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.ChuyenBay,
            this.SoVe,
            this.DoanhThu,
            this.TiLe});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 409);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(1145, 347);
            this.dataGridView1.TabIndex = 3;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // ChuyenBay
            // 
            this.ChuyenBay.HeaderText = "Chuyến Bay";
            this.ChuyenBay.Name = "ChuyenBay";
            // 
            // SoVe
            // 
            this.SoVe.HeaderText = "Số Vé";
            this.SoVe.Name = "SoVe";
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
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(750, 210);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(110, 38);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Location = new System.Drawing.Point(570, 210);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(110, 38);
            this.btnBaoCao.TabIndex = 6;
            this.btnBaoCao.Text = "Xem";
            this.btnBaoCao.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Thang_label);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.Nam_label);
            this.groupBox1.Controls.Add(this.btnBaoCao);
            this.groupBox1.Controls.Add(this.Thang_comboBox);
            this.groupBox1.Controls.Add(this.Nam_comboBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1145, 409);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Báo cáo doanh thu tháng";
            // 
            // frmBaoCaoDoanhThuThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 756);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmBaoCaoDoanhThuThang";
            this.Text = "BaoCaoDoanhThuThang";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Thang_label;
        private System.Windows.Forms.ComboBox Thang_comboBox;
        private System.Windows.Forms.Label Nam_label;
        private System.Windows.Forms.ComboBox Nam_comboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChuyenBay;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoanhThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiLe;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}