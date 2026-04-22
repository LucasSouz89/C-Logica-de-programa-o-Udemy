using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExercicios2.Ex9.Interface
{
    internal class TaxaBasica : ITaxa
    {
        public double ApplicarTaxa(double valor, int mes)
        {
            return valor + (valor * mes * 0.02);
        }
    }
}
