using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVMBDTO
{
    public class VBDTO
    {
        private string maHanhKhach;
        private string maChuyenBay;
        private string maHangVe;
        private string maVe;
        private string error;

        public string MaHanhKhach { get => maHanhKhach; set => maHanhKhach = value; }
        public string MaChuyenBay { get => maChuyenBay; set => maChuyenBay = value; }
        public string MaHangVe { get => maHangVe; set => maHangVe = value; }
        public string MaVe { get => maVe; set => maVe = value; }
        public string Error { get => error; set => error = value; }
    }
}
