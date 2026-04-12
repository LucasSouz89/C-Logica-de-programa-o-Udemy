using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExerciciosPolimorfismo.Ex_2.Entites.Class
{
    sealed class Necromancia : Magia
    {
        public bool CuraOConjurador { get;private set; }

        public Necromancia() { }

        public Necromancia(string nome,double danoBase,bool cura): base(nome,danoBase) {
            CuraOConjurador = cura;
        }
        public sealed override string Conjurar()
        {
            if (CuraOConjurador) { return $"{Nome} conjurado(a)! Causou {DanoBase} de dano. O necromante curou metade do dano causado!"; }
            else { return $"{Nome} conjurado(a)! Causou {DanoBase} de dano!"; }
           
        }
    }
}
