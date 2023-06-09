﻿using SEFinal.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEFinal.DTA
{
    public class DTA_PaymentDetail
    {
        private Connection cn;
        private C_P_Details p;
        public DTA_PaymentDetail() 
        {
            cn = new Connection();
            p = new C_P_Details();
        }
        public DTA_PaymentDetail(string id, string order, int status)
        {
            cn = new Connection();
            p = new C_P_Details(id, order, status);
        }

        public bool set_Status()
        {
            bool is_exists_id = cn.is_Exists_data("PaymentDetail", "OrderID ", p.OrderID);
            if(!is_exists_id) 
            {
                return false;
            }
            string s = $"update PaymentDetail set Status={p.status} where OrderID ='{p.OrderID}'";
            cn.actionQuery(s);
            return true;
        }
    }
}
