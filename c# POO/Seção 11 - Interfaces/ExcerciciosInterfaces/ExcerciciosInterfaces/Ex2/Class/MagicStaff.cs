using ExcerciciosInterfaces.Ex2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciciosInterfaces.Ex2.Class
{
    sealed class MagicStaff : IWeapon
    {
        public int CalculateDamage(int playerStrenght)
        {
            return 50;
        }
    }
}
