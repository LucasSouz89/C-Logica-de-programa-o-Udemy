using System;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {

            // ---------------------------------------------------------
            // 1. Operadores de Atribuição Acumulativa
            // ---------------------------------------------------------
            // Servem para economizar escrita. "a += 2" é igual a "a = a + 2"

            int a = 10;
            Console.WriteLine($"Valor inicial: {a}");

            // Soma (+=)
            a += 2;
            Console.WriteLine($"a += 2: {a}");

            // Subtração (-=)
            a = 10; // Resetando valor
            a -= 2;
            Console.WriteLine($"a -= 2: {a}");

            // Multiplicação (*=)
            a = 10;
            a *= 2;
            Console.WriteLine($"a *= 2: {a}");

            // Divisão (/=)
            a = 10;
            a /= 2;
            Console.WriteLine($"a /= 2: {a}");

            // Módulo/Resto (%=)
            a = 10;
            a %= 2; // 10 dividido por 2 dá resto 0
            Console.WriteLine($"a %= 2: {a}");


            // ---------------------------------------------------------
            // 2. Atribuição com Strings
            // ---------------------------------------------------------

            string s = "abc";
            Console.WriteLine("\n--- Strings ---");
            Console.WriteLine(s);

            s += "def"; // Concatena (junta) o texto no final
            Console.WriteLine(s);


            // ---------------------------------------------------------
            // 3. Incremento e Decremento (Simples)
            // ---------------------------------------------------------

            Console.WriteLine("\n--- Loop While ---");
            a = 1;
            while (a <= 10) {
                Console.WriteLine($"Contador: {a}");
                a++; // O mesmo que a = a + 1
            }


            // ---------------------------------------------------------
            // 4. A Grande Diferença: Pós-fixado (a++) vs Pré-fixado (++a)
            // ---------------------------------------------------------

            Console.WriteLine("\n--- Pós vs Pré Incremento ---");

            // CENÁRIO A: Pós-fixado (a++) -> PRIMEIRO entrega, DEPOIS incrementa.
            a = 10;
            int b = a++;

            // Aqui, o 'b' recebe 10 (valor antigo), e só DEPOIS o 'a' vira 11.
            Console.WriteLine($"[a++] Valor de A: {a} | Valor de B: {b}");


            // CENÁRIO B: Pré-fixado (++a) -> PRIMEIRO incrementa, DEPOIS entrega.
            a = 10;
            b = ++a;

            // Aqui, o 'a' vira 11 imediatamente, e entrega o 11 para o 'b'.
            Console.WriteLine($"[++a] Valor de A: {a} | Valor de B: {b}");
        }
    }
}