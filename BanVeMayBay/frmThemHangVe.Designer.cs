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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbMaHangVe = new System.Windows.Forms.TextBox();
            this.txbTenHangVe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbTiLe = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dtgvDsHangVe = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDsHangVe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(380, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "HẠNG VÉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Hạng Vé";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên Hạng Vé";
            // 
            // txbMaHangVe
            // 
            this.txbMaHangVe.Location = new System.Drawing.Point(197, 51);
            this.txbMaHangVe.Name = "txbMaHangVe";
            this.txbMaHangVe.Size = new System.Drawing.Size(167, 22);
            this.txbMaHangVe.TabIndex = 2;
            this.txbMaHangVe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbMaHangVe_KeyPress);
            // 
            // txbTenHangVe
            // 
            this.txbTenHangVe.Location = new System.Drawing.Point(197, 99);
            this.txbTenHangVe.Name = "txbTenHangVe";
            this.txbTenHangVe.Size = new System.Drawing.Size(167, 22);
            this.txbTenHangVe.TabIndex = 2;
            this.txbTenHangVe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbTenHangVe_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tỉ lệ đơn giá";
            // 
            // txbTiLe
            // 
            this.txbTiLe.Location = new System.Drawing.Point(197, 147);
            this.txbTiLe.Name = "txbTiLe";
            this.txbTiLe.Size = new System.Drawing.Size(167, 22);
            this.txbTiLe.TabIndex = 2;
            this.txbTiLe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbTiLe_KeyPress);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(524, 90);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(85, 40);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(730, 9);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(85, 41);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dtgvDsHangVe
            // 
            this.dtgvDsHangVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDsHangVe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvDsHangVe.Location = new System.Drawing.Point(0, 235);
            this.dtgvDsHangVe.Name = "dtgvDsHangVe";
            this.dtgvDsHangVe.RowTemplate.Height = 24;
            this.dtgvDsHangVe.Size = new System.Drawing.Size(827, 345);
            this.dtgvDsHangVe.TabIndex = 4;
            // 
            // frmThemHangVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 580);
            this.Controls.Add(this.dtgvDsHangVe);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txbTiLe);
            this.Controls.Add(this.txbTenHangVe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbMaHangVe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmThemHangVe";
            this.Text = "Hạng vé";
            this.Load += new System.EventHandler(this.frmThemHangVe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDsHangVe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbMaHangVe;
        private System.Windows.Forms.TextBox txbTenHangVe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbTiLe;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dtgvDsHangVe;
    }
}