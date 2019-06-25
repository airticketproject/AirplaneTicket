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
    public partial class frmBaoCaoDoanhThuThang : Form
    {
        private DTTBUS dttBUS;
        public frmBaoCaoDoanhThuThang()
        {
            InitializeComponent();
        }

        private void frmBaoCaoDoanhThuThang_Load(object sender, EventArgs e)
        {
            dttBUS = new DTTBUS();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            bool kq = dttBUS.GoiProcClear();
            if (kq == false)
                MessageBox.Show("Gọi procedure xử lí dữ liệu thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            kq = dttBUS.GoiProcAdd(int.Parse(Thang_comboBox.Text), int.Parse(Nam_comboBox.Text));
            if (kq == false)
                MessageBox.Show("Gọi procedure xử lí dữ liệu thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadData_Vao_dtgvDTT();
        }

        private void loadData_Vao_dtgvDTT()
        {
            List<DTTDTO> listDTT = dttBUS.select(int.Parse(Thang_comboBox.Text), int.Parse(Nam_comboBox.Text));

            if (listDTT == null)
            {
                MessageBox.Show("Có lỗi khi lấy danh sách sân bay từ DB");
                return;
            }

            dtgvDTT.Columns.Clear();
            dtgvDTT.DataSource = null;

            dtgvDTT.AllowUserToAddRows = false;
            dtgvDTT.AllowUserToResizeColumns = false;
            dtgvDTT.AllowUserToResizeRows = false;
            dtgvDTT.DataSource = listDTT;

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dtgvDTT.DataSource];
            myCurrencyManager.Refresh();

        }
    }
}
