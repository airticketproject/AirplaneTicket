using QLVMBDAL;
using QLVMBDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVMBBUS
{
    public class SBBUS 
    {
        private SBDAL sbDAL;
        public SBBUS()
        {
            sbDAL = new SBDAL();
        }
        public bool ThemSanBay(SBDTO sb)
        {
            bool re = sbDAL.ThemSanBay(sb);
            return re;
        }
 
        public bool SuaSanBay(SBDTO sb)
        {
            bool re = sbDAL.SuaSanBay(sb);
            return re;
        } 

        public bool XoaSanBay(SBDTO sb)
        {
            bool re = sbDAL.XoaSanBay(sb);
            return re;
        }


        public List<SBDTO> select()
        {
            return sbDAL.select();
        }
    }
}
