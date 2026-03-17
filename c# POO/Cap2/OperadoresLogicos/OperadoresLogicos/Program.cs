using System;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Hello World!");

            // Variáveis de teste
            int n = 1;
            int n2 = 2;

            // ---------------------------------------------------------
            // 1. Operador AND (&&) - O Exigente
            // ---------------------------------------------------------
            // Regra: TODOS precisam ser verdadeiros.

            Console.WriteLine("Usando o operador && (AND):");

            bool b = n >= 1 && n2 <= 2;     // V e V -> Verdadeiro
            Console.WriteLine($"Dois verdadeiros: {b}");

            b = n > 1 && n2 <= 2;           // F e V -> Falso
            Console.WriteLine($"Um falso e um verdadeiro: {b}");

            b = n == 1 && n2 >= 3;          // V e F -> Falso
            Console.WriteLine($"Um verdadeiro e um falso: {b}");

            b = n > 1 && n2 < 2;            // F e F -> Falso
            Console.WriteLine($"Dois Falsos: {b}");

            Console.WriteLine("----------------------");


            // ---------------------------------------------------------
            // 2. Operador OR (||) - O "Gente Boa"
            // ---------------------------------------------------------
            // Regra: Basta UM ser verdadeiro.

            Console.WriteLine("Usando o operador || (OU):");

            b = n >= 1 || n2 <= 2;          // V ou V -> Verdadeiro
            Console.WriteLine($"Dois verdadeiros: {b}");

            b = n > 1 || n2 <= 2;           // F ou V -> Verdadeiro
            Console.WriteLine($"Um falso e um verdadeiro: {b}");

            b = n == 1 || n2 >= 3;          // V ou F -> Verdadeiro
            Console.WriteLine($"Um verdadeiro e um falso: {b}");

            b = n > 1 || n2 != 2;           // F ou F -> Falso
            Console.WriteLine($"Dois Falsos: {b}");

            Console.WriteLine("----------------------");


            // ---------------------------------------------------------
            // 3. Operador NOT (!) e Precedência - O Do Contra
            // ---------------------------------------------------------
            // Ordem de força (Precedência): ! > && > ||

            Console.WriteLine("Usando operador ! (NOT):");

            // Exemplo 1:
            // 1. (n > 1) é F.
            // 2. !F vira V.
            // 3. V && V = Verdadeiro.
            b = !(n > 1) && n2 <= 2;
            Console.WriteLine($"Falso (invertido para V) e Verdadeiro: {b}");

            // Exemplo 2:
            // 1. (n == 1) é V.
            // 2. !V vira F.
            // 3. F || F = Falso.
            b = !(n == 1) || n2 >= 3;
            Console.WriteLine($"Verdadeiro (invertido para F) ou Falso: {b}");

            Console.WriteLine("----------------------");


            // ---------------------------------------------------------
            // 4. Exercício de Fixação (Precedência)
            // ---------------------------------------------------------

            Console.WriteLine("Pequeno exercício de Precedência");

            bool c1 = 2 > 3 || 4 != 5;      // F || V -> Verdadeiro
            bool c2 = !(2 > 3) || 4 != 5;   // !F || V -> V || V -> Verdadeiro
            bool c3 = 10 < 5;               // Falso

            // O Grande Teste: c1 || c2 && c3
            // O && ganha do ||, então resolvemos ele primeiro.
            // 1º passo: (c2 && c3) -> V && F -> Falso
            // 2º passo: c1 || Falso -> V || F -> Verdadeiro

            bool c4 = c1 || c2 && c3;

            Console.WriteLine($"Resultado Final (c4): {c4}");
        }
    }
}