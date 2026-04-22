using ListaDeExercicios2.Ex2.Interface;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExercicios2.Ex2.Class
{
    sealed class Loja
    {
        private readonly IDesconto _desconto;

        public Loja(IDesconto desconto)
        {
            _desconto = desconto;
        }
        public void Vender(double valor)
        {
            Console.WriteLine($"Valor total com desconto: {(_desconto.Calcular(valor)).ToString("F2",CultureInfo.InvariantCulture)}");
        }
    }
}
