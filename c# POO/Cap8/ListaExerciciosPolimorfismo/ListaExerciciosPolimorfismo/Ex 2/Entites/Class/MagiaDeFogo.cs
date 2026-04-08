using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExerciciosPolimorfismo.Ex_2.Entites.Class
{
    sealed class MagiaDeFogo : Magia
    {
        public int TurnosDeQueimadura { get; set; }

        public MagiaDeFogo() { }

        public MagiaDeFogo(string nome, double danoBase,int turnoQueimadura) : base(nome,danoBase)
        {
            TurnosDeQueimadura = turnoQueimadura;
        }
        public sealed override string Conjurar()
        {
            return $"{Nome} conjurado(a)! Causou {DanoBase} de dano e deixou o alvo queimando por {TurnosDeQueimadura} turnos!";
        }
    }
}
