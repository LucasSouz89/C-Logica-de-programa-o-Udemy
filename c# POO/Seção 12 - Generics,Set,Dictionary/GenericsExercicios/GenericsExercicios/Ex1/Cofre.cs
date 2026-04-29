using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExercicios.Ex1
{
    sealed class Cofre<T>
    {
        public T Value { get; set; }

        private bool CofreEstaCheio { get; set; }
        public void Guardar(T item)
        {
            if (CofreEstaCheio) { throw new InvalidOperationException("O cofre esta cheio"); }
            Value = item;
            CofreEstaCheio = true;

        }
        public T Destrancar()
        {
            CofreEstaCheio = false;
            return Value;
        }

    }
}
