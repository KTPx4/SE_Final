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

        public C_Payment()
        {
            this.PaymentID = "";
            this.Name = "";
        }

        public C_Payment(string paymentID, string name)
        {
            PaymentID = paymentID;
            Name = name;
        }
    }
}
