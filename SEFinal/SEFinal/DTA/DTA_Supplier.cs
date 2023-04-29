using SEFinal.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEFinal.DTA
{
    public class DTA_Supplier
    {
        private Connection cn;
        private C_Supplier p;


        public DTA_Supplier()
        {
            cn = new Connection();
            p = new C_Supplier();
        }
        public DTA_Supplier(string supId, string name, string address, string phone, int is_deleted)
        {
            cn = new Connection();
            p = new C_Supplier(supId, name, address, phone, is_deleted);
        }

        public bool add_()
        {
            bool isExists_id = cn.is_Exists_data("Supplier", "SupID", p.SupId);

            if (isExists_id)
            {
                return false;
            }
            string s = $"insert into Supplier values('{p.SupId}', '{p.Name}', '{p.Address}', '{p.Phone}', {p.is_deleted})";
            cn.actionQuery(s);
            return true;

        }

        public bool delete_()
        {
            bool isExists_id = cn.is_Exists_data("Supplier", "SupID", p.SupId);
            if (!isExists_id)
            {
                return false;
            }
            string s = $"update Supplier set is_deleted= 1 where SupID='{p.SupId}'";

            cn.actionQuery(s);
            return true;
        }

        public bool edit_()
        {
            bool isExists_id = cn.is_Exists_data("Supplier", "SupID", p.SupId);
            if (!isExists_id)
            {
                return false;
            }
            string s = $"update Supplier set  Name='{p.Name}', address='{p.Address}', phone='{p.Phone}', is_deleted={p.is_deleted} where SupID='{p.SupId}'";
            cn.actionQuery(s);
            return true;
        }

        public string getNextID_(string defaultID) // return next id of table in db
        {
            return cn.getID("SupID", "Supplier", defaultID);
        }

        public string getID()
        {
            return p.SupId;
        }

    }
}
