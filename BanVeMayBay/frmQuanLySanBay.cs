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
    public partial class frmQuanLySanBay : Form
    {
        private SBBUS sbBUS;

        public frmQuanLySanBay()
        {
            InitializeComponent();
        }

        private void frmQuanLySanBay_Load(object sender, EventArgs e)
        {
            sbBUS = new SBBUS();
            this.loadData_Vao_dtgvDsThemSanBay();
        }

        private void loadData_Vao_dtgvDsThemSanBay()
        {
            List<SBDTO> listSanBay = sbBUS.select();

            if (listSanBay == null)
            {
                MessageBox.Show("Có lỗi khi lấy danh sách sân bay từ DB");
                return;
            }

            dtgvSanBay.Columns.Clear();
            dtgvSanBay.DataSource = null;

            dtgvSanBay.AllowUserToAddRows = false;
            dtgvSanBay.AllowUserToResizeColumns = false;
            dtgvSanBay.AllowUserToResizeRows = false;
            dtgvSanBay.DataSource = listSanBay;

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dtgvSanBay.DataSource];
            myCurrencyManager.Refresh();

        }

        private void Sua_button_Click(object sender, EventArgs e)
        {

        }

     
    }
}
