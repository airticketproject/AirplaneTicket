﻿using System;
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
    public partial class frmQuanLyKhachHang : Form
    {
        private KHBUS khBUS;

        public frmQuanLyKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHanh_Load(object sender, EventArgs e)
        {
            khBUS = new KHBUS();
            this.loadData_Vao_dtgvDsKhachHang();
        }

        private void loadData_Vao_dtgvDsKhachHang()
        {
            List<KHDTO> listKhachHang = khBUS.select();

            if (listKhachHang == null)
            {
                MessageBox.Show("Có lỗi khi lấy danh sách khách hàng từ DB");
                return;
            }

            dtgvDsKhachHang.Columns.Clear();
            dtgvDsKhachHang.DataSource = null;

            dtgvDsKhachHang.AllowUserToAddRows = false;
            dtgvDsKhachHang.AllowUserToResizeColumns = false;
            dtgvDsKhachHang.AllowUserToResizeRows = false;
            dtgvDsKhachHang.DataSource = listKhachHang;

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dtgvDsKhachHang.DataSource];
            myCurrencyManager.Refresh();

        }

        //Kiểm tra null của textbox
        private bool checkNullData()
        {
            if (
                string.IsNullOrEmpty(txbSuaTenKhachHang.Text) ||
                string.IsNullOrEmpty(txbSuaCMND.Text) ||
                string.IsNullOrEmpty(txbSuaSDT.Text)
                )
            {
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


        private void btnXoaKhachHang_Click(object sender, EventArgs e)
        {
            KHDTO khDTO = new KHDTO();

            //2. Kiểm tra data hợp lệ or not
            if (checkNullData())
            {
                //1. Map data from GUI
                khDTO.MaKhachHang = txbSuaMaKhachHang.Text;

                //3. Thêm vào DB
                bool kq = khBUS.XoaKhachHang(khDTO);
                if (kq == false)
                    MessageBox.Show("Xoá khách hàng thất bại. Vui lòng kiểm tra lại dũ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    MessageBox.Show("Xoá khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.loadData_Vao_dtgvDsKhachHang();
                }
            }
        }

        private void btnSuaKhachHang_Click(object sender, EventArgs e)
        {
            KHDTO khDTO = new KHDTO();

            //2. Kiểm tra data hợp lệ or not
            if (checkNullData())
            {
                //1. Map data from GUI
                khDTO.MaKhachHang = txbSuaMaKhachHang.Text;
                khDTO.TenKhachHang = txbSuaTenKhachHang.Text;
                khDTO.cmndKhachHang = txbSuaCMND.Text;
                khDTO.SDT = txbSuaSDT.Text;

                //3. Thêm vào DB
                bool kq = khBUS.SuaKhachHang(khDTO);
                if (kq == false)
                    MessageBox.Show("Cập nhật khách hàng thất bại. Vui lòng kiểm tra lại dũ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    MessageBox.Show("Cập nhật khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.loadData_Vao_dtgvDsKhachHang();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần chỉnh sửa", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dtgvDsKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Row = e.RowIndex;
            if (Row != -1)
            {
                txbSuaMaKhachHang.Text = dtgvDsKhachHang.Rows[Row].Cells["MaKhachHang"].Value.ToString();
                txbSuaTenKhachHang.Text = dtgvDsKhachHang.Rows[Row].Cells["TenKhachHang"].Value.ToString();
                txbSuaCMND.Text = dtgvDsKhachHang.Rows[Row].Cells["cmndKhachHang"].Value.ToString();
                txbSuaSDT.Text = dtgvDsKhachHang.Rows[Row].Cells["SDT"].Value.ToString();
            }
            else
                return;
        }

        private void txbSuaTenKhachHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (inputTextLengthCheck(txbSuaTenKhachHang, e))
            {
                inputTextNonCharacter(txbSuaTenKhachHang, e);
            }
        }

        private void txbSuaCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputTextOnlyNumber(e);
        }

        private void txbSuaSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputTextOnlyNumber(e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
