using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciciosInterfaces.Ex6.Interface
{
    internal class HollowPointAmmo : IAmmoType
    {
        public double CalculateArmorPenetration(double rawDamage, double armorValue)
        {
            return armorValue * 2;
        }
    }
}
