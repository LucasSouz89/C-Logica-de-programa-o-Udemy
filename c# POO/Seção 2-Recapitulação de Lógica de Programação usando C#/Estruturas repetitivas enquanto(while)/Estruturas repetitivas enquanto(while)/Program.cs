using System;
using System.Globalization;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Digite um numero: ");

            // 1. INICIALIZAÇÃO: Lemos o primeiro valor antes do loop começar.
            // Essa variável 'numero' é quem controla se o loop continua ou para.
            double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // 2. CONDIÇÃO: O programa pergunta "O número é maior ou igual a zero?"
            // - Se SIM (Verdadeiro): Entra no bloco { } e executa.
            // - Se NÃO (Falso): Pula todo o bloco e vai para o final.
            while (numero >= 0.0) {

                // --- Bloco de Execução ---
                double raizQ = Math.Sqrt(numero);
                Console.WriteLine(raizQ.ToString("F3", CultureInfo.InvariantCulture));

                Console.Write("Digite outro numero: ");

                // 3. ATUALIZAÇÃO: Este passo é CRUCIAL!
                // Precisamos ler o valor novamente DENTRO do loop.
                // Se esquecer essa linha, o 'numero' nunca muda e gera um LOOP INFINITO (trava o PC).
                numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                // Chegando aqui, ele volta lá pra cima no 'while' para testar o novo número.
            }

            // 4. FIM: O código só chega aqui quando o usuário digitar um Negativo (condição virou False).
            Console.WriteLine("Numero negativo");
        }
    }
}