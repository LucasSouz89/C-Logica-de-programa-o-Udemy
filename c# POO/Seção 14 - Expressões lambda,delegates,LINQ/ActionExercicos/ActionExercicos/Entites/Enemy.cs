using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionExercicos.Entites
{
     class Enemy
    {
        public string Name { get; set; }

        public int Health { get; set; }

        public Enemy(string name, int health) {  Name = name; Health = health; }

        public override string ToString()
        {
            return  $"{Name}, {Health}hp";
        }
    }
}
