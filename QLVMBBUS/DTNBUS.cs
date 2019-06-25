using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLVMBDTO;
using QLVMBDAL;

namespace QLVMBBUS
{
    public class DTNBUS
    {

        private DTNDAL dtnDAL;
        public DTNBUS()
        {
            dtnDAL = new DTNDAL();
        }

        public bool GoiProcAdd(int nam)
        {
            bool re = dtnDAL.GoiProcAdd(nam);
            return re;
        }

        public List<DTNDTO> select(int nam)
        {
            return dtnDAL.select(nam);
        }
    }
}
