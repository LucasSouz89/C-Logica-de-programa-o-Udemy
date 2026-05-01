using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExercicios.Ex10
{
    static class Ordenador
    {
        public static void OrdenarLista<T>(List<T> list) where T : IComparable<T>
        {
            for (int i = 0; i < list.Count; i++) {
                for (int j = 0; j < list.Count - 1; j++) {
                    if (list[j].CompareTo(list[j+1]) > 0) {
                        T temp = list[j];
                        list[j] = list[j+1];
                        list[j+1] = temp;
                    }
                }
            }
            foreach (T item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
