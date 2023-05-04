using SEFinal.DTA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SEFinal.BUS
{
    public class BUS_Acoountant
    {
        private DTA_Accountant a;
        
        public BUS_Acoountant()
        {
            a = new DTA_Accountant();
        }

        public BUS_Acoountant(string aID, string aName, string aUser, string aPass, int isDel)
        {
            a = new DTA_Accountant(aID, aName, aUser, aPass, isDel);
        }

        public BUS_Acoountant(string user, string pass)
        {
            a = new DTA_Accountant("", "", user, pass, 0);
        }
        public BUS_Acoountant(string id)
        {
            a = new DTA_Accountant(id, "", "", "", 0);
        }

        public string is_Accountant()
        {
            return a.is_Accountant();            
        }

        public string getID_from_User() // get ID from user and pass
        {
            return a.ID_from_User();
        }

        public int checkAdd()
        {
            if (a.getID_() == "" || a.getUser_() == "" || a.getPass_() == "")
            {
                return -1; // -1 for error null values
            }
            else if (a.is_old_Accountant())
            {
                return 0; // 0 for message confirm is add new or restore
            }
            else if (a.is_Exists())
            {
                return 2; // 2 for exists id or user (that not was deleted)
            }
            else
            {              
                return 1; // 1 for success add rows
            }
        }

        public bool add()
        {
            if(!a.check_parameter())
            {
                return false;
            }
            return a.add_();
            
        }

        public bool delete()
        {
           return  a.delete_();
        }

        public bool edit()
        {
            if (!a.check_parameter())
            {
                return false;
            }
            return a.edit_();
        }

        public bool restore()
        {
            if (!a.check_parameter())
            {
                return false;
            }
            string id = this.getID_from_User();
            return a.update_status("AID", id, "is_deleted", 0);
        }

        public DataTable getALL()
        {
            string s = $"select AID, AName, AUser, Apass from Accountant where is_deleted = 0";
            return a.Query(s);
        }

        public string get_Next_ID()
        {
            return a.getNextID_("A0001");
        }
       
    }
}
