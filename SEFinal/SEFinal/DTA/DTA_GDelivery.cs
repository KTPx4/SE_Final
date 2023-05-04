using SEFinal.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEFinal.DTA
{
    public class DTA_GDelivery
    {
        private Connection cn;
        private C_GDelivery gd;

        public DTA_GDelivery()
        {
            cn = new Connection();
            gd = new C_GDelivery();
        }
        public DTA_GDelivery(string deliveryID, string orderID, string employee, string deliveryDate, int status)
        {
            cn = new Connection();
            gd = new C_GDelivery(deliveryID, orderID, employee, deliveryDate, status);
        }

        public bool add_()
        {
            bool isExists_id = cn.is_Exists_data("GoodsDelivery", "DeliveryID", gd.DeliveryID); // exists id -> not add new
       
            if (isExists_id )
            {
                return false;
            }
            string s = $"insert into GoodsDelivery values('{gd.DeliveryID}', '{gd.OrderID}', '{gd.Employee}', '{gd.DeliveryDate}', {gd.Status})";
            cn.actionQuery(s);
            return true;

        }
        public DataTable getDelivery() // get delivery with status delivery = 0 or 1
        {
            string s = $"select * from GoodsDelivery where  Status != -1 ";
            return cn.selectQuery(s);
        }
        public bool delete_()
        {
            bool isExists_id = cn.is_Exists_data("GoodsDelivery", "DeliveryID", gd.DeliveryID);
            if (!isExists_id)
            {
                return false;
            }
            string s = $"delete from GoodsDelivery where DeliveryID = '{gd.DeliveryID}'";
            cn.actionQuery(s);
            return true;
        }

        public bool edit_()
        {
            bool isExists_id = cn.is_Exists_data("GoodsDelivery", "DeliveryID", gd.DeliveryID);
            if (!isExists_id)
            {
                return false;
            }
            string s = $"update GoodsDelivery set OrderID='{gd.OrderID}' , " +
                $"Employee = '{gd.Employee}' , DeliveryDate = '{gd.DeliveryDate}', status = {gd.Status} where DeliveryID='{gd.DeliveryID}'";
            cn.actionQuery(s);
            return true;
        }

        public bool set_Status()
        {
            bool isExists_id = cn.is_Exists_data("GoodsDelivery", "DeliveryID", gd.DeliveryID);
            if (!isExists_id)
            {
                return false;
            }
            string s = $"update GoodsDelivery set status = {gd.Status} where DeliveryID='{gd.DeliveryID}'";
            cn.actionQuery(s);
            return true;
        }

        public string getNextID_(string defaultID) // return next id in db
        {
            return cn.getID("DeliveryID", "GoodsDelivery", defaultID);
        }

        public string getID()
        {
            return gd.DeliveryID;
        }
        public string getOrder()
        {
            return gd.OrderID;
        }

        public DataTable Query(string s)
        {
            return cn.selectQuery(s);
        }
        //public string getID_()
        //{
        //    return ac.AID;
        //}
    }
}
