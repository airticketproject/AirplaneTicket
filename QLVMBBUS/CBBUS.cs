using QLVMBDTO;
using QLVMBDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVMBBUS
{
    public class CBBUS
    {
        private CBDAL vbmDAL;
        public CBBUS()
        {
            vbmDAL = new CBDAL();
        }
        public bool ThemChuyenBay(CBDTO cb)
        {
            bool re = vbmDAL.ThemChuyenBay(cb);
            return re;
        }

        public bool XoaChuyenBay(CBDTO cb)
        {
            bool re = vbmDAL.XoaChuyenBay(cb);
            return re;
        }

        public bool SuaChuyenBay(CBDTO cb)
        {
            bool re = vbmDAL.SuaChuyenBay(cb);
            return re;
        }

        public List<CBDTO> select()
        {
            return vbmDAL.select();
        }

    }
}
