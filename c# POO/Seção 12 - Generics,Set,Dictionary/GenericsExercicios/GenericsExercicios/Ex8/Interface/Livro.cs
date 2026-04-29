using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExercicios.Ex8.Interface
{
    sealed class Livro : IProduto
    {
        public double Preco {  get; set; }

        public Livro(double preco) { Preco = preco; }
    }
}
