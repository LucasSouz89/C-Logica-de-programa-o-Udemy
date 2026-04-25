using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosIComparable.Ex1
{
    internal class Item : IComparable
    {
        public  string Name { get; set; }

        public double ValorGold { get; set; }

        public Item(string name, double valorGold)
        {
            Name = name;
            ValorGold = valorGold;
        }

        
        public override string ToString()
        {
            return $"{Name} , $ {ValorGold.ToString("F2",CultureInfo.InvariantCulture)}";
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Item)) throw new ArgumentException("Erro: a classe não é do tipo item");
            Item other = obj as Item;
            return other.ValorGold.CompareTo(ValorGold);
        }
    }
}
