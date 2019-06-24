using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVMBDTO
{
    public class SBDTO
    {
        private string maSanBay;
        private string tenSanBay;
        private string error;

        public string MaSanBay { get => maSanBay; set => maSanBay = value; }
        public string TenSanBay { get => tenSanBay; set => tenSanBay = value; }
        public string Error { get => error; set => error = value; }

    }
}
