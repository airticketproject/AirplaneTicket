using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanVeMayBay
{
    public partial class frmDatVe : Form
    {
        public frmDatVe()
        {
            InitializeComponent();
        }

        private void Thoat_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ThemHanhKhach_button_Click(object sender, EventArgs e)
        {
            Form frmKhachHang = new frmQuanLyKhachHang();
            frmKhachHang.Show();
        }
    }
}
