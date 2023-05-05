using SEFinal.DTA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SEFinal.BUS
{
    public class BUS_GDelivery
    {
        private DTA_GDelivery d;

        public BUS_GDelivery()
        {
            d = new DTA_GDelivery();
        }
        public BUS_GDelivery(string orderID)
        {
            d = new DTA_GDelivery("", orderID, "", "", 0);
        }
        public BUS_GDelivery(string deliveryID, string orderID, string employee, string deliveryDate, int status)
        {
            d = new DTA_GDelivery(deliveryID, orderID, employee, deliveryDate, status);
        }
        public bool add()
        {
            if(this.is_Exists_Order())
            {
                return false;
            }
            
            return d.add_();
        }

        public string getNextID()
        {
            return d.getNextID_("GD0001");
        }

        public bool is_Exists_Order()
        {
            DataTable data = d.getDelivery();
            string idOrder = d.getOrder();

            foreach(DataRow r in data.Rows)
            {
                if (r[1].ToString() == idOrder) // get id order and compare with id input
                {
                    return true;
                }    

            }
            return false;
        }
        public DataTable getALL()
        {
            string s = $"select* from GoodsDelivery where  status != -1";
            return d.Query(s);
        }
        public DataTable getALLs()
        {
            string s = $"select* from GoodsDelivery";
            return d.Query(s);
        }
        public DataTable getAll(string top)
        {
            string s = $"select Top {top} * from GoodsDelivery where (status = 0 or status = 1)";
            return d.Query(s);
        }
            
        private DataTable Reports(string query_month, string query_year) // report delivery for month or year or both
        {
            string s = "SELECT Goods.GoodsID, Goods.GoodsName, SUM(Quantity) AS TotalGoodsDelivered, DeliveryDate, OrderDetail.OrderID " +
                " FROM GoodsDelivery " +
                " JOIN OrderDetail ON GoodsDelivery.OrderID = OrderDetail.OrderID " +
                " JOIN Goods ON OrderDetail.GoodsID = Goods.GoodsID " +
                " WHERE Status != -1 " + query_month + query_year +
                " GROUP BY Goods.GoodsID, Goods.GoodsName, DeliveryDate, OrderDetail.OrderID" +
                " ORDER BY  OrderDetail.OrderID ASC";

            return d.Query(s);
        }

        private DataTable Report_Tops(string top, string query_month, string query_year)
        {
            string s = "SELECT TOP "+top+ " Goods.GoodsID, Goods.GoodsName, SUM(Quantity) AS TotalGoodsDelivered, DeliveryDate, OrderDetail.OrderID" +
                " FROM GoodsDelivery" +
                " JOIN OrderDetail ON GoodsDelivery.OrderID = OrderDetail.OrderID" +
                " JOIN Goods ON OrderDetail.GoodsID = Goods.GoodsID" +
                " WHERE Status != -1 " + query_month + query_year +
                " GROUP BY Goods.GoodsID, Goods.GoodsName, DeliveryDate, OrderDetail.OrderID" +
                " ORDER BY TotalGoodsDelivered DESC";
            return d.Query(s);

        }



        // report not have top
        /*
        public DataTable  Report_Month(string month) // report follow month
        {
            string quey_month = " AND MONTH(DeliveryDate) = " + month;
            return this.Reports(quey_month, "");
        }

        public DataTable Report_Year(string year) // report follow year
        {
            string quey_year = " AND YEAR(DeliveryDate) = " + year;
            return this.Reports("", quey_year);
        }
        
        public DataTable Report() // get all report not both month and year
        {            
            return this.Reports("", "");
        }
        */

        public DataTable Report(string month, string year) // report follow both month and year
        {
            string query_month = "";
            string query_year = "";
            if(month != "")
            {
                query_month = " AND MONTH(DeliveryDate) = " + month;
            }
            if(year != "")
            {
                query_year = " AND YEAR(DeliveryDate) = " + year;

            }
            return this.Reports(query_month, query_year);
        }




        // report have top

        /*public DataTable Report_Top_Month(string top, string month)
        {
            string query_month = " AND MONTH(DeliveryDate) = " + month;
            return this.Report_Tops(top, query_month, "");
        }
        
        public DataTable Report_Top_Year(string top, string year)
        {
            string query_year = " AND YEAR(DeliveryDate) = " + year;
            return this.Report_Tops(top, "", query_year);
        }

        public DataTable Report_Top(string top)
        {
            return this.Report_Tops(top, "", "");
        }
        */

        public DataTable Report_Top(string top, string month, string year)
        {
            string query_month = "";
            string query_year = "";
            if (month != "") 
            {
                query_month = " AND MONTH(DeliveryDate) = " + month;
            }
            if(year != "")
            {
                query_year = " AND YEAR(DeliveryDate) = " + year;
            }

            return this.Report_Tops(top, query_month, query_year);
        }

        



    }
}
