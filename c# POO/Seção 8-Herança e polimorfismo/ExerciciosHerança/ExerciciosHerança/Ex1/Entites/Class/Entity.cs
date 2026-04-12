using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosHerança.Ex1.Entites.Class
{
    internal class Entity
    {
        public string Name { get; set; }

        public double Health { get; protected set; }

        public Entity() { }
        public Entity(string name, double health)
        {
            Name = name;
            Health = health;
        }
        public void TakeDamage(double amount) 
        {
            Health -= amount;

        }
    }
}
