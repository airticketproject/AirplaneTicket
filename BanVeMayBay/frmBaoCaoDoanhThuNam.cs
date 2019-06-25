using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLVMBDTO;
using QLVMBBUS;
using System.Data.SqlClient;
using System.Configuration;

namespace BanVeMayBay
{
    public partial class frmBaoCaoDoanhThuNam : Form
    {
        private DTTBUS dttBUS;
        private DTNBUS dtnBUS;
        public frmBaoCaoDoanhThuNam()
        {
            InitializeComponent();
        }

        private void frmBaoCaoDoanhThuNam_Load(object sender, EventArgs e)
        {
            dttBUS = new DTTBUS();
            dtnBUS = new DTNBUS();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void loadData_Vao_dtgvDTN()
        {
            List<DTNDTO> listDTN = dtnBUS.select(int.Parse(Nam_comboBox.Text));

            if (listDTN == null)
            {
                MessageBox.Show("Có lỗi khi lấy danh sách sân bay từ DB");
                return;
            }

            dtgvDTN.Columns.Clear();
            dtgvDTN.DataSource = null;

            dtgvDTN.AllowUserToAddRows = false;
            dtgvDTN.AllowUserToResizeColumns = false;
            dtgvDTN.AllowUserToResizeRows = false;
            dtgvDTN.DataSource = listDTN;

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dtgvDTN.DataSource];
            myCurrencyManager.Refresh();

        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            bool kq = dttBUS.GoiProcClear();
            if (kq == false)
            {
                MessageBox.Show("Gọi procedure xử lí dữ liệu thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            for (int i = 1; i <= 12; i++)
            {
                kq = dttBUS.GoiProcAdd(i, int.Parse(Nam_comboBox.Text));
                if (kq == false)
                {
                    MessageBox.Show("Gọi procedure xử lí dữ liệu thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            dtnBUS.GoiProcAdd(int.Parse(Nam_comboBox.Text));
            loadData_Vao_dtgvDTN();
        }

    }
}
