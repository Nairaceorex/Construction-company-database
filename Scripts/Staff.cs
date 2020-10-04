using System;
using System.Collections.Generic;

namespace Scripts
{
    public partial class Staff
    {
        public Staff()
        {
            BrigadesIdEmployee3idEmployeeNavigation = new HashSet<Brigades>();
            BrigadesIdEmployeeNavigation = new HashSet<Brigades>();
        }

        public string FullName { get; set; }
        public long Age { get; set; }
        public string Sex { get; set; }
        public string Address { get; set; }
        public long Phone { get; set; }
        public long PassportData { get; set; }
        public long IdEmployee { get; set; }
        public long? IdPosition { get; set; }
        public long IdBrigade { get; set; }

        public virtual Brigades IdBrigadeNavigation { get; set; }
        public virtual Positions IdPositionNavigation { get; set; }
        public virtual ICollection<Brigades> BrigadesIdEmployee3idEmployeeNavigation { get; set; }
        public virtual ICollection<Brigades> BrigadesIdEmployeeNavigation { get; set; }
    }
}
