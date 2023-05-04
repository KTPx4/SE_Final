using SEFinal.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEFinal.DTA
{
    public class DTA_Accountant
    {
        private C_Accountant ac;
        private Connection cn;
        public DTA_Accountant()
        {
            cn = new Connection();
            ac = new C_Accountant();
        }
        public DTA_Accountant(string aID, string aName, string aUser, string aPass, int isDel)
        {
            cn = new Connection();
            ac = new C_Accountant(aID, aName, aUser, aPass, isDel);
        }
        public bool check_parameter()
        {
            if(ac.AID.Length > 10 || ac.AID == "")
            {
                return false;
            }
            else if(ac.AName.Length > 200 || ac.AName == "")
            {
                return false;
            }
            else if (ac.AUser.Length > 200 || ac.AUser == "")
            {
                return false;
            }
            else if (ac.APassword.Length > 200 || ac.APassword == "")
            {
                return false;
            }
            return true;
        }
        public bool is_Exists()
        {
            bool isExists_id = cn.is_Exists_data("Accountant", "AID", ac.AID);
            bool isExists_user = cn.is_Exists_data("Accountant", "Auser", ac.AUser); // check unique for user
            if(isExists_id || isExists_user)
            {
                return true;
            }
            return false;
        }
        public bool add_()
        {
            bool isExists_id = cn.is_Exists_data("Accountant", "AID", ac.AID);
            bool isExists_user = cn.is_Exists_data("Accountant", "Auser", ac.AUser); // check unique for user
            if (isExists_id || isExists_user)
            {
                return false;
            }
            string s = $"insert into Accountant values('{ac.AID}', '{ac.AName}', '{ac.AUser}', '{ac.APassword}', {ac.is_deleted})";
            cn.actionQuery(s);
            return true;

        }

        public bool delete_()
        {
            bool isExists = cn.is_Exists_data("Accountant", "AID", ac.AID);
            if (!isExists)
            {
                return false;
            }
            string s = $"update Accountant set is_deleted = 1 where AID ='{ac.AID}'"; // hide accountant when delete
            cn.actionQuery(s);
            return true;
        }
        
        public bool edit_()
        {
            bool isExists = cn.is_Exists_data("Accountant", "AID", ac.AID);
            bool isExists_user = cn.is_Exists_data("Accountant", "Auser", ac.AUser);
            if (!isExists || isExists_user)
            {
                return false;
            }
            string s = $"update Accountant set AName='{ac.AName}', Auser ='{ac.AUser}', Apass ='{ac.APassword}', is_deleted={ac.is_deleted} where AID ='{ac.AID}'";
            cn.actionQuery(s);
            return true;
        }

        public bool update_status(string fieldID, string id, string fieldStatus, int status)
        {
            bool isExists = cn.is_Exists_data("Accountant", "AID", id);
            if (!isExists)
            {
                return false;
            }
            string s = $"update Accountant set {fieldStatus}='{status}' where {fieldID}='{id}'"; 
            cn.actionQuery(s);
            return true;
        }

        public string getNextID_(string defaultID) // return next id in table of db
        {
            return cn.getID("AID", "Accountant", defaultID);
        }
        
        public string getID_()
        {
            return ac.AID;
        }
        public string getUser_()
        {
            return ac.AUser;
        }

        public string getPass_()
        {
            return ac.APassword;
        }

        public string is_Accountant() // check accountant is true user and pass
        {
           string s = "select AName from Accountant where Auser='" + ac.AUser + "' and Apass = '"+ ac.APassword+"'";
           DataTable tb = cn.selectQuery(s);
            if(tb.Rows.Count < 1)
            {
                return "";
            }
            else
            {
                return tb.Rows[0][0].ToString();
            }
        }

      

        public string ID_from_User()
        {
            string s = "select AID from Accountant where Auser='" + ac.AUser + "'";
            DataTable tb = cn.selectQuery(s);
            if (tb.Rows.Count < 1)
            {
                return "";
            }
            else
            {
                return tb.Rows[0][0].ToString();
            }
        }

        public bool is_old_Accountant() // check account is status is deleted
        {
            //MessageBox.Show("" + ac.AName + " " + ac.AUser + " " + ac.APassword);
            string s = $"select * from Accountant where AName='{ac.AName}' and Auser='{ac.AUser}'  and is_deleted= 1";
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
       

        public DataTable Query(string s)
        {
            return cn.selectQuery(s);
        }
    }
}
