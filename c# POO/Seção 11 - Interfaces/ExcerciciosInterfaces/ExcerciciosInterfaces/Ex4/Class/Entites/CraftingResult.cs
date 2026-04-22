using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciciosInterfaces.Ex4.Class.Entites
{
    sealed class CraftingResult
    {
        public string WeaponName { get;private set; }
        public double BaseDamage { get;private set; }

        public double FinalDamage { get;private set; }

        public CraftingResult() { }

        public CraftingResult(string weaponName,double baseDamage,double finalDamge) 
        {
            WeaponName = weaponName;
            BaseDamage = baseDamage;
            FinalDamage = finalDamge;
        }
        public override string ToString()
        {
            return $"Weapon name:{WeaponName}\n" +
                $"Base damage: {BaseDamage.ToString("F2",CultureInfo.InvariantCulture)}\n" +
                $"Final damage: {FinalDamage.ToString("F2", CultureInfo.InvariantCulture)}\n";
        }

    }
}
