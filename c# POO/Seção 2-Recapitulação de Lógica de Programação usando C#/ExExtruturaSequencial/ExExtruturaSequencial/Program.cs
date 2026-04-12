using System;
using System.Globalization;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {

            // -----------------------------------------------------------------
            // EXERCÍCIO 01: Soma Simples
            // -----------------------------------------------------------------
            /*
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"SOMA = {num1 + num2}");
            */

            // -----------------------------------------------------------------
            // EXERCÍCIO 02: Área do Círculo
            // -----------------------------------------------------------------
            /*
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double pi = 3.14159;
            double area = pi * Math.Pow(raio, 2);
            
            Console.WriteLine($"A={area.ToString("F4", CultureInfo.InvariantCulture)}");
            */

            // -----------------------------------------------------------------
            // EXERCÍCIO 03: Diferença de Produtos
            // -----------------------------------------------------------------
            /*
            string[] vet = Console.ReadLine().Split(' ');
            int A = int.Parse(vet[0]), B = int.Parse(vet[1]), C = int.Parse(vet[2]), D = int.Parse(vet[3]);

            Console.WriteLine($"DIFERENCA = {(A * B - C * D)}");
            */

            // -----------------------------------------------------------------
            // EXERCÍCIO 04: Cálculo de Salário
            // -----------------------------------------------------------------
            /*
            Console.WriteLine("Digite o numero de funcionarios:");
            int funcionarios = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Digite o numero de horas trabalhadas:");
            int HorasTrabalhadas = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Digite o valor do salario/hora:");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double salario = valor * HorasTrabalhadas;

            Console.Clear();
            Console.WriteLine($"NUMBER = {funcionarios}");
            Console.WriteLine($"SALARY = U$ {salario.ToString("F2", CultureInfo.InvariantCulture)}");
            */

            // -----------------------------------------------------------------
            // EXERCÍCIO 05: Valor a Pagar (Peças)
            // -----------------------------------------------------------------
            /*
            Console.WriteLine("Digite o codigo, quantidade e preço de um produto (mesma linha)");
            string[] vet = Console.ReadLine().Split(' ');
            int codigo = int.Parse(vet[0]);
            int quantidade = int.Parse(vet[1]);
            double preço = double.Parse(vet[2], CultureInfo.InvariantCulture);
            double total = preço * quantidade;
            
            Console.Clear();
            
            Console.WriteLine("Digite o codigo, quantidade e preço de outro produto (mesma linha)");
            string[] vet2 = Console.ReadLine().Split(' ');
            int codigo2 = int.Parse(vet2[0]);
            int quantidade2 = int.Parse(vet2[1]);
            double preço2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);
            double total2 = preço2 * quantidade2;

            Console.WriteLine($"VALOR A PAGAR: R$ {(total + total2).ToString("F2", CultureInfo.InvariantCulture)}");
            */

            // -----------------------------------------------------------------
            // EXERCÍCIO 06: Áreas Geométricas (ATIVO)
            // -----------------------------------------------------------------

            Console.WriteLine("DE UM NUMERO PARA AS LETRAS A B C (MESMA LINHA)");
            string[] vet = Console.ReadLine().Split(' ');

            double A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            double C = double.Parse(vet[2], CultureInfo.InvariantCulture);
            double pi = 3.14159;

            Console.Clear();

            double areaTriangulo = (A * C) / 2;
            double areaCirculo = pi * Math.Pow(C, 2);
            double areaTrapezio = ((A + B) * C) / 2;
            double areaQuadrado = B * B;
            double areaRetangulo = A * B;

            Console.WriteLine($"TRIANGULO: {areaTriangulo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"CIRCULO: {areaCirculo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"TRAPEZIO: {areaTrapezio.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"QUADRADO: {areaQuadrado.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"RETANGULO: {areaRetangulo.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}