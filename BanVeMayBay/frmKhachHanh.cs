using System;
using QLVMBBUS;
using QLVMBDTO;
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
    public partial class frmKhachHanh : Form
    {
        private KHBUS khBUS;

        public frmKhachHanh()
        {
            InitializeComponent();
        }

        private void frmKhachHanh_Load(object sender, EventArgs e)
        {
            khBUS = new KHBUS();
        }

        private void ThemKhachHang_Click(object sender, EventArgs e)
        {

        }

        private void btnXoaKhachHang_Click(object sender, EventArgs e)
        {

        }

        private void btnSuaKhachHang_Click(object sender, EventArgs e)
        {

        }
    }
}
