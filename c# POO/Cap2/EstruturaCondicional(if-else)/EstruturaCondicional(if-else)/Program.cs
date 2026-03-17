using System;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {

            // -----------------------------------------------------------------
            // EXERCÍCIO 01: Lógica de Saudação (Ranges e Validação)
            // -----------------------------------------------------------------

            Console.WriteLine("Que horas são?");
            int hora = int.Parse(Console.ReadLine());

            if (hora >= 5 && hora < 12) {
                // Manhã: Entre 05:00 e 11:59
                Console.WriteLine("Bom dia");
            } else if (hora >= 12 && hora < 18) {
                // Tarde: Entre 12:00 e 17:59
                Console.WriteLine("Boa tarde");
            } else if (hora > 24 || hora < 0) {
                // Validação: Usa o OU (||) para barrar números impossíveis
                Console.WriteLine("Digite um horário válido");
            } else {
                // Noite: O que sobrou (0h-4h e 18h-24h)
                Console.WriteLine("Boa noite");
            }

            Console.WriteLine("----------------------------------");

            // -----------------------------------------------------------------
            // EXERCÍCIO 02: Par ou Ímpar (Operador Módulo %)
            // -----------------------------------------------------------------

            Console.WriteLine("Entre com um número inteiro:");
            int num1 = int.Parse(Console.ReadLine());

            // O operador % pega o RESTO da divisão.
            // Se o resto da divisão por 2 for ZERO, o número é PAR.
            int mod = num1 % 2;

            if (mod == 0) {
                Console.WriteLine("Par");
            } else {
                Console.WriteLine("Ímpar");
            }

            Console.WriteLine("----------------------------------");

            // -----------------------------------------------------------------
            // DICA DE SINTAXE: If de Linha Única
            // -----------------------------------------------------------------

            int k = 0;

            // Regra: Se o bloco do if/else tiver APENAS UM comando,
            // as chaves { } são opcionais.

            if (k == 0) Console.WriteLine("K é 0 (Sintaxe resumida)");

            // Mas cuidado! Se tiver mais de uma linha, as chaves são OBRIGATÓRIAS.
            // Para quem está começando, recomendo usar sempre as chaves para organizar.
        }
    }
}