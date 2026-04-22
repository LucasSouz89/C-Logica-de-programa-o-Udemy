using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciciosInterfaces.Ex5.Class
{
    sealed class HealReport
    {
        public double InitialHealth { get; set; }

        public double HealedAmount { get; set; }

        public double FinalHealth { get; set; }


        

        public HealReport(double intialHealth, double healedAmount, double finalHealth)
        {
            InitialHealth = intialHealth;
            HealedAmount = healedAmount;
            FinalHealth = finalHealth;
        }
        public override string ToString()
        {
            return $"InitialHealth: {InitialHealth.ToString("F2", CultureInfo.InvariantCulture)}\n" +
                $"HealedAmount: {HealedAmount.ToString("F2", CultureInfo.InvariantCulture)}\n" +
                $"FinalHealth: {FinalHealth.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}

