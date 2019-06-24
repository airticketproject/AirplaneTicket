using System;
using QLVMBBUS;
using QLVMBDAL;
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
    public partial class frmQuanLyChuyenBay : Form
    {
        private CBBUS cbBUS;
        private SBBUS sbBUS;
        public frmQuanLyChuyenBay()
        {
            InitializeComponent();
        }

        private void frmQuanLyChuyenBay_Load(object sender, EventArgs e)
        {
            cbBUS = new CBBUS();
            sbBUS = new SBBUS();
            this.loadData_Vao_dtgvDsChuyenBay();
            this.loadSanBayVao_Combobox(cbbSanBayDi);
            this.loadSanBayVao_Combobox(cbbSanBayDen);
        }

        //Kiểm tra null của textbox
        private bool checkNullData()
        {
            if (string.IsNullOrEmpty(txbMaChuyenBay.Text) ||
                string.IsNullOrEmpty(txbSuaThoiGianBay.Text) ||
                string.IsNullOrEmpty(txbSuaSLGheHang1.Text) ||
                string.IsNullOrEmpty(txbSuaSLGheHang2.Text) ||
                string.IsNullOrEmpty(txbDonGiaVe.Text)
                )
            {
                return false;
            }
           
            return true;
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

        //Xoá Chuyến bay
        private void btnXoaChuyenBay_Click(object sender, EventArgs e)
        {
            CBDTO cbDTO = new CBDTO();

            //2. Kiểm tra data hợp lệ or not
            if (checkNullData())
            {
                //1. Map data from GUI
                cbDTO.MaChuyenBay = txbMaChuyenBay.Text;

                //3. Thêm vào DB
                bool kq = cbBUS.XoaChuyenBay(cbDTO);
                if (kq == false)
                    MessageBox.Show("Xoá Chuyến bay thất bại. Vui lòng kiểm tra lại dũ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    MessageBox.Show("Xoá Chuyến bay thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.loadData_Vao_dtgvDsChuyenBay();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thông tin cần chỉnh sửa", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Sửa Chuyến bay
        private void btnCapNhatChuyenBay_Click(object sender, EventArgs e)
        {
            CBDTO cbDTO = new CBDTO();

            //2. Kiểm tra data hợp lệ or not
            if(checkNullData())
            {
                //1. Map data from GUI
                cbDTO.MaChuyenBay = txbMaChuyenBay.Text;
                cbDTO.SanBayDi = cbbSanBayDi.SelectedValue.ToString();
                cbDTO.SanBayDen = cbbSanBayDen.SelectedValue.ToString();
                cbDTO.TGKhoiHanh = suaThoiGianKhoiHanh.Value.ToShortDateString();
                cbDTO.TGBay = int.Parse(txbSuaThoiGianBay.Text);
                cbDTO.SLGheHang1 = int.Parse(txbSuaSLGheHang1.Text);
                cbDTO.SLGheHang2 = int.Parse(txbSuaSLGheHang2.Text);
                cbDTO.GiaVe = int.Parse(txbDonGiaVe.Text);

                //3. Thêm vào DB
                bool kq = cbBUS.SuaChuyenBay(cbDTO);
                if (kq == false)
                    MessageBox.Show("Cập nhật Chuyến bay thất bại. Vui lòng kiểm tra lại dũ liệu \n" + cbDTO.Error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show("Cập nhật Chuyến bay thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.loadData_Vao_dtgvDsChuyenBay();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thông tin cần chỉnh sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dtgvDsChuyenBay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Row = e.RowIndex;
            if (Row != -1)
            {
                txbMaChuyenBay.Text = dtgvDsChuyenBay.Rows[Row].Cells["MaChuyenBay"].Value.ToString();
                cbbSanBayDen.SelectedValue = dtgvDsChuyenBay.Rows[Row].Cells["SanBayDen"].Value.ToString();
                cbbSanBayDi.SelectedValue = dtgvDsChuyenBay.Rows[Row].Cells["SanBayDi"].Value.ToString();
                suaThoiGianKhoiHanh.Value = DateTime.Parse(dtgvDsChuyenBay.Rows[Row].Cells["TGKhoiHanh"].Value.ToString());
                txbSuaThoiGianBay.Text = dtgvDsChuyenBay.Rows[Row].Cells["TGBay"].Value.ToString();
                txbSuaSLGheHang1.Text = dtgvDsChuyenBay.Rows[Row].Cells["SLGheHang1"].Value.ToString();
                txbSuaSLGheHang2.Text = dtgvDsChuyenBay.Rows[Row].Cells["SLGheHang2"].Value.ToString(); 
                txbDonGiaVe.Text = dtgvDsChuyenBay.Rows[Row].Cells["GiaVe"].Value.ToString();
            }
            else
                return;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Form form = new frmTimKiem_DanhSachChuyenBay();
            form.ShowDialog();
        }
    }
}
