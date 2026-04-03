using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExercicioFinalComposicao.Entites.Class
{
    internal class OrderItem
    {
        public int Quantity { get;private set; }
        public double Price { get;private set; }

        public Product Product { get; private set; }

        public OrderItem() { }
        public OrderItem(int quantity,double price, Product product) {
            Quantity = quantity;
            Price = price;
            Product = product;
        }
        public double SubTotal() {
            double price = (double)Quantity * Price;
            return price;
        }
        public override string ToString()
        {
            
            return $"{Product.Name},{Price.ToString("F2",CultureInfo.InvariantCulture)} Quantity:{Quantity}, Subtotal: ${SubTotal().ToString("F2",CultureInfo.InvariantCulture)}";
            
        }

    }
}
