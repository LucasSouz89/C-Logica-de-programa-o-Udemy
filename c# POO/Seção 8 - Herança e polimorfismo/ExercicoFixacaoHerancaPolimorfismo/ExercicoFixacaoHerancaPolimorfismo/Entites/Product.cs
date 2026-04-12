using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicoFixacaoHerancaPolimorfismo.Entites
{
    internal class Product
    {
        public string Name { get;private set; }
        public double Price { get;protected set; }

        public Product() { }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public virtual string priceTag()
        {
            return $"{Name} $ {Price.ToString("F2", CultureInfo.InvariantCulture)}";
        }
        
    }
}
