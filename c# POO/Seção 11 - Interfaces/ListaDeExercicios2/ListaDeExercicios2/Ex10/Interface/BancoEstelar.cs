using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExercicios2.Ex10.Interface
{
    internal class BancoEstelar : ITaxaIntergalactica
    {
        public double Juros(double valor, int meses) { return valor + (valor * meses * 0.01); }
        public double TaxaDeEmissao(double valor) { return valor + (valor * 0.02); }
    }
}
