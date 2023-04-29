using SEFinal.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEFinal.DTA
{
    public class DTA_AdminSystem
    {
        private Connection cn;
        private C_AdminSystem ad;
        
        public DTA_AdminSystem()
        {
            cn = new Connection();
            ad = new C_AdminSystem();
        }
        public DTA_AdminSystem(string id, string name, string user, string pass)
        {
            cn = new Connection();
            ad = new C_AdminSystem(id, name, user, pass);
        }

        public string is_Accountant() // check accountant is true user and pass
        {
            string s = $"select name from AdminSystem where users='{ad.AdminUser}' and pass='{ad.AdminPassword}'";
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
    }
}
