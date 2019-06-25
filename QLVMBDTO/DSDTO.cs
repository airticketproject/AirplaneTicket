using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVMBDTO
{
    public class DSDTO
    {
        private string maChuyenBay;
        private string sanBayDi;
        private string sanBayDen;
        private string ngayGio;
        private int thoiGianBay;
        private int soGheTrong;
        private int soGheDaDat;

        public string MaChuyenBay { get => maChuyenBay; set => maChuyenBay = value; }
        public string SanBayDi { get => sanBayDi; set => sanBayDi = value; }
        public string SanBayDen { get => sanBayDen; set => sanBayDen = value; }
        public string TGKhoiHanh { get => ngayGio; set => ngayGio = value; }
        public int TGBay { get => thoiGianBay; set => thoiGianBay = value; }
        public int SoGheTrong { get => soGheTrong; set => soGheTrong = value; }
        public int SoGheDaDat { get => soGheDaDat; set => soGheDaDat = value; }
    }
}
