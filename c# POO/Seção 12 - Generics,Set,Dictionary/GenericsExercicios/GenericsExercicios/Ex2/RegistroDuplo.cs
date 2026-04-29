using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExercicios.Ex2
{
    sealed class RegistroDuplo<T1,T2>
    {
        public T1 PrimeiroRegistro { get; set; }
        public T2 SegundoRegistro { get; set; }

        public RegistroDuplo(T1 primeiro, T2 segundo) 
        {
            PrimeiroRegistro = primeiro;
            SegundoRegistro = segundo;
        }
        public override string ToString()
        {
            return $"{PrimeiroRegistro}, {SegundoRegistro}";
        }
    }
}
