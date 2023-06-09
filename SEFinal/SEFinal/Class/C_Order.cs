﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEFinal.Class
{
    public class C_Order
    {
        public string OrderID { get; set; }
        public string AgentID { get; set; }
        public string ODate { get; set; }
        public string PaymentID { get; set; }
        public double TotalAmount { get; set; }
        public int is_Hide { get; set; }    

        public C_Order()
        {
            this.OrderID = "";
            this.AgentID = "";
            this.ODate = "";
            this.PaymentID = "";
            this.TotalAmount = 0;
            this.is_Hide = 0;
        }

        public C_Order(string orderID, string agentID, string oDate, string paymentID, double totalAmount, int is_HIDE)
        {
            OrderID = orderID;
            AgentID = agentID;
            ODate = oDate;
            PaymentID = paymentID;
            TotalAmount = totalAmount;
            this.is_Hide = is_Hide;
        }
    }
}
