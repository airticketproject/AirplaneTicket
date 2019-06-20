using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLVMBDTO;
using QLVMBDAL;


namespace QLVMBBUS
{
    public class PDVBUS
    {
        private  PDVDAL pdvDAL;
        public PDVBUS()

        {
            pdvDAL = new PDVDAL();
        }
        public bool ThemPhieuDatVe(PDVDTO pd)
        {
            bool re = pdvDAL.ThemPhieuDatVe(pd);
            return re;
        }

        public bool XoaPhieuDatVe(PDVDTO pd)
        {
            bool re = pdvDAL.XoaPhieuDatVe(pd);
            return re;
        }


        public List<PDVDTO> select()
        {
            return pdvDAL.select();
        }
    }
}
