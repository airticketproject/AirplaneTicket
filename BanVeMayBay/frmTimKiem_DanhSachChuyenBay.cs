using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLVMBBUS;
using QLVMBDTO;

namespace BanVeMayBay
{
    public partial class frmTimKiem_DanhSachChuyenBay : Form
    {
        private SBBUS sbBUS;
        private CBBUS cbBUS;

        public frmTimKiem_DanhSachChuyenBay()
        {
            InitializeComponent();
        }

        private void loadSanBayVao_Combobox(ComboBox comboBox)
        {
            List<SBDTO> listSanBay = sbBUS.select();

            if (listSanBay == null)
            {
                MessageBox.Show("Có lỗi khi lấy Sân bay từ cơ sở dữ liệu");
                return;
            }
            comboBox.DataSource = new BindingSource(listSanBay, String.Empty);
            comboBox.DisplayMember = "TenSanBay";
            comboBox.ValueMember = "MaSanBay";

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[comboBox.DataSource];
            myCurrencyManager.Refresh();

            if (comboBox.Items.Count > 0)
            {
                comboBox.SelectedIndex = 0;
            }
        }

        private void frmTimKiem_DanhSachChuyenBay_Load(object sender, EventArgs e)
        {
            sbBUS = new SBBUS();
            cbBUS = new CBBUS();
            loadSanBayVao_Combobox(cbbSanBayDi);
            loadSanBayVao_Combobox(cbbSanBayDen);
        }

        private void loadData_Vao_dtgvDsChuyenBay(List<CBDTO> listChuyenBay)
        {
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

        private void TimKiem_button_Click(object sender, EventArgs e)
        {
            List<CBDTO> listChuyenBay = cbBUS.search(cbbSanBayDen.SelectedValue.ToString(), cbbSanBayDi.SelectedValue.ToString());
            loadData_Vao_dtgvDsChuyenBay(listChuyenBay);
        }

        private void Thoat_button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}