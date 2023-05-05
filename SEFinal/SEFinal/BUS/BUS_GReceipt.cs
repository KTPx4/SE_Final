using SEFinal.DTA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEFinal.BUS
{
    public class BUS_GReceipt
    {
        private DTA_GReceipt r;
        public BUS_GReceipt() 
        {
            r = new DTA_GReceipt();
        }
        public BUS_GReceipt(string id)
        {
            r = new DTA_GReceipt(id, "", "", "", 0);
        }
        public BUS_GReceipt(string receiptID, string receiptDate, string supID, string employee, double totalAmount)
        {
            r = new DTA_GReceipt(receiptID, receiptDate, supID, employee, totalAmount);
        }

        public DataTable getAll()
        {

            string s = "select * from GoodsReceipt";
            return r.Query(s);
        }
        public string getNextID()
        {
            return r.getNextID_("GR0001");
        }

        public bool add()
        {
            return r.add_();
        }
        public bool edit()
        {
            return r.edit_();
        }
        public void setTotal(double total)
        {
            r.setTotal(total);
        }

        private DataTable Reports(string query_month, string query_year) // report delivery for month or year or both
        {
            string s = "SELECT g.GoodsID, g.GoodsName, gr.ReceiptDate, gr.ReceiptID, SUM(grd.Quan) AS TotalQuantity" +
                " FROM GoodsReceiptDetail grd" +
                " INNER JOIN GoodsReceipt gr ON grd.ReceiptID = gr.ReceiptID" +
                " INNER JOIN Goods g ON grd.GoodsID = g.GoodsID" +
                " WHERE  1 = 1 " + query_month+ query_year +
                " GROUP BY g.GoodsID, g.GoodsName, gr.ReceiptDate, gr.ReceiptID" +
                " Order by gr.ReceiptID ASC";

            return r.Query(s);
        }

        private DataTable Report_Tops(string top, string query_month, string query_year)
        {
            string s = "SELECT TOP "+top+" G.GoodsID, G.GoodsName, SUM(RD.Quan) AS TotalQuantity" +
                " FROM GoodsReceiptDetail RD" +
                " INNER JOIN GoodsReceipt GR ON RD.ReceiptID = GR.ReceiptID" +
                " INNER JOIN Goods G ON RD.GoodsID = G.GoodsID" +
                " WHERE 1 = 1 " + query_month + query_year +
                " GROUP BY G.GoodsID, G.GoodsName" +
                " ORDER BY TotalQuantity DESC;";
            return r.Query(s);

        }

        public DataTable Report(string month, string year) // report follow both month and year
        {
            string query_month = "";
            string query_year = "";
            if (month != "")
            {
                query_month = " AND MONTH(gr.ReceiptDate) = " + month;
            }
            if (year != "")
            {
                query_year = " AND YEAR(gr.ReceiptDate) = " + year;

            }
            return this.Reports(query_month, query_year);
        }

        public DataTable Report_Top(string top, string month, string year)
        {
            string query_month = "";
            string query_year = "";
            if (month != "")
            {
                query_month = " AND MONTH(gr.ReceiptDate) = " + month;
            }
            if (year != "")
            {
                query_year = " AND YEAR(gr.ReceiptDate) = " + year;
            }

            return this.Report_Tops(top, query_month, query_year);
        }
    }
}
