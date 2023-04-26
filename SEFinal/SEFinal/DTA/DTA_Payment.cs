using SEFinal.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEFinal.DTA
{
    public class DTA_Payment
    {
        private Connection cn;
        private C_Payment p;

        public DTA_Payment()
        {
            cn = new Connection();
            p = new C_Payment();
        }

        public DTA_Payment(string paymentID, string name)
        {
            cn = new Connection();
            p = new C_Payment(paymentID, name);
        }

        public bool add_()
        {
            bool isExists_id = cn.is_Exists_data("Payment", "PaymentID",  p.PaymentID);

            if (isExists_id)
            {
                return false;
            }
            string s = $"insert into Payment values('{p.PaymentID}', '{p.Name}')";
            cn.actionQuery(s);
            return true;

        }

        public bool delete_()
        {
            bool isExists_id = cn.is_Exists_data("Payment", "PaymentID", p.PaymentID);
            if (!isExists_id)
            {
                return false;
            }
            string s = $"delete from Payment where PaymentID='{p.PaymentID}'";
            cn.actionQuery(s);
            return true;
        }

        public bool edit_()
        {
            bool isExists_id = cn.is_Exists_data("Payment", "PaymentID", p.PaymentID);
            if (!isExists_id)
            {
                return false;
            }
            string s = $"update from Payment set Name='{p.Name}' where PaymentID='{p.PaymentID}'";
            cn.actionQuery(s);
            return true;
        }

        public string getNextID_() // return next id of table in db
        {
            return cn.getID("PaymentID", "Payment", "P0001");
        }

        public string getID()
        {
            return p.PaymentID;
        }


    }
}
