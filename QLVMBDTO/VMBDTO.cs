using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVMBDTO
{
    public class VMBDTO
    {
        private string maChuyenBay;
        private string sanBayDi;
        private string sanBayDen;
        private DateTime ngayGio;
        private int thoiGianBay;
        private int soLuongGheHang1;
        private int soLuongGheHang2;

        public string MaChuyenBay { get => maChuyenBay; set => maChuyenBay = value; }
        public string SanBayDi { get => sanBayDi; set => sanBayDi = value; }
        public string SanBayDen { get => sanBayDen; set => sanBayDen = value; }
        public DateTime TGKhoiHanh { get => ngayGio; set => ngayGio = value; }
        public int TGBay { get => thoiGianBay; set => thoiGianBay = value; }
        public int SLGheHang1 { get => soLuongGheHang1; set => soLuongGheHang1 = value; }
        public int SLGheHang2 { get => soLuongGheHang2; set => soLuongGheHang2 = value; }
    }
}
