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
    public partial class frmDanhSachChuyenBay : Form
    {
        public frmDanhSachChuyenBay()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Form frmLichChuyenBay = new frmThemChuyenBay();
            frmLichChuyenBay.Show();
        }

        private void TimKiem_button_Click(object sender, EventArgs e)
        {
            Form frmTimKiem = new frmTimKiem_DanhSachChuyenBay();
            frmTimKiem.Show();
        }

        private void Thoat_button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
