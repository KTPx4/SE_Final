using SEFinal.DTA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEFinal.BUS
{
    public class BUS_Goods
    {
        private DTA_Goods g;
        private DTA_Warehouse warehouse;

        public BUS_Goods() 
        {
            g = new DTA_Goods();
            warehouse = new DTA_Warehouse();
        }

        public BUS_Goods(string goodsID, string goodsName, string unit, double price, string country, int quan)
        {
            g = new DTA_Goods(goodsID, goodsName, unit, price, country, 0);
            warehouse = new DTA_Warehouse(goodsID, quan);

        }
        public BUS_Goods(string id)
        {
            g = new DTA_Goods(id, "", "", 0, "", 0);
            warehouse = new DTA_Warehouse(id, 0);
        }

        public string get_Next_ID()
        {
            return g.getNextID_("G0001");
        }

        public bool add()
        {
            if(g.add_())
            {
                warehouse.add_();
                return true;
            }
           return false;
        }

        public bool edit()
        {
            if(g.edit_())
            {
                warehouse.edit_();
                return true;
            }
            return false;
        }

        public bool delete()
        {
            if(g.delete_())
            {
                warehouse.delete_();
                return true;
            }
            return false;
        }

        public DataTable getALL()
        {
            string s = $"Select Goods.GoodsID, Goods.GoodsName, Goods.Unit, Goods.Price, Goods.Country, Warehouse.Quan " +
                $"From goods inner join  Warehouse ON Goods.GoodsID = Warehouse.GoodsID and Goods.is_deleted = 0";
            return g.Query(s);
        }
        public int checkAdd()
        {
           
            if (g.is_old_())
            {
                return 0; // 0 for message confirm is add new or restore
            }   
            else if(g.isExists())
            {
                return 2;
            }
            else
            {
                return 1; // 1 for success add rows
            }
        }

        public string getID_from_Name()
        {
            string s = $"select GoodsID from Goods where GoodsName='{g.getName()}' and is_deleted = 1";
            DataTable tb = g.Query(s);
            if(tb.Rows.Count < 1)
            {
                return "";
            }
            return tb.Rows[0][0].ToString();
        }

        public  void restore(string id)
        {
            //string s = $"update Goods set is_deleted = 0 where GoodsID = '{id}'";
            //g.QueryAction(s);
            //warehouse = new DTA_Warehouse(id, 0);
            g.setID(id);
            g.edit_();
            warehouse.setID(id);
            warehouse.add_();

        }
    }
}
