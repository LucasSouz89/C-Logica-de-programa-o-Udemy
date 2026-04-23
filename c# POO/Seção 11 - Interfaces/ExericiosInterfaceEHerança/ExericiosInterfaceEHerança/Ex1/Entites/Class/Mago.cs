using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExericiosInterfaceEHerança.Ex1.Entites.Class
{
    sealed class Mago : Campeao
    {
        public Mago(string name, double vidaBase) : base(name,vidaBase) { }

        public override double CalcularVidaFinal(int itensHearsteel)
        {
            return VidaBase + itensHearsteel * 100;
        }
    }
}
