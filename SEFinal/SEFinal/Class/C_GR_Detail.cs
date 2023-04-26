using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEFinal.Class
{
    public class C_GR_Detail
    {
        public string RDID { get; set; }
        public string ReceiptID { get; set; }
        public string GoodsID { get; set; }
        public int Quan { get; set; }
        public double Amount { get; set; }

        public C_GR_Detail()
        {
            this.RDID = "";
            this.ReceiptID = "";
            this.GoodsID = "";
            this.Quan = 0;
            this.Amount = 0;
        }

        public C_GR_Detail(string rDID, string receiptID, string goodsID, int quan, double amount)
        {
            RDID = rDID;
            ReceiptID = receiptID;
            GoodsID = goodsID;
            Quan = quan;
            Amount = amount;
        }
    }
}
