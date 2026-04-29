using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExercicios.Ex6
{
    internal class Armazem <T> where T : class
    {
        private List<T> List { get; set; } = new List<T>();

        public void Adicionar(T obj)
        {
            List.Add(obj);
        }
    }
}
