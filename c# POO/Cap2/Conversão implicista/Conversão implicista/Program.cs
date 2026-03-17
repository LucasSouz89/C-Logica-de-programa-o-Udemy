using System;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {

            // ---------------------------------------------------------
            // 1. Conversão Implícita (De tipo menor para maior)
            // ---------------------------------------------------------
            // O float (4 bytes) cabe "frouxo" dentro do double (8 bytes).
            // O compilador faz isso sozinho.
            float x = 4.5f;
            double y = x;

            Console.WriteLine(y);


            // ---------------------------------------------------------
            // 2. Casting (Conversão Explícita - De maior para menor)
            // ---------------------------------------------------------
            // Aqui estamos "forçando" um double a entrar num float.
            // É obrigatório usar o (float) porque há risco de perder precisão.
            double a = 2.3;
            float b = (float)a;

            // Correção: O formato é :F2 (Fixed-point 2 casas), e não :2F
            Console.WriteLine($"'a' equivale a {a:F2} e 'b' equivale a {b:F2}");


            // ---------------------------------------------------------
            // 3. Casting de Double para Int (Truncamento)
            // ---------------------------------------------------------
            // Importante: O casting para int NÃO arredonda. Ele corta (trunca) a parte decimal.
            double c = 5.9999;
            int d = (int)c; // Corta o 0.9999 e sobra apenas 5

            Console.WriteLine(d);


            // ---------------------------------------------------------
            // 4. Casting em Operações Matemáticas
            // ---------------------------------------------------------
            int n1 = 5;
            int n2 = 2;

            // Sem o (double), o C# faria a divisão inteira: 5 / 2 = 2.
            // Ao converter um dos números, o resultado vira 2.5.
            double resultado = (double)n1 / n2;

            Console.WriteLine(resultado);
        }
    }
}