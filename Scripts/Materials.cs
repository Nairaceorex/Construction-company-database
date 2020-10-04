using System;
using System.Collections.Generic;

namespace Scripts
{
    public partial class Materials
    {
        public long IdMaterial { get; set; }
        public long IdType { get; set; }
        public long IdMaterials2idType { get; set; }
        public long IdMaterials3idType { get; set; }

        public virtual TypesOfJobs IdMaterials2idTypeNavigation { get; set; }
        public virtual TypesOfJobs IdMaterials3idTypeNavigation { get; set; }
        public virtual TypesOfJobs IdTypeNavigation { get; set; }
    }
}
