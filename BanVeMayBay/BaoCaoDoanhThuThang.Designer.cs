namespace BanVeMayBay
{
    partial class BaoCaoDoanhThuThang
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
            this.label2 = new System.Windows.Forms.Label();
            this.Thang_comboBox = new System.Windows.Forms.ComboBox();
            this.Nam_label = new System.Windows.Forms.Label();
            this.Nam_comboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChuyenBay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoanhThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiLe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Thang_label
            // 
            this.Thang_label.AutoSize = true;
            this.Thang_label.Location = new System.Drawing.Point(12, 75);
            this.Thang_label.Name = "Thang_label";
            this.Thang_label.Size = new System.Drawing.Size(49, 17);
            this.Thang_label.TabIndex = 0;
            this.Thang_label.Text = "Tháng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "BÁO CÁO DOANH THU";
            // 
            // Thang_comboBox
            // 
            this.Thang_comboBox.FormattingEnabled = true;
            this.Thang_comboBox.Location = new System.Drawing.Point(133, 72);
            this.Thang_comboBox.Name = "Thang_comboBox";
            this.Thang_comboBox.Size = new System.Drawing.Size(90, 24);
            this.Thang_comboBox.TabIndex = 2;
            // 
            // Nam_label
            // 
            this.Nam_label.AutoSize = true;
            this.Nam_label.Location = new System.Drawing.Point(333, 75);
            this.Nam_label.Name = "Nam_label";
            this.Nam_label.Size = new System.Drawing.Size(37, 17);
            this.Nam_label.TabIndex = 0;
            this.Nam_label.Text = "Năm";
            // 
            // Nam_comboBox
            // 
            this.Nam_comboBox.FormattingEnabled = true;
            this.Nam_comboBox.Location = new System.Drawing.Point(444, 72);
            this.Nam_comboBox.Name = "Nam_comboBox";
            this.Nam_comboBox.Size = new System.Drawing.Size(90, 24);
            this.Nam_comboBox.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.ChuyenBay,
            this.SoVe,
            this.DoanhThu,
            this.TiLe});
            this.dataGridView1.Location = new System.Drawing.Point(15, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(551, 230);
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
            // BaoCaoDoanhThuThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 361);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Nam_comboBox);
            this.Controls.Add(this.Thang_comboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nam_label);
            this.Controls.Add(this.Thang_label);
            this.Name = "BaoCaoDoanhThuThang";
            this.Text = "BaoCaoDoanhThuThang";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Thang_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Thang_comboBox;
        private System.Windows.Forms.Label Nam_label;
        private System.Windows.Forms.ComboBox Nam_comboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChuyenBay;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoanhThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiLe;
    }
}