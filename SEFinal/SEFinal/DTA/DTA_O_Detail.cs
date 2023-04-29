using System;
using System.Collections.Generic;
using SEFinal.Class;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEFinal.DTA
{
    public class DTA_O_Detail // it not use in winform so not have necessary complete full
    {
        private Connection cn;
        private C_O_Detail o;

        public DTA_O_Detail()
        {
            cn = new Connection();
            o = new C_O_Detail();
        }
        public DTA_O_Detail(string detailID, string orderID, string goodsID, int quantity)
        {
            cn = new Connection();
            o = new C_O_Detail(detailID, orderID, goodsID, quantity);
        }
        /*
        public bool add_()
        {
            bool isExists_id = cn.is_Exists_data("OrderDetail", "DetailID", o.DetailID);
            bool isExists_idOder = cn.is_Exists_data("[Order]", "OrderID", o.OrderID); // id order not exists in table order-> false

            if (isExists_id || !isExists_idOder)
            {
                return false;
            }
            string s = $"insert into OrderDetail values('{o.DetailID}', '{o.OrderID}', '{o.GoodsID}', {o.Quantity})";
            cn.actionQuery(s);
            return true;

        }
        public bool delete_()
        {
            bool isExists_id = cn.is_Exists_data("OrderDetail", "DetailID", o.DetailID);
            if (!isExists_id)
            {
                return false;
            }
            string s = $"delete from OrderDetail where DetailID= '{o.DetailID}'" ;
            cn.actionQuery(s);
            return true;
        }

        public bool edit_()
        {
            bool isExists_id = cn.is_Exists_data("OrderDetail", "DetailID", o.DetailID);
            if (!isExists_id)
            {
                return false;
            }
            string s = $"update OrderDetail set OrderID ='{o.OrderID}', GoodsID='{o.GoodsID}', Quantity={o.Quantity} where DetailID='{o.DetailID}'";
            cn.actionQuery(s);
            return true;
        }

        public string getNextID_(string defaultID) // return next id in db
        {
            return cn.getID("DetailID", "OrderDetail", defaultID    );
        }
        */
        
        
        public string getID()
        {
            return o.DetailID;
        }
    }
}
