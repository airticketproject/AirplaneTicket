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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.NgayKhoiHanh_label = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.TimKiem_button = new System.Windows.Forms.Button();
            this.Thoat_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÌM KIẾM CHUYẾN BAY";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(20, 61);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(78, 17);
            this.label.TabIndex = 1;
            this.label.Text = "Sân Bay Đi";
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // SanBayDen_label
            // 
            this.SanBayDen_label.AutoSize = true;
            this.SanBayDen_label.Location = new System.Drawing.Point(20, 108);
            this.SanBayDen_label.Name = "SanBayDen_label";
            this.SanBayDen_label.Size = new System.Drawing.Size(91, 17);
            this.SanBayDen_label.TabIndex = 1;
            this.SanBayDen_label.Text = "Sân Bay Đến";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(158, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(158, 105);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 22);
            this.textBox2.TabIndex = 2;
            // 
            // NgayKhoiHanh_label
            // 
            this.NgayKhoiHanh_label.AutoSize = true;
            this.NgayKhoiHanh_label.Location = new System.Drawing.Point(20, 152);
            this.NgayKhoiHanh_label.Name = "NgayKhoiHanh_label";
            this.NgayKhoiHanh_label.Size = new System.Drawing.Size(111, 17);
            this.NgayKhoiHanh_label.TabIndex = 3;
            this.NgayKhoiHanh_label.Text = "Ngày Khởi Hành";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(158, 152);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // TimKiem_button
            // 
            this.TimKiem_button.Location = new System.Drawing.Point(36, 187);
            this.TimKiem_button.Name = "TimKiem_button";
            this.TimKiem_button.Size = new System.Drawing.Size(106, 36);
            this.TimKiem_button.TabIndex = 5;
            this.TimKiem_button.Text = "Tìm kiếm";
            this.TimKiem_button.UseVisualStyleBackColor = true;
            // 
            // Thoat_button
            // 
            this.Thoat_button.Location = new System.Drawing.Point(222, 187);
            this.Thoat_button.Name = "Thoat_button";
            this.Thoat_button.Size = new System.Drawing.Size(106, 36);
            this.Thoat_button.TabIndex = 5;
            this.Thoat_button.Text = "Thoát";
            this.Thoat_button.UseVisualStyleBackColor = true;
            // 
            // TimKiem_DanhSachChuyenBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 235);
            this.Controls.Add(this.Thoat_button);
            this.Controls.Add(this.TimKiem_button);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.NgayKhoiHanh_label);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SanBayDen_label);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label1);
            this.Name = "TimKiem_DanhSachChuyenBay";
            this.Text = "TimKiem_DanhSachChuyenBay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label SanBayDen_label;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label NgayKhoiHanh_label;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button TimKiem_button;
        private System.Windows.Forms.Button Thoat_button;
    }
}