using System;
using System.Collections.Generic;

namespace Script
{
    public partial class Сотрудники
    {
        public Сотрудники()
        {
            БригадаКодСотрудника3кодСотрудникаNavigation = new HashSet<Бригада>();
            БригадаКодСотрудникаNavigation = new HashSet<Бригада>();
        }

        public string Фио { get; set; }
        public long Возраст { get; set; }
        public string Пол { get; set; }
        public string Адрес { get; set; }
        public long Телефон { get; set; }
        public long ПаспортныеДанные { get; set; }
        public long КодСотрудника { get; set; }
        public long? КодДолжности { get; set; }
        public long КодБригада { get; set; }

        public virtual Бригада КодБригадаNavigation { get; set; }
        public virtual Должности КодДолжностиNavigation { get; set; }
        public virtual ICollection<Бригада> БригадаКодСотрудника3кодСотрудникаNavigation { get; set; }
        public virtual ICollection<Бригада> БригадаКодСотрудникаNavigation { get; set; }
    }
}
