using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEFinal.Class
{
    public class C_GD_Detail
    {
        public string DetailID { get; set; }
        public string OrderID { get; set; }
        public string GoodsID { get; set; }
        public int Quantity { get; set; }

        public C_GD_Detail()
        {
            this.DetailID = "";
            this.OrderID = "";
            this.GoodsID = "";
            this.Quantity = 0;
        }

        public C_GD_Detail(string detailID, string orderID, string goodsID, int quantity)
        {
            this.DetailID = detailID;
            this.OrderID = orderID;
            this.GoodsID = goodsID;
            this.Quantity = quantity;
        }
    }
}
