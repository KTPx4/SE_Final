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

        public C_Supplier()
        {
            this.SupId = "";
            this.Name = "";
            this.Address = "";
            this.Phone = "";
        }

        public C_Supplier(string supId, string name, string address, string phone)
        {
            SupId = supId;
            Name = name;
            Address = address;
            Phone = phone;
        }
    }
}
