using SEFinal.Class;
using SEFinal.DTA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEFinal.BUS
{
    public class BUS_Supplier
    {
        private DTA_Supplier sup;

        public BUS_Supplier()
        {
            sup = new DTA_Supplier();
        }
        public BUS_Supplier(string supId, string name, string address, string phone)
        {
            sup = new DTA_Supplier(supId, name, address, phone, 0);
        }
        public BUS_Supplier(string id)
        {
            sup = new DTA_Supplier(id, "", "", "", 0);
        }

        public string get_Next_ID()
        {
            return sup.getNextID_("S0001"); // get next iD, if not have id, default id is S0001
        }

        public bool add()
        {
            if (!sup.check_parameter())
            {
                return false;
            }
            return sup.add_();
        }

        public bool edit()
        {
            if(!sup.check_parameter())
            {
                return false;
            }

            return sup.edit_();
        }

        public bool delete()
        {
            return sup.delete_();            
        }

        public DataTable getALL()
        {
            string s = $"select SupID, Name,Address,Phone from Supplier where is_deleted = 0";
            return sup.Query(s);
        }

        public int checkAdd()
        {

            if (sup.is_old_())
            {
                return 0; // 0 for message confirm is add new or restore
            }
            else if (sup.isExists())
            {
                return 2;
            }
            else
            {
                return 1; // 1 for valid add rows
            }
        }

        public string getID_from_Name()
        {
            string s = $"select SupID from Supplier where Name='{sup.getName()}' and is_deleted = 1";
            DataTable tb = sup.Query(s);
            if (tb.Rows.Count < 1)
            {
                return "";
            }
            return tb.Rows[0][0].ToString();
        }

        public bool restore()
        {
            //string s = $"update Goods set is_deleted = 0 where GoodsID = '{id}'";
            //g.QueryAction(s);
            //warehouse = new DTA_Warehouse(id, 0);
            string id = this.getID_from_Name();
            sup.setID(id);
            if(!sup.check_parameter())
            {
                return false;
            }
            return sup.edit_(); ;
        }
    }
}
