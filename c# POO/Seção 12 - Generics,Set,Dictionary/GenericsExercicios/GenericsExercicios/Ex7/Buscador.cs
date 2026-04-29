using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExercicios.Ex7
{
    static class Buscador
    {
        public static bool ContemItem<T>(List<T> lista, T alvo) where T : IEquatable<T>
        {
            
            foreach (T item in lista) 
            { 
                if (item.Equals(alvo)) { return true; } 
                
            }
            return false;
        }
    }
}
