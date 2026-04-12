using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosHerança.Ex3.Entites.Class
{
    internal class Tank : Champion
    {
        public double Armor { get;private set; }

        public Tank() {
            
        }
        public Tank(string name, double maxHealth,double armor) : base(name,maxHealth)
        {
            Armor = armor;
        }
        public void Regenarate()
        {
            CurretHealth += MaxHealth * 0.2;
            if (CurretHealth > MaxHealth) {
                CurretHealth = MaxHealth;
            }
            
        }
    }
}
