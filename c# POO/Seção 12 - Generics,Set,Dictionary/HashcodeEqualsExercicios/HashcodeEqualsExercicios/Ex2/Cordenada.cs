using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashcodeEqualsExercicios.Ex2
{
    sealed class Cordenada
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Cordenada(int x, int y) {  X = x; Y = y; }

        public override bool Equals(object? obj)
        {
            if(obj is not Cordenada other) return false;
            return other.X == X && other.Y == Y;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y);
        }
    }
}
