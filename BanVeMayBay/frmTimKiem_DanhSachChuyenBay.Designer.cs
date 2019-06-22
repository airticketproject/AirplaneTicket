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
            this.label = new System.Windows.Forms.Label();
            this.SanBayDen_label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.NgayKhoiHanh_label = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.TimKiem_button = new System.Windows.Forms.Button();
            this.Thoat_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(147, 62);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(78, 17);
            this.label.TabIndex = 1;
            this.label.Text = "Sân Bay Đi";
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // SanBayDen_label
            // 
            this.SanBayDen_label.AutoSize = true;
            this.SanBayDen_label.Location = new System.Drawing.Point(147, 109);
            this.SanBayDen_label.Name = "SanBayDen_label";
            this.SanBayDen_label.Size = new System.Drawing.Size(91, 17);
            this.SanBayDen_label.TabIndex = 1;
            this.SanBayDen_label.Text = "Sân Bay Đến";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(285, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(253, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(285, 106);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(253, 22);
            this.textBox2.TabIndex = 2;
            // 
            // NgayKhoiHanh_label
            // 
            this.NgayKhoiHanh_label.AutoSize = true;
            this.NgayKhoiHanh_label.Location = new System.Drawing.Point(147, 153);
            this.NgayKhoiHanh_label.Name = "NgayKhoiHanh_label";
            this.NgayKhoiHanh_label.Size = new System.Drawing.Size(111, 17);
            this.NgayKhoiHanh_label.TabIndex = 3;
            this.NgayKhoiHanh_label.Text = "Ngày Khởi Hành";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(285, 153);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(253, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // TimKiem_button
            // 
            this.TimKiem_button.Location = new System.Drawing.Point(263, 264);
            this.TimKiem_button.Name = "TimKiem_button";
            this.TimKiem_button.Size = new System.Drawing.Size(106, 36);
            this.TimKiem_button.TabIndex = 5;
            this.TimKiem_button.Text = "Tìm kiếm";
            this.TimKiem_button.UseVisualStyleBackColor = true;
            // 
            // Thoat_button
            // 
            this.Thoat_button.Location = new System.Drawing.Point(449, 264);
            this.Thoat_button.Name = "Thoat_button";
            this.Thoat_button.Size = new System.Drawing.Size(106, 36);
            this.Thoat_button.TabIndex = 5;
            this.Thoat_button.Text = "Thoát";
            this.Thoat_button.UseVisualStyleBackColor = true;
            this.Thoat_button.Click += new System.EventHandler(this.Thoat_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.Thoat_button);
            this.groupBox1.Controls.Add(this.TimKiem_button);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Controls.Add(this.SanBayDen_label);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.NgayKhoiHanh_label);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(819, 351);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // frmTimKiem_DanhSachChuyenBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 615);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTimKiem_DanhSachChuyenBay";
            this.Text = "TimKiem_DanhSachChuyenBay";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label SanBayDen_label;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label NgayKhoiHanh_label;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button TimKiem_button;
        private System.Windows.Forms.Button Thoat_button;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}