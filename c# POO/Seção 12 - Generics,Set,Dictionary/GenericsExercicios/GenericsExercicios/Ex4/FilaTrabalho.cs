using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExercicios.Ex4
{
    internal class FilaTrabalho <T>
    {

        private Queue<T> fifo = new Queue<T>();

        public void Adicionar(T item) {  fifo.Enqueue(item); }

        public void Proximo() 
        {
            fifo.Dequeue();
            
        }
        public void Listar() 
        {
            foreach (var item in fifo) 
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
