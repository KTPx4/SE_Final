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

        public DTA_Payment(string paymentID, string name, int is_Del)
        {
            cn = new Connection();
            p = new C_Payment(paymentID, name, is_Del);
        }

        public bool add_()
        {
            bool isExists_id = cn.is_Exists_data("Payment", "PaymentID",  p.PaymentID);

            if (isExists_id)
            {
                return false;
            }
            string s = $"insert into Payment values('{p.PaymentID}', '{p.Name}', {p.is_deleted})";
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
            string s = $"update Payment set is_deleted = 1 where PaymentID='{p.PaymentID}'";
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
            string s = $"update Payment set Name='{p.Name}', is_deleted={p.is_deleted} where PaymentID='{p.PaymentID}'";
            cn.actionQuery(s);
            return true;
        }

        public string getNextID_(string defaultID) // return next id of table in db
        {
            return cn.getID("PaymentID", "Payment", defaultID);
        }

        public string getID()
        {
            return p.PaymentID;
        }


    }
}
