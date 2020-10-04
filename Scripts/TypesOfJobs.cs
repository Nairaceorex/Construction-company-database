using System;
using System.Collections.Generic;

namespace Scripts
{
    public partial class TypesOfJobs
    {
        public TypesOfJobs()
        {
            MaterialsIdMaterials2idTypeNavigation = new HashSet<Materials>();
            MaterialsIdMaterials3idTypeNavigation = new HashSet<Materials>();
            MaterialsIdTypeNavigation = new HashSet<Materials>();
            Orders = new HashSet<Orders>();
        }

        public long IdType { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long PriceOfWork { get; set; }

        public virtual ICollection<Materials> MaterialsIdMaterials2idTypeNavigation { get; set; }
        public virtual ICollection<Materials> MaterialsIdMaterials3idTypeNavigation { get; set; }
        public virtual ICollection<Materials> MaterialsIdTypeNavigation { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
