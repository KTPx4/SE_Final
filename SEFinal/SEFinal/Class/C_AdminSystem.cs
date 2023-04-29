using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEFinal.Class
{
    public class C_AdminSystem
    {
        public string AdminID { get; set; }
        public string AdminName { get; set; }
        public string AdminUser { get; set; }
        public string AdminPassword { get; set; }

        public C_AdminSystem()
        {
            this.AdminID = "";
            this.AdminName = "";
            this.AdminUser = "";
            this.AdminPassword = "";
        }
        public C_AdminSystem(string id, string name, string user, string pass)
        {
            this.AdminID = id;
            this.AdminName = name;
            this.AdminUser = user;
            this.AdminPassword = pass;
        }

    }
}
