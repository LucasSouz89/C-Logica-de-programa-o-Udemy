using System;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {
            int x = int.Parse(Console.ReadLine()), y = int.Parse(Console.ReadLine()), min, max,soma= 0;
            max = x;
            if (max > y) { min = y; } else { max = y;min = x; }
            for (int i = min + 1; i < max; i++) {
                if (i % 2 != 0) {
                    soma += i;
                }



            }
            Console.WriteLine(soma);
        }
    }
}