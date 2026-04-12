using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAbastrataExercicio.Ex2.Entites.Class
{
    sealed class Moto : Veiculo
    {
        public bool TemTurbo { get;private set; }

        public Moto() { }

        public Moto(string modelo, double velocidade, bool temTurbo) : base(modelo, velocidade) 
        {
            TemTurbo = temTurbo;
        }

        public sealed override string TentarFuga()
        {
            string condicao = (TemTurbo) ? "Cortou caminho pelos becos com o turbo ligado! Policiais despistados." : "Acelerou muito, mas a viatura ainda está na cola!";
            return condicao;
        }
    }
}
