using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExercicios2.Ex10.Interface
{
    internal interface ITaxaIntergalactica
    {
        public double Juros(double valor, int meses);
        public double TaxaDeEmissao(double valor);
    }
}
