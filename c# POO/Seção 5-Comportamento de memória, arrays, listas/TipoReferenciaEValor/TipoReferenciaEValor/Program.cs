using System;
using TipoReferenciaEValor;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {
            Point p;
            p.X = 20;
            p.Y = 20;
            Console.WriteLine(p);
            p = new Point();
            Point q;
            q.X = p.X;
            q.X = 20;
            q.Y = 30;
            Console.WriteLine(p.X);
            Console.WriteLine(q.X);
        }
    }
}