using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncExercicios
{
    class Weapon
    {
        public string Name { get;private set; }

        public double Damage { get;private set; }

        public Weapon(string name, double damage)
        {
            Name = name;
            Damage = damage;
        }
        public override string ToString() => $"{Name} {Damage.ToString("F2",CultureInfo.InvariantCulture)} damage";
        
    }
}
