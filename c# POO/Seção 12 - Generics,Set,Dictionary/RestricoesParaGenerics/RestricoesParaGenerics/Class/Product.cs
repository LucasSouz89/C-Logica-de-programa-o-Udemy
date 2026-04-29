using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestricoesParaGenerics.Class
{
    sealed class Product : IComparable<Product>
    {
        public string Name { get; set; }

        public double Price { get; set; }

        public Product(string drawValue)
        {
            string[] line = drawValue.Split(',');
            Name = line[0];
            Price = double.Parse(line[1],CultureInfo.InvariantCulture);
        }
        public override string ToString()
        {
            return $"{Name}, {Price.ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public int CompareTo(Product obj)
        {
            return Price.CompareTo(obj.Price);
        }
    }
}
