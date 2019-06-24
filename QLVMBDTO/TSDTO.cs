using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVMBDTO
{
    public class TSDTO
    {
        private int slSanBayTrungGianToiDa;
        private int thoiGianBayToiThieu;
        private int thoiGianDungToiDa;
        private int thoiGianDungToiThieu;
        private int thoiGianChamNhatKhiDatVe;
        private int thoiGianHuyVe;
        private string error;

        public int SoLuongSanBayTrungGianToiDa { get => slSanBayTrungGianToiDa; set => slSanBayTrungGianToiDa = value; }
        public int ThoiGianBayToiThieu { get => thoiGianBayToiThieu; set => thoiGianBayToiThieu = value; }
        public int ThoiGianDungToiDa { get => thoiGianDungToiDa; set => thoiGianDungToiDa = value; }
        public int ThoiGianDungToiThieu { get => thoiGianDungToiThieu; set => thoiGianDungToiThieu = value; }
        public int ThoiGianChamNhatKhiDatVe { get => thoiGianChamNhatKhiDatVe; set => thoiGianChamNhatKhiDatVe = value; }
        public int ThoiGianHuyVe { get => thoiGianHuyVe; set => thoiGianHuyVe = value; }

        public string Error { get => error; set => error = value; }

    }
}
