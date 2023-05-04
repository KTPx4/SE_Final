using SEFinal.DTA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEFinal.BUS
{
    public class BUS_PaymentDetail
    {
        private DTA_PaymentDetail p;
        public BUS_PaymentDetail() 
        {
            p = new DTA_PaymentDetail();
        }
        public BUS_PaymentDetail(string order, int status)
        {
            p = new DTA_PaymentDetail("", order, status);
        }

        public bool update_Status()
        {
            return p.set_Status();
        }
    }
}
