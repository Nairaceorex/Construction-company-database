using System;
using System.Collections.Generic;

namespace Scripts
{
    public partial class Brigades
    {
        public Brigades()
        {
            Orders = new HashSet<Orders>();
            Staff = new HashSet<Staff>();
        }

        public long IdBrigade { get; set; }
        public long IdEmployee { get; set; }
        public long IdEmployee3idEmployee { get; set; }

        public virtual Staff IdEmployee3idEmployeeNavigation { get; set; }
        public virtual Staff IdEmployeeNavigation { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
        public virtual ICollection<Staff> Staff { get; set; }
    }
}
