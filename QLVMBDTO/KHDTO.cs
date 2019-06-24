using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVMBDTO
{
    public class KHDTO
    {
        private string maKhachHang;
        private string tenKhachHang;
        private string CMND;
        private string soDienThoai;
        private string error;

        public string MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        public string TenKhachHang { get => tenKhachHang; set => tenKhachHang = value; }
        public string cmndKhachHang { get => CMND; set => CMND = value; }
        public string SDT { get => soDienThoai; set => soDienThoai = value; }
        public string Error { get => error; set => error = value; }
    }
}
