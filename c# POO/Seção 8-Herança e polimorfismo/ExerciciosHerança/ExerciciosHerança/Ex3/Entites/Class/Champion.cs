using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosHerança.Ex3.Entites.Class
{
    internal class Champion 
    {
        public string Name { get;private set; }
        public double MaxHealth { get; private set; }

        public double CurretHealth { get;protected set; }

        public Champion() {  }

        public Champion(string name, double maxHealth)
        {
            Name = name;
            MaxHealth = maxHealth;
            CurretHealth = MaxHealth;
        }
        public void Damage(double amont)
        {
            CurretHealth -= amont;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Name);
            sb.AppendLine($"Max health: {MaxHealth} | Curret health: {CurretHealth}");
            sb.AppendLine();
            return sb.ToString();

        }
    }
}
