using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExercicios.Ex5
{
    internal class Fabrica<T> where T : new()
    {
        public T CriarNovo() { return new T(); }
    }
}
