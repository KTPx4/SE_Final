using System;
using System.Collections.Generic;
using SEFinal.Class;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEFinal.DTA
{
    public class DTA_O_Detail
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

        public bool add_()
        {
            bool isExists_id = cn.is_Exists_data("OrderDetail", "DetailID", o.DetailID);           
            if (isExists_id)
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
            string s = $"update from OrderDetail set OrderID ='{o.OrderID}', GoodsID='{o.GoodsID}', Quantity={o.Quantity} where DetailID='{o.DetailID}'";
            cn.actionQuery(s);
            return true;
        }

        public string getNextID_() // return next id in db
        {
            return cn.getID("DetailID", "OrderDetail", "OD0001");
        }

        public string getID()
        {
            return o.DetailID;
        }
    }
}
