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

        //Chuyến bay
        private void thêmChuyếnBayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmThemChuyenBay = new frmThemChuyenBay();
            frmThemChuyenBay.MdiParent = this;
            frmThemChuyenBay.Dock = DockStyle.Fill;
            frmThemChuyenBay.Show();
        }

        private void danhSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmQuanLyChuyenBay = new frmQuanLyChuyenBay();
            frmQuanLyChuyenBay.MdiParent = this;
            frmQuanLyChuyenBay.Dock = DockStyle.Fill;
            frmQuanLyChuyenBay.Show();
        }


        //Khách hàng
        private void thêmKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmThemKhachHang = new frmThemKhachHang();
            frmThemKhachHang.MdiParent = this;
            frmThemKhachHang.Dock = DockStyle.Fill;
            frmThemKhachHang.Show();
        }

        private void danhSáchKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmQuanLyKhachHang = new frmQuanLyKhachHang();
            frmQuanLyKhachHang.MdiParent = this;
            frmQuanLyKhachHang.Dock = DockStyle.Fill;
            frmQuanLyKhachHang.Show();
        }


        //Sân bay
        private void danhSáchSânBayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmQuanLySanBay = new frmQuanLySanBay();
            frmQuanLySanBay.MdiParent = this;
            frmQuanLySanBay.Dock = DockStyle.Fill;
            frmQuanLySanBay.Show();
        }

        private void thêmSânBayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmThemSanBay= new frmThemSanBay();
            frmThemSanBay.MdiParent = this;
            frmThemSanBay.Dock = DockStyle.Fill;
            frmThemSanBay.Show();
        }

        private void đặtVéToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frmDatVe = new frmDatVe();
            frmDatVe.MdiParent = this;
            frmDatVe.Dock = DockStyle.Left;
            frmDatVe.Show();
        }

        private void bánVéToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frmBanVe = new frmBanVe();
            frmBanVe.MdiParent = this;
            frmBanVe.Dock = DockStyle.Left;
            frmBanVe.Show();
        }


        private void hạngVéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmHangVe = new frmThemHangVe();
            frmHangVe.MdiParent = this;
            frmHangVe.Show();
        }

        private void đóngỨngDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void thayĐổiThamSốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmThamSo = new frmThamSo();
            frmThamSo.MdiParent = this;
            frmThamSo.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void thôngTinToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Đây là kết quả đồ án nhóm môn Nhập môn công nghệ phần mềm.\nĐược thiết kế và thực hiện trên nền tảng C# và SQL Server.\nThành viên thực hiện:\n1. Võ Phi Nhật Duy - 17520407\n2. Phan Huỳnh Minh Duy - 17520405", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void báoCáoThángToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmBaoCaoDoanhThuThang = new frmBaoCaoDoanhThuThang();
            frmBaoCaoDoanhThuThang.MdiParent = this;
            frmBaoCaoDoanhThuThang.Show();
        }

        private void báoCáoNămToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmBaoCaoDoanhThuNam = new frmBaoCaoDoanhThuNam();
            frmBaoCaoDoanhThuNam.MdiParent = this;
            frmBaoCaoDoanhThuNam.Show();
        }

        private void thêmHạngVéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmThemHangVe = new frmThemHangVe();
            frmThemHangVe.MdiParent = this;
            frmThemHangVe.Dock = DockStyle.Fill;
            frmThemHangVe.Show();
        }

        private void danhSáchHạngVéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmQuanLyHangVe = new frmQuanLyHangVe();
            frmQuanLyHangVe.MdiParent = this;
            frmQuanLyHangVe.Dock = DockStyle.Fill;
            frmQuanLyHangVe.Show();
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmTimKiem_DanhSachChuyenBay = new frmTimKiem_DanhSachChuyenBay();
            frmTimKiem_DanhSachChuyenBay.MdiParent = this;
            frmTimKiem_DanhSachChuyenBay.Dock = DockStyle.Fill;
            frmTimKiem_DanhSachChuyenBay.Show();
        }
    }
}
