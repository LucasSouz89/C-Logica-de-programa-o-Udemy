using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExMembrosEstaticos {
    internal class ConvesorDeMoeda {
        public static double Iof = 6.0;

        public static double Total(double dolar, double qtd) {
            return dolar*qtd+(dolar*qtd*Iof/100.00);
        }
    }
}
