using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLVMBDTO;
using QLVMBDAL;

namespace QLVMBBUS
{
    public class CTBUS
    {

        private CTDAL ctDAL;
        public CTBUS()
        {
            ctDAL = new CTDAL();
        }
        public bool ThemChiTietSanBay(CTDTO ct)
        {
            bool re = ctDAL.ThemChiTietSanBay(ct);
            return re;
        }

        public bool XoaChiTietSanBay(CTDTO ct)
        {
            bool re = ctDAL.XoaChiTietSanBay(ct);
            return re;
        }

        public bool SuaChiTietSanBay(CTDTO ct)
        {
            bool re = ctDAL.SuaChiTietSanBay(ct);
            return re;
        }

        public List<CTDTO> select(CTDTO ct)
        {
            return ctDAL.select(ct);
        }
    }
}
