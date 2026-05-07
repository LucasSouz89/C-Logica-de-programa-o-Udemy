using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    static class DatimeExtensions
    {
        public static string ElapsedTime(this DateTime thisObj )
        {

            TimeSpan time= DateTime.Now.Subtract( thisObj );
            if(time.TotalHours < 24.0)
            {
                return time.TotalHours.ToString("F1",CultureInfo.InvariantCulture) + "hours";
            }
            else
            {
                return time.Days.ToString("F1", CultureInfo.InvariantCulture) + "days";
            }
        }
    }
}
