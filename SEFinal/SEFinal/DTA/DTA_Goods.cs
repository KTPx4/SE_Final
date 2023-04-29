using SEFinal.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEFinal.DTA
{
    public class DTA_Goods
    {
        private C_Goods gs;
        private Connection cn;
        
        public DTA_Goods()
        {
            cn = new Connection();
            gs = new C_Goods();
        }
        public DTA_Goods(string goodsID, string goodsName, string unit, double price, string country, int is_delete)
        {
            cn = new Connection();
            gs = new C_Goods(goodsID, goodsName, unit, price, country, is_delete);
        }

        public bool add_()
        {
            bool isExists_id = cn.is_Exists_data("Goods", "GoodsID", gs.GoodsID);
            
            if (isExists_id)
            {
                return false;
            }
            string s = $"insert into Goods values( '{gs.GoodsID}', '{gs.GoodsName}', '{gs.Unit}', {gs.Price}, '{gs.Country}', {gs.is_deleted})";
            cn.actionQuery(s);
            return true;

        }


        public bool delete_()
        {
            bool isExists_id = cn.is_Exists_data("Goods", "GoodsID", gs.GoodsID); // if id not exists in goods -> can not delete
                      

            if (!isExists_id )
            {
                return false;

            }
            string s = $"update Goods set is_deleted = 1 where GoodsID='{gs.GoodsID}'";
  
            cn.actionQuery(s);
            return true;
        }

        public bool edit_()
        {
            bool isExists_id = cn.is_Exists_data("Goods", "GoodsID", gs.GoodsID); // Not Exists => not edit 
            if (!isExists_id)
            {
                return false;
            }
            string s = $"update Goods set GoodsName= '{gs.GoodsName}', Unit= '{gs.Unit}' , Price = {gs.Price}, Country = '{gs.Country}', is_deleted={gs.is_deleted} where GoodsID='{gs.GoodsID}'";
            cn.actionQuery(s);
            return true;
        }

        public string getNextID_(string defaultID) // return next id of table in db
        {
            return cn.getID("GoodsID", "Goods", defaultID);
        }

        public string getID()
        {
            return gs.GoodsID;
        }
    }
}
