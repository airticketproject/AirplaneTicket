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
    public partial class frmQuanLyChuyenBay : Form
    {
        private CBBUS cbBUS;
        public frmQuanLyChuyenBay()
        {
            InitializeComponent();
        }

        private void frmQuanLyChuyenBay_Load(object sender, EventArgs e)
        {
            cbBUS = new CBBUS();
            this.loadData_Vao_dtgvDsChuyenBay();
        }

        private void loadData_Vao_dtgvDsChuyenBay()
        {
            List<CBDTO> listChuyenBay = cbBUS.select();

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

        private void dtgvDsChuyenBay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXoaChuyenBay_Click(object sender, EventArgs e)
        {

        }

        private void btnCapNhatChuyenBay_Click(object sender, EventArgs e)
        {

        }
    }
}
