using ExcerciciosInterfaces.Ex6.Interface;
using ExcerciciosInterfaces.Ex6.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciciosInterfaces.Ex6.Class
{
    internal class CombatService
    {
        public IAmmoType _ammoType;

        public CombatService(IAmmoType ammoType) {_ammoType = ammoType;}

        public CombatLog ProcessShot(double rawDamage,EnemyTarget target)
        {
            
            double blockAmount = _ammoType.CalculateArmorPenetration(rawDamage,target.ArmorValue);
            double effectiveDamage = rawDamage - blockAmount;
            effectiveDamage = Math.Max(effectiveDamage, 0);

            return new CombatLog(rawDamage,blockAmount,effectiveDamage);
        }
    }
}
