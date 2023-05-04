using SEFinal.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEFinal.DTA
{
    public class DTA_Supplier
    {
        private Connection cn;
        private C_Supplier supp;


        public DTA_Supplier()
        {
            cn = new Connection();
            supp = new C_Supplier();
        }
        public DTA_Supplier(string supId, string name, string address, string phone, int is_deleted)
        {
            cn = new Connection();
            supp = new C_Supplier(supId, name, address, phone, is_deleted);
        }
        public bool check_parameter()
        {
            if (supp.SupId.Length > 10 || supp.SupId == "")
            {
                return false;
            }
            else if (supp.Name.Length > 200 || supp.Name == "")
            {
                return false;
            }
            else if (supp.Address.Length > 100 || supp.Address == "")
            {
                return false;
            }
            else if (supp.Phone.Length > 10 || supp.Phone == "")
            {
                return false;
            }
            return true;
        }

        public string getName()
        {
            return supp.Name;
        }

        public string getID()
        {
            return supp.SupId;
        }

        public void setID(string supId)
        {
            supp.SupId = supId;
        }

       

        public bool add_()
        {
            bool isExists_id = cn.is_Exists_data("Supplier", "SupID", supp.SupId);

            if (isExists_id)
            {
                return false;
            }
            string s = $"insert into Supplier values('{supp.SupId}', '{supp.Name}', '{supp.Address}', '{supp.Phone}', {supp.is_deleted})";
            cn.actionQuery(s);
            return true;

        }

        public bool delete_()
        {
            bool isExists_id = cn.is_Exists_data("Supplier", "SupID", supp.SupId);
            if (!isExists_id)
            {
                return false;
            }
            string s = $"update Supplier set is_deleted= 1 where SupID='{supp.SupId}'";

            cn.actionQuery(s);
            return true;
        }

        public bool edit_()
        {
            bool isExists_id = cn.is_Exists_data("Supplier", "SupID", supp.SupId);
            if (!isExists_id)
            {
                return false;
            }
            string s = $"update Supplier set  Name='{supp.Name}', address='{supp.Address}', phone='{supp.Phone}', is_deleted={supp.is_deleted} where SupID='{supp.SupId}'";
            cn.actionQuery(s);
            return true;
        }


        public string getNextID_(string defaultID) // return next id of table in db
        {
            return cn.getID("SupID", "Supplier", defaultID);
        }
              
        public bool is_old_()
        {
            //MessageBox.Show("" + ac.AName + " " + ac.AUser + " " + ac.APassword);
            string s = $"select * from Supplier where Name='{supp.Name}' and is_deleted= 1";
            DataTable tb = cn.selectQuery(s);
            if (tb.Rows.Count < 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool isExists()
        {
            return cn.is_Exists_data("Supplier", "SupID", supp.SupId);
        }
        public DataTable Query(string s)
        {
            return cn.selectQuery(s);
        }
    }
}
