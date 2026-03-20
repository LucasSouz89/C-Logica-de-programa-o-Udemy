using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ref_e_out {
    internal class Calculator {
        //Usando ref
        public static int Triplicar(ref int x) {
            return x *= 3;
        }
        public static int Triplicar2(ref int x,out int resultado) {
            return resultado = x * 3;
        }
    }
}
