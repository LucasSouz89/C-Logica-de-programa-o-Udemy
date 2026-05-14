using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLINQ
{
    class Enemy
    {
        public string Name { get; set; }

        public double Health { get; set; }

        public Enemy(string name, double price)
        {
            Name = name;
            Health = price;
        }
    }
}
