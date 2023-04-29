using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEFinal.Class
{
    public class C_GReceipt
    {
        public string ReceiptID { get; set; }
        public string ReceiptDate { get; set; }
        public string SupID { get; set; }
        public string Employee { get; set; }
        public double TotalAmount { get; set; }

        public C_GReceipt()
        {
            this.ReceiptID = "";
            this.ReceiptDate = "";
            this.SupID = "";
            this.Employee = "";
            this.TotalAmount = 0;
        }

        public C_GReceipt(string receiptID, string receiptDate, string supID, string employee, double totalAmount)
        {
            this.ReceiptID = receiptID;
            this.ReceiptDate = receiptDate;
            this.SupID = supID;
            this.Employee = employee;
            this.TotalAmount = totalAmount;
        }
    }
}
