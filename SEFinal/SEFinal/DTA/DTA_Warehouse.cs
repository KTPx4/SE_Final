using SEFinal.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEFinal.DTA
{
    public class DTA_Warehouse
    {
        private Connection cn;
        private C_Warehouse w;

        public DTA_Warehouse() 
        {
            cn = new Connection();
            w = new C_Warehouse();
        }
        public DTA_Warehouse(string goodsID, int quan)
        {
            cn = new Connection();
            w = new C_Warehouse(goodsID, quan);
        }

        public bool add_()
        {
            bool isExists_id = cn.is_Exists_data("Goods", "GoodsID", w.GoodsID); // foreign key, if in table primary not exists -> can not insert for foreign key
            bool isExists_wareh = cn.is_Exists_data("Warehouse", "GoodsID", w.GoodsID);

            if (!isExists_id || isExists_wareh)
            {
                return false;
            }
            string s = $"insert into Warehouse values('{w.GoodsID}', {w.Quan})";
            cn.actionQuery(s);
            return true;

        }

        public bool delete_()
        {
            bool isExists_id = cn.is_Exists_data("Warehouse", "GoodsID", w.GoodsID);
            if (!isExists_id)
            {
                return false;
            }
            string s = $"delete from Warehouse where GoodsID='{w.GoodsID}'";
            cn.actionQuery(s);
            return true;
        }

        public bool edit_()
        {
            bool isExists_id = cn.is_Exists_data("Warehouse", "GoodsID", w.GoodsID);
            if (!isExists_id)
            {
                return false;
            }
            string s = $"update from Warehouse set quan={w.Quan} where GoodsID='{w.GoodsID}'";
            cn.actionQuery(s);
            return true;
        }

     
    }
}
