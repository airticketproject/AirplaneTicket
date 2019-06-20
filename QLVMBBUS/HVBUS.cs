using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLVMBDAL;
using QLVMBDTO;

namespace QLVMBBUS
{
    public class HVBUS
    {
        private HVDAL hvDAL;

        public HVBUS()
        {
            hvDAL = new HVDAL();
        }
        public bool ThemHangVe(HVDTO hv)
        {
            bool re = hvDAL.ThemHangVe(hv);
            return re;
        }

        public bool XoaHangVe(HVDTO hv)
        {
            bool re = hvDAL.XoaHangVe(hv);
            return re;
        }

        public bool SuaHangVe(HVDTO hv)
        {
            bool re = hvDAL.SuaHangVe(hv);
            return re;
        }

        public List<HVDTO> select()
        {
            return hvDAL.select();
        }
    }
}
