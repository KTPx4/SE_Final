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
        public int TotalAmount { get; set; }

        public C_GReceipt()
        {
            this.ReceiptID = "";
            this.ReceiptDate = "";
            this.SupID = "";
            this.Employee = "";
            this.TotalAmount = 0;
        }

        public C_GReceipt(string receiptID, string receiptDate, string supID, string employee, int totalAmount)
        {
            ReceiptID = receiptID;
            ReceiptDate = receiptDate;
            SupID = supID;
            Employee = employee;
            TotalAmount = totalAmount;
        }
    }
}
