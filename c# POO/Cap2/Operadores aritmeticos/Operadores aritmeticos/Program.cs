using System;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {

            // ---------------------------------------------------------
            // 1. Precedência de Operadores (* / vs + -)
            // ---------------------------------------------------------

            // O C# respeita a ordem da matemática: multiplicação vem antes da adição.
            int n1 = 3 + 4 * 2;      // 4 * 2 = 8, depois + 3 = 11

            // Os parênteses mudam a prioridade.
            int n2 = (3 + 4) * 2;    // 3 + 4 = 7, depois * 2 = 14

            // Operador de Módulo (%) retorna o RESTO da divisão.
            int n3 = 17 % 3;         // 17 dividido por 3 dá 5 e sobra 2.

            Console.WriteLine($"n1: {n1}");
            Console.WriteLine($"n2: {n2}");
            Console.WriteLine($"n3 (resto): {n3}");


            // ---------------------------------------------------------
            // 2. Divisão de Inteiros e Casting
            // ---------------------------------------------------------

            // Errado: 10 / 8 (ambos inteiros) daria 1. O casting (double) força o resultado decimal.
            double n4 = (double)10 / 8;
            Console.WriteLine($"Divisão com casting: {n4}");

            // Certo também: Colocar .0 ou .00 faz o compilador entender que é double.
            n4 = 10.00 / 8;
            Console.WriteLine($"Divisão com ponto flutuante: {n4}");


            // ---------------------------------------------------------
            // 3. Fórmula de Bhaskara
            // ---------------------------------------------------------

            double a = 1.0, b = -3.0, c = -4.0;

            // Math.Pow(base, expoente) é usado para potência.
            // Delta = b² - 4ac
            double delta = Math.Pow(b, 2.0) - (4.0 * a * c);

            // Importante: Math.Sqrt calcula a raiz quadrada.
            // Atenção aos parênteses no denominador: (2 * a). Sem eles, o código dividiria por 2 e multiplicaria por A.
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine("\n--- Resultados de Bhaskara ---");
            Console.WriteLine($"Delta: {delta}");
            Console.WriteLine($"x1: {x1}");
            Console.WriteLine($"x2: {x2}");
        }
    }
}