﻿namespace BanVeMayBay
{
    partial class frmThemSanBay
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
            this.Them_button = new System.Windows.Forms.Button();
            this.txbTenSanBay = new System.Windows.Forms.TextBox();
            this.txbMaSanBay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvThemDsChuyenBay = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThemDsChuyenBay)).BeginInit();
            this.SuspendLayout();
            // 
            // Them_button
            // 
            this.Them_button.Location = new System.Drawing.Point(592, 96);
            this.Them_button.Name = "Them_button";
            this.Them_button.Size = new System.Drawing.Size(98, 41);
            this.Them_button.TabIndex = 16;
            this.Them_button.Text = "Thêm";
            this.Them_button.UseVisualStyleBackColor = true;
            this.Them_button.Click += new System.EventHandler(this.Them_button_Click);
            // 
            // txbTenSanBay
            // 
            this.txbTenSanBay.Location = new System.Drawing.Point(189, 141);
            this.txbTenSanBay.Name = "txbTenSanBay";
            this.txbTenSanBay.Size = new System.Drawing.Size(166, 22);
            this.txbTenSanBay.TabIndex = 13;
            // 
            // txbMaSanBay
            // 
            this.txbMaSanBay.Location = new System.Drawing.Point(189, 71);
            this.txbMaSanBay.Name = "txbMaSanBay";
            this.txbMaSanBay.Size = new System.Drawing.Size(166, 22);
            this.txbMaSanBay.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tên Sân Bay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mã Sân Bay";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvThemDsChuyenBay);
            this.groupBox1.Controls.Add(this.txbMaSanBay);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Them_button);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txbTenSanBay);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(762, 631);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sân bay";
            // 
            // dtgvThemDsChuyenBay
            // 
            this.dtgvThemDsChuyenBay.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgvThemDsChuyenBay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvThemDsChuyenBay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvThemDsChuyenBay.Location = new System.Drawing.Point(3, 277);
            this.dtgvThemDsChuyenBay.Name = "dtgvThemDsChuyenBay";
            this.dtgvThemDsChuyenBay.RowTemplate.Height = 24;
            this.dtgvThemDsChuyenBay.Size = new System.Drawing.Size(756, 351);
            this.dtgvThemDsChuyenBay.TabIndex = 17;
            // 
            // frmThemSanBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 631);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmThemSanBay";
            this.Text = "Quản lý sân bay";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThemDsChuyenBay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Them_button;
        private System.Windows.Forms.TextBox txbTenSanBay;
        private System.Windows.Forms.TextBox txbMaSanBay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvThemDsChuyenBay;
    }
}