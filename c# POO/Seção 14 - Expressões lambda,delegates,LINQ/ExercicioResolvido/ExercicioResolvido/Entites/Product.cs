using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioResolvido.Entites
{
    class Product
    {
        public string Name { get; set; }

        public double Price { get; set; }

        public Product(string pharse)
        {
            string[] line = pharse.Trim('\'').Split(",");
            Name =line[0];
            Price = double.Parse(line[1],CultureInfo.InvariantCulture);
        }
    }
}
