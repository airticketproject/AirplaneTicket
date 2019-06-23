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

        //Kiểm tra null của textbox
        private bool checkNullData()
        {
            if (
                string.IsNullOrEmpty(txbSuaMaSanBay.Text) ||
                string.IsNullOrEmpty(txbSuaTenSanBay.Text)
                )
            {
                return false;
            }
            return true;
        }

        //Load dữ liệu sân bay vào danh sách
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


        private void dtgvSanBay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Row = e.RowIndex;
            if (Row != -1)
            {
                txbSuaMaSanBay.Text = dtgvSanBay.Rows[Row].Cells["MaSanBay"].Value.ToString();
                txbSuaTenSanBay.Text = dtgvSanBay.Rows[Row].Cells["TenSanBay"].Value.ToString();
            }
            else
                return;
        }

        //Xoá sân bay
        private void Xoa_button_Click(object sender, EventArgs e)
        {
            SBDTO sbDTO = new SBDTO();

            sbDTO.MaSanBay = txbSuaMaSanBay.Text;

            //Them vao DTB
            bool kq = sbBUS.XoaSanBay(sbDTO);
            if (kq == false)
                MessageBox.Show("Xoá Sân bay thất bại. Vui lòng kiểm tra lại dũ liệu");
            else
            {
                MessageBox.Show("Xoá Sân bay thành công");
                this.loadData_Vao_dtgvDsThemSanBay();
            }
        }

        //Sửa sân bay
        private void Sua_button_Click(object sender, EventArgs e)
        {
            SBDTO sbDTO = new SBDTO();

            //2. Kiểm tra data hợp lệ or not
            if (checkNullData())
            {
                sbDTO.MaSanBay = txbSuaMaSanBay.Text;
                sbDTO.TenSanBay = txbSuaTenSanBay.Text;

                //Them vao DTB
                bool kq = sbBUS.SuaSanBay(sbDTO);
                if (kq == false)
                    MessageBox.Show("Cập nhật Sân bay thất bại. Vui lòng kiểm tra lại dũ liệu");
                else
                {
                    MessageBox.Show("Cập nhật Sân bay thành công");
                    this.loadData_Vao_dtgvDsThemSanBay();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sân bay cần chỉnh sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
