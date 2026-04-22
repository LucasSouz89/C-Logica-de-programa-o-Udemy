using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciciosInterfaces.Ex3.Class.Interface
{
    internal class StudentDiscountService : IDiscountService
    {
        public double ApplyDiscount(double subtotal) { return subtotal * 0.20; }
    }
}
