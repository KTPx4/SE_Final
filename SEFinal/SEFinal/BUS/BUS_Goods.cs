using SEFinal.DTA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
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
        public void setID(string id)
        {
            g.setID(id);
        }
        public string getID()
        {
            return g.getID();
        }
        public bool checkQuan(int quan_delivery)
        {
            string s = $"select quan from Warehouse where GoodsID='{g.getID()}'";
            DataTable data = g.Query(s);
            if(data.Rows.Count < 1)
            {
                return false;
            }
            int quan_warehouse = int.Parse(data.Rows[0][0].ToString());
            if(quan_delivery > quan_warehouse)
            {
                return false;
            }
            return true;
        }
        public string get_Next_ID()
        {
            return g.getNextID_("G0001");
        }

        public bool add()
        {
            if(!g.check_parameter()) // parameter invalid
            {
                return false;
            }

            if(g.add_())
            {
                warehouse.add_();
                return true;
            }
           return false;
        }

        public bool edit()
        {
            if(!g.check_parameter()) // parameter invalid
            {
                return false;
            }

            if (g.edit_())
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
        public DataTable getGoods()
        {
            string s = $"Select Goods.GoodsID, Goods.GoodsName, Goods.Unit, Goods.Price, Goods.Country, Warehouse.Quan " +
                $"From goods inner join  Warehouse " +
                $"ON Goods.GoodsID = Warehouse.GoodsID and Goods.is_deleted = 0 and Goods.GoodsID = '{g.getID()}'";
            return g.Query(s);
        }
        public DataTable getAll_ID()
        {
            string s = $"Select Goods.GoodsID " +
               $"From goods inner join  Warehouse " +
               $"ON Goods.GoodsID = Warehouse.GoodsID and Goods.is_deleted = 0 ";
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

        public string getID_from_Name_deleted()
        {
            string s = $"select GoodsID from Goods where GoodsName='{g.getName()}' and is_deleted = 1";
            DataTable tb = g.Query(s);
            if(tb.Rows.Count < 1)
            {
                return "";
            }
            return tb.Rows[0][0].ToString();
        }
        public string getName_from_ID()
        {
            string s = $"select GoodsName from Goods where GoodsID='{g.getID()}' and is_deleted = 0";
            DataTable tb = g.Query(s);
            if (tb.Rows.Count < 1)
            {
                return "";
            }
            return tb.Rows[0][0].ToString();
        }

        public  bool restore()
        {
            //string s = $"update Goods set is_deleted = 0 where GoodsID = '{id}'";
            //g.QueryAction(s);
            //warehouse = new DTA_Warehouse(id, 0);
            string id = this.getID_from_Name_deleted();
            g.setID(id);
            if(!g.check_parameter()) // check info before edit
            {
                return false;
            }
            g.edit_();
            warehouse.setID(id); // set id = old id exists in data
            warehouse.add_();
            return true;

        }
        
        public bool is_Exists()
        {
            string s = $"select *  from Goods where GoodsID='{g.getID()}' and is_deleted = 0";
            DataTable tb = g.Query(s);
            if (tb.Rows.Count < 1)
            {

                return false;
            }
            return true;
        }
        public bool updateQuan_a(int quan) // update quan add more in warehouse
        {
            int old_quan = warehouse.GetQuan();
            int new_quan = old_quan + quan;

            warehouse = new DTA_Warehouse(g.getID(), new_quan);
            return warehouse.edit_();
        }
        public bool updateQuan_m(int quan) // update quan minus
        {
            int old_quan = warehouse.GetQuan();
            int new_quan = old_quan - quan;

            warehouse = new DTA_Warehouse(g.getID(), new_quan);
            return warehouse.edit_();
        }
        public void update_warehouse(DataTable listGoods, int index_quan_listGoods)
        {
            foreach(DataRow dr in listGoods.Rows)
            {
                g.setID(dr[0].ToString()); // new id of goods at index 0
                int quan = int.Parse(dr[index_quan_listGoods].ToString());
                this.updateQuan_m(quan);
            }
        }
    }
}
