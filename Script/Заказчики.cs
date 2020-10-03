using System;
using System.Collections.Generic;

namespace Script
{
    public partial class Заказчики
    {
        public Заказчики()
        {
            Заказы = new HashSet<Заказы>();
        }

        public long КодЗаказчика { get; set; }
        public string Адрес { get; set; }
        public string Фио { get; set; }
        public long Телефон { get; set; }
        public long ПаспортныеДанные { get; set; }

        public virtual ICollection<Заказы> Заказы { get; set; }
    }
}
