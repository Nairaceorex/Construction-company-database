using System;
using System.Collections.Generic;

namespace Script
{
    public partial class Должности
    {
        public Должности()
        {
            Сотрудники = new HashSet<Сотрудники>();
        }

        public string НаименованиеДолжности { get; set; }
        public long Оклад { get; set; }
        public string Обязанности { get; set; }
        public string Требования { get; set; }
        public long КодДолжности { get; set; }

        public virtual ICollection<Сотрудники> Сотрудники { get; set; }
    }
}
