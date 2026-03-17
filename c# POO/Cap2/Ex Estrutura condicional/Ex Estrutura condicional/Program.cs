using System;
using System.Globalization;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {

            // =================================================================
            // LISTA DE EXERCÍCIOS: ESTRUTURA CONDICIONAL (IF / ELSE)
            // =================================================================

            // Dica Geral: CultureInfo.InvariantCulture serve para o C# aceitar
            // o PONTO (.) como separador decimal (Padrão Internacional), e não a vírgula.

            // -----------------------------------------------------------------
            // EXERCÍCIO 01: Negativo ou Não
            // -----------------------------------------------------------------
            /*
            int numero = int.Parse(Console.ReadLine());

            if (numero < 0) {
                Console.WriteLine("NEGATIVO");
            } else {
                Console.WriteLine("NAO NEGATIVO");
            }
            */

            // -----------------------------------------------------------------
            // EXERCÍCIO 02: Par ou Ímpar (Operador Módulo %)
            // -----------------------------------------------------------------
            /*
            Console.WriteLine("digite um numero");
            // Dica: O operador % pega o RESTO da divisão. Se resto == 0, é par.
            int numero = int.Parse(Console.ReadLine()), mod = numero % 2;

            if (mod == 0)
                Console.WriteLine("PAR");
            else
                Console.WriteLine("IMPAR");
            */

            // -----------------------------------------------------------------
            // EXERCÍCIO 03: Múltiplos
            // -----------------------------------------------------------------
            /*
            // Lê dois números na mesma linha
            string[] vet = Console.ReadLine().Split(' '); 
            int A = int.Parse(vet[0]);
            int B = int.Parse(vet[1]);

            // Testamos os dois lados com OU (||) porque não sabemos a ordem
            if (A % B == 0 || B % A == 0) 
                Console.WriteLine("Sao Multiplos");
            else 
                Console.WriteLine("Nao sao Multiplos");
            */

            // -----------------------------------------------------------------
            // EXERCÍCIO 04: Duração de Jogo (Lógica do Relógio)
            // -----------------------------------------------------------------
            /*
            Console.WriteLine("Digite a hora inicial e final");
            string[] vet = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(vet[0]);
            int horaFinal = int.Parse(vet[1]);
            int duracao;

            if (horaInicial < horaFinal) {
                // Começou e terminou no mesmo dia
                duracao = horaFinal - horaInicial;
            }
            else {
                // Virou a noite OU durou 24h (0 e 0)
                // Fórmula mágica: 24 - inicio + fim
                duracao = 24 - horaInicial + horaFinal;
            }
            
            Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");
            */

            // -----------------------------------------------------------------
            // EXERCÍCIO 05: Lanchonete (Código e Quantidade)
            // -----------------------------------------------------------------
            /*
            string[] vet = Console.ReadLine().Split(' ');
            int code = int.Parse(vet[0]);
            int quantid = int.Parse(vet[1]);
            double total;

            if (code == 1) total = quantid * 4.00;
            else if (code == 2) total = quantid * 4.50;
            else if (code == 3) total = quantid * 5.00;
            else if (code == 4) total = quantid * 2.00;
            else total = quantid * 1.50; // Código 5 (Refri)

            Console.WriteLine($"Total: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
            */

            // -----------------------------------------------------------------
            // EXERCÍCIO 06: Intervalos ( && = E )
            // -----------------------------------------------------------------
            /*
            double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (numero >= 0 && numero <= 25) Console.WriteLine("Intervalo [0,25]");
            else if (numero > 25 && numero <= 50) Console.WriteLine("Intervalo (25,50]");
            else if (numero > 50 && numero <= 75) Console.WriteLine("Intervalo (50,75]");
            else if (numero > 75 && numero <= 100) Console.WriteLine("Intervalo (75,100]");
            else Console.WriteLine("Fora de intervalo");
            */

            // -----------------------------------------------------------------
            // EXERCÍCIO 07: Coordenadas Cartesianas (X, Y)
            // -----------------------------------------------------------------
            /*
            string[] vet = Console.ReadLine().Split(' ');
            double x = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double y = double.Parse(vet[1], CultureInfo.InvariantCulture);

            // Importante: Testar Origem e Eixos ANTES dos Quadrantes
            if (x == 0.0 && y == 0.0) Console.WriteLine("Origem");
            else if (x == 0.0) Console.WriteLine("Eixo Y");
            else if (y == 0.0) Console.WriteLine("Eixo X");
            else if (x > 0.0 && y > 0.0) Console.WriteLine("Q1");
            else if (x < 0.0 && y > 0.0) Console.WriteLine("Q2");
            else if (x < 0.0 && y < 0.0) Console.WriteLine("Q3");
            else Console.WriteLine("Q4");
            */

            // -----------------------------------------------------------------
            // EXERCÍCIO 08: Imposto de Renda (Progressivo) - O CHEFÃO 🏆
            // -----------------------------------------------------------------

            Console.WriteLine("Calcule seu imposto de renda");
            double renda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double Imposto;

            if (renda < 0) {
                Console.WriteLine("Digite um valor valido");
            }
            // Faixa 1: Isento
            else if (renda <= 2000.00) {
                Console.WriteLine("Isento");
            }
            // Faixa 2: 8%
            else if (renda <= 3000.00) {
                // Cobra 8% só do que passou de 2000
                Imposto = (renda - 2000.0) * 0.08;
                Console.WriteLine($"R$ {Imposto.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            // Faixa 3: 18%
            else if (renda <= 4500.00) {
                // 80 reais (teto da faixa anterior) + 18% do que passou de 3000
                Imposto = 80.0 + (renda - 3000.0) * 0.18;
                Console.WriteLine($"R$ {Imposto.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            // Faixa 4: 28%
            else { // renda > 4500
                // 80 (faixa 2) + 270 (faixa 3) + 28% do que passou de 4500
                Imposto = 80.0 + 270.0 + (renda - 4500.0) * 0.28;
                Console.WriteLine($"R$ {Imposto.ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}