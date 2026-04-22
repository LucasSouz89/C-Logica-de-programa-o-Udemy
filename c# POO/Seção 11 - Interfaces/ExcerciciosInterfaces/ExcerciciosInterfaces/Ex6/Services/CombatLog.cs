using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciciosInterfaces.Ex6.Services
{
    internal class CombatLog
    {
        public double RawDamage { get; set; }
        public double TotalDamage { get; set; }

        public double EffectiveDamage { get; set; }

        public CombatLog(double rawDamage, double totalDamage, double effectiveDamage)
        {
            RawDamage = rawDamage;
            TotalDamage = totalDamage;
            EffectiveDamage = effectiveDamage;
        }
        public override string ToString()
        {
            return $"Raw Damage:{RawDamage.ToString("F2", CultureInfo.InvariantCulture)}\n" +
                $"Total Damage:{TotalDamage.ToString("F2", CultureInfo.InvariantCulture)}\n" +
                $"Effective Damage:{EffectiveDamage.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
