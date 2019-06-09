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
    public partial class frmQuanLyKhachHang : Form
    {
        private KHBUS khBUS;

        public frmQuanLyKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHanh_Load(object sender, EventArgs e)
        {
            khBUS = new KHBUS();
            this.loadData_Vao_dtgvDsKhachHang();
        }

        private void loadData_Vao_dtgvDsKhachHang()
        {
            List<KHDTO> listKhachHang = khBUS.select();

            if (listKhachHang == null)
            {
                MessageBox.Show("Có lỗi khi lấy danh sách khách hàng từ DB");
                return;
            }

            dtgvDsKhachHang.Columns.Clear();
            dtgvDsKhachHang.DataSource = null;

            dtgvDsKhachHang.AllowUserToAddRows = false;
            dtgvDsKhachHang.AllowUserToResizeColumns = false;
            dtgvDsKhachHang.AllowUserToResizeRows = false;
            dtgvDsKhachHang.DataSource = listKhachHang;

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dtgvDsKhachHang.DataSource];
            myCurrencyManager.Refresh();

        }


        private void btnXoaKhachHang_Click(object sender, EventArgs e)
        {

        }

        private void btnSuaKhachHang_Click(object sender, EventArgs e)
        {
        }
    }
}
