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
    public partial class frmDatVe : Form
    {
        private CBBUS cbBUS;
        private KHBUS khBUS;
        private HVBUS hvBUS;
        private PDVBUS pdvBUS;

        public frmDatVe()
        {
            InitializeComponent();
        }

        private void frmDatVe_Load(object sender, EventArgs e)
        {
            cbBUS = new CBBUS();
            khBUS = new KHBUS();
            hvBUS = new HVBUS();
            pdvBUS = new PDVBUS();
            this.loadChuyenBayVao_Combobox(MaChuyenBay_comboBox);
            this.loadKhachHangVao_Combobox(MaHanhKhach_comboBox);
            this.loadHangVeVao_Combobox(HangVe_comboBox);
        }

        //Load dữ liệu chuyến bay vào combobox
        private void loadChuyenBayVao_Combobox(ComboBox comboBox)
        {
            List<CBDTO> listChuyenBay = cbBUS.select();

            if (listChuyenBay == null)
            {
                MessageBox.Show("Có lỗi khi lấy Sân bay từ cơ sở dữ liệu");
                return;
            }
            comboBox.DataSource = new BindingSource(listChuyenBay, String.Empty);
            comboBox.DisplayMember = "MaChuyenBay";
            comboBox.ValueMember = "MaChuyenBay";


            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[comboBox.DataSource];
            myCurrencyManager.Refresh();

            if (comboBox.Items.Count > 0)
            {
                comboBox.SelectedIndex = 0;
            }
        }

        //load dữ liệu khách hàng vào combobox
        private void loadKhachHangVao_Combobox(ComboBox comboBox)
        {
            List<KHDTO> listKhachHang = khBUS.select();

            if (listKhachHang == null)
            {
                MessageBox.Show("Có lỗi khi lấy Sân bay từ cơ sở dữ liệu");
                return;
            }
            comboBox.DataSource = new BindingSource(listKhachHang, String.Empty);
            comboBox.DisplayMember = "TenKhachHang";
            comboBox.ValueMember = "MaKhachHang";


            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[comboBox.DataSource];
            myCurrencyManager.Refresh();

            if (comboBox.Items.Count > 0)
            {
                comboBox.SelectedIndex = 0;
            }
        }

        //load dữ liệu khách hàng vào combobox
        private void loadHangVeVao_Combobox(ComboBox comboBox)
        {
            List<HVDTO> listHangVe = hvBUS.select();

            if (listHangVe == null)
            {
                MessageBox.Show("Có lỗi khi lấy Sân bay từ cơ sở dữ liệu");
                return;
            }
            comboBox.DataSource = new BindingSource(listHangVe, String.Empty);
            comboBox.DisplayMember = "TenHangVe";
            comboBox.ValueMember = "MaHangVe";


            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[comboBox.DataSource];
            myCurrencyManager.Refresh();

            if (comboBox.Items.Count > 0)
            {
                comboBox.SelectedIndex = 0;
            }
        }


        //Binding dữ liệu vào texbox thuộc Chuyến bay
        private void MaChuyenBay_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBDTO cbDTO = MaChuyenBay_comboBox.SelectedItem as CBDTO;
            txbSanBayDi.Text = cbDTO.SanBayDi;
            txbSanBayDen.Text = cbDTO.SanBayDen;
            txbNgayGio.Text = cbDTO.TGKhoiHanh;
            txbThoiGianBay.Text = cbDTO.TGBay.ToString();
        }

        //Binding dữ liệu vào texbox thuộc Khách hàng
        private void MaHanhKhach_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            KHDTO khDTO = MaHanhKhach_comboBox.SelectedItem as KHDTO;
            txbTenKhachHang.Text = khDTO.TenKhachHang;
            txbDienThoai.Text = khDTO.SDT;
            txbCMND.Text = khDTO.cmndKhachHang;
        }

        //Binding dữ liệu vào texbox thuộc Hạng ghế
        private void HangVe_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            HVDTO hvDTO = HangVe_comboBox.SelectedItem as HVDTO;
            CBDTO cbDTO = MaChuyenBay_comboBox.SelectedItem as CBDTO;
            txbGiaTien.Text = (hvDTO.TiLeDonGia * cbDTO.GiaVe).ToString();
        }


        private void Thoat_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ThemHanhKhach_button_Click(object sender, EventArgs e)
        {
            Form frmKhachHang = new frmQuanLyKhachHang();
            frmKhachHang.ShowDialog();
        }

        private void DatVe_button_Click(object sender, EventArgs e)
        {
            PDVDTO pdvDTO = new PDVDTO();

            //2. Kiểm tra data hợp lệ or not

            //1. Map data from GUI
            pdvDTO.MaChuyenBay = MaChuyenBay_comboBox.SelectedValue.ToString();
            pdvDTO.MaHangVe = HangVe_comboBox.SelectedValue.ToString();
            pdvDTO.MaHanhKhach = MaHanhKhach_comboBox.SelectedValue.ToString();


            //3. Thêm vào DB
            bool kq = pdvBUS.ThemPhieuDatVe(pdvDTO);
            if (kq == false)
                MessageBox.Show("Thêm vé bay thất bại. Vui lòng kiểm tra lại dũ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Thêm vé bay thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
