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

        //Clear input
        private void ClearInput ()
        {
            txbCmndKhachHang.Clear();
            txbDienThoaiKhachHang.Clear();
            txbMaKhachHang.Clear();
            txbTenKhachHang.Clear();
        }

        //Kiểm tra độ dài của textbox
        private bool inputTextLengthCheck(TextBox textBox, KeyPressEventArgs e)
        {
            if (textBox.Text.Length > 30)
            {
                MessageBox.Show("Bạn nhập quá số kí tự cho phép", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                textBox.Clear();
                e.Handled = true;
                return false;
            }
            return true;

        }

        //Kiểm tra dấu và kí tự đặc biệt
        private void inputTextNonCharacter(TextBox textBox, KeyPressEventArgs e)
        {

            if (char.IsWhiteSpace(e.KeyChar) || //Khoảng cách
                char.IsPunctuation(e.KeyChar))//Dấu chấm 
            {
                e.Handled = true; //Không cho thể hiện lên TextBox
                MessageBox.Show("Vui lòng không nhập kí tự đặc biệt !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            if (char.IsControl(e.KeyChar) && //Cho phép chữ và só
                !char.IsDigit(e.KeyChar) && !(e.KeyChar == 8)) //có dấu sẽ loại bỏ
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng không viết dấu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                textBox.Clear();//Clear
                textBox.Focus();//Focus vào textBox
            }

        }

        //Kiểm tra số
        private void InputTextOnlyNumber(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || //Ký tự Alphabe
                char.IsSymbol(e.KeyChar) || //Ký tự đặc biệt
                char.IsWhiteSpace(e.KeyChar) || //Khoảng cách
                char.IsPunctuation(e.KeyChar)) //Dấu chấm              
            {
                e.Handled = true; //Không cho thể hiện lên TextBox
                MessageBox.Show("Vui lòng nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
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
            dtgvDsThemKhachHang.Columns["Error"].Visible = false;

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
                    MessageBox.Show("Thêm khách hàng thất bại. Vui lòng kiểm tra lại dũ liệu! \n" + khDTO.Error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    this.loadData_Vao_dtgvDsKhachHang();
                    this.ClearInput();
                    MessageBox.Show("Thêm khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }


        private void txbCmndKhachHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (inputTextLengthCheck(txbCmndKhachHang, e))
            {
                InputTextOnlyNumber(e);
            }
        }

        private void txbDienThoaiKhachHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (inputTextLengthCheck(txbCmndKhachHang, e))
            {
                InputTextOnlyNumber(e);
            }
        }
    }
}
