using GenericsExercicios.Ex11.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExercicios.Ex11.Class
{
    sealed class Repositorio<T> where T : class,IEntidade,new()
    {
        public void AdicionarNovo()
        {
            T novoItem = new T();
            novoItem.Id = new Random().Next(1,1000);
            Console.WriteLine($"Novo item do tipo {novoItem} salvo com o id:{novoItem.Id}");
        }
    }
}
