using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVMBDTO
{
    public class CTDTO
    {
        private string maChuyenBay;
        private string maSanBay;
        private string maChiTietSanBayTrungGian;
        private string ghiChu;
        private int thoiGianDung;

        public string MaChiTietSanBayTrungGian { get => maChiTietSanBayTrungGian; set => maChiTietSanBayTrungGian = value; }
        public string MaChuyenBay { get => maChuyenBay; set => maChuyenBay = value; }
        public string MaSanBay { get => maSanBay; set => maSanBay = value; }
        public int TGDung { get => thoiGianDung; set => thoiGianDung = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }

    }
}
