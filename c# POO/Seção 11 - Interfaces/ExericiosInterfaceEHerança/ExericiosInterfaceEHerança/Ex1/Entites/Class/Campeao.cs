using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExericiosInterfaceEHerança.Ex1.Entites.Class
{
    abstract class Campeao
    {
        public string Name { get;private set; }
        public double VidaBase { get;private set; }

        public Campeao(string name, double vidaBase)
        {
            Name = name;
            VidaBase = vidaBase;
        }
        public abstract double CalcularVidaFinal(int itensHearsteel);
    }
}
