using System;
using System.Globalization;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {
            int X = int.Parse(Console.ReadLine());
            int Z = int.Parse(Console.ReadLine());

            while (Z <= X) { Z = int.Parse(Console.ReadLine()); }
            int quantidade = 0;
            
            int valor = 0;
            for (int i = 0; valor <= Z; i++) {
                valor += X + i;
                quantidade++;
            }
            Console.WriteLine(quantidade);
        }
    }
}