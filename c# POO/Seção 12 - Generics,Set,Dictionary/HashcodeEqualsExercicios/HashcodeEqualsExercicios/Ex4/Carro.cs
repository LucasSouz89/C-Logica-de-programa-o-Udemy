using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashcodeEqualsExercicios.Ex4
{
    internal class Carro
    {
        public string Placa { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj is not Carro other) return false;
            return other.Placa == Placa;
        }
        public override int GetHashCode() {
            return Placa.GetHashCode();
        }
    }
}
