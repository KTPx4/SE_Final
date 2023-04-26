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
        public DTA_Goods(string goodsID, string goodsName, string unit, double price, string country)
        {
            cn = new Connection();
            gs = new C_Goods(goodsID, goodsName, unit, price, country);
        }

        public bool add_()
        {
            bool isExists_id = cn.is_Exists_data("Goods", "GoodsID", gs.GoodsID);
            
            if (isExists_id)
            {
                return false;
            }
            string s = $"insert into Goods values( '{gs.GoodsID}', '{gs.GoodsName}', '{gs.Unit}', {gs.Price}, '{gs.Country}' )";
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

            bool isExists_wareh = cn.is_Exists_data("Warehouse", "GoodsID", gs.GoodsID); // if exists values in tb warehouse(foreign key) -> delete it before delete in table contain primary key
            bool isExists_OD = cn.is_Exists_data("OrderDetail", "GoodsID", gs.GoodsID); // if exists values in tb OrderDetail(foreign key) -> delete it before delete in table contain primary key
            bool isExists_RD = cn.is_Exists_data("GoodsReceiptDetail", "GoodsID", gs.GoodsID); // if exists values in tb GoodsReceiptDetail(foreign key) -> delete it before delete in table contain primary key

            // Code here -> delete foreign key, up date total amount (if any)


            string s = $"delete from Goods where GoodsID = '{gs.GoodsID}'";
            cn.actionQuery(s);
            return true;
        }

        public bool edit_()
        {
            bool isExists_id = cn.is_Exists_data("Goods", "GoodsID", gs.GoodsID);
            if (!isExists_id)
            {
                return false;
            }
            string s = $"update from Goods set GoodsName= '{gs.GoodsName}', Unit= '{gs.Unit}' , Price = {gs.Price}, Country = '{gs.Country}' where GoodsID='{gs.GoodsID}'";
            cn.actionQuery(s);
            return true;
        }

        public string getNextID_() // return next id of table in db
        {
            return cn.getID("GoodsID", "Goods", "G0001");
        }

        public string getID()
        {
            return gs.GoodsID;
        }
    }
}
