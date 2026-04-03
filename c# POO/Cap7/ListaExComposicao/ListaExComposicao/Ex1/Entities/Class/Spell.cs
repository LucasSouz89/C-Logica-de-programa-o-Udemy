using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExComposicao.Ex1.Entities.Class
{
    internal class Spell
    {
        public string Name { get;private set; }
        public double  BaseDamage {get; private set; }
        public Spell() { }

        public Spell(string name, double baseDamage)
        {
            Name = name;
            BaseDamage = baseDamage;
        }

        public override string ToString()
        {
            return $"{Name} | Dano: {BaseDamage.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
