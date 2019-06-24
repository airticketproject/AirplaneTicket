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
    public partial class frmQuanLySanBayTrungGian : Form
    {
        private CTBUS ctBUS;

        public frmQuanLySanBayTrungGian()
        {
            InitializeComponent();
        }

        private void frmQuanLySanBayTrungGian_Load(object sender, EventArgs e)
        {
            ctBUS = new CTBUS();
            this.loadData_Vao_dtgvDsSanBayTrungGian();
        }

        //Kiểm tra null của textbox
        private bool checkNullData()
        {
            if (string.IsNullOrEmpty(txbGhiChu.Text))
            {
                MessageBox.Show("Bạn chưa nhập ghi chú!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbGhiChu.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txbThoiGianDung.Text))
            {
                MessageBox.Show("Bạn chưa nhập thời gian dừng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbThoiGianDung.Focus();
                return false;
            }
            return true;
        }

        //Clear input
        private void ClearInput()
        {
            txbGhiChu.Clear();
            txbThoiGianDung.Clear();
            txbMaChuyenBay.Clear();
            txbMaSanBay.Clear();
        }

        //Load dữ liệu chuyến bay vào danh sách
        private void loadData_Vao_dtgvDsSanBayTrungGian()
        {
            List<CTDTO> listSanBayTrungGian = ctBUS.select();

            if (listSanBayTrungGian == null)
            {
                MessageBox.Show("Có lỗi khi lấy danh sách chuyến bay từ DB");
                return;
            }

            dtgvDsSanBayTrungGian.Columns.Clear();
            dtgvDsSanBayTrungGian.DataSource = null;

            dtgvDsSanBayTrungGian.AllowUserToAddRows = false;
            dtgvDsSanBayTrungGian.AllowUserToResizeColumns = false;
            dtgvDsSanBayTrungGian.AllowUserToResizeRows = false;
            dtgvDsSanBayTrungGian.DataSource = listSanBayTrungGian;
            dtgvDsSanBayTrungGian.Columns["Error"].Visible = false;

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dtgvDsSanBayTrungGian.DataSource];
            myCurrencyManager.Refresh();

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
            if (char.IsLetter(e.KeyChar) || //Ký tự Alphabe
                char.IsSymbol(e.KeyChar) || //Ký tự đặc biệt
                char.IsWhiteSpace(e.KeyChar) || //Khoảng cách
                char.IsPunctuation(e.KeyChar)) //Dấu chấm              
            {
                e.Handled = true; //Không cho thể hiện lên TextBox
                MessageBox.Show("Vui lòng nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }


        private void dtgvDsSanBayTrungGian_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Row = e.RowIndex;
            if (Row != -1)
            {
                txbGhiChu.Text = dtgvDsSanBayTrungGian.Rows[Row].Cells["GhiChu"].Value.ToString();
                txbThoiGianDung.Text = dtgvDsSanBayTrungGian.Rows[Row].Cells["TGDung"].Value.ToString();
                txbMaChuyenBay.Text = dtgvDsSanBayTrungGian.Rows[Row].Cells["MaChuyenBay"].Value.ToString();
                txbMaSanBay.Text = dtgvDsSanBayTrungGian.Rows[Row].Cells["MaSanBay"].Value.ToString();
            }
            else
                return;
        }


        private void buttonSua_Click(object sender, EventArgs e)
        {
            CTDTO ctDTO = new CTDTO();

            //2. Kiểm tra data hợp lệ or not
            if (checkNullData())
            {
                //1. Map data from GUI
                ctDTO.MaChuyenBay = txbMaChuyenBay.Text.ToString();
                ctDTO.MaSanBay = txbMaSanBay.Text.ToString();
                ctDTO.TGDung = int.Parse(txbThoiGianDung.Text);
                ctDTO.GhiChu = txbGhiChu.Text;

                //3. Thêm vào DB
                bool kq = ctBUS.SuaChiTietSanBay(ctDTO);
                if (kq == false)
                    MessageBox.Show("Cập nhật Sân bay trung gian thất bại. Vui lòng kiểm tra lại dũ liệu! \n" + ctDTO.Error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show("Cập nhật Sân bay trung gian thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ClearInput();
                    this.loadData_Vao_dtgvDsSanBayTrungGian();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            CTDTO ctDTO = new CTDTO();

            //2. Kiểm tra data hợp lệ or not
            if (checkNullData())
            {
                //1. Map data from GUI
                ctDTO.MaChuyenBay = txbMaChuyenBay.Text.ToString();
                ctDTO.MaSanBay = txbMaSanBay.Text.ToString();

                //3. Thêm vào DB
                bool kq = ctBUS.XoaChiTietSanBay(ctDTO);
                if (kq == false)
                    MessageBox.Show("Cập nhật Sân bay trung gian thất bại. Vui lòng kiểm tra lại dũ liệu! \n" + ctDTO.Error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show("Cập nhật Sân bay trung gian thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ClearInput();
                    this.loadData_Vao_dtgvDsSanBayTrungGian();
                }
            }
        }

        private void txbThoiGianDung_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (inputTextLengthCheck(txbThoiGianDung, e))
            {
                inputTextOnlyNumber(e);
            }
        }

        private void txbGhiChu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txbGhiChu.Text.Length > 300)
            {
                MessageBox.Show("Bạn nhập quá số kí tự cho phép", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txbGhiChu.Clear();
                e.Handled = true;
            }
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
