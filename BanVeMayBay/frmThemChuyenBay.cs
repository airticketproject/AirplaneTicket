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
    public partial class frmThemChuyenBay : Form
    {
        private CBBUS cbBUS;
        private SBBUS sbBUS;

        public frmThemChuyenBay()
        {
            InitializeComponent();
        }

        //Kiểm tra null của textbox
        private bool checkNullData()
        {
            if (string.IsNullOrEmpty(txbMaChuyenBay.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã chuyến bay!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbMaChuyenBay.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txbThoiGianBay.Text))
            {
                MessageBox.Show("Bạn chưa nhập thời gian bay!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbThoiGianBay.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txbSLGheHang1.Text))
            {
                MessageBox.Show("Bạn chưa nhập số lượng ghế hạng 1!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbSLGheHang1.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txbSLGheHang2.Text))
            {
                MessageBox.Show("Bạn chưa nhập số lượng ghế hạng 2!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbSLGheHang2.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txbDonGiaVe.Text))
            {
                MessageBox.Show("Bạn chưa nhập đơn giá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbDonGiaVe.Focus();
                return false;
            }
            return true;
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
        
        //Clear input
        private void ClearInput ()
        {
            txbDonGiaVe.Clear();
            txbMaChuyenBay.Clear();
            txbSLGheHang1.Clear();
            txbSLGheHang2.Clear();
            txbThoiGianBay.Clear();
        }
        
        //frm_Load
        private void frmLichChuyenBay_Load(object sender, EventArgs e)
        {
            cbBUS = new CBBUS();
            sbBUS = new SBBUS();
            this.loadSanBayVao_Combobox(cbbSanBayDi);
            this.loadSanBayVao_Combobox(cbbSanBayDen);
            this.loadData_Vao_dtgvDsChuyenBay();
        }


        //Load dữ liệu sân bay vào combobox
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

        //Load dữ liệu chuyến bay vào danh sách
        private void loadData_Vao_dtgvDsChuyenBay()
        {
            List<CBDTO> listChuyenBay = cbBUS.select();

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
            dtgvDsChuyenBay.Columns["Error"].Visible = false;

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dtgvDsChuyenBay.DataSource];
            myCurrencyManager.Refresh();

        }

        private void themChuyenBay_Click(object sender, EventArgs e)
        {
            CBDTO cbDTO = new CBDTO();
           
            //2. Kiểm tra data hợp lệ or not
            if (checkNullData())
            {
                //1. Map data from GUI
                cbDTO.MaChuyenBay = txbMaChuyenBay.Text;
                cbDTO.SanBayDi = cbbSanBayDi.SelectedValue.ToString();
                cbDTO.SanBayDen = cbbSanBayDen.SelectedValue.ToString();
                cbDTO.TGKhoiHanh = ngayKhoiHanh.Value.ToShortDateString();
                cbDTO.TGBay = int.Parse(txbThoiGianBay.Text);
                cbDTO.SLGheHang1 = int.Parse(txbSLGheHang1.Text);
                cbDTO.SLGheHang2 = int.Parse(txbSLGheHang2.Text);
                cbDTO.GiaVe = int.Parse(txbDonGiaVe.Text);

                //3. Thêm vào DB
                bool kq = cbBUS.ThemChuyenBay(cbDTO);
                if (kq == false)
                    MessageBox.Show("Thêm Chuyến bay thất bại. Vui lòng kiểm tra lại dũ liệu! \n" + cbDTO.Error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show("Thêm Chuyến bay thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.loadData_Vao_dtgvDsChuyenBay();
                    this.ClearInput();
                }
            }

        }

        private void buttonThemSanBayTrungGian_Click(object sender, EventArgs e)
        {
            Form themSanBayTrungGian = new frmThemSanBayTrungGian();
            themSanBayTrungGian.ShowDialog();
        }

        private void txbMaChuyenBay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (inputTextLengthCheck(txbMaChuyenBay,e))
            {
                inputTextNonCharacter(txbMaChuyenBay, e);
            }
        }

        private void txbThoiGianBay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (inputTextLengthCheck(txbThoiGianBay,e))
            {
                InputTextOnlyNumber(e);
            }
        }

        private void txbSLGheHang1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (inputTextLengthCheck(txbSLGheHang1,e))
            {
                InputTextOnlyNumber(e);
            }
        }

        private void txbSLGheHang2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (inputTextLengthCheck(txbSLGheHang2, e))
            {
                InputTextOnlyNumber(e);
            }
        }
   
        private void txbDonGiaVe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (inputTextLengthCheck(txbSLGheHang2, e))
            {
                InputTextOnlyNumber(e);
            }
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
