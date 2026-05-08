using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethotsExercicios.Extension
{
    static class DateTimeExtension
    {
        public static bool IsWeekend(this DateTime date)
        {
            switch (date.DayOfWeek)
            {
                case (DayOfWeek.Sunday):
                case (DayOfWeek.Saturday): return true;
                default: return false;  
            }
        }
    }
}
