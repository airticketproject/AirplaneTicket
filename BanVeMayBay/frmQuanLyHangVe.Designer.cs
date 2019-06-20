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
            this.dtgvDsHangVe = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbMaHangVe = new System.Windows.Forms.TextBox();
            this.txbTiLeDonGia = new System.Windows.Forms.TextBox();
            this.txbTenHangVe = new System.Windows.Forms.TextBox();
            this.btnSuaHangVe = new System.Windows.Forms.Button();
            this.btnXoaHangVe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDsHangVe)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvDsHangVe
            // 
            this.dtgvDsHangVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDsHangVe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvDsHangVe.Location = new System.Drawing.Point(0, 240);
            this.dtgvDsHangVe.Name = "dtgvDsHangVe";
            this.dtgvDsHangVe.Size = new System.Drawing.Size(768, 315);
            this.dtgvDsHangVe.TabIndex = 0;
            this.dtgvDsHangVe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDsHangVe_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Hạng Vé :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Hạng Vé :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tỉ lệ đơn giá :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Danh sách hạng vé";
            // 
            // txbMaHangVe
            // 
            this.txbMaHangVe.BackColor = System.Drawing.Color.White;
            this.txbMaHangVe.Location = new System.Drawing.Point(223, 62);
            this.txbMaHangVe.Name = "txbMaHangVe";
            this.txbMaHangVe.Size = new System.Drawing.Size(192, 22);
            this.txbMaHangVe.TabIndex = 5;
            // 
            // txbTiLeDonGia
            // 
            this.txbTiLeDonGia.Location = new System.Drawing.Point(223, 149);
            this.txbTiLeDonGia.Name = "txbTiLeDonGia";
            this.txbTiLeDonGia.Size = new System.Drawing.Size(192, 22);
            this.txbTiLeDonGia.TabIndex = 6;
            this.txbTiLeDonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbTiLeDonGia_KeyPress);
            // 
            // txbTenHangVe
            // 
            this.txbTenHangVe.Location = new System.Drawing.Point(223, 104);
            this.txbTenHangVe.Name = "txbTenHangVe";
            this.txbTenHangVe.Size = new System.Drawing.Size(192, 22);
            this.txbTenHangVe.TabIndex = 7;
            this.txbTenHangVe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbTenHangVe_KeyPress);
            // 
            // btnSuaHangVe
            // 
            this.btnSuaHangVe.Location = new System.Drawing.Point(493, 127);
            this.btnSuaHangVe.Name = "btnSuaHangVe";
            this.btnSuaHangVe.Size = new System.Drawing.Size(89, 50);
            this.btnSuaHangVe.TabIndex = 8;
            this.btnSuaHangVe.Text = "Cập nhật";
            this.btnSuaHangVe.UseVisualStyleBackColor = true;
            this.btnSuaHangVe.Click += new System.EventHandler(this.btnSuaHangVe_Click);
            // 
            // btnXoaHangVe
            // 
            this.btnXoaHangVe.Location = new System.Drawing.Point(615, 127);
            this.btnXoaHangVe.Name = "btnXoaHangVe";
            this.btnXoaHangVe.Size = new System.Drawing.Size(89, 50);
            this.btnXoaHangVe.TabIndex = 9;
            this.btnXoaHangVe.Text = "Xoá";
            this.btnXoaHangVe.UseVisualStyleBackColor = true;
            this.btnXoaHangVe.Click += new System.EventHandler(this.btnXoaHangVe_Click);
            // 
            // frmQuanLyHangVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 555);
            this.Controls.Add(this.btnXoaHangVe);
            this.Controls.Add(this.btnSuaHangVe);
            this.Controls.Add(this.txbTenHangVe);
            this.Controls.Add(this.txbTiLeDonGia);
            this.Controls.Add(this.txbMaHangVe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvDsHangVe);
            this.Name = "frmQuanLyHangVe";
            this.Text = "frmQuanLyHangVe";
            this.Load += new System.EventHandler(this.frmQuanLyHangVe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDsHangVe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvDsHangVe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbMaHangVe;
        private System.Windows.Forms.TextBox txbTiLeDonGia;
        private System.Windows.Forms.TextBox txbTenHangVe;
        private System.Windows.Forms.Button btnSuaHangVe;
        private System.Windows.Forms.Button btnXoaHangVe;
    }
}