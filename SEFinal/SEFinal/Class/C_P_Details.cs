using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEFinal.Class
{
    public class C_P_Details
    {

        public string PDID { get; set; }

        public string OrderID { get; set; }
           
        public int status { get; set; }

        public C_P_Details() 
        {
            this.PDID = "";
            this.OrderID = "";
            this.status = 0;
        }

        public C_P_Details(string pdid, string order, int status)
        {
            this.PDID = pdid;
            this.OrderID = order;
            this.status = status;
        }
    }
}
