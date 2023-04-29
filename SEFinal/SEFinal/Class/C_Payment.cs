using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEFinal.Class
{
    public class C_Payment
    {
        public string PaymentID { get; set; }
        public string Name { get; set; }
        public int is_deleted { get; set; }

        public C_Payment()
        {
            this.PaymentID = "";
            this.Name = "";
            this.is_deleted= 0;
        }

        public C_Payment(string paymentID, string name, int is_delete)
        {
            this.PaymentID = paymentID;
            this.Name = name;
            this.is_deleted= is_delete;
        }
    }
}
