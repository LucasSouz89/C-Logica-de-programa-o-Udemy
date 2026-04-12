using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExerciciosPolimorfismo.Entites.Class
{
    sealed class Arma : Item
    {
        public double PoderDeFogo { get;private set; }

        public Arma() { }

        public Arma(string nome, double precoBase,double poderDeFogo) : base(nome,precoBase)
        { 
            
            PoderDeFogo = poderDeFogo;
        }
        public sealed override string Inspecionar()
        {
            return $"{Nome} (Poder de Fogo: {PoderDeFogo}) - {PrecoFinal().ToString("F2",CultureInfo.InvariantCulture)} ptas";
        }
        public double PrecoFinal()
        {
            var precoFinal = PrecoBase + 2000;
            return precoFinal;
        }
    }
}
