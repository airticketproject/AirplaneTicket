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

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đây là kết quả của đồ án môn học Nhập môn Công nghệ phần mềm. Phần mềm được thiết kế và thực hiện trên nền tảng C# và SQL Server.\n Thành viên thực hiện:\n1. Võ Phi Nhật Duy 17520407\n2. Phan Huỳnh Minh Duy 17520405","Thông tin phần mềm", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnQuanLyChuyenBay_Click(object sender, EventArgs e)
        {
            Form frmDanhSachChuyenBay = new frmDanhSachChuyenBay();
            frmDanhSachChuyenBay.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSanBay_Click(object sender, EventArgs e)
        {
            Form frmSanBay = new frmSanBay();
            frmSanBay.Show();
        }

        private void btnBanVe_Click(object sender, EventArgs e)
        {
            Form frmBanVe = new frmBanVe();
            frmBanVe.Show();
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            Form frmDatVe = new frmDatVe();
            frmDatVe.Show();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            Form frmKhachHang = new frmKhachHang();
            frmKhachHang.Show();
        }

        private void btnBaoCaoNam_Click(object sender, EventArgs e)
        {
            Form frmBaoCaoNam = new frmBaoCaoDoanhThuNam();
            frmBaoCaoNam.Show();
        }

        private void btnBaoCaoThang_Click(object sender, EventArgs e)
        {
            Form frmBaoCaoThang = new frmBaoCaoDoanhThuThang();
            frmBaoCaoThang.Show();
        }

        private void btnThemChuyenBay_Click(object sender, EventArgs e)
        {
            Form frmLichChuyenBay = new frmLichChuyenBay();
            frmLichChuyenBay.Show();
        }
    }
}
