using GenericsExercicios.Ex8.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExercicios.Ex8.Class
{
    static class CalcularEstoque
    {

        public static double SomaTotal<T>(List<T> itens) where T : IProduto
        {
            double total = 0;
            foreach(var item in itens)
            {
                total += item.Preco;
            }
            return total;
        }
    }
}
