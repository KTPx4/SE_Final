using SEFinal.DTA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
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

        public DataTable getMonth(string month)
        {
           string s = $"select* from GoodsDelivery where month(DeliveryDate) = '{month}' and (status = 0 or status = 1)";
            return d.Query(s);
        }
        public DataTable getMonth(string month, string top)
        {
            string s = $"select Top {top} * from GoodsDelivery where month(DeliveryDate) = '{month}'  and (status = 0 or status = 1)";
            return d.Query(s);
        }

        public DataTable getYear(string year)
        {
            string s = $"select* from GoodsDelivery where Year(DeliveryDate) = '{year} and (status = 0 or status = 1)";
            return d.Query(s);
        }
        public DataTable getYear(string year, string top)
        {
            string s = $"select Top {top} * from GoodsDelivery where Year(DeliveryDate) = '{year}'  and (status = 0 or status = 1)";
            return d.Query(s);
        }


        public DataTable getMonth_Year(string month, string year) 
        {
            string s = $"select* from GoodsDelivery where month(DeliveryDate) = '{month}' and year(DeliveryDate)= '{year}' and (status = 0 or status = 1)";
            return d.Query(s);
        }
                
        public DataTable getMonth_Year(string month, string year, string top)
        {
            string s = $"select Top {top} * from GoodsDelivery where month(DeliveryDate) = '{month}' and year(DeliveryDate)= '{year}' and (status = 0 or status = 1)";
            return d.Query(s);
        }

        
    }
}
