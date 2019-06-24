namespace BanVeMayBay
{
    partial class frmThemHangVe
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbMaHangVe = new System.Windows.Forms.TextBox();
            this.txbTenHangVe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbTiLe = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dtgvDsHangVe = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDsHangVe)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Hạng Vé";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên Hạng Vé";
            // 
            // txbMaHangVe
            // 
            this.txbMaHangVe.Location = new System.Drawing.Point(442, 56);
            this.txbMaHangVe.Name = "txbMaHangVe";
            this.txbMaHangVe.Size = new System.Drawing.Size(248, 32);
            this.txbMaHangVe.TabIndex = 0;
            this.txbMaHangVe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbMaHangVe_KeyPress);
            // 
            // txbTenHangVe
            // 
            this.txbTenHangVe.Location = new System.Drawing.Point(442, 114);
            this.txbTenHangVe.Name = "txbTenHangVe";
            this.txbTenHangVe.Size = new System.Drawing.Size(248, 32);
            this.txbTenHangVe.TabIndex = 1;
            this.txbTenHangVe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbTenHangVe_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tỉ lệ đơn giá";
            // 
            // txbTiLe
            // 
            this.txbTiLe.Location = new System.Drawing.Point(442, 175);
            this.txbTiLe.Name = "txbTiLe";
            this.txbTiLe.Size = new System.Drawing.Size(248, 32);
            this.txbTiLe.TabIndex = 2;
            this.txbTiLe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbTiLe_KeyPress);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(635, 263);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(126, 56);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(796, 263);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(119, 56);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
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
            this.dtgvDsHangVe.Location = new System.Drawing.Point(3, 389);
            this.dtgvDsHangVe.Name = "dtgvDsHangVe";
            this.dtgvDsHangVe.RowHeadersVisible = false;
            this.dtgvDsHangVe.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgvDsHangVe.RowTemplate.Height = 24;
            this.dtgvDsHangVe.ShowCellErrors = false;
            this.dtgvDsHangVe.ShowCellToolTips = false;
            this.dtgvDsHangVe.ShowEditingIcon = false;
            this.dtgvDsHangVe.ShowRowErrors = false;
            this.dtgvDsHangVe.Size = new System.Drawing.Size(1157, 345);
            this.dtgvDsHangVe.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.dtgvDsHangVe);
            this.groupBox1.Controls.Add(this.txbMaHangVe);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbTiLe);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txbTenHangVe);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1163, 737);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lý hạng vé";
            // 
            // frmThemHangVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BanVeMayBay.Properties.Resources.background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1163, 737);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmThemHangVe";
            this.Text = "Hạng vé";
            this.Load += new System.EventHandler(this.frmThemHangVe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDsHangVe)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbMaHangVe;
        private System.Windows.Forms.TextBox txbTenHangVe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbTiLe;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dtgvDsHangVe;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}