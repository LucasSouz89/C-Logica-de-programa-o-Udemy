using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExercicios.Ex3
{
    internal class Avaliador 
    {

        public static T EncontrarMaior<T>(List<T> lista) where T : IComparable<T> 
        {
            if (lista.Count == 0){ throw new ArgumentException("A lista deve ter um tamanho maior que zero"); }
            T maior = lista[0];
            for (int i = 1; i < lista.Count; i++) {
                if (lista[i].CompareTo(maior) > 0) {maior = lista[i];}
                
            }
            return maior;
        }
      

        
    }
}
