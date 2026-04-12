using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosHerança.Ex1.Entites.Class
{
    internal class Enemy : Entity
    {
        public int AgroRadius { get; private set; }

        public Enemy() { }

        public Enemy(string name, double health,int agroRadius) : base(name,health) 
        {
            AgroRadius = agroRadius;
        }
        public void Roar() 
        {
            
            Console.WriteLine($"{Name} avistou o jogador a {AgroRadius} metros e rugiu com {Health} de vida");
        }
    }
}
