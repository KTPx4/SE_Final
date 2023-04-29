using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEFinal.Class
{
    public class C_Supplier
    {
        public string SupId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int is_deleted { get; set; }

        public C_Supplier()
        {
            this.SupId = "";
            this.Name = "";
            this.Address = "";
            this.Phone = "";
            this.is_deleted= 0;
        }

        public C_Supplier(string supId, string name, string address, string phone, int is_deleted)
        {
            SupId = supId;
            Name = name;
            Address = address;
            Phone = phone;
            this.is_deleted = is_deleted;
        }
    }
}
