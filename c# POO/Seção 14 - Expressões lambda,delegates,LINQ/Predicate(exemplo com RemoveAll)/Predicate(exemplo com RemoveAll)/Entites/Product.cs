using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predicate_exemplo_com_RemoveAll_.Entites
{
     class Product
    {
        public string Name { get; set; }

        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public override bool Equals(object? obj)
        {
            if(obj is not Product other) return false;

            return Name == other.Name && Price == other.Price;
        }
        public override int GetHashCode() 
        {
            return HashCode.Combine(Name, Price);
        }
        public override string ToString()
        {
            return $"{Name}, ${Price.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
