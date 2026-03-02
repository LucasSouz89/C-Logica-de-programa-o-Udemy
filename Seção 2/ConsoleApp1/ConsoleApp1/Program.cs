using System;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {
            int x = 5, y = 0;
            while (x > 2) { Console.WriteLine(x);y += x; x -= 1;}
        }
    }
}