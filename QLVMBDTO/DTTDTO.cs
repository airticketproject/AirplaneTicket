using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVMBDTO
{
    public class DTTDTO
    {
        private int thang;
        private int nam;
        private string maChuyenBay;
        private int soLuongVe;
        private int doanhThu;
        private float tiLe;

        public int Thang { get => thang; set => thang = value; }
        public int Nam { get => nam; set => nam = value; }
        public string MaChuyenBay { get => maChuyenBay; set => maChuyenBay = value; }
        public int SoLuongVe { get => soLuongVe; set => soLuongVe = value; }
        public int DoanhThu { get => doanhThu; set => doanhThu = value; }
        public float TiLe { get => tiLe; set => tiLe = value; }

    }
}
