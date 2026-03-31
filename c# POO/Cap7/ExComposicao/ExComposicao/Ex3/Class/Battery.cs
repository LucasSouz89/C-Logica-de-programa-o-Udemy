using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExComposicao.Ex3.Class
{
    internal class Battery
    {
        public string Brand { get; private set; }
        public double MaxCapacity { get; private set; }


        public Battery() { }

        public Battery(string brand,double maxCapacity) {
            Brand = brand;
            MaxCapacity = maxCapacity;
        }

    }
}
