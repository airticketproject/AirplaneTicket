namespace BanVeMayBay
{
    partial class frmQuanLyHangVe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyHangVe));
            this.dtgvDsHangVe = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbMaHangVe = new System.Windows.Forms.TextBox();
            this.txbTiLeDonGia = new System.Windows.Forms.TextBox();
            this.txbTenHangVe = new System.Windows.Forms.TextBox();
            this.btnSuaHangVe = new System.Windows.Forms.Button();
            this.btnXoaHangVe = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDsHangVe)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvDsHangVe
            // 
            this.dtgvDsHangVe.AllowUserToAddRows = false;
            this.dtgvDsHangVe.AllowUserToDeleteRows = false;
            this.dtgvDsHangVe.AllowUserToResizeColumns = false;
            this.dtgvDsHangVe.AllowUserToResizeRows = false;
            this.dtgvDsHangVe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDsHangVe.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgvDsHangVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvDsHangVe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvDsHangVe.Location = new System.Drawing.Point(3, 421);
            this.dtgvDsHangVe.Name = "dtgvDsHangVe";
            this.dtgvDsHangVe.ShowCellErrors = false;
            this.dtgvDsHangVe.ShowCellToolTips = false;
            this.dtgvDsHangVe.ShowEditingIcon = false;
            this.dtgvDsHangVe.Size = new System.Drawing.Size(1035, 315);
            this.dtgvDsHangVe.TabIndex = 0;
            this.dtgvDsHangVe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDsHangVe_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Hạng Vé :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Hạng Vé :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tỉ lệ đơn giá :";
            // 
            // txbMaHangVe
            // 
            this.txbMaHangVe.BackColor = System.Drawing.Color.White;
            this.txbMaHangVe.Location = new System.Drawing.Point(307, 77);
            this.txbMaHangVe.Name = "txbMaHangVe";
            this.txbMaHangVe.Size = new System.Drawing.Size(254, 32);
            this.txbMaHangVe.TabIndex = 5;
            // 
            // txbTiLeDonGia
            // 
            this.txbTiLeDonGia.Location = new System.Drawing.Point(307, 186);
            this.txbTiLeDonGia.Name = "txbTiLeDonGia";
            this.txbTiLeDonGia.Size = new System.Drawing.Size(254, 32);
            this.txbTiLeDonGia.TabIndex = 6;
            this.txbTiLeDonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbTiLeDonGia_KeyPress);
            // 
            // txbTenHangVe
            // 
            this.txbTenHangVe.Location = new System.Drawing.Point(307, 130);
            this.txbTenHangVe.Name = "txbTenHangVe";
            this.txbTenHangVe.Size = new System.Drawing.Size(254, 32);
            this.txbTenHangVe.TabIndex = 7;
            this.txbTenHangVe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbTenHangVe_KeyPress);
            // 
            // btnSuaHangVe
            // 
            this.btnSuaHangVe.Location = new System.Drawing.Point(440, 284);
            this.btnSuaHangVe.Name = "btnSuaHangVe";
            this.btnSuaHangVe.Size = new System.Drawing.Size(121, 59);
            this.btnSuaHangVe.TabIndex = 8;
            this.btnSuaHangVe.Text = "Cập nhật";
            this.btnSuaHangVe.UseVisualStyleBackColor = true;
            this.btnSuaHangVe.Click += new System.EventHandler(this.btnSuaHangVe_Click);
            // 
            // btnXoaHangVe
            // 
            this.btnXoaHangVe.Location = new System.Drawing.Point(596, 284);
            this.btnXoaHangVe.Name = "btnXoaHangVe";
            this.btnXoaHangVe.Size = new System.Drawing.Size(113, 59);
            this.btnXoaHangVe.TabIndex = 9;
            this.btnXoaHangVe.Text = "Xoá";
            this.btnXoaHangVe.UseVisualStyleBackColor = true;
            this.btnXoaHangVe.Click += new System.EventHandler(this.btnXoaHangVe_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnSuaHangVe);
            this.groupBox1.Controls.Add(this.txbMaHangVe);
            this.groupBox1.Controls.Add(this.dtgvDsHangVe);
            this.groupBox1.Controls.Add(this.btnXoaHangVe);
            this.groupBox1.Controls.Add(this.txbTenHangVe);
            this.groupBox1.Controls.Add(this.txbTiLeDonGia);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1041, 739);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lý hạng vé";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(762, 284);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(113, 59);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmQuanLyHangVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BanVeMayBay.Properties.Resources.background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1041, 739);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQuanLyHangVe";
            this.Text = "Quản lý hạng vé";
            this.Load += new System.EventHandler(this.frmQuanLyHangVe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDsHangVe)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvDsHangVe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbMaHangVe;
        private System.Windows.Forms.TextBox txbTiLeDonGia;
        private System.Windows.Forms.TextBox txbTenHangVe;
        private System.Windows.Forms.Button btnSuaHangVe;
        private System.Windows.Forms.Button btnXoaHangVe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThoat;
    }
}