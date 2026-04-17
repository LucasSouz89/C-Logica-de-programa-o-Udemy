using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicio_de_fixação.Exceptions;

namespace Exercicio_de_fixação.Class
{
    sealed class Produtos
    {
        public string Name { get;private set; }

        public double Price { get;private set; }

        public int Quantity { get;private set; }

        public Produtos() { }

        public Produtos(string name,double price, int quantity) 
        {
            if(string.IsNullOrWhiteSpace(name)) throw new ExceptionDomain("O nome não pode ser nulo");
            if(price <= 0) throw new ExceptionDomain("O preço não pode ser nulo ou negativo");
            if(quantity <=0) throw new ExceptionDomain("A quantidade não pode ser nula ou negativa");
            Name = name;
            Price = price;
            Quantity = quantity;
        }
        public double FinalPrice() 
        {
            return Price*Quantity;
        }
        public override string ToString()
        {
            return $"{Name},{FinalPrice().ToString("F2",CultureInfo.InvariantCulture)}";
        }
        public string Catalog()
        {
            return $"{Name},{Price.ToString("F2", CultureInfo.InvariantCulture)},{Quantity}";
        }
    }
}
