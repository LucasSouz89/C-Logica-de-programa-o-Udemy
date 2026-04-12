using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAbastrataExercicio.Ex2.Entites.Class
{
    sealed class Helicoptero : Veiculo
    {
        public double Altitude { get;private set; }

        public Helicoptero() { }

        public Helicoptero(string modelo, double velocidade,double altitude) : base(modelo,velocidade){ Altitude = altitude; }

        public sealed override string TentarFuga()
        {
            Altitude += 500;
            return $"Ganhou {Altitude} pés de altitude! Escondido nas nuvens. ";
        }
    }
}
