namespace BanVeMayBay
{
    partial class frmSanBay
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSanBay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSanBay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.Thoat_button = new System.Windows.Forms.Button();
            this.Sua_button = new System.Windows.Forms.Button();
            this.Them_button = new System.Windows.Forms.Button();
            this.Xoa_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(14, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 386);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sân bay";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaSanBay,
            this.TenSanBay});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(494, 365);
            this.dataGridView1.TabIndex = 0;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // MaSanBay
            // 
            this.MaSanBay.HeaderText = "Mã Sân Bay";
            this.MaSanBay.Name = "MaSanBay";
            // 
            // TenSanBay
            // 
            this.TenSanBay.HeaderText = "Tên Sân Bay";
            this.TenSanBay.Name = "TenSanBay";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "THÔNG TIN SÂN BAY";
            // 
            // Thoat_button
            // 
            this.Thoat_button.Location = new System.Drawing.Point(419, 452);
            this.Thoat_button.Name = "Thoat_button";
            this.Thoat_button.Size = new System.Drawing.Size(92, 42);
            this.Thoat_button.TabIndex = 11;
            this.Thoat_button.Text = "Thoát";
            this.Thoat_button.UseVisualStyleBackColor = true;
            this.Thoat_button.Click += new System.EventHandler(this.Thoat_button_Click);
            // 
            // Sua_button
            // 
            this.Sua_button.Location = new System.Drawing.Point(288, 452);
            this.Sua_button.Name = "Sua_button";
            this.Sua_button.Size = new System.Drawing.Size(92, 42);
            this.Sua_button.TabIndex = 12;
            this.Sua_button.Text = "Sửa";
            this.Sua_button.UseVisualStyleBackColor = true;
            // 
            // Them_button
            // 
            this.Them_button.Location = new System.Drawing.Point(17, 452);
            this.Them_button.Name = "Them_button";
            this.Them_button.Size = new System.Drawing.Size(92, 42);
            this.Them_button.TabIndex = 13;
            this.Them_button.Text = "Thêm";
            this.Them_button.UseVisualStyleBackColor = true;
            this.Them_button.Click += new System.EventHandler(this.Them_button_Click);
            // 
            // Xoa_button
            // 
            this.Xoa_button.Location = new System.Drawing.Point(152, 452);
            this.Xoa_button.Name = "Xoa_button";
            this.Xoa_button.Size = new System.Drawing.Size(92, 42);
            this.Xoa_button.TabIndex = 14;
            this.Xoa_button.Text = "Xóa";
            this.Xoa_button.UseVisualStyleBackColor = true;
            // 
            // frmSanBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 510);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Thoat_button);
            this.Controls.Add(this.Sua_button);
            this.Controls.Add(this.Them_button);
            this.Controls.Add(this.Xoa_button);
            this.Name = "frmSanBay";
            this.Text = "frmSanBay";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSanBay;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSanBay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Thoat_button;
        private System.Windows.Forms.Button Sua_button;
        private System.Windows.Forms.Button Them_button;
        private System.Windows.Forms.Button Xoa_button;
    }
}