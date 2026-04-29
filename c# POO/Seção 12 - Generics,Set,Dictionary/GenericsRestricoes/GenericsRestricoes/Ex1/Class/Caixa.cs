using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsRestricoes.Ex1.Class
{
    internal class Caixa<T>
    {
        private T Item { get; set; }

        private bool Cheio;
        public void Guardar(T item)
        {
            if (Cheio) { throw new Exception("A caixa já possui um item"); }
            Item = item;
            Cheio = true;
        }
        public void Inspecionar()
        {
            if (!Cheio) { throw new ArgumentNullException("O item não pode ser encontrado"); }
            Console.WriteLine(Item);
            Cheio = false;
        }
    }
}
