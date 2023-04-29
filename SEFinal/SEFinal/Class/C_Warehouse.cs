using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEFinal.Class
{
    public class C_Warehouse
    {
        public string GoodsID { get; set; }
        public int Quan { get; set; }

        public C_Warehouse() 
        {
            this.GoodsID = "";
            this.Quan = 0;
        }

        public C_Warehouse(string goodsID, int quan)
        {
            this.GoodsID = goodsID; 
            this.Quan = quan;
        }
    }
}
