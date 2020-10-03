using System;
using System.Collections.Generic;

namespace Script
{
    public partial class ВидыРабот
    {
        public ВидыРабот()
        {
            Заказы = new HashSet<Заказы>();
            МатериалыКодВидаNavigation = new HashSet<Материалы>();
            МатериалыКодМатериала2кодВидаNavigation = new HashSet<Материалы>();
            МатериалыКодМатериала3кодВидаNavigation = new HashSet<Материалы>();
        }

        public long КодВида { get; set; }
        public string Наименование { get; set; }
        public string Описание { get; set; }
        public long ЦенаРаботы { get; set; }

        public virtual ICollection<Заказы> Заказы { get; set; }
        public virtual ICollection<Материалы> МатериалыКодВидаNavigation { get; set; }
        public virtual ICollection<Материалы> МатериалыКодМатериала2кодВидаNavigation { get; set; }
        public virtual ICollection<Материалы> МатериалыКодМатериала3кодВидаNavigation { get; set; }
    }
}
