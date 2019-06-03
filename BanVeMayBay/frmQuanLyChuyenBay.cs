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
            loadData_Vao_dtgvDsChuyenBay();
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

            dtgvDsChuyenBay.AutoGenerateColumns = false;
            dtgvDsChuyenBay.AllowUserToAddRows = false;
            dtgvDsChuyenBay.DataSource = listChuyenBay;

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dtgvDsChuyenBay.DataSource];
            myCurrencyManager.Refresh();

        }

        private void dtgvDsChuyenBay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // ' Get the current cell location.
            int currentRowIndex = dtgvDsChuyenBay.CurrentCellAddress.Y;// 'current row selected

            if(-1 < currentRowIndex && currentRowIndex < dtgvDsChuyenBay.RowCount)
            {
                CBDTO cbDTO = (CBDTO)dtgvDsChuyenBay.Rows[currentRowIndex].DataBoundItem;
                if(cbDTO != null)
                {
                    bool kq = cbBUS.XoaChuyenBay(cbDTO);
                    if (kq == false)
                        MessageBox.Show("Xóa chuyến bay thất bại. Vui lòng kiểm tra lại dũ liệu");
                    else
                    {
                        MessageBox.Show("Xóa chuyến bay thành công");
                        this.loadData_Vao_dtgvDsChuyenBay();
                    }
                }
            }
        }

        private void btnXoaChuyenBay_Click(object sender, EventArgs e)
        {

        }

        private void btnCapNhatChuyenBay_Click(object sender, EventArgs e)
        {

        }
    }
}
