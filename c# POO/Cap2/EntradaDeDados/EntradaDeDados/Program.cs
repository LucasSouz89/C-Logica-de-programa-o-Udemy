using System;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {

            // ---------------------------------------------------------
            // 1. Leitura da frase inteira
            // ---------------------------------------------------------

            // Variável que recebe o dado do usuário (lê a linha toda)
            string frase = Console.ReadLine();

            // Console.WriteLine($"Você digitou: {frase}"); // Teste de impressão


            // ---------------------------------------------------------
            // 2. Leitura de várias palavras na mesma linha (sem Split)
            // ---------------------------------------------------------

            // Lê três palavras, uma em cada execução do ReadLine
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            /* --- Bloco de anotações / Testes anteriores ---
               Console.WriteLine(frase);
               Console.WriteLine(x);
               Console.WriteLine(y);
               Console.WriteLine(z);
            */


            // ---------------------------------------------------------
            // 3. Leitura usando Split (Vetores)
            // ---------------------------------------------------------

            /*
               --- Exemplo: Resolvendo de forma manual (linha a linha) ---
               string a = Console.ReadLine();
               string b = Console.ReadLine();
               string c = Console.ReadLine();
               Console.WriteLine($"{a} {b} {c}");
            */

            // O Split é um método que divide a string em partes (vetor) baseando-se nos espaços.
            // Abaixo, a forma simplificada: lê a linha e já aplica o Split na mesma instrução.
            string[] v = Console.ReadLine().Split(' ');

            string a = v[0];
            string b = v[1];
            string c = v[2];


            // ---------------------------------------------------------
            // 4. Saída de dados (Output)
            // ---------------------------------------------------------

            Console.Clear(); // Limpa a tela antes de mostrar os resultados

            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine($"{a}, {b}, {c}");
        }
    }
}