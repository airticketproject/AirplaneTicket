namespace BanVeMayBay
{
    partial class frmTimKiem_DanhSachChuyenBay
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
            this.label = new System.Windows.Forms.Label();
            this.SanBayDen_label = new System.Windows.Forms.Label();
            this.TimKiem_button = new System.Windows.Forms.Button();
            this.Thoat_button = new System.Windows.Forms.Button();
            this.cbbSanBayDi = new System.Windows.Forms.ComboBox();
            this.cbbSanBayDen = new System.Windows.Forms.ComboBox();
            this.dtgvDsChuyenBay = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDsChuyenBay)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(383, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÌM KIẾM CHUYẾN BAY";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(275, 89);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(112, 26);
            this.label.TabIndex = 1;
            this.label.Text = "Sân Bay Đi";
            // 
            // SanBayDen_label
            // 
            this.SanBayDen_label.AutoSize = true;
            this.SanBayDen_label.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SanBayDen_label.Location = new System.Drawing.Point(275, 142);
            this.SanBayDen_label.Name = "SanBayDen_label";
            this.SanBayDen_label.Size = new System.Drawing.Size(128, 26);
            this.SanBayDen_label.TabIndex = 1;
            this.SanBayDen_label.Text = "Sân Bay Đến";
            // 
            // TimKiem_button
            // 
            this.TimKiem_button.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimKiem_button.Location = new System.Drawing.Point(268, 186);
            this.TimKiem_button.Name = "TimKiem_button";
            this.TimKiem_button.Size = new System.Drawing.Size(119, 50);
            this.TimKiem_button.TabIndex = 5;
            this.TimKiem_button.Text = "Tìm kiếm";
            this.TimKiem_button.UseVisualStyleBackColor = true;
            this.TimKiem_button.Click += new System.EventHandler(this.TimKiem_button_Click);
            // 
            // Thoat_button
            // 
            this.Thoat_button.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thoat_button.Location = new System.Drawing.Point(664, 188);
            this.Thoat_button.Name = "Thoat_button";
            this.Thoat_button.Size = new System.Drawing.Size(119, 47);
            this.Thoat_button.TabIndex = 5;
            this.Thoat_button.Text = "Thoát";
            this.Thoat_button.UseVisualStyleBackColor = true;
            this.Thoat_button.Click += new System.EventHandler(this.Thoat_button_Click);
            // 
            // cbbSanBayDi
            // 
            this.cbbSanBayDi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSanBayDi.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSanBayDi.FormattingEnabled = true;
            this.cbbSanBayDi.Location = new System.Drawing.Point(517, 86);
            this.cbbSanBayDi.Name = "cbbSanBayDi";
            this.cbbSanBayDi.Size = new System.Drawing.Size(266, 32);
            this.cbbSanBayDi.TabIndex = 6;
            // 
            // cbbSanBayDen
            // 
            this.cbbSanBayDen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSanBayDen.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSanBayDen.FormattingEnabled = true;
            this.cbbSanBayDen.Location = new System.Drawing.Point(517, 139);
            this.cbbSanBayDen.Name = "cbbSanBayDen";
            this.cbbSanBayDen.Size = new System.Drawing.Size(266, 32);
            this.cbbSanBayDen.TabIndex = 6;
            // 
            // dtgvDsChuyenBay
            // 
            this.dtgvDsChuyenBay.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgvDsChuyenBay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDsChuyenBay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvDsChuyenBay.Location = new System.Drawing.Point(0, 251);
            this.dtgvDsChuyenBay.Name = "dtgvDsChuyenBay";
            this.dtgvDsChuyenBay.RowTemplate.Height = 24;
            this.dtgvDsChuyenBay.Size = new System.Drawing.Size(977, 240);
            this.dtgvDsChuyenBay.TabIndex = 7;
            // 
            // frmTimKiem_DanhSachChuyenBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::BanVeMayBay.Properties.Resources._0;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(977, 491);
            this.Controls.Add(this.dtgvDsChuyenBay);
            this.Controls.Add(this.cbbSanBayDen);
            this.Controls.Add(this.cbbSanBayDi);
            this.Controls.Add(this.Thoat_button);
            this.Controls.Add(this.TimKiem_button);
            this.Controls.Add(this.SanBayDen_label);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "frmTimKiem_DanhSachChuyenBay";
            this.Text = "Tìm Kiếm Chuyến Bay";
            this.Load += new System.EventHandler(this.frmTimKiem_DanhSachChuyenBay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDsChuyenBay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label SanBayDen_label;
        private System.Windows.Forms.Button TimKiem_button;
        private System.Windows.Forms.Button Thoat_button;
        private System.Windows.Forms.ComboBox cbbSanBayDi;
        private System.Windows.Forms.ComboBox cbbSanBayDen;
        private System.Windows.Forms.DataGridView dtgvDsChuyenBay;
    }
}