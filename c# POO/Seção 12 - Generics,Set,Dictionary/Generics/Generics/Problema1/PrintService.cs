using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Generics.Problema1
{
    sealed class PrintService <T>
    {
        private List<T> Numbers { get; set; } = new List<T>();

        public void AddValue(T value)
        {
            if (Numbers.Count >= 10) throw new Exception("O maximo de valores é 10");
            Numbers.Add(value);
        }
        public T First()
        {
            return Numbers.First();
            
        }
        public void Print()
        {
            
            for (int i = 0; i < Numbers.Count; i++) {
                if (i == Numbers.Count -1 ) { Console.WriteLine(Numbers[i]+ "]");}
                else if(i == 0) { Console.Write("[" + Numbers[i] + ", "); }
                else
                {
                    Console.Write(Numbers[i] + ", " );
                }
            }
            ;
        }
    }
}
