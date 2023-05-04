using SEFinal.DTA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEFinal.BUS
{
    public class BUS_Order
    {
        private DTA_Order o;
        public BUS_Order() 
        {
            o = new DTA_Order();
        }
        public BUS_Order(string id)
        {
            o = new DTA_Order(id, "", "", "", 0, 0);
        }

        public DataTable getGoods_Delivery()
        {
            string s = $"select g.GoodsID as 'Goods ID', g.GoodsName as 'Goods Name', g.Price, od.Quantity ,g.Price*od.Quantity as 'Amount'" +
                $" from goods g, [order] o, OrderDetail od " +
                $"where o.OrderID = '{o.getID()}' and od.OrderID = o.OrderID and od.GoodsID = g.GoodsID";
            return o.Query(s);
        }

        public DataTable getOrder_from_Payment(string idCash, string idOnline)
        {
            string s = "select o.OrderID from [order] o, PaymentDetail pd , GoodsDelivery gd " +
                "where (gd.Status = -1 and gd.OrderID = o.OrderID)" +
                " or (o.OrderID not in (select gd.OrderID from GoodsDelivery gd) and o.PaymentID ='"+ idCash+"' and pd.OrderID = o.OrderID and pd.Status != -1)" +
                "or (o.OrderID not in (select gd.OrderID from GoodsDelivery gd) and o.PaymentID ='"+idOnline+"' and pd.OrderID = o.OrderID and pd.Status = 1)" +
                        "group by o.OrderID";
            return o.Query(s);
        }
    }
}
