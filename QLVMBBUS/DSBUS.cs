using QLVMBDTO;
using QLVMBDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVMBBUS
{
    public class DSBUS
    {
        private DSDAL dsDAL;
        public DSBUS()
        {
            dsDAL = new DSDAL();
        }

        public List<DSDTO> select()
        {
            return dsDAL.select();
        }
    }
}
