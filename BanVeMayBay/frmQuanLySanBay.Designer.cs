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
            this.txbSuaTenSanBay = new System.Windows.Forms.TextBox();
            this.txbSuaMaSanBay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvSanBay = new System.Windows.Forms.DataGridView();
            this.Xoa_button = new System.Windows.Forms.Button();
            this.Sua_button = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSanBay)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.txbSuaTenSanBay);
            this.groupBox1.Controls.Add(this.txbSuaMaSanBay);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtgvSanBay);
            this.groupBox1.Controls.Add(this.Xoa_button);
            this.groupBox1.Controls.Add(this.Sua_button);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1090, 718);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sân bay";
            // 
            // txbSuaTenSanBay
            // 
            this.txbSuaTenSanBay.Location = new System.Drawing.Point(284, 141);
            this.txbSuaTenSanBay.Name = "txbSuaTenSanBay";
            this.txbSuaTenSanBay.Size = new System.Drawing.Size(250, 32);
            this.txbSuaTenSanBay.TabIndex = 18;
            // 
            // txbSuaMaSanBay
            // 
            this.txbSuaMaSanBay.Enabled = false;
            this.txbSuaMaSanBay.Location = new System.Drawing.Point(284, 70);
            this.txbSuaMaSanBay.Name = "txbSuaMaSanBay";
            this.txbSuaMaSanBay.Size = new System.Drawing.Size(250, 32);
            this.txbSuaMaSanBay.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 26);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tên sân bay :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 26);
            this.label1.TabIndex = 15;
            this.label1.Text = "Mã sân bay :";
            // 
            // dtgvSanBay
            // 
            this.dtgvSanBay.AllowUserToAddRows = false;
            this.dtgvSanBay.AllowUserToDeleteRows = false;
            this.dtgvSanBay.AllowUserToResizeColumns = false;
            this.dtgvSanBay.AllowUserToResizeRows = false;
            this.dtgvSanBay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvSanBay.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dtgvSanBay.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgvSanBay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvSanBay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvSanBay.Location = new System.Drawing.Point(3, 357);
            this.dtgvSanBay.Name = "dtgvSanBay";
            this.dtgvSanBay.RowTemplate.Height = 24;
            this.dtgvSanBay.ShowCellToolTips = false;
            this.dtgvSanBay.ShowEditingIcon = false;
            this.dtgvSanBay.Size = new System.Drawing.Size(1084, 358);
            this.dtgvSanBay.TabIndex = 0;
            this.dtgvSanBay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvSanBay_CellClick);
            // 
            // Xoa_button
            // 
            this.Xoa_button.Location = new System.Drawing.Point(682, 212);
            this.Xoa_button.Name = "Xoa_button";
            this.Xoa_button.Size = new System.Drawing.Size(107, 52);
            this.Xoa_button.TabIndex = 14;
            this.Xoa_button.Text = "Xóa";
            this.Xoa_button.UseVisualStyleBackColor = true;
            this.Xoa_button.Click += new System.EventHandler(this.Xoa_button_Click);
            // 
            // Sua_button
            // 
            this.Sua_button.Location = new System.Drawing.Point(515, 212);
            this.Sua_button.Name = "Sua_button";
            this.Sua_button.Size = new System.Drawing.Size(104, 52);
            this.Sua_button.TabIndex = 12;
            this.Sua_button.Text = "Sửa";
            this.Sua_button.UseVisualStyleBackColor = true;
            this.Sua_button.Click += new System.EventHandler(this.Sua_button_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(862, 212);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(107, 52);
            this.btnThoat.TabIndex = 19;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmQuanLySanBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BanVeMayBay.Properties.Resources._0;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1090, 718);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuanLySanBay";
            this.Text = "Quản lý sân bay";
            this.Load += new System.EventHandler(this.frmQuanLySanBay_Load);
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
        private System.Windows.Forms.Button btnThoat;
    }
}