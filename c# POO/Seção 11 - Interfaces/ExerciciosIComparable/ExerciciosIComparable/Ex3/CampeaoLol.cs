using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosIComparable.Ex3
{
    sealed class CampeaoLol : IComparable<CampeaoLol>
    {
        public string Nome { get;private set; }

        public int Vida { get;private set; }

        public double Armadura { get;private set; }

        public CampeaoLol(string nome, int vida, double armadura)
        {
            Nome = nome;
            Vida = vida;
            Armadura = armadura;
        }

        public int CompareTo(CampeaoLol other)
        {
            if(other.Vida == Vida) {return other.Armadura.CompareTo(Armadura); }
            else {return other.Vida.CompareTo(Vida); }
        }
        public override string ToString()
        {
            return $"{Nome}, {Vida} hp, {Armadura.ToString("F2", CultureInfo.InvariantCulture)} armor";
        }
    }
}
