using System;
using System.Collections.Generic;

namespace Scripts
{
    public partial class Orders
    {
        public byte[] StartDate { get; set; }
        public long Cost { get; set; }
        public string AboutPayment { get; set; }
        public string CompletionMark { get; set; }
        public byte[] ExpirationDate { get; set; }
        public long IdOrder { get; set; }
        public long IdCustomer { get; set; }
        public long? IdBrigade { get; set; }
        public long IdType { get; set; }

        public virtual Brigades IdBrigadeNavigation { get; set; }
        public virtual Customers IdCustomerNavigation { get; set; }
        public virtual TypesOfJobs IdTypeNavigation { get; set; }
    }
}
