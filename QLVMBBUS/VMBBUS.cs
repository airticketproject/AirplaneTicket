using QLVMBDTO;
using QLVMBDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVMBBUS
{
    public class VMBBUS
    {
        private VMBDAL vbmDAL;
        public VMBBUS()
        {
            vbmDAL = new VMBDAL();
        }
        public bool ThemChuyenBay(VMBDTO cb)
        {
            bool re = vbmDAL.ThemChuyenBay(cb);
            return re;
        }

        public bool XoaChuyenBay(VMBDTO cb)
        {
            bool re = vbmDAL.XoaChuyenBay(cb);
            return re;
        }

        public bool SuaChuyenBay(VMBDTO cb)
        {
            bool re = vbmDAL.SuaChuyenBay(cb);
            return re;
        }

        public List<VMBDTO> select()
        {
            return null;
        }
    }
}
