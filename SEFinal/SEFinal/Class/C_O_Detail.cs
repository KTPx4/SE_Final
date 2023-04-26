using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEFinal.Class
{
    public class C_O_Detail
    {
        public string DetailID { get; set; }
        public string OrderID { get; set; }
        public string GoodsID { get; set; }
        public int Quantity { get; set; }

        public C_O_Detail()
        {
            this.DetailID = "";
            this.OrderID = "";
            this.GoodsID = "";
            this.Quantity = 0;
        }

        public C_O_Detail(string detailID, string orderID, string goodsID, int quantity)
        {
            DetailID = detailID;
            OrderID = orderID;
            GoodsID = goodsID;
            Quantity = quantity;
        }
    }
}
