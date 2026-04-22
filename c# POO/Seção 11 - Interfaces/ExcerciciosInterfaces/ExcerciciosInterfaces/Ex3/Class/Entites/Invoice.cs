using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciciosInterfaces.Ex3.Class.Entites1
{
    sealed class Invoice
    {
        public double Subtotal { get; set; }

        public double Discount { get; set; }

        public double Total { get; set; }

        public Invoice() { }

        public Invoice(double subtotal, double discount,double total)
        {
            Subtotal = subtotal;
            Discount = discount;
            Total = total;
        }
        public override string ToString()
        {
            return $"Subtotal: {Subtotal.ToString("F2",CultureInfo.InvariantCulture)}\n" +
                $"Discount {Discount.ToString("F2", CultureInfo.InvariantCulture)} \n" +
                $"Total {Total.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
