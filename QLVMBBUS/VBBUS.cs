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
        public bool ThemVeBay(VBDTO vb)
        {
            bool re = vbDAL.ThemVeBay(vb);
            return re;
        }

        public bool XoaveBay(VBDTO vb)
        {
            bool re = vbDAL.XoaVeBay(vb);
            return re;
        }


        public List<VBDTO> select()
        {
            return vbDAL.select();
        }
    }
}
