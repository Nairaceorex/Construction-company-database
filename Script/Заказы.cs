using System;
using System.Collections.Generic;

namespace Script
{
    public partial class Заказы
    {
        public byte[] ДатаНачала { get; set; }
        public long Стоимость { get; set; }
        public string ОбОплате { get; set; }
        public string ОтметкаОЗавершении { get; set; }
        public byte[] ДатаОкончания { get; set; }
        public long КодЗаказа { get; set; }
        public long КодЗаказчика { get; set; }
        public long? КодБригада { get; set; }
        public long КодВида { get; set; }

        public virtual Бригада КодБригадаNavigation { get; set; }
        public virtual ВидыРабот КодВидаNavigation { get; set; }
        public virtual Заказчики КодЗаказчикаNavigation { get; set; }
    }
}
