﻿using System;
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
        public double Price { get; set; }
        public string Country { get; set; }

        public int is_deleted { get; set; }
        public C_Goods()
        {
            this.GoodsID = "";
            this.GoodsName = "";
            this.Unit = "";
            this.Price = 0;
            this.Country = "";
            this.is_deleted = 0;
        }

        public C_Goods(string goodsID, string goodsName, string unit, double price, string country, int is_deleted)
        {
            this.GoodsID = goodsID;
            this.GoodsName = goodsName;
            this.Unit = unit;
            this.Price = price;
            this.Country = country;
            this.is_deleted = is_deleted;
        }
    }
}
