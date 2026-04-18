using SoluçãoSemInterface.Entites.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoluçãoSemInterface.Entites.Services
{
    sealed class BrazilTaxService
    {
        public double Tax(double amount)
        {
            double taxValue = (amount <= 100) ? amount * 0.2 : amount * 0.15; 
            return taxValue;
        }
        
    }
}
