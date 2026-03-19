using System;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {
            double? x = null;
            double? y = 10;
            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());
            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);
            if (x.HasValue) { Console.WriteLine(x.Value); }

            if (y.HasValue) { Console.WriteLine(y.Value); } else { Console.WriteLine("ValorInvalido"); }

            double ? z = null;
            double w = z ?? 0;
            Console.WriteLine(w);
            
        }
    }
}