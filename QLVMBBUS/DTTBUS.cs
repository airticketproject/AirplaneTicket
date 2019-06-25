using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLVMBDTO;
using QLVMBDAL;

namespace QLVMBBUS
{
    public class DTTBUS
    {

        private DTTDAL dttDAL;
        public DTTBUS()
        {
            dttDAL = new DTTDAL();
        }
        public bool GoiProcAdd(int thang, int nam)
        {
            bool re = dttDAL.GoiProcAdd(thang, nam);
            return re;
        }

        public bool GoiProcClear()
        {
            bool re = dttDAL.GoiProcClear();
            return re;
        }

        public List<DTTDTO> select(int thang, int nam)
        {
            return dttDAL.select(thang, nam);
        }
    }
}
