using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SEFinal.Class
{
    public class C_Accountant
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string User { get; set; }
        public string Password { get; set; }

        public C_Accountant() 
        {
            this.ID = "";
            this.Name = "";
            this.User = "";
            this.Password = "";
        }
        public C_Accountant(string id, string name, string user, string pass)
        {
            this.ID = id;
            this.Name = name;
            this.User = user;
            this.Password = pass;
        }
    }
}
