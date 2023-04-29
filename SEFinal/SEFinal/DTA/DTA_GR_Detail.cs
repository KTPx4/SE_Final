using SEFinal.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEFinal.DTA
{
    public class DTA_GR_Detail
    {
        private C_GR_Detail gr;
        private Connection cn;

        public DTA_GR_Detail()
        {

            cn = new Connection();
            gr = new C_GR_Detail();
        }

        public DTA_GR_Detail(string rDID, string receiptID, string goodsID, int quan, double amount)
        {

            cn = new Connection();
            gr = new C_GR_Detail(rDID, receiptID, goodsID, quan, amount);
        }

        public bool add_() // if id is exists in table -> can not to add 2 rows same id
        {
            bool isExists_id = cn.is_Exists_data("GoodsReceiptDetail", "RDID", gr.RDID);

            bool isExists_RID = cn.is_Exists_data("GoodsReceipt", "ReceiptID", gr.ReceiptID);// check exists receipt
            bool isExists_G = cn.is_Exists_data("Goods", "GoodsID", gr.GoodsID, "is_deleted");// check exists goods

            if (isExists_id || !isExists_RID || !isExists_G)
            {
                return false;
            }
            string s = $"insert into GoodsReceiptDetail values( '{gr.RDID}', '{gr.ReceiptID}', '{gr.GoodsID}', {gr.Quan}, {gr.Amount})";
            cn.actionQuery(s);
            return true;
        }

        // if id is not exists in table -> can not edit or delete

        public bool delete_()
        {
            bool isExists_id = cn.is_Exists_data("GoodsReceiptDetail", "RDID", gr.RDID);
            if (!isExists_id)
            {
                return false;
            }
            string s = $"delete from GoodsReceiptDetail where RDID ='{gr.RDID}'";
            cn.actionQuery(s);
            return true;
        }

        public bool edit_()
        {
            bool isExists_id = cn.is_Exists_data("GoodsReceiptDetail", "RDID", gr.RDID);
            bool isExists_RID = cn.is_Exists_data("GoodsReceipt", "ReceiptID", gr.ReceiptID);// check exists receipt
            bool isExists_G = cn.is_Exists_data("Goods", "GoodsID", gr.GoodsID, "is_deleted");// check exists goods

            if (!isExists_id || !isExists_RID || !isExists_G)
            {
                return false;
            }
            string s = $"update  GoodsReceiptDetail set ReceiptID ='{gr.ReceiptID}', GoodsID='{gr.GoodsID}', Quan ={gr.Quan}, Amount = {gr.Amount} where RDID ='{gr.RDID}'";
            cn.actionQuery(s);
            return true;
        }

        public string getNextID_(string defaultID) // return next id of table in db
        {
            return cn.getID("RDID", "GoodsReceiptDetail", defaultID);
        }

        public string getID()
        {
            return gr.RDID;
        }

    }
}
