﻿namespace BanVeMayBay
{
    partial class frmQuanLyKhachHang
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
            this.txbSuaTenKhachHang = new System.Windows.Forms.TextBox();
            this.txbSuaMaKhachHang = new System.Windows.Forms.TextBox();
            this.txbSuaCMND = new System.Windows.Forms.TextBox();
            this.txbSuaSDT = new System.Windows.Forms.TextBox();
            this.dtgvDsKhachHang = new System.Windows.Forms.DataGridView();
            this.btnSuaKhachHang = new System.Windows.Forms.Button();
            this.btnXoaKhachHang = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDsKhachHang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên khách hàng :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã khách hàng :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Điện thoại :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "CMND :";
            // 
            // txbSuaTenKhachHang
            // 
            this.txbSuaTenKhachHang.Location = new System.Drawing.Point(288, 98);
            this.txbSuaTenKhachHang.Name = "txbSuaTenKhachHang";
            this.txbSuaTenKhachHang.Size = new System.Drawing.Size(180, 32);
            this.txbSuaTenKhachHang.TabIndex = 4;
            this.txbSuaTenKhachHang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSuaTenKhachHang_KeyPress);
            // 
            // txbSuaMaKhachHang
            // 
            this.txbSuaMaKhachHang.Enabled = false;
            this.txbSuaMaKhachHang.Location = new System.Drawing.Point(288, 48);
            this.txbSuaMaKhachHang.Name = "txbSuaMaKhachHang";
            this.txbSuaMaKhachHang.Size = new System.Drawing.Size(180, 32);
            this.txbSuaMaKhachHang.TabIndex = 5;
            // 
            // txbSuaCMND
            // 
            this.txbSuaCMND.Location = new System.Drawing.Point(288, 143);
            this.txbSuaCMND.Name = "txbSuaCMND";
            this.txbSuaCMND.Size = new System.Drawing.Size(180, 32);
            this.txbSuaCMND.TabIndex = 6;
            this.txbSuaCMND.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSuaCMND_KeyPress);
            // 
            // txbSuaSDT
            // 
            this.txbSuaSDT.Location = new System.Drawing.Point(288, 190);
            this.txbSuaSDT.Name = "txbSuaSDT";
            this.txbSuaSDT.Size = new System.Drawing.Size(180, 32);
            this.txbSuaSDT.TabIndex = 7;
            this.txbSuaSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSuaSDT_KeyPress);
            // 
            // dtgvDsKhachHang
            // 
            this.dtgvDsKhachHang.AllowUserToAddRows = false;
            this.dtgvDsKhachHang.AllowUserToDeleteRows = false;
            this.dtgvDsKhachHang.AllowUserToResizeColumns = false;
            this.dtgvDsKhachHang.AllowUserToResizeRows = false;
            this.dtgvDsKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDsKhachHang.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgvDsKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvDsKhachHang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvDsKhachHang.Location = new System.Drawing.Point(0, 260);
            this.dtgvDsKhachHang.Name = "dtgvDsKhachHang";
            this.dtgvDsKhachHang.RowTemplate.Height = 24;
            this.dtgvDsKhachHang.Size = new System.Drawing.Size(828, 279);
            this.dtgvDsKhachHang.TabIndex = 8;
            this.dtgvDsKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDsKhachHang_CellClick);
            // 
            // btnSuaKhachHang
            // 
            this.btnSuaKhachHang.Location = new System.Drawing.Point(613, 65);
            this.btnSuaKhachHang.Name = "btnSuaKhachHang";
            this.btnSuaKhachHang.Size = new System.Drawing.Size(123, 62);
            this.btnSuaKhachHang.TabIndex = 10;
            this.btnSuaKhachHang.Text = "Cập nhật";
            this.btnSuaKhachHang.UseVisualStyleBackColor = true;
            this.btnSuaKhachHang.Click += new System.EventHandler(this.btnSuaKhachHang_Click);
            // 
            // btnXoaKhachHang
            // 
            this.btnXoaKhachHang.Location = new System.Drawing.Point(613, 154);
            this.btnXoaKhachHang.Name = "btnXoaKhachHang";
            this.btnXoaKhachHang.Size = new System.Drawing.Size(123, 62);
            this.btnXoaKhachHang.TabIndex = 11;
            this.btnXoaKhachHang.Text = "Xoá";
            this.btnXoaKhachHang.UseVisualStyleBackColor = true;
            this.btnXoaKhachHang.Click += new System.EventHandler(this.btnXoaKhachHang_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnXoaKhachHang);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnSuaKhachHang);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txbSuaSDT);
            this.groupBox1.Controls.Add(this.txbSuaTenKhachHang);
            this.groupBox1.Controls.Add(this.txbSuaCMND);
            this.groupBox1.Controls.Add(this.txbSuaMaKhachHang);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(828, 260);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lý khách hàng";
            // 
            // frmQuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BanVeMayBay.Properties.Resources._0;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(828, 539);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgvDsKhachHang);
            this.DoubleBuffered = true;
            this.Name = "frmQuanLyKhachHang";
            this.Text = "Quản lý khách hàng";
            this.Load += new System.EventHandler(this.frmKhachHanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDsKhachHang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbSuaTenKhachHang;
        private System.Windows.Forms.TextBox txbSuaMaKhachHang;
        private System.Windows.Forms.TextBox txbSuaCMND;
        private System.Windows.Forms.TextBox txbSuaSDT;
        private System.Windows.Forms.Button btnSuaKhachHang;
        private System.Windows.Forms.Button btnXoaKhachHang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvDsKhachHang;
    }
}