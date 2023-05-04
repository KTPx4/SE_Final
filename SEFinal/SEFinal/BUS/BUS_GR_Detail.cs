using SEFinal.DTA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEFinal.BUS
{
    public class BUS_GR_Detail
    {
        private DTA_GR_Detail r;
        
        public BUS_GR_Detail()
        {
            r = new DTA_GR_Detail();
        }
        public BUS_GR_Detail(string rDID, string receiptID, string goodsID, int quan, double amount)
        {
            r = new DTA_GR_Detail(rDID, receiptID, goodsID, quan, amount);
        }

        public string getNextID()
        {
            return r.getNextID_("GRD0001");
        }
        public bool add()
        {
            return r.add_();
        }
    }
}
