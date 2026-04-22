using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExercicios2.Ex2.Interface
{
    internal class DescontoVip : IDesconto
    {
        public double Calcular(double valor) {  return valor* 0.8; }
    }
}
