﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SEFinal.Class
{
    public class C_Accountant
    {
        public string AID { get; set; }
        public string AName { get; set; }
        public string AUser { get; set; }
        public string APassword { get; set; }

        public C_Accountant()
        {
            this.AID = "";
            this.AName = "";
            this.AUser = "";
            this.APassword = "";
        }

        public C_Accountant(string aID, string aName, string aUser, string aPass)
        {
            this.AID = aID;
            this.AName = aName;
            this.AUser = aUser;
            this.APassword = aPass;
        }
    }
}
