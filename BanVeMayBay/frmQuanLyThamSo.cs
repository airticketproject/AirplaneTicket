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
    public partial class frmQuanLyThamSo : Form
    {
        private TSBUS tsBUS;
        public frmQuanLyThamSo()
        {
            InitializeComponent();
        }

        private void frmQuanLyThamSo_Load(object sender, EventArgs e)
        {
            tsBUS = new TSBUS();
            loadData();
        }

        private void loadData()
        {
            TSDTO ts = tsBUS.select();
            txbThoiGianBayToiThieu.Text = ts.ThoiGianBayToiThieu.ToString();
            txbSoSanBayTrungGianToiDa.Text = ts.SoLuongSanBayTrungGianToiDa.ToString();
            txbThoiGianDungToiDa.Text = ts.ThoiGianDungToiDa.ToString();
            txbThoiGianDungToiThieu.Text = ts.ThoiGianDungToiThieu.ToString();
            txbThoiGianChamNhatKhiDatVe.Text = ts.ThoiGianChamNhatKhiDatVe.ToString();
            txbThoiGianHuyVe.Text = ts.ThoiGianHuyVe.ToString();
        }

        //Kiểm tra null
        private bool checkNullData ()
        {
            if (
                string.IsNullOrEmpty(txbThoiGianBayToiThieu.Text) ||
                string.IsNullOrEmpty(txbThoiGianDungToiDa.Text) ||
                string.IsNullOrEmpty(txbThoiGianDungToiThieu.Text) ||
                string.IsNullOrEmpty(txbSoSanBayTrungGianToiDa.Text) ||
                string.IsNullOrEmpty(txbThoiGianChamNhatKhiDatVe.Text) ||
                string.IsNullOrEmpty(txbThoiGianHuyVe.Text)
               )
            {
                return false;
            }
            return true;
        }

        //Kiểm tra số
        private void InputTextOnlyNumber(KeyPressEventArgs e)
        {
            if (
                char.IsLetter(e.KeyChar) || //Ký tự Alphabe
                char.IsSymbol(e.KeyChar) || //Ký tự đặc biệt
                char.IsWhiteSpace(e.KeyChar) ||//Khoảng cách
                char.IsPunctuation(e.KeyChar) //Dấy chấm
               )
            {
                e.Handled = true; //Không cho thể hiện lên TextBox
                MessageBox.Show("Vui lòng nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            TSDTO tsDTO = new TSDTO();

            //2. Kiểm tra dữ liệu
            if (checkNullData())
            {
                tsDTO.SoLuongSanBayTrungGianToiDa = int.Parse(txbSoSanBayTrungGianToiDa.Text);
                tsDTO.ThoiGianDungToiDa = int.Parse(txbThoiGianDungToiDa.Text);
                tsDTO.ThoiGianDungToiThieu = int.Parse(txbThoiGianDungToiThieu.Text);
                tsDTO.ThoiGianHuyVe = int.Parse(txbThoiGianHuyVe.Text);
                tsDTO.ThoiGianChamNhatKhiDatVe = int.Parse(txbThoiGianChamNhatKhiDatVe.Text);
                tsDTO.ThoiGianBayToiThieu = int.Parse(txbThoiGianBayToiThieu.Text);

                //3. Thêm vào DBn
                bool kq = tsBUS.CapNhatThamSo(tsDTO);
                if (kq == false)
                    MessageBox.Show("Thay đổi tham số thất bại. Vui lòng kiểm tra lại dũ liệu! \n", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show("Thay đổi tham số thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void txbThoiGianBayToiThieu_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputTextOnlyNumber(e);
        }

        private void txbSoSanBayTrungGianToiDa_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputTextOnlyNumber(e);
        }

        private void txbThoiGianDungToiThieu_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputTextOnlyNumber(e);
        }

        private void txbThoiGianDungToiDa_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputTextOnlyNumber(e);
        }

        private void txbThoiGianChamNhatKhiDatVe_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputTextOnlyNumber(e);
        }

        private void txbThoiGianHuyVe_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputTextOnlyNumber(e);
        }
    }
}
