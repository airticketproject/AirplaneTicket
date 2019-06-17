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

        //Kiểm tra null của textbox
        private bool checkNullData()
        {
            if (string.IsNullOrEmpty(txbSuaMaKhachHang.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbSuaMaKhachHang.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txbSuaTenKhachHang.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbSuaTenKhachHang.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txbSuaCMND.Text))
            {
                MessageBox.Show("Bạn chưa nhập số CMND khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbSuaCMND.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txbSuaSDT.Text))
            {
                MessageBox.Show("Bạn chưa nhập điện thoại khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbSuaSDT.Focus();
                return false;
            }
            return true;
        }

        private void btnXoaKhachHang_Click(object sender, EventArgs e)
        {
            KHDTO khDTO = new KHDTO();

            //2. Kiểm tra data hợp lệ or not
            if (checkNullData())
            {
                //1. Map data from GUI
                khDTO.MaKhachHang = txbSuaMaKhachHang.Text;

                //3. Thêm vào DB
                bool kq = khBUS.XoaKhachHang(khDTO);
                if (kq == false)
                    MessageBox.Show("Xoá khách hàng thất bại. Vui lòng kiểm tra lại dũ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    MessageBox.Show("Xoá khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.loadData_Vao_dtgvDsKhachHang();
                }
            }
        }

        private void btnSuaKhachHang_Click(object sender, EventArgs e)
        {
            KHDTO khDTO = new KHDTO();

            //2. Kiểm tra data hợp lệ or not
            if (checkNullData())
            {
                //1. Map data from GUI
                khDTO.MaKhachHang = txbSuaMaKhachHang.Text;
                khDTO.TenKhachHang = txbSuaTenKhachHang.Text;
                khDTO.cmndKhachHang = txbSuaCMND.Text;
                khDTO.SDT = txbSuaSDT.Text;

                //3. Thêm vào DB
                bool kq = khBUS.SuaKhachHang(khDTO);
                if (kq == false)
                    MessageBox.Show("Cập nhật khách hàng thất bại. Vui lòng kiểm tra lại dũ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    MessageBox.Show("Cập nhật khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.loadData_Vao_dtgvDsKhachHang();
                }
            }
        }

        private void dtgvDsKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Row = e.RowIndex;
            if (Row != -1)
            {
                txbSuaMaKhachHang.Text = dtgvDsKhachHang.Rows[Row].Cells["MaKhachHang"].Value.ToString();
                txbSuaTenKhachHang.Text = dtgvDsKhachHang.Rows[Row].Cells["TenKhachHang"].Value.ToString();
                txbSuaCMND.Text = dtgvDsKhachHang.Rows[Row].Cells["cmndKhachHang"].Value.ToString();
                txbSuaSDT.Text = dtgvDsKhachHang.Rows[Row].Cells["SDT"].Value.ToString();
            }
            else
                return;
        }
    }
}
