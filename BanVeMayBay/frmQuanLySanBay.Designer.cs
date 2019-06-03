namespace BanVeMayBay
{
    partial class frmQuanLySanBay
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
            this.dtgvSanBay = new System.Windows.Forms.DataGridView();
            this.Sua_button = new System.Windows.Forms.Button();
            this.Xoa_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbSuaMaSanBay = new System.Windows.Forms.TextBox();
            this.txbSuaTenSanBay = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSanBay)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbSuaTenSanBay);
            this.groupBox1.Controls.Add(this.txbSuaMaSanBay);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtgvSanBay);
            this.groupBox1.Controls.Add(this.Xoa_button);
            this.groupBox1.Controls.Add(this.Sua_button);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(916, 648);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sân bay";
            // 
            // dtgvSanBay
            // 
            this.dtgvSanBay.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgvSanBay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSanBay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvSanBay.Location = new System.Drawing.Point(3, 278);
            this.dtgvSanBay.Name = "dtgvSanBay";
            this.dtgvSanBay.RowTemplate.Height = 24;
            this.dtgvSanBay.Size = new System.Drawing.Size(910, 367);
            this.dtgvSanBay.TabIndex = 0;
            // 
            // Sua_button
            // 
            this.Sua_button.Location = new System.Drawing.Point(545, 121);
            this.Sua_button.Name = "Sua_button";
            this.Sua_button.Size = new System.Drawing.Size(104, 52);
            this.Sua_button.TabIndex = 12;
            this.Sua_button.Text = "Sửa";
            this.Sua_button.UseVisualStyleBackColor = true;
            // 
            // Xoa_button
            // 
            this.Xoa_button.Location = new System.Drawing.Point(712, 121);
            this.Xoa_button.Name = "Xoa_button";
            this.Xoa_button.Size = new System.Drawing.Size(107, 52);
            this.Xoa_button.TabIndex = 14;
            this.Xoa_button.Text = "Xóa";
            this.Xoa_button.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Mã sân bay :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tên sân bay :";
            // 
            // txbSuaMaSanBay
            // 
            this.txbSuaMaSanBay.Location = new System.Drawing.Point(207, 80);
            this.txbSuaMaSanBay.Name = "txbSuaMaSanBay";
            this.txbSuaMaSanBay.Size = new System.Drawing.Size(206, 22);
            this.txbSuaMaSanBay.TabIndex = 17;
            // 
            // txbSuaTenSanBay
            // 
            this.txbSuaTenSanBay.Location = new System.Drawing.Point(207, 140);
            this.txbSuaTenSanBay.Name = "txbSuaTenSanBay";
            this.txbSuaTenSanBay.Size = new System.Drawing.Size(206, 22);
            this.txbSuaTenSanBay.TabIndex = 18;
            // 
            // frmSanBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 648);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSanBay";
            this.Text = "Quản lý sân bay";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSanBay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvSanBay;
        private System.Windows.Forms.Button Sua_button;
        private System.Windows.Forms.Button Xoa_button;
        private System.Windows.Forms.TextBox txbSuaTenSanBay;
        private System.Windows.Forms.TextBox txbSuaMaSanBay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}