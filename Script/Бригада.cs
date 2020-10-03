using System;
using System.Collections.Generic;

namespace Script
{
    public partial class Бригада
    {
        public Бригада()
        {
            Заказы = new HashSet<Заказы>();
            Сотрудники = new HashSet<Сотрудники>();
        }

        public long КодБригада { get; set; }
        public long КодСотрудника { get; set; }
        public long КодСотрудника3кодСотрудника { get; set; }

        public virtual Сотрудники КодСотрудника3кодСотрудникаNavigation { get; set; }
        public virtual Сотрудники КодСотрудникаNavigation { get; set; }
        public virtual ICollection<Заказы> Заказы { get; set; }
        public virtual ICollection<Сотрудники> Сотрудники { get; set; }
    }
}
