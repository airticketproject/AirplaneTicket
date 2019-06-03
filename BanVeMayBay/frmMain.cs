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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Chuyến bay
        private void thêmChuyếnBayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmThemChuyenBay = new frmThemChuyenBay();
            frmThemChuyenBay.MdiParent = this;
            frmThemChuyenBay.Show();
        }

        private void danhSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmQuanLyChuyenBay = new frmQuanLyChuyenBay();
            frmQuanLyChuyenBay.MdiParent = this;
            frmQuanLyChuyenBay.Show();
        }


        //Khách hàng
        private void thêmKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmThemKhachHang = new frmThemKhachHang();
            frmThemKhachHang.MdiParent = this;
            frmThemKhachHang.Show();
        }

        private void danhSáchKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmQuanLyKhachHang = new frmQuanLyKhachHang();
            frmQuanLyKhachHang.MdiParent = this;
            frmQuanLyKhachHang.Show();
        }


        //Sân bay
        private void danhSáchSânBayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmQuanLySanBay = new frmQuanLySanBay();
            frmQuanLySanBay.MdiParent = this;
            frmQuanLySanBay.Show();
        }

        private void thêmSânBayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmThemSanBay= new frmThemSanBay();
            frmThemSanBay.MdiParent = this;
            frmThemSanBay.Show();
        }
    }
}
