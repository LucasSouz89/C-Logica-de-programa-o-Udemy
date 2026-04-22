using ExcerciciosInterfaces.Ex4.Class.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcerciciosInterfaces.Ex4.Class.Entites;

namespace ExcerciciosInterfaces.Ex4.Class
{
    sealed class BlacksmithService
    {
        IMaterialModifier _materialModifier;

       public BlacksmithService() { }

       public BlacksmithService(IMaterialModifier materialModifier) { _materialModifier = materialModifier; }

       public CraftingResult ForgeWeapon(string name,double baseDamge)
        {
            double finalDamage = _materialModifier.ApllyModifer(baseDamge);
            return new CraftingResult(name,baseDamge,finalDamage);
        }

    }
}
