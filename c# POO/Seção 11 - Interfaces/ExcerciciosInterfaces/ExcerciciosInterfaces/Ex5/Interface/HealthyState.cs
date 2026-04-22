using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciciosInterfaces.Ex5.Interface
{
    internal class HealthyState : IInfectionState 
    {
        public double CalculateHeal(double baseHealAmount)
        {
            return baseHealAmount;
        }
    }
}
