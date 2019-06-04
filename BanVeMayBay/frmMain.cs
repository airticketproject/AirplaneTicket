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

        private void đặtVéToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frmDatVe = new frmDatVe();
            frmDatVe.MdiParent = this;
            frmDatVe.Show();
        }

        private void bánVéToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frmBanVe = new frmBanVe();
            frmBanVe.MdiParent = this;
            frmBanVe.Show();
        }

        private void doanhThuThángToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmBaoCaoDoanhThuThang = new frmBaoCaoDoanhThuThang();
            frmBaoCaoDoanhThuThang.MdiParent = this;
            frmBaoCaoDoanhThuThang.Show();
        }

        private void doanhThuNămToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmBaoCaoDoanhThuNam = new frmBaoCaoDoanhThuNam();
            frmBaoCaoDoanhThuNam.MdiParent = this;
            frmBaoCaoDoanhThuNam.Show();
        }

        private void đóngỨngDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đây là kết quả đồ án nhóm môn Nhập môn công nghệ phần mềm.\nĐược thiết kế và thực hiện trên nền tảng C# và SQL Server.\nThành viên thực hiện:\n1. Võ Phi Nhật Duy - 17520407\n2. Phan Huỳnh Minh Duy - 17520405", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
