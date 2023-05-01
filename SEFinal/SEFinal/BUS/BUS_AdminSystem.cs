using SEFinal.DTA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEFinal.BUS
{
    public class BUS_AdminSystem
    {
        private DTA_AdminSystem ad;
        
        public BUS_AdminSystem() 
        {
            ad = new DTA_AdminSystem();
        }
        public BUS_AdminSystem(string id, string name, string user, string pass)
        {
            ad = new DTA_AdminSystem(id, name , user, pass);
        }
        public BUS_AdminSystem(string user, string pass)
        {
            ad = new DTA_AdminSystem("", "", user, pass);
        }

        public string is_Accountant() // check accountant is true user and pass
        { 
            return ad.is_Accountant();
        }
    }
}
