using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExerciciosPolimorfismo.Entites.Class
{
    sealed class Erva : Item
    {
        public string Cor { get;private set; }

        public Erva() { }

        public Erva(string nome, double precoBase,string cor) :base(nome,precoBase) {
            Cor = cor;
        }
        public sealed override string Inspecionar()
        {
            return $"Erva {Cor} - {PrecoFinal().ToString("F2",CultureInfo.InvariantCulture)} ptas";
        }
        public double PrecoFinal()
        {
            var precoFinal = (Cor == "Amarela" || Cor == "amarela") ? PrecoBase + 3000 : PrecoBase;
            return precoFinal;
        }
    }
}
