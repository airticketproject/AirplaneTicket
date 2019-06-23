namespace BanVeMayBay
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
            this.dtgvDsThemSanBay = new System.Windows.Forms.DataGridView();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDsThemSanBay)).BeginInit();
            this.SuspendLayout();
            // 
            // Them_button
            // 
            this.Them_button.Location = new System.Drawing.Point(535, 71);
            this.Them_button.Name = "Them_button";
            this.Them_button.Size = new System.Drawing.Size(119, 48);
            this.Them_button.TabIndex = 16;
            this.Them_button.Text = "Thêm";
            this.Them_button.UseVisualStyleBackColor = true;
            this.Them_button.Click += new System.EventHandler(this.Them_button_Click);
            // 
            // txbTenSanBay
            // 
            this.txbTenSanBay.Location = new System.Drawing.Point(234, 173);
            this.txbTenSanBay.Name = "txbTenSanBay";
            this.txbTenSanBay.Size = new System.Drawing.Size(196, 32);
            this.txbTenSanBay.TabIndex = 13;
            // 
            // txbMaSanBay
            // 
            this.txbMaSanBay.Location = new System.Drawing.Point(234, 68);
            this.txbMaSanBay.Name = "txbMaSanBay";
            this.txbMaSanBay.Size = new System.Drawing.Size(196, 32);
            this.txbMaSanBay.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tên Sân Bay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 26);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mã Sân Bay";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dtgvDsThemSanBay);
            this.groupBox1.Controls.Add(this.txbMaSanBay);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_Thoat);
            this.groupBox1.Controls.Add(this.Them_button);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txbTenSanBay);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(762, 631);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sân bay";
            // 
            // dtgvDsThemSanBay
            // 
            this.dtgvDsThemSanBay.AllowUserToAddRows = false;
            this.dtgvDsThemSanBay.AllowUserToDeleteRows = false;
            this.dtgvDsThemSanBay.AllowUserToResizeColumns = false;
            this.dtgvDsThemSanBay.AllowUserToResizeRows = false;
            this.dtgvDsThemSanBay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDsThemSanBay.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dtgvDsThemSanBay.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgvDsThemSanBay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvDsThemSanBay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvDsThemSanBay.Location = new System.Drawing.Point(3, 277);
            this.dtgvDsThemSanBay.MultiSelect = false;
            this.dtgvDsThemSanBay.Name = "dtgvDsThemSanBay";
            this.dtgvDsThemSanBay.ReadOnly = true;
            this.dtgvDsThemSanBay.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgvDsThemSanBay.RowTemplate.Height = 24;
            this.dtgvDsThemSanBay.ShowCellToolTips = false;
            this.dtgvDsThemSanBay.ShowEditingIcon = false;
            this.dtgvDsThemSanBay.Size = new System.Drawing.Size(756, 351);
            this.dtgvDsThemSanBay.TabIndex = 17;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(535, 150);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(119, 55);
            this.btn_Thoat.TabIndex = 16;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // frmThemSanBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BanVeMayBay.Properties.Resources.background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(762, 631);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "frmThemSanBay";
            this.Text = "Quản lý sân bay";
            this.Load += new System.EventHandler(this.frmThemSanBay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDsThemSanBay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Them_button;
        private System.Windows.Forms.TextBox txbTenSanBay;
        private System.Windows.Forms.TextBox txbMaSanBay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvDsThemSanBay;
        private System.Windows.Forms.Button btn_Thoat;
    }
}