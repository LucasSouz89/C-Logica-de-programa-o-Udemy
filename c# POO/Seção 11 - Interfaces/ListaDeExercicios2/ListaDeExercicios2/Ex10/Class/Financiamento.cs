using ListaDeExercicios2.Ex10.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExercicios2.Ex10.Class
{
    sealed class Financiamento
    {
        private readonly ITaxaIntergalactica _taxa;

        public Financiamento(ITaxaIntergalactica taxa)
        {
            _taxa = taxa;
        }
        public void Processar(ContratoEspacial contratos, int meses)
        {
            double cotaBase = contratos.ValorTotal / meses;
            for (int i = 1; i <= meses; i++)
            {
                double subtotal = _taxa.Juros(cotaBase,i);
                double ValorFinal = _taxa.TaxaDeEmissao(subtotal);
                contratos.AddParcelas(new Parcelas(contratos.DataDoContrato.AddMonths(i), ValorFinal));
            }
            Console.WriteLine();
            Console.WriteLine(contratos);
        }
    }
}
