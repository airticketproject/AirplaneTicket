namespace BanVeMayBay
{
    partial class frmQuanLySanBayTrungGian
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
            this.buttonThoat = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.txbGhiChu = new System.Windows.Forms.TextBox();
            this.txbThoiGianDung = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgvDsSanBayTrungGian = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txbMaSanBay = new System.Windows.Forms.TextBox();
            this.txbMaChuyenBay = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDsSanBayTrungGian)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonThoat
            // 
            this.buttonThoat.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThoat.Location = new System.Drawing.Point(858, 320);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(106, 53);
            this.buttonThoat.TabIndex = 16;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // buttonSua
            // 
            this.buttonSua.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSua.Location = new System.Drawing.Point(770, 216);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(111, 53);
            this.buttonSua.TabIndex = 15;
            this.buttonSua.Text = "Cập nhật";
            this.buttonSua.UseVisualStyleBackColor = true;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // txbGhiChu
            // 
            this.txbGhiChu.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbGhiChu.Location = new System.Drawing.Point(274, 272);
            this.txbGhiChu.Multiline = true;
            this.txbGhiChu.Name = "txbGhiChu";
            this.txbGhiChu.Size = new System.Drawing.Size(321, 113);
            this.txbGhiChu.TabIndex = 14;
            this.txbGhiChu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbGhiChu_KeyPress);
            // 
            // txbThoiGianDung
            // 
            this.txbThoiGianDung.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbThoiGianDung.Location = new System.Drawing.Point(274, 198);
            this.txbThoiGianDung.Name = "txbThoiGianDung";
            this.txbThoiGianDung.Size = new System.Drawing.Size(228, 32);
            this.txbThoiGianDung.TabIndex = 13;
            this.txbThoiGianDung.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbThoiGianDung_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(103, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ghi Chú";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(528, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 26);
            this.label6.TabIndex = 8;
            this.label6.Text = "(phút)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(103, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "Thời Gian Dừng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mã Chuyến Bay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 26);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mã Sân Bay";
            // 
            // dtgvDsSanBayTrungGian
            // 
            this.dtgvDsSanBayTrungGian.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDsSanBayTrungGian.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgvDsSanBayTrungGian.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvDsSanBayTrungGian.Location = new System.Drawing.Point(0, 455);
            this.dtgvDsSanBayTrungGian.Name = "dtgvDsSanBayTrungGian";
            this.dtgvDsSanBayTrungGian.ReadOnly = true;
            this.dtgvDsSanBayTrungGian.RowHeadersVisible = false;
            this.dtgvDsSanBayTrungGian.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgvDsSanBayTrungGian.RowTemplate.Height = 24;
            this.dtgvDsSanBayTrungGian.ShowCellErrors = false;
            this.dtgvDsSanBayTrungGian.ShowCellToolTips = false;
            this.dtgvDsSanBayTrungGian.ShowEditingIcon = false;
            this.dtgvDsSanBayTrungGian.ShowRowErrors = false;
            this.dtgvDsSanBayTrungGian.Size = new System.Drawing.Size(1219, 381);
            this.dtgvDsSanBayTrungGian.TabIndex = 17;
            this.dtgvDsSanBayTrungGian.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDsSanBayTrungGian_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(410, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 32);
            this.label1.TabIndex = 18;
            this.label1.Text = "QUẢN LÝ SÂN BAY TRUNG GIAN";
            // 
            // txbMaSanBay
            // 
            this.txbMaSanBay.BackColor = System.Drawing.Color.White;
            this.txbMaSanBay.Enabled = false;
            this.txbMaSanBay.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMaSanBay.Location = new System.Drawing.Point(274, 138);
            this.txbMaSanBay.Name = "txbMaSanBay";
            this.txbMaSanBay.Size = new System.Drawing.Size(321, 32);
            this.txbMaSanBay.TabIndex = 19;
            // 
            // txbMaChuyenBay
            // 
            this.txbMaChuyenBay.BackColor = System.Drawing.Color.White;
            this.txbMaChuyenBay.Enabled = false;
            this.txbMaChuyenBay.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMaChuyenBay.Location = new System.Drawing.Point(274, 86);
            this.txbMaChuyenBay.Name = "txbMaChuyenBay";
            this.txbMaChuyenBay.Size = new System.Drawing.Size(321, 32);
            this.txbMaChuyenBay.TabIndex = 20;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(948, 216);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(111, 53);
            this.btnXoa.TabIndex = 21;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // frmQuanLySanBayTrungGian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BanVeMayBay.Properties.Resources._0;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1219, 836);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txbMaChuyenBay);
            this.Controls.Add(this.txbMaSanBay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvDsSanBayTrungGian);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.txbGhiChu);
            this.Controls.Add(this.txbThoiGianDung);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuanLySanBayTrungGian";
            this.Text = "frmQuanLySanBayTrungGian";
            this.Load += new System.EventHandler(this.frmQuanLySanBayTrungGian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDsSanBayTrungGian)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.TextBox txbGhiChu;
        private System.Windows.Forms.TextBox txbThoiGianDung;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgvDsSanBayTrungGian;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbMaSanBay;
        private System.Windows.Forms.TextBox txbMaChuyenBay;
        private System.Windows.Forms.Button btnXoa;
    }
}