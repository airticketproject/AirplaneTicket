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
    public partial class frmThemSanBay : Form
    {
        private SBBUS sbBUS;
        public frmThemSanBay()
        {
            InitializeComponent();
        }

        private void frmThemSanBay_Load(object sender, EventArgs e)
        {
            sbBUS = new SBBUS();
            this.loadData_Vao_dtgvDsThemSanBay();
        }

        //Kiểm tra null của textbox
        private bool checkNullData()
        {
            if (string.IsNullOrEmpty(txbMaSanBay.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã sân bay!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbMaSanBay.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txbTenSanBay.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên sân bay!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbTenSanBay.Focus();
                return false;
            }
            return true;
        }

        private void loadData_Vao_dtgvDsThemSanBay()
        {
            List<SBDTO> listSanBay = sbBUS.select();

            if (listSanBay == null)
            {
                MessageBox.Show("Có lỗi khi lấy danh sách sân bay từ DB");
                return;
            }

            dtgvDsThemSanBay.Columns.Clear();
            dtgvDsThemSanBay.DataSource = null;

            dtgvDsThemSanBay.AllowUserToAddRows = false;
            dtgvDsThemSanBay.AllowUserToResizeColumns = false;
            dtgvDsThemSanBay.AllowUserToResizeRows = false;
            dtgvDsThemSanBay.DataSource = listSanBay;

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dtgvDsThemSanBay.DataSource];
            myCurrencyManager.Refresh();

        }

        private void Them_button_Click(object sender, EventArgs e)
        {
            SBDTO sbDTO = new SBDTO();

            //2. Kiểm tra data hợp lệ or not
            if (checkNullData())
            {
                sbDTO.MaSanBay = txbMaSanBay.Text;
                sbDTO.TenSanBay = txbTenSanBay.Text;

                //Them vao DTB
                bool kq = sbBUS.ThemSanBay(sbDTO);
                if (kq == false)
                    MessageBox.Show("Thêm sân bay thất bại. Vui lòng kiểm tra lại dũ liệu");
                else
                {
                    MessageBox.Show("Thêm sân bay thành công");
                    this.loadData_Vao_dtgvDsThemSanBay();
                }
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
