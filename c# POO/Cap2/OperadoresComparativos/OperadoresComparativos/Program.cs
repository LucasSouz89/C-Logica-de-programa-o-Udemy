using System;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {

            // ---------------------------------------------------------
            // Operadores Comparativos (Lógica Booleana)
            // ---------------------------------------------------------
            // Lembre-se: O resultado é sempre TRUE (Verdadeiro) ou FALSE (Falso)

            int a = 10;

            bool c2 = a < 10;   // False -> Menor que (<)
            bool c3 = a > 10;   // False -> Maior que (>)
            bool c4 = a == 10;  // True  -> Igual a (==)

            bool c5 = a <= 50;  // True  -> Menor ou igual (<=)
            bool c6 = a >= 4;   // True  -> Maior ou igual (>=)

            bool c7 = a != 10;  // False -> Diferente de (!=)

            Console.WriteLine($"{c2} {c3} {c4} {c5} {c6} {c7}");
        }
    }
}