using SEFinal.Class;
using System;
using System.Collections.Generic;
using System.Data;
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
        public void setTotal(double total)
        {
            gr.TotalAmount= total;
        }
        public bool add_()
        {
            bool isExists_id = cn.is_Exists_data("GoodsReceipt", "ReceiptID", gr.ReceiptID);
            bool isExists_sup = cn.is_Exists_data("Supplier", "SupID", gr.SupID, "is_deleted");// check suplier
            bool isExists_emp = cn.is_Exists_data("Accountant", "AID", gr.Employee, "is_deleted");// check employee

            if (isExists_id || !isExists_sup || !isExists_emp)
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

            // if in table detail have id of Receip-> delete detail before delete receipt (foreign key)
            bool isExists_detail = cn.is_Exists_data("GoodsReceiptDetail", "ReceiptID", gr.ReceiptID);
            if (isExists_id)
            {
                string d = $"detele from GoodsReceiptDetail where ReceiptID='{gr.ReceiptID}'";
                cn.actionQuery(d);
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
            string s = $"update GoodsReceipt set ReceiptDate='{gr.ReceiptDate}', SupID ='{gr.SupID}', Employee ='{gr.Employee}', TotalAmount={gr.TotalAmount} where ReceiptID='{gr.ReceiptID}'";
            cn.actionQuery(s);
            return true;
        }

        public string getNextID_(string defaultID) // return next id of table in db
        {
            return cn.getID("ReceiptID", "GoodsReceipt", defaultID);
        }

        public string getID()
        {
            return gr.ReceiptID;
        }
        public DataTable Query(string s)
        {
            return cn.selectQuery(s);
        }

    }
}
