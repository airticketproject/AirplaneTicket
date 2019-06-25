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
        private Form frmUser;
        public frmMain()
        {
            InitializeComponent();
        }

        //Chuyến bay
        private void thêmChuyếnBayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.ActiveMdiChild == null || frmUser.IsDisposed || frmUser == null)
            {
                frmUser = new frmThemChuyenBay ();
                frmUser.MdiParent = this;
                frmUser.Dock = DockStyle.Fill;
                frmUser.Show();
            }
            else
            {
                MessageBox.Show("Chức năng đã được hiển thị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void danhSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null || frmUser.IsDisposed || frmUser == null)
            {
                frmUser = new frmDanhSachChuyenBay();
                frmUser.MdiParent = this;
                frmUser.Dock = DockStyle.Fill;
                frmUser.Show();
            }
            else
            {
                MessageBox.Show("Chức năng đã được hiển thị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        //Khách hàng
        private void thêmKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null || frmUser.IsDisposed || frmUser == null)
            {
                frmUser = new frmThemKhachHang();
                frmUser.MdiParent = this;
                frmUser.Dock = DockStyle.Fill;
                frmUser.Show();
            }
            else
            {
                MessageBox.Show("Chức năng đã được hiển thị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void danhSáchKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null || frmUser.IsDisposed || frmUser == null)
            {
                frmUser = new frmQuanLyKhachHang();
                frmUser.MdiParent = this;
                frmUser.Dock = DockStyle.Fill;
                frmUser.Show();
            }
            else
            {
                MessageBox.Show("Chức năng đã được hiển thị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Sân bay
        private void danhSáchSânBayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null || frmUser.IsDisposed || frmUser == null)
            {
                frmUser = new frmQuanLySanBay();
                frmUser.MdiParent = this;
                frmUser.Dock = DockStyle.Fill;
                frmUser.Show();
            }
            else
            {
                MessageBox.Show("Chức năng đã được hiển thị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void thêmSânBayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null || frmUser.IsDisposed || frmUser == null)
            {
                frmUser = new frmThemSanBay();
                frmUser.MdiParent = this;
                frmUser.Dock = DockStyle.Fill;
                frmUser.Show();
            }
            else
            {
                MessageBox.Show("Chức năng đã được hiển thị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void đặtVéToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null || frmUser.IsDisposed || frmUser == null)
            {
                frmUser = new frmDatVe();
                frmUser.MdiParent = this;
                frmUser.Dock = DockStyle.Fill;
                frmUser.Show();
            }
            else
            {
                MessageBox.Show("Chức năng đã được hiển thị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bánVéToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null || frmUser.IsDisposed || frmUser == null)
            {
                frmUser = new frmBanVe();
                frmUser.MdiParent = this;
                frmUser.Dock = DockStyle.Fill;
                frmUser.Show();
            }
            else
            {
                MessageBox.Show("Chức năng đã được hiển thị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void hạngVéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null || frmUser.IsDisposed || frmUser == null)
            {
                frmUser = new frmThemHangVe();
                frmUser.MdiParent = this;
                frmUser.Dock = DockStyle.Fill;
                frmUser.Show();
            }
            else
            {
                MessageBox.Show("Chức năng đã được hiển thị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void đóngỨngDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void thayĐổiThamSốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null || frmUser.IsDisposed || frmUser == null)
            {
                frmUser = new frmQuanLyThamSo();
                frmUser.MdiParent = this;
                frmUser.Dock = DockStyle.Fill;
                frmUser.Show();
            }
            else
            {
                MessageBox.Show("Chức năng đã được hiển thị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void thôngTinToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Đây là kết quả đồ án nhóm môn Nhập môn công nghệ phần mềm.\nĐược thiết kế và thực hiện trên nền tảng C# và SQL Server.\nThành viên thực hiện:\n1. Võ Phi Nhật Duy - 17520407\n2. Phan Huỳnh Minh Duy - 17520405", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void báoCáoThángToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null || frmUser.IsDisposed || frmUser == null)
            {
                frmUser = new frmBaoCaoDoanhThuThang();
                frmUser.MdiParent = this;
                frmUser.Dock = DockStyle.Fill;
                frmUser.Show();
            }
            else
            {
                MessageBox.Show("Chức năng đã được hiển thị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void báoCáoNămToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null || frmUser.IsDisposed || frmUser == null)
            {
                frmUser = new frmBaoCaoDoanhThuNam();
                frmUser.MdiParent = this;
                frmUser.Dock = DockStyle.Fill;
                frmUser.Show();
            }
            else
            {
                MessageBox.Show("Chức năng đã được hiển thị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void thêmHạngVéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null || frmUser.IsDisposed || frmUser == null)
            {
                frmUser = new frmThemHangVe();
                frmUser.MdiParent = this;
                frmUser.Dock = DockStyle.Fill;
                frmUser.Show();
            }
            else
            {
                MessageBox.Show("Chức năng đã được hiển thị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void danhSáchHạngVéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null || frmUser.IsDisposed || frmUser == null)
            {
                frmUser = new frmQuanLyHangVe();
                frmUser.MdiParent = this;
                frmUser.Dock = DockStyle.Fill;
                frmUser.Show();
            }
            else
            {
                MessageBox.Show("Chức năng đã được hiển thị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void thêmSânBayTrungGianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null || frmUser.IsDisposed || frmUser == null)
            {
                frmUser = new frmThemSanBayTrungGian();
                frmUser.MdiParent = this;
                frmUser.Dock = DockStyle.Fill;
                frmUser.Show();
            }
            else
            {
                MessageBox.Show("Chức năng đã được hiển thị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void thôngTinSânBayTrungGianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null || frmUser.IsDisposed || frmUser == null)
            {
                frmUser = new frmQuanLySanBayTrungGian();
                frmUser.MdiParent = this;
                frmUser.Dock = DockStyle.Fill;
                frmUser.Show();
            }
            else
            {
                MessageBox.Show("Chức năng đã được hiển thị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cậpNhậtXóaChuyếnBayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null || frmUser.IsDisposed || frmUser == null)
            {
                frmUser = new frmQuanLyChuyenBay();
                frmUser.MdiParent = this;
                frmUser.Dock = DockStyle.Fill;
                frmUser.Show();
            }
            else
            {
                MessageBox.Show("Chức năng đã được hiển thị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
