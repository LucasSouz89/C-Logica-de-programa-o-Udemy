using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciciosInterfaces.Ex2.Services
{
    internal interface IWeapon
    {
        public int CalculateDamage(int playerStrenght);
    }
}
