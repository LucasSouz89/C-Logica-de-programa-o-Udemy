using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerCiciosFinais.Class
{
    sealed class Itens
    {
        public string Name { get;private set; }
        public double Weight { get; set; }

        public int Quantity { get; set; }


        public Itens() { }

        public Itens(string name, double weight, int quantity) 
        {
            Name = name;
            Weight = weight;
            Quantity = quantity;
        }
        public override string ToString()
        {
            return $"{Name}, {TotalWeight().ToString("F2",CultureInfo.InvariantCulture)}";
        }
        public double TotalWeight() {
            return (double)Weight*Quantity;
        }
    }
}
