using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEFinal.Class
{
    public class C_Goods
    {
        public string GoodsID { get; set; }
        public string GoodsName { get; set; }
        public string Unit { get; set; }
        public int Price { get; set; }
        public string Country { get; set; }

        public C_Goods()
        {
            this.GoodsID = "";
            this.GoodsName = "";
            this.Unit = "";
            this.Price = 0;
            this.Country = "";
        }

        public C_Goods(string goodsID, string goodsName, string unit, int price, string country)
        {
            this.GoodsID = goodsID;
            this.GoodsName = goodsName;
            this.Unit = unit;
            this.Price = price;
            this.Country = country;
        }
    }
}
