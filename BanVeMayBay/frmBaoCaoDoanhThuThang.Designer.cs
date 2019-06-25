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
            this.dtgvDTT = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDTT)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Thang_label
            // 
            this.Thang_label.AutoSize = true;
            this.Thang_label.Location = new System.Drawing.Point(367, 78);
            this.Thang_label.Name = "Thang_label";
            this.Thang_label.Size = new System.Drawing.Size(70, 26);
            this.Thang_label.TabIndex = 0;
            this.Thang_label.Text = "Tháng";
            // 
            // Thang_comboBox
            // 
            this.Thang_comboBox.FormattingEnabled = true;
            this.Thang_comboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.Thang_comboBox.Location = new System.Drawing.Point(500, 75);
            this.Thang_comboBox.Name = "Thang_comboBox";
            this.Thang_comboBox.Size = new System.Drawing.Size(211, 32);
            this.Thang_comboBox.TabIndex = 2;
            // 
            // Nam_label
            // 
            this.Nam_label.AutoSize = true;
            this.Nam_label.Location = new System.Drawing.Point(367, 145);
            this.Nam_label.Name = "Nam_label";
            this.Nam_label.Size = new System.Drawing.Size(56, 26);
            this.Nam_label.TabIndex = 0;
            this.Nam_label.Text = "Năm";
            // 
            // Nam_comboBox
            // 
            this.Nam_comboBox.FormattingEnabled = true;
            this.Nam_comboBox.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025"});
            this.Nam_comboBox.Location = new System.Drawing.Point(500, 142);
            this.Nam_comboBox.Name = "Nam_comboBox";
            this.Nam_comboBox.Size = new System.Drawing.Size(211, 32);
            this.Nam_comboBox.TabIndex = 2;
            // 
            // dtgvDTT
            // 
            this.dtgvDTT.AllowUserToResizeColumns = false;
            this.dtgvDTT.AllowUserToResizeRows = false;
            this.dtgvDTT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDTT.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvDTT.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgvDTT.ColumnHeadersHeight = 30;
            this.dtgvDTT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvDTT.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvDTT.Location = new System.Drawing.Point(0, 352);
            this.dtgvDTT.Name = "dtgvDTT";
            this.dtgvDTT.RowTemplate.Height = 24;
            this.dtgvDTT.ShowCellErrors = false;
            this.dtgvDTT.ShowCellToolTips = false;
            this.dtgvDTT.ShowEditingIcon = false;
            this.dtgvDTT.ShowRowErrors = false;
            this.dtgvDTT.Size = new System.Drawing.Size(1145, 404);
            this.dtgvDTT.TabIndex = 3;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(601, 210);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(110, 38);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Location = new System.Drawing.Point(372, 210);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(110, 38);
            this.btnBaoCao.TabIndex = 6;
            this.btnBaoCao.Text = "Xem";
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.Thang_label);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.Nam_label);
            this.groupBox1.Controls.Add(this.btnBaoCao);
            this.groupBox1.Controls.Add(this.Thang_comboBox);
            this.groupBox1.Controls.Add(this.Nam_comboBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1145, 352);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Báo cáo doanh thu tháng";
            // 
            // frmBaoCaoDoanhThuThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::BanVeMayBay.Properties.Resources.background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1145, 756);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgvDTT);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBaoCaoDoanhThuThang";
            this.Text = "Báo cáo doanh thu tháng";
            this.Load += new System.EventHandler(this.frmBaoCaoDoanhThuThang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDTT)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Thang_label;
        private System.Windows.Forms.ComboBox Thang_comboBox;
        private System.Windows.Forms.Label Nam_label;
        private System.Windows.Forms.ComboBox Nam_comboBox;
        private System.Windows.Forms.DataGridView dtgvDTT;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}