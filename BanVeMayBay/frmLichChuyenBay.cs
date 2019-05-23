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
        private VMBBUS vmbBUS;
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
            vmbBUS = new VMBBUS();
        }

        private void themChuyenBay_Click(object sender, EventArgs e)
        {
            VMBDTO vmbDTO = new VMBDTO();

           
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
                vmbDTO.MaChuyenBay = txbMaChuyenBay.Text;
                vmbDTO.SanBayDi = "1";
                vmbDTO.SanBayDen = "2";
                vmbDTO.TGKhoiHanh = ngayKhoiHanh.Value;
                vmbDTO.TGBay = int.Parse(txbThoiGianBay.Text);
                vmbDTO.SLGheHang1 = int.Parse(txbSLGheHang1.Text);
                vmbDTO.SLGheHang2 = int.Parse(txbSLGheHang2.Text);
                //3. Thêm vào DB
                bool kq = vmbBUS.ThemChuyenBay(vmbDTO);
                if (kq == false)
                    MessageBox.Show("Thêm Kiểu nấu thất bại. Vui lòng kiểm tra lại dũ liệu");
                else
                    MessageBox.Show("Thêm Kiểu nấu thành công");
            }

        }
    }
}
