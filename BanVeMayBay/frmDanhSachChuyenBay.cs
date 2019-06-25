using System;
using QLVMBBUS;
using QLVMBDAL;
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
    public partial class frmDanhSachChuyenBay : Form
    {
        private CBBUS cbBUS;
        private DSBUS dsBUS;

        public frmDanhSachChuyenBay()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            frmTimKiem_DanhSachChuyenBay frmTimKiem = new frmTimKiem_DanhSachChuyenBay();
            frmTimKiem.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDanhSachChuyenBay_Load(object sender, EventArgs e)
        {
            cbBUS = new CBBUS();
            dsBUS = new DSBUS();
            loadData_Vao_dtgvDsChuyenBay();
        }

        private void loadData_Vao_dtgvDsChuyenBay()
        {
            List<DSDTO> listChuyenBay = dsBUS.select();

            if (listChuyenBay == null)
            {
                MessageBox.Show("Có lỗi khi lấy danh sách chuyến bay từ DB");
                return;
            }

            dtgvDsChuyenBay.Columns.Clear();
            dtgvDsChuyenBay.DataSource = null;

            dtgvDsChuyenBay.AllowUserToAddRows = false;
            dtgvDsChuyenBay.AllowUserToResizeColumns = false;
            dtgvDsChuyenBay.AllowUserToResizeRows = false;
            dtgvDsChuyenBay.DataSource = listChuyenBay;

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dtgvDsChuyenBay.DataSource];
            myCurrencyManager.Refresh();

        }
    }
}
