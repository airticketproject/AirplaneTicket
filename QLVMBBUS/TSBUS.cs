using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLVMBDAL;
using QLVMBDTO;

namespace QLVMBBUS
{
    public class TSBUS
    {
        private TSDAL tsDAL;
        public TSBUS()
        {
            tsDAL = new TSDAL();
        }
        public bool CapNhatThamSo(TSDTO ts)
        {
            bool re = tsDAL.CapNhatThamSo(ts);
            return re;
        }

        public TSDTO select()
        { 
            return tsDAL.select();
        }

    }
}
