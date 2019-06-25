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
            this.dtgvDTN = new System.Windows.Forms.DataGridView();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDTN)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Nam_label
            // 
            this.Nam_label.AutoSize = true;
            this.Nam_label.Location = new System.Drawing.Point(243, 152);
            this.Nam_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.Nam_comboBox.Location = new System.Drawing.Point(425, 152);
            this.Nam_comboBox.Margin = new System.Windows.Forms.Padding(4);
            this.Nam_comboBox.Name = "Nam_comboBox";
            this.Nam_comboBox.Size = new System.Drawing.Size(237, 32);
            this.Nam_comboBox.TabIndex = 2;
            // 
            // dtgvDTN
            // 
            this.dtgvDTN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDTN.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvDTN.Location = new System.Drawing.Point(0, 460);
            this.dtgvDTN.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvDTN.Name = "dtgvDTN";
            this.dtgvDTN.RowTemplate.Height = 24;
            this.dtgvDTN.Size = new System.Drawing.Size(1304, 490);
            this.dtgvDTN.TabIndex = 3;
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Location = new System.Drawing.Point(248, 219);
            this.btnBaoCao.Margin = new System.Windows.Forms.Padding(4);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(137, 50);
            this.btnBaoCao.TabIndex = 4;
            this.btnBaoCao.Text = "Xem";
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(525, 219);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(137, 50);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.Nam_comboBox);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnBaoCao);
            this.groupBox1.Controls.Add(this.Nam_label);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1304, 460);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Báo cáo doanh thu năm";
            // 
            // frmBaoCaoDoanhThuNam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BanVeMayBay.Properties.Resources.background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1304, 950);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgvDTN);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBaoCaoDoanhThuNam";
            this.Text = "BaoCaoDoanhThuNam";
            this.Load += new System.EventHandler(this.frmBaoCaoDoanhThuNam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDTN)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Nam_label;
        private System.Windows.Forms.ComboBox Nam_comboBox;
        private System.Windows.Forms.DataGridView dtgvDTN;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}