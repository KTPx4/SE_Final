﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEFinal.Class
{
    public class C_Agent
    {
        public string AgentID { get; set; }
        public string AgentName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string User { get; set; }
        public string Pass { get; set; }

        public C_Agent()
        {
            this.AgentID = "";
            this.AgentName = "";
            this.Phone = "";
            this.Address = "";
            this.User = "";
            this.Pass = "";
        }

        public C_Agent(string agtID, string agtName, string phone, string address, string user, string pass)
        {
            this.AgentID = agtID;
            this.AgentName = agtName;
            this.Phone = phone;
            this.Address = address;
            this.User = user;
            this.Pass = pass;
        }
    }
}
