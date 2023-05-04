using SEFinal.DTA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEFinal.BUS
{
    public class BUS_Agent
    {
        private DTA_Agent ag;

        public BUS_Agent()
        {
            ag = new DTA_Agent();
        }
        public BUS_Agent(string agtID, string agtName, string phone, string address, string user, string pass)
        {
            ag = new DTA_Agent(agtID, agtName, phone, address, user, pass, 0);
        }
        public BUS_Agent(string id)
        {
            ag = new DTA_Agent(id, "", "", "", "", "", 0);
        }

        public string get_Next_ID()
        {
            return ag.getNextID_("AG0001"); // get next iD, if not have id, default id is S0001
        }

        public bool add()
        {
            if (!ag.check_parameter())
            {
                return false;
            }
            return ag.add_();
        }

        public bool edit()
        {
            if (!ag.check_parameter())
            {
                return false;
            }

            return ag.edit();
        }

        public bool delete()
        {
            return ag.delete_();
        }

        public DataTable getALL()
        {
            string s = $"select AgentID, AgentName,Phone,Address, Users, Pass from Agent where is_deleted = 0";
            return ag.Query(s);
        }

        public int checkAdd()
        {

            if (ag.is_old_())
            {
                return 0; // 0 for message confirm is add new or restore
            }
            else if (ag.isExists())
            {
                return 2;
            }
            else
            {
                return 1; // 1 for valid add rows
            }
        }

        public string getID_from_User_Name()
        {
            string s = $"select AgentID from Agent where AgentName='{ag.getName()}' and Users='{ag.getUser()}' and is_deleted = 1";
            DataTable tb = ag.Query(s);
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
            string id = this.getID_from_User_Name();
            ag.setID(id);
            if (!ag.check_parameter())
            {
                return false;
            }
            return ag.edit(); ;
        }

        public DataTable getStatus()
        {
            string s = "select o.OrderID, a.agentID, a.AgentName, o.Odate, p.Status  from [order] o, PaymentDetail p, Agent a where p.orderID = o.orderID and o.AgentID = a.AgentID";
            return ag.Query(s);
        }
       
      
       
    }
}
