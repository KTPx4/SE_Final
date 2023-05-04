using SEFinal.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SEFinal.DTA
{
    public class DTA_Agent
    {
        private C_Agent ag;
        private Connection cn;
        public DTA_Agent()
        {
            cn = new Connection();
            ag = new C_Agent();
        }
        public DTA_Agent(string agtID, string agtName, string phone, string address, string user, string pass, int is_delete)
        {
            cn = new Connection();
            ag = new C_Agent(agtID, agtName, phone, address, user, pass, is_delete);
        }

        public bool check_parameter()
        {
            if(ag.AgentID.Length > 10 || ag.AgentID == "")
            {
                return false;
            }
            else if (ag.AgentName.Length > 200 || ag.AgentName == "")
            {
                return false;
            }
            else if (ag.Phone.Length > 10 || ag.Phone == "")
            {
                return false;
            }
            else if (ag.Address.Length > 200 || ag.Address == "")
            {
                return false;
            }
            else if (ag.User.Length > 200 || ag.User == "")
            {
                return false;
            }
            else if (ag.Pass.Length > 200 || ag.Pass == "")
            {
                return false;
            }
            return true;
        }


        public bool add_()
        {
            bool isExists_id = cn.is_Exists_data("Agent", "AgentID", ag.AgentID);
            bool isExists_user = cn.is_Exists_data("Agent", "Users", ag.User); // set unique for user
            if (isExists_id || isExists_user)
            {
                return false;
            }
            string s = $"insert into Agent values('{ag.AgentID}', '{ag.AgentName}', '{ag.Phone}', '{ag.Address}', '{ag.User}', '{ag.Pass}', {ag.is_deleted})";
            cn.actionQuery(s);

            return true;
        }
            
        public bool delete_()
        {
            bool isExists = cn.is_Exists_data("Agent", "AgentID", ag.AgentID);
            if (!isExists)
            {
                return false;
            }
            string s = $"update Agent set is_deleted = 1 where AgentID='{ag.AgentID}'";
            cn.actionQuery(s);
            return true;
        }

        public bool edit()
        {
            bool isExists = cn.is_Exists_data("Agent", "AgentID", ag.AgentID);
            if (!isExists)
            {
                return false;
            }
            string s = $"update Agent set AgentName= '{ag.AgentName}', Phone ='{ag.Phone}', Address ='{ag.Address}',Users = '{ag.User}', Pass = '{ag.Pass}', is_deleted={ag.is_deleted} where AgentID='{ag.AgentID}'"; 
            cn.actionQuery(s);
            return true;
        }
       
        public string getNextID_(string defaultID)
        {
            return cn.getID("AgentID", "Agent", defaultID);
        }
      
        public string getID()
        {
            return ag.AgentID;
        }
        public void setID(string id)
        {
            ag.AgentID = id;
        }
        public string getName()
        {
            return ag.AgentName;
        }
        public string getUser()
        {
            return ag.User;
        }
        public bool isExists()
        {
            return cn.is_Exists_data("Agent", "AgentID", ag.AgentID);
        }
        public DataTable Query(string s)
        {
            return cn.selectQuery(s);
        }

        public bool is_old_()
        {
            //MessageBox.Show("" + ac.AName + " " + ac.AUser + " " + ac.APassword);
            string s = $"select * from Agent where AgentName='{ag.AgentName}' and Users='{ag.User}' and is_deleted= 1";
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
    }
}
