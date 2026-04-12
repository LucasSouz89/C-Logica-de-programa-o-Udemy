using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriacaoDeMetodo {
    internal class Triangulo {
        public double A;
        public double B;
        public double C;

        public double Area() {
            double p = (double)(A + B + C)/2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }


    }
}
