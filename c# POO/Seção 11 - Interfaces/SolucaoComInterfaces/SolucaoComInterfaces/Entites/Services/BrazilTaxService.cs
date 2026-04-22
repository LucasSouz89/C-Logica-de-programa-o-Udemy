using SolucaoComInterfaces.Entites.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucaoComInterfaces.Entites.Services
{
    sealed class BrazilTaxService : ITaxService
    {
        public double Tax(double amount)
        {
            double taxValue = amount <= 100 ? amount * 0.2 : amount * 0.15; 
            return taxValue;
        }
        
    }
}
