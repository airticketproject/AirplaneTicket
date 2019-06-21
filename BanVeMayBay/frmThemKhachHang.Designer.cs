namespace BanVeMayBay
{
    partial class frmThemKhachHang
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThemKhachHang = new System.Windows.Forms.Button();
            this.dtgvDsThemKhachHang = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbDienThoaiKhachHang = new System.Windows.Forms.TextBox();
            this.txbCmndKhachHang = new System.Windows.Forms.TextBox();
            this.txbTenKhachHang = new System.Windows.Forms.TextBox();
            this.txbMaKhachHang = new System.Windows.Forms.TextBox();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDsThemKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btn_Thoat);
            this.groupBox1.Controls.Add(this.btnThemKhachHang);
            this.groupBox1.Controls.Add(this.dtgvDsThemKhachHang);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txbDienThoaiKhachHang);
            this.groupBox1.Controls.Add(this.txbCmndKhachHang);
            this.groupBox1.Controls.Add(this.txbTenKhachHang);
            this.groupBox1.Controls.Add(this.txbMaKhachHang);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(778, 590);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm thông tin khách hàng";
            // 
            // btnThemKhachHang
            // 
            this.btnThemKhachHang.Location = new System.Drawing.Point(554, 84);
            this.btnThemKhachHang.Name = "btnThemKhachHang";
            this.btnThemKhachHang.Size = new System.Drawing.Size(125, 53);
            this.btnThemKhachHang.TabIndex = 9;
            this.btnThemKhachHang.Text = "Lưu";
            this.btnThemKhachHang.UseVisualStyleBackColor = true;
            this.btnThemKhachHang.Click += new System.EventHandler(this.btnThemKhachHang_Click);
            // 
            // dtgvDsThemKhachHang
            // 
            this.dtgvDsThemKhachHang.AllowUserToAddRows = false;
            this.dtgvDsThemKhachHang.AllowUserToDeleteRows = false;
            this.dtgvDsThemKhachHang.AllowUserToResizeColumns = false;
            this.dtgvDsThemKhachHang.AllowUserToResizeRows = false;
            this.dtgvDsThemKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDsThemKhachHang.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dtgvDsThemKhachHang.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgvDsThemKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDsThemKhachHang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvDsThemKhachHang.Location = new System.Drawing.Point(3, 284);
            this.dtgvDsThemKhachHang.Name = "dtgvDsThemKhachHang";
            this.dtgvDsThemKhachHang.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgvDsThemKhachHang.RowTemplate.Height = 24;
            this.dtgvDsThemKhachHang.ShowCellToolTips = false;
            this.dtgvDsThemKhachHang.ShowEditingIcon = false;
            this.dtgvDsThemKhachHang.ShowRowErrors = false;
            this.dtgvDsThemKhachHang.Size = new System.Drawing.Size(772, 303);
            this.dtgvDsThemKhachHang.TabIndex = 8;
            this.dtgvDsThemKhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDsThemKhachHang_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Điện thoại :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "CMND :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã khách hàng :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên khách hàng :";
            // 
            // txbDienThoaiKhachHang
            // 
            this.txbDienThoaiKhachHang.Location = new System.Drawing.Point(258, 206);
            this.txbDienThoaiKhachHang.Name = "txbDienThoaiKhachHang";
            this.txbDienThoaiKhachHang.Size = new System.Drawing.Size(191, 32);
            this.txbDienThoaiKhachHang.TabIndex = 3;
            // 
            // txbCmndKhachHang
            // 
            this.txbCmndKhachHang.Location = new System.Drawing.Point(258, 157);
            this.txbCmndKhachHang.Name = "txbCmndKhachHang";
            this.txbCmndKhachHang.Size = new System.Drawing.Size(191, 32);
            this.txbCmndKhachHang.TabIndex = 2;
            // 
            // txbTenKhachHang
            // 
            this.txbTenKhachHang.Location = new System.Drawing.Point(258, 108);
            this.txbTenKhachHang.Name = "txbTenKhachHang";
            this.txbTenKhachHang.Size = new System.Drawing.Size(191, 32);
            this.txbTenKhachHang.TabIndex = 1;
            // 
            // txbMaKhachHang
            // 
            this.txbMaKhachHang.Location = new System.Drawing.Point(258, 58);
            this.txbMaKhachHang.Name = "txbMaKhachHang";
            this.txbMaKhachHang.Size = new System.Drawing.Size(191, 32);
            this.txbMaKhachHang.TabIndex = 0;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(554, 160);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(125, 53);
            this.btn_Thoat.TabIndex = 9;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmThemKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BanVeMayBay.Properties.Resources._0;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(778, 590);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "frmThemKhachHang";
            this.Text = "Quản lý khách hàng";
            this.Load += new System.EventHandler(this.frmThemKhachHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDsThemKhachHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbDienThoaiKhachHang;
        private System.Windows.Forms.TextBox txbCmndKhachHang;
        private System.Windows.Forms.TextBox txbTenKhachHang;
        private System.Windows.Forms.TextBox txbMaKhachHang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThemKhachHang;
        private System.Windows.Forms.DataGridView dtgvDsThemKhachHang;
        private System.Windows.Forms.Button btn_Thoat;
    }
}