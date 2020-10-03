using System;
using System.Collections.Generic;

namespace Script
{
    public partial class Материалы
    {
        public long КодМатериала { get; set; }
        public long КодВида { get; set; }
        public long КодМатериала2кодВида { get; set; }
        public long КодМатериала3кодВида { get; set; }

        public virtual ВидыРабот КодВидаNavigation { get; set; }
        public virtual ВидыРабот КодМатериала2кодВидаNavigation { get; set; }
        public virtual ВидыРабот КодМатериала3кодВидаNavigation { get; set; }
    }
}
