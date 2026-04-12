using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace MembrosEstaticos {
    internal class Circulo {
        public double raio;
        public static double pi = 3.14;
        

        public static double Circuferencia(double r) {
            return 2*pi*r;
        }
        public static double Volume(double r) {
            return (double)4/3 * pi * Math.Pow(r,3);
        }
        
    }
}
