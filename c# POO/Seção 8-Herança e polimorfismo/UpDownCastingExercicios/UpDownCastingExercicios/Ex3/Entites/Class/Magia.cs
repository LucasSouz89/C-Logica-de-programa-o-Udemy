using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpDownCastingExercicios.Ex3.Entites.Class
{
    internal class Magia : Habilidade
    {
        public double CustoDeMana { get; private set; }

        public Magia()  { }
        public Magia(double mana) : base() 
        {
            CustoDeMana = mana;
        }
    }
}
