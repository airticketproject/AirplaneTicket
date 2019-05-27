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
            this.Thoat_button = new System.Windows.Forms.Button();
            this.Them_button = new System.Windows.Forms.Button();
            this.txbTenSanBay = new System.Windows.Forms.TextBox();
            this.txbMaSanBay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Thoat_button
            // 
            this.Thoat_button.Location = new System.Drawing.Point(188, 278);
            this.Thoat_button.Name = "Thoat_button";
            this.Thoat_button.Size = new System.Drawing.Size(98, 41);
            this.Thoat_button.TabIndex = 15;
            this.Thoat_button.Text = "Thoát";
            this.Thoat_button.UseVisualStyleBackColor = true;
            this.Thoat_button.Click += new System.EventHandler(this.Thoat_button_Click);
            // 
            // Them_button
            // 
            this.Them_button.Location = new System.Drawing.Point(35, 278);
            this.Them_button.Name = "Them_button";
            this.Them_button.Size = new System.Drawing.Size(98, 41);
            this.Them_button.TabIndex = 16;
            this.Them_button.Text = "Thêm";
            this.Them_button.UseVisualStyleBackColor = true;
            this.Them_button.Click += new System.EventHandler(this.Them_button_Click);
            // 
            // txbTenSanBay
            // 
            this.txbTenSanBay.Location = new System.Drawing.Point(134, 190);
            this.txbTenSanBay.Name = "txbTenSanBay";
            this.txbTenSanBay.Size = new System.Drawing.Size(166, 22);
            this.txbTenSanBay.TabIndex = 13;
            // 
            // txbMaSanBay
            // 
            this.txbMaSanBay.Location = new System.Drawing.Point(134, 85);
            this.txbMaSanBay.Name = "txbMaSanBay";
            this.txbMaSanBay.Size = new System.Drawing.Size(166, 22);
            this.txbMaSanBay.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tên Sân Bay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mã Sân Bay";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "THÊM SÂN BAY";
            // 
            // frmThemSanBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 347);
            this.Controls.Add(this.Thoat_button);
            this.Controls.Add(this.Them_button);
            this.Controls.Add(this.txbTenSanBay);
            this.Controls.Add(this.txbMaSanBay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmThemSanBay";
            this.Text = "frmThemSanBay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Thoat_button;
        private System.Windows.Forms.Button Them_button;
        private System.Windows.Forms.TextBox txbTenSanBay;
        private System.Windows.Forms.TextBox txbMaSanBay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}