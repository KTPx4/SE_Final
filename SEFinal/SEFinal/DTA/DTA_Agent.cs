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
        public DTA_Agent(string agtID, string agtName, string phone, string address, string user, string pass)
        {
            cn = new Connection();
            ag = new C_Agent(agtID, agtName, phone, address, user, pass);
        }

        //public DTA_Agent(string agtName, string phone, string address, string user, string pass)
        //{
        //    cn = new Connection();
        //    string agtID = cn.getID("AgentID", "Agent", "AG0001");
        //    ag = new C_Agent(agtID, agtName, phone, address, user, pass);
        //}

        public bool add_()
        {
            bool isExists_id = cn.is_Exists_data("Agent", "AgentID", ag.AgentID);
            bool isExists_user = cn.is_Exists_data("Agent", "Users", ag.User);
            if (isExists_id || isExists_user)
            {
                return false;
            }
            string s = "insert into Agent values('" + ag.AgentID + "', '"+ 
                ag.AgentName+"', '"+ag.Phone+"', '"+ag.Address+"', '"+ag.User+"', '"+ag.Pass+ "')";
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
            string s = "detele from Agent where ";
            cn.actionQuery(s);
            return true;
        }

        public bool edit_()
        {
            bool isExists = cn.is_Exists_data("Agent", "AgentID", ag.AgentID);
            if (!isExists)
            {
                return false;
            }
            string s = "update Agent set AName= '" +  ag.AgentName + "', Phone ='" + ag.Phone + "', Address ='" +
                        ag.Address + "',Users = '" + ag.User + "', Pass = '" + ag.Pass + "' where AgentID='" + ag.AgentID+"'"; 
            cn.actionQuery(s);
            return true;
        }
       
        public string getNextID_()
        {
            return cn.getID("AgentID", "Agent", "AG0001");
        }
      
        public string getID_()
        {
            return ag.AgentID;
        }
    }
}
