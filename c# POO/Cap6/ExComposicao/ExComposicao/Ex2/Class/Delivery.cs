using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExComposicao.Ex2.Class
{
    internal class Delivery
    {
       public DateTime Date { get; private set; }
       public double Distance { get; private set; }
       public double Revenue { get; private set; }

        public Delivery() { }

        public Delivery(DateTime date, double distance,double revenue) {
            Date = date;
            Distance = distance;
            Revenue = revenue;
        }
    }
}
