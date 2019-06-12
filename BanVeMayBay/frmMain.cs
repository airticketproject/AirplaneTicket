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

<<<<<<< HEAD
=======
        private void đặtVéToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frmDatVe = new frmDatVe();
            frmDatVe.MdiParent = this;
            frmDatVe.Show();
        }

>>>>>>> 6e7082b66938581a6b07bb0e83e07cf9520f54c1
        private void bánVéToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frmBanVe = new frmBanVe();
            frmBanVe.MdiParent = this;
<<<<<<< HEAD
            frmBanVe.Dock = DockStyle.Fill;
            frmBanVe.Show();
        }

        private void đặtVéToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frmDatVe = new frmDatVe();
            frmDatVe.MdiParent = this;
            frmDatVe.Dock = DockStyle.Fill;
            frmDatVe.Show();
=======
            frmBanVe.Show();
        }

        private void hạngVéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmHangVe = new frmHangVe();
            frmHangVe.MdiParent = this;
            frmHangVe.Show();
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
>>>>>>> 6e7082b66938581a6b07bb0e83e07cf9520f54c1
        }

        private void thayĐổiThamSốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmThamSo = new frmThamSo();
            frmThamSo.MdiParent = this;
            frmThamSo.Show();
        }
    }
}
