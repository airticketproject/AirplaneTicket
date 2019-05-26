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
    public partial class frmLichChuyenBay : Form
    {
        private CBBUS cbBUS;
        private SBBUS sbBUS;

        public frmLichChuyenBay()
        {
            InitializeComponent();
        }

        private bool checkNull(string txb)
        {
            if(string.IsNullOrEmpty(txb))
            {
                return false;
            }
            return true;
        }

        private void frmLichChuyenBay_Load(object sender, EventArgs e)
        {
            cbBUS = new CBBUS();
            sbBUS = new SBBUS();
            loadSanBayVao_Combobox(cbbSanBayDi);
            loadSanBayVao_Combobox(cbbSanBayDen);
        }

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

        private void themChuyenBay_Click(object sender, EventArgs e)
        {
            CBDTO cbDTO = new CBDTO();

           
            //2. Kiểm tra data hợp lệ or not
            if (
                string.IsNullOrEmpty(txbMaChuyenBay.Text) || 
                string.IsNullOrEmpty(txbThoiGianBay.Text) || 
                string.IsNullOrEmpty(txbSLGheHang1.Text) ||
                string.IsNullOrEmpty(txbSLGheHang2.Text)
               )
            {
                MessageBox.Show("Thông tin chưa hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //1. Map data from GUI
                cbDTO.MaChuyenBay = txbMaChuyenBay.Text;
                cbDTO.SanBayDi = cbbSanBayDi.Text;
                cbDTO.SanBayDen = cbbSanBayDen.Text;
                cbDTO.TGKhoiHanh = ngayKhoiHanh.Value;
                cbDTO.TGBay = int.Parse(txbThoiGianBay.Text);
                cbDTO.SLGheHang1 = int.Parse(txbSLGheHang1.Text);
                cbDTO.SLGheHang2 = int.Parse(txbSLGheHang2.Text);

                //3. Thêm vào DB
                bool kq = cbBUS.ThemChuyenBay(cbDTO);
                if (kq == false)
                    MessageBox.Show("Thêm Chuyến bay thất bại. Vui lòng kiểm tra lại dũ liệu");
                else
                    MessageBox.Show("Thêm Chuyến bay thành công");
            }

        }
    }
}
