using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExercicios.Ex8.Interface
{
    sealed class PlacaDeVideo : IProduto
    {
        public double Preco {  get; set; }

        public PlacaDeVideo(double preco) { Preco = preco; }
    }
}
