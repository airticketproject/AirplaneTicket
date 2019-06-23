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
    public partial class frmQuanLyHangVe : Form
    {
        private HVBUS hvBUS;

        public frmQuanLyHangVe()
        {
            InitializeComponent();
        }
        private void frmQuanLyHangVe_Load(object sender, EventArgs e)
        {
            hvBUS = new HVBUS();
            this.loadData_Vao_dtgvDsHangVe();
        }

        //Kiểm tra null
        private bool checkNullData()
        {
            if (
                string.IsNullOrEmpty(txbMaHangVe.Text) ||
                string.IsNullOrEmpty(txbTenHangVe.Text) ||
                string.IsNullOrEmpty(txbTiLeDonGia.Text)
                )
            {
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
        private void inputTextOnlyNumber(KeyPressEventArgs e)
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

        private void clearInputText()
        {
            txbTenHangVe.Clear();
            txbMaHangVe.Clear();
            txbTiLeDonGia.Clear();
        }

        private void btnXoaHangVe_Click(object sender, EventArgs e)
        {
            HVDTO hvDTO = new HVDTO();

            if (checkNullData())
            {
                hvDTO.MaHangVe = txbMaHangVe.Text;
                //3. Thêm vào DBn
                bool kq = hvBUS.XoaHangVe(hvDTO);
                if (kq == false)
                    MessageBox.Show("Xoá Hạng vé thất bại. Vui lòng kiểm tra lại dũ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    MessageBox.Show("Xoá Hạng vé thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.loadData_Vao_dtgvDsHangVe();
                    this.clearInputText();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thông tin cần xoá", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnSuaHangVe_Click(object sender, EventArgs e)
        {
            HVDTO hvDTO = new HVDTO();

            if (checkNullData())
            {
                hvDTO.MaHangVe = txbMaHangVe.Text;
                hvDTO.TenHangVe = txbTenHangVe.Text;
                hvDTO.TiLeDonGia = float.Parse(txbTiLeDonGia.Text);
                //3. Thêm vào DBn
                bool kq = hvBUS.SuaHangVe(hvDTO);
                if (kq == false)
                    MessageBox.Show("Cập nhật Hạng vé thất bại. Vui lòng kiểm tra lại dũ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    MessageBox.Show("Cập nhật Hạng vé thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.loadData_Vao_dtgvDsHangVe();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thông tin cần chỉnh sửa", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
         
        }

        private void txbTenHangVe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (inputTextLengthCheck(txbTenHangVe, e))
            {
                inputTextNonCharacter(txbTenHangVe, e);
            }
        }

        private void txbTiLeDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (inputTextLengthCheck(txbTiLeDonGia, e))
            {
                inputTextOnlyNumber(e);
            }
        }

        private void dtgvDsHangVe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Row = e.RowIndex;
            if (Row != -1)
            {
                txbMaHangVe.Text = dtgvDsHangVe.Rows[Row].Cells["MaHangVe"].Value.ToString();
                txbTenHangVe.Text = dtgvDsHangVe.Rows[Row].Cells["TenHangVe"].Value.ToString();
                txbTiLeDonGia.Text = dtgvDsHangVe.Rows[Row].Cells["TiLeDonGia"].Value.ToString();
            }
            else
                return;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
