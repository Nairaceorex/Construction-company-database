using System;
using System.Collections.Generic;

namespace Scripts
{
    public partial class Customers
    {
        public Customers()
        {
            Orders = new HashSet<Orders>();
        }

        public long IdCustomer { get; set; }
        public string Address { get; set; }
        public string FullName { get; set; }
        public long Phone { get; set; }
        public long PassportData { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}
