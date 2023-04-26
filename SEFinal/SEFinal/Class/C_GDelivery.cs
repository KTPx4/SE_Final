using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEFinal.Class
{
    public class C_GDelivery
    {
        public string DeliveryID { get; set; }
        public string OrderID { get; set; }
        public string Employee { get; set; }
        public string DeliveryDate { get; set; }
        public int Status { get; set; }

        public C_GDelivery() 
        {
            this.DeliveryID = "";
            this.OrderID = "";
            this.Employee = "";
            this.DeliveryDate = "";
            this.Status = 0;
        }

        public C_GDelivery(string deliveryID, string orderID, string employee, string deliveryDate, int status)
        {
            this.DeliveryID = deliveryID;
            this.OrderID = orderID;
            this.Employee = employee;
            this.DeliveryDate = deliveryDate;
            this.Status = status;
        }

    }
}
