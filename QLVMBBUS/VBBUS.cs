using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLVMBDTO;
using QLVMBDAL;

namespace QLVMBBUS
{
    public class VBBUS
    {
        private VBDAL vbDAL;
        public VBBUS()
        {
            vbDAL = new VBDAL();
        }
        public bool ThemChuyenBay(VBDTO vb)
        {
            bool re = vbDAL.ThemVeBay(vb);
            return re;
        }

        public bool XoaChuyenBay(VBDTO vb)
        {
            bool re = vbDAL.XoaChuyenBay(vb);
            return re;
        }

        public bool SuaChuyenBay(VBDTO cb)
        {
            bool re = vbDAL.SuaChuyenBay(cb);
            return re;
        }

        public List<VBDTO> select()
        {
            return vbDAL.select();
        }
    }
}
