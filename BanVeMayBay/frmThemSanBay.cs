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
    public partial class frmThemSanBay : Form
    {
        private SBBUS sbBUS;
        public frmThemSanBay()
        {
            InitializeComponent();
        }

        private void Thoat_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Them_button_Click(object sender, EventArgs e)
        {
            SBDTO sbDTO = new SBDTO();

            //2. Kiểm tra data hợp lệ or not
            if (
                String.IsNullOrEmpty(txbMaSanBay.Text) ||
                String.IsNullOrEmpty(txbTenSanBay.Text)
                )
            {
                MessageBox.Show("Thông tin chưa hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                sbDTO.MaSanBay = txbMaSanBay.Text;
                sbDTO.TenSanBay = txbTenSanBay.Text;

                //Them vao DTB
                bool kq = sbBUS.ThemSanBay(sbDTO);
                if (kq == false)
                    MessageBox.Show("Thêm sân bay thất bại. Vui lòng kiểm tra lại dũ liệu");
                else
                    MessageBox.Show("Thêm sân bay thành công");
            }
        }
    }
}
