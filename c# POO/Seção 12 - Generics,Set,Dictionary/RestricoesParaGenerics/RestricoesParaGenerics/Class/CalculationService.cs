using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestricoesParaGenerics.Class
{
    sealed class CalculationService 
    {
        public static T Max<T>(List<T> list) where T : IComparable<T>
        {
            if (list.Count == 0) throw new ArgumentException("A lista n pode ser vazia");
            T max = list[0];
            for (int i = 1; i < list.Count; i++) {
                if (list[i].CompareTo(max) > 0) { max = list[i]; }
                
            }
            return max;
        }
    }
}
