using SEFinal.DTA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEFinal.BUS
{
    public class BUS_GReceipt
    {
        private DTA_GReceipt r;
        public BUS_GReceipt() 
        {
            r = new DTA_GReceipt();
        }
        public BUS_GReceipt(string id)
        {
            r = new DTA_GReceipt(id, "", "", "", 0);
        }
        public BUS_GReceipt(string receiptID, string receiptDate, string supID, string employee, double totalAmount)
        {
            r = new DTA_GReceipt(receiptID, receiptDate, supID, employee, totalAmount);
        }

        public DataTable getAll()
        {

            string s = "select * from GoodsReceipt";
            return r.Query(s);
        }
        public string getNextID()
        {
            return r.getNextID_("GR0001");
        }

        public bool add()
        {
            return r.add_();
        }
        public bool edit()
        {
            return r.edit_();
        }
        public void setTotal(double total)
        {
            r.setTotal(total);
        }
    }
}
