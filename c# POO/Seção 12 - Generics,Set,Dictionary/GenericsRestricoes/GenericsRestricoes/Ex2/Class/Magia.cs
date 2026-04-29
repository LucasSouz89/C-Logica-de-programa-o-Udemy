using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsRestricoes.Ex2.Class
{
    internal static class Magia
    {
        public static void TrocarValores<T>(ref T a,ref T b)
        {
            
            T valor1 = a;
            a = b;
            b = valor1;
        }
    }
}
