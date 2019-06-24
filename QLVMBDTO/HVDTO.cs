using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVMBDTO
{
    public class HVDTO
    {
        private string maHangVe;
        private string tenHangVe;
        private float tiLeDonGia;
        private string error;

        public string MaHangVe { get => maHangVe; set => maHangVe = value; }
        public string TenHangVe { get => tenHangVe; set => tenHangVe = value; }
        public float TiLeDonGia { get => tiLeDonGia; set => tiLeDonGia = value; }
        public string Error { get => error; set => error = value; }

    }
}
