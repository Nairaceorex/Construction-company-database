using System;
using System.Collections.Generic;

namespace Scripts
{
    public partial class Positions
    {
        public Positions()
        {
            Staff = new HashSet<Staff>();
        }

        public string JobTitle { get; set; }
        public long Salary { get; set; }
        public string Duties { get; set; }
        public string Requirements { get; set; }
        public long IdPosition { get; set; }

        public virtual ICollection<Staff> Staff { get; set; }
    }
}
