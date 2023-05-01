using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SEFinal.DTA
{
    public class Connection
    {

        public static SqlConnection cn;
        private static string serverName = "";
        private static string dbName = "";
        public static String strConn = "initial catalog = (db); data source = (local); integrated security = true";
        public Connection()
        {
            if (!readServer())
            {
                MessageBox.Show("Can not find 'server.txt', please create");
                Environment.Exit(0);
            }
        }

        public static bool readServer()
        {
            string path = "server.txt";
            if (!File.Exists(path))
            {
                return false;
            }

            string text = File.ReadAllText(path);
            string[] arr = text.Split('|');
            if (arr.Length != 2)
            {
                return false;
            }
            serverName = arr[0];
            dbName = arr[1];

            strConn = strConn.Replace("(local)", serverName);
            strConn = strConn.Replace("(db)", dbName);
            return true;
        }

        public  void connect()
        {
            string s = strConn;
            cn = new SqlConnection(s);
            cn.Open();

        }

        public void actionQuery(string sql)
        {
            connect();

            SqlCommand cmd = new SqlCommand(sql, cn);

            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public  DataTable selectQuery(string sql)
        {
            connect();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, cn);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            cn.Close();
            return dt;
        }

        public bool is_Exists_data(string tableName, string field, string id)
        {

            string s = "select * from " + tableName + " where " + field + " = '" + id + "'";
            DataTable tb = selectQuery(s);
            if (tb.Rows.Count < 1)
            {
                return false;
            }
            return true;
        }

        //function check exists of value and is not hide/deleted
        public bool is_Exists_data(string table, string field, string id, string field_check)
        {
            string s = $"select* from {table} where {field} = '{id}' and {field_check} = 0";
            DataTable tb = selectQuery(s);
            if (tb.Rows.Count < 1)
            {
                return false;
            }
            return true;
        }
        public DataTable selectTop(string field, string table)
        {
            string s = $"select top 1 {field} from {table} order by {field} desc";
            //string s = "select top 1 "+field+" from "+table+" order by "+field+" desc";
            return selectQuery(s);
        }

        public string getID(string field, string table, string defaultID)
        {
            DataTable tb = selectTop(field, table);
            string lastID = "";
            if (tb.Rows.Count > 0)
            {               
                String sttEnd = tb.Rows[0][0].ToString();
             
                int index = 0;

                for (int i = 0; i < sttEnd.Length; i++)
                {
                    var isNumeric = int.TryParse(sttEnd[i].ToString(), out int n);
                    if (isNumeric)
                    {
                        index = i;
                        break;
                    }
                }
                string firtID = sttEnd.Substring(0, index);

                String sttend = sttEnd.Substring(index, sttEnd.Length - index);

                int newStt = int.Parse(sttend) + 1;

                int lenNum = sttEnd.Length - index;

                for (int i = 0; i < (lenNum - newStt.ToString().Length); i++)
                {
                    lastID = lastID + "0";
                }
                lastID = firtID + lastID + newStt.ToString();
            
                 
         
            }
            else
            {
                lastID = defaultID;
            }
            //MessageBox.Show(lastID);
            return lastID;
        }

        public static string get_serverName()
        {
            return serverName;
        }
        public static string get_DB()
        {
            return dbName;
        }
    }
}
