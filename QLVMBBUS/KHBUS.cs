using System;
using QLVMBDAL;
using QLVMBDTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVMBBUS
{
    public class KHBUS
    {
        private KHDAL khDAL;
        public KHBUS()
        {
            khDAL = new KHDAL();
        }

        public bool ThemKhachHang(KHDTO kh)
        {
            bool re = khDAL.ThemKhachHang(kh);
            return re;
        }

        public bool SuaKhachHang(KHDTO kh)
        {
            bool re = khDAL.SuaKhachHang(kh);
            return re;
        }

        public bool XoaKhachHang(KHDTO kh)
        {
            bool re = khDAL.XoaKhachHang(kh);
            return re;
        }


        public List<KHDTO> select()
        {
            return khDAL.select();
        }
    }
}
