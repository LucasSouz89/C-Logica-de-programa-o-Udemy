using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operações_do_LINQ_Ref
{
    class Weapon
    {
        public string Name { get;private set; }

        public double Price { get;private set; }

        public Weapon(string name,double price ) { Name = name; Price = price; }
    }
}
