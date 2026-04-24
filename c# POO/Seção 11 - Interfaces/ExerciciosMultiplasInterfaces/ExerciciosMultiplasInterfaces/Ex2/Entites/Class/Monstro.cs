using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosMultiplasInterfaces.Ex2.Entites.Class
{
    abstract class Monstro
    {
        public int Vida { get;protected set; }

        public Monstro(int vida) { Vida = vida; }
    }
}
