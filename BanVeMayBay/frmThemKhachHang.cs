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
    public partial class frmThemKhachHang : Form
    {
        private KHBUS khBUS;
        public frmThemKhachHang()
        {
            InitializeComponent();
        }
        private void frmThemKhachHang_Load(object sender, EventArgs e)
        {
            khBUS = new KHBUS();
            this.loadData_Vao_dtgvDsKhachHang();
        }
        //Kiểm tra null của textbox
        private bool checkNullData()
        {
            if (string.IsNullOrEmpty(txbMaKhachHang.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbMaKhachHang.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txbTenKhachHang.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbTenKhachHang.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txbCmndKhachHang.Text))
            {
                MessageBox.Show("Bạn chưa nhập số CMND khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbCmndKhachHang.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txbDienThoaiKhachHang.Text))
            {
                MessageBox.Show("Bạn chưa nhập điện thoại khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbDienThoaiKhachHang.Focus();
                return false;
            }
            return true;
        }

        private void loadData_Vao_dtgvDsKhachHang()
        {
            List<KHDTO> listKhachHang = khBUS.select();

            if (listKhachHang == null)
            {
                MessageBox.Show("Có lỗi khi lấy danh sách chuyến bay từ DB");
                return;
            }

            dtgvDsThemKhachHang.Columns.Clear();
            dtgvDsThemKhachHang.DataSource = null;

            dtgvDsThemKhachHang.AllowUserToAddRows = false;
            dtgvDsThemKhachHang.AllowUserToResizeColumns = false;
            dtgvDsThemKhachHang.AllowUserToResizeRows = false;
            dtgvDsThemKhachHang.DataSource = listKhachHang;

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dtgvDsThemKhachHang.DataSource];
            myCurrencyManager.Refresh();

        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            KHDTO khDTO = new KHDTO();

            //2. Kiểm tra data hợp lệ or not
            if (checkNullData())
            {
                //1. Map data from GUI
                khDTO.MaKhachHang = txbMaKhachHang.Text;
                khDTO.TenKhachHang = txbTenKhachHang.Text;
                khDTO.cmndKhachHang = txbCmndKhachHang.Text;
                khDTO.SDT = txbDienThoaiKhachHang.Text;

                //3. Thêm vào DB
                bool kq = khBUS.ThemKhachHang(khDTO);
                if (kq == false)
                    MessageBox.Show("Thêm khách hàng thất bại. Vui lòng kiểm tra lại dũ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    this.loadData_Vao_dtgvDsKhachHang();
                    MessageBox.Show("Thêm khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dtgvDsThemKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgvDsThemKhachHang.ReadOnly = true;
        }
    }
}
