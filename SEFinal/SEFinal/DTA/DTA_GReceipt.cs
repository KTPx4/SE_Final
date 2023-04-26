using SEFinal.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEFinal.DTA
{
    public class DTA_GReceipt
    {
        private C_GReceipt gr;
        private Connection cn;

        public DTA_GReceipt()
        {
            cn = new Connection();
            gr = new C_GReceipt();
        }
        public DTA_GReceipt(string receiptID, string receiptDate, string supID, string employee, double totalAmount)
        {
            cn = new Connection();
            gr = new C_GReceipt(receiptID, receiptDate, supID, employee, totalAmount);
        }

        public bool add_()
        {
            bool isExists_id = cn.is_Exists_data("GoodsReceipt", "ReceiptID", gr.ReceiptID);

            if (isExists_id)
            {
                return false;
            }
            string s = $"insert into GoodsReceipt values('{gr.ReceiptID}', '{gr.ReceiptDate}', '{gr.SupID}', '{gr.Employee}', {gr.TotalAmount})";
            cn.actionQuery(s);
            return true;

        }

        public bool delete_()
        {
            bool isExists_id = cn.is_Exists_data("GoodsReceipt", "ReceiptID", gr.ReceiptID);
            if (!isExists_id)
            {
                return false;
            }
            string s = $"detele from GoodsReceipt where ReceiptID='{gr.ReceiptID}'";
            cn.actionQuery(s);
            return true;
        }

        public bool edit_()
        {
            bool isExists_id = cn.is_Exists_data("GoodsReceipt", "ReceiptID", gr.ReceiptID);
            if (!isExists_id)
            {
                return false;
            }
            string s = $"update from GoodsReceipt set ReceiptDate='{gr.ReceiptDate}', SupID ='{gr.SupID}', Employee ='{gr.Employee}', TotalAmount={gr.TotalAmount} where ReceiptID='{gr.ReceiptID}'";
            cn.actionQuery(s);
            return true;
        }

        public string getNextID_() // return next id of table in db
        {
            return cn.getID("ReceiptID", "GoodsReceipt", "GR0001");
        }

        public string getID()
        {
            return gr.ReceiptID;
        }


    }
}
