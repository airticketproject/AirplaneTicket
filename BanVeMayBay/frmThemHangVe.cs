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
    public partial class frmThemHangVe : Form
    {
        private HVBUS hvBUS;
        public frmThemHangVe()
        {
            InitializeComponent();
        }

        private void frmThemHangVe_Load(object sender, EventArgs e)
        {
            hvBUS = new HVBUS();
            this.loadData_Vao_dtgvDsHangVe();
        }

   

        //Kiểm tra null
        private bool checkNullData()
        {
            if (string.IsNullOrEmpty(txbMaHangVe.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã hạng vé!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbMaHangVe.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txbTenHangVe.Text))
            {
                MessageBox.Show("Bạn chưa tên hạng vé!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbTenHangVe.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txbTiLe.Text))
            {
                MessageBox.Show("Bạn chưa nhập tỉ lệ đơn giá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbTiLe.Focus();
                return false;
            }
           
            return true;
        }

        //Kiểm tra dấu và kí tự đặc biệt
        private void inputTextNonCharacter(TextBox textBox, KeyPressEventArgs e)
        {

            if (char.IsPunctuation(e.KeyChar))//Dấu chấm 
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
            if (
                char.IsLetter(e.KeyChar) || //Ký tự Alphabe
                char.IsSymbol(e.KeyChar) || //Ký tự đặc biệt
                char.IsWhiteSpace(e.KeyChar) //Khoảng cách
               )
            {
                e.Handled = true; //Không cho thể hiện lên TextBox
                MessageBox.Show("Vui lòng nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
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


        //Load dữ liệu chuyến bay vào danh sách
        private void loadData_Vao_dtgvDsHangVe()
        {
            List<HVDTO> listChuyenBay = hvBUS.select();

            if (listChuyenBay == null)
            {
                MessageBox.Show("Có lỗi khi lấy danh sách chuyến bay từ DB");
                return;
            }

            dtgvDsHangVe.Columns.Clear();
            dtgvDsHangVe.DataSource = null;

            dtgvDsHangVe.AllowUserToAddRows = false;
            dtgvDsHangVe.AllowUserToResizeColumns = false;
            dtgvDsHangVe.AllowUserToResizeRows = false;
            dtgvDsHangVe.DataSource = listChuyenBay;

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dtgvDsHangVe.DataSource];
            myCurrencyManager.Refresh();

        }



        private void btnThem_Click(object sender, EventArgs e)
        {
            HVDTO hvDTO = new HVDTO();

            if (checkNullData())
            {
                hvDTO.MaHangVe = txbMaHangVe.Text;
                hvDTO.TenHangVe = txbTenHangVe.Text;
                hvDTO.TiLeDonGia = float.Parse(txbTiLe.Text);
            }
    
            //3. Thêm vào DBn
            bool kq = hvBUS.ThemHangVe(hvDTO);
            if (kq == false)
                MessageBox.Show("Thêm Hạng vé thất bại. Vui lòng kiểm tra lại dũ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBox.Show("Thêm Hạng vé thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.loadData_Vao_dtgvDsHangVe();
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

        private void txbMaHangVe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (inputTextLengthCheck(txbMaHangVe, e))
            {
                inputTextNonCharacter(txbMaHangVe, e);
            }
        }

        private void txbTenHangVe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (inputTextLengthCheck(txbTenHangVe, e))
            {
                inputTextNonCharacter(txbTenHangVe, e);
            }
        }

        private void txbTiLe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (inputTextLengthCheck(txbTiLe, e))
            {
                InputTextOnlyNumber(e);
            }
        }

    }
}
