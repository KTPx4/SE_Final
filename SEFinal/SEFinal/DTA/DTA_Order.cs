using SEFinal.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEFinal.DTA
{
    public class DTA_Order
    {
        private Connection cn;
        private C_Order o;

        public DTA_Order()
        {
            cn = new Connection();
            o = new C_Order();
        }
        public DTA_Order(string orderID, string agentID, string oDate, string paymentID, double totalAmount)
        {
            cn = new Connection();
            o = new C_Order(orderID, agentID, oDate, paymentID, totalAmount);
        }

        public bool add_()
        {
            bool isExists_id = cn.is_Exists_data("[Order]", "OrderID", o.OrderID);
            if (isExists_id)
            {
                return false;
            }
            string s = $"insert into [Order] values('{o.OrderID}', '{o.AgentID}', '{o.ODate}', '{o.PaymentID}', {o.TotalAmount})";
            cn.actionQuery(s);
            return true;

        }
        public bool delete_()
        {
            bool isExists_id = cn.is_Exists_data("[Order]", "OrderID", o.OrderID);
            if (!isExists_id)
            {
                return false;
            }
            string s = $"delete from [Order] where OrderID ='{o.OrderID}'";
            cn.actionQuery(s);
            return true;
        }

        public bool edit_()
        {
            bool isExists_id = cn.is_Exists_data("[Order]", "OrderID", o.OrderID);
            if (!isExists_id)
            {
                return false;
            }
            string s = $"update from [Order] set AgentID='{o.AgentID}', Odate='{o.ODate}', PaymentID='{o.PaymentID}', TotalAmount={o.TotalAmount} where OrderID='{o.OrderID}'";
            cn.actionQuery(s);
            return true;
        }

        public string getNextID_() // return next id in db
        {
            return cn.getID("OrderID", "[Order]", "O0001");
        }

        public string getID()
        {
            return o.OrderID;
        }
    }
}
