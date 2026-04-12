using System;
using System.Globalization;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {
            //Ex 1
            //feito por mim
            /*
            Console.Write("Digite um valor inteiro: ");
            int X = int.Parse(Console.ReadLine());
            
            
            for (int i = 0; i <= X; ) {
                int mod = X % 2;

                if (mod == 0) {

                } else
                    
                {
                    Console.WriteLine($"{X}");
                }
                X = X - 1;
            }
            */
            //Correção
            /*
            for (int i = 1; i <= X; i++) {

                if (i % 2 != 0) { Console.WriteLine(i); }

            }
            */
            //Ex 2
            /*Console.Write("Digite a quantidade de numeros ");
            int INN = 0;
            int outt = 0;
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++) {
                int a = int.Parse(Console.ReadLine());
                if (a >= 10 && a <= 20) {
                    INN++;
                } else outt++;

            }
            Console.WriteLine($"{INN} in");
            Console.WriteLine($"{outt} out");
            */

            //EX3
            /*
            Console.Write("Digite um numero: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++) {
                Console.WriteLine("Digite três notas (mesma linha): ");
                string[] vet = Console.ReadLine().Split(' ');
                double valor = double.Parse(vet[0], CultureInfo.InvariantCulture);
                double valor1 = double.Parse(vet[1], CultureInfo.InvariantCulture);
                double valor2 = double.Parse(vet[2], CultureInfo.InvariantCulture);
                double resultado = (double)((valor * 2) + (valor1 * 3) + (valor2 * 5) / 10);
                Console.WriteLine($"Valor #{i}: {resultado.ToString("F1", CultureInfo.InvariantCulture)}");

            */
            //EX4
            /*
            Console.Write("Digite a quantidade de divisões: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++) 
                {
                Console.Write("Digite dois numeros na mesma linha: ");
                string[] vet = Console.ReadLine().Split(' ');
                int num1 = int.Parse(vet[0]);
                int num2 = int.Parse(vet[1]);
                double divisao = (double)num1 / (num2);
                if((divisao <= 0 || divisao >= 0) && (divisao != double.PositiveInfinity && divisao != double.NegativeInfinity) ) Console.WriteLine(divisao.ToString("F1",CultureInfo.InvariantCulture));
                else Console.WriteLine("Divisão impossível");

            }
            */
            //Ex 5
            /*
            Console.WriteLine("Digite um numero: ");
            int N = int.Parse(Console.ReadLine());
            int Fatorial = 1;

            

            for (int i = 1; i <= N; i++) {
                Fatorial = Fatorial * i;

                
            }
            Console.WriteLine(Fatorial);
            */
            //Ex 6
            /*
            Console.Write("Digite um numero: ");
            int N = int.Parse(Console.ReadLine());
            


            for (int i = 1; i <= N; i++) {
                int divisao = N % i;

                if (divisao == 0) {
                    Console.WriteLine(i);
                }
            }
            */
            //Ex 7
            Console.Write("Digite um numero: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++) {
                int quadrado = (int)Math.Pow(i, 2);
                int cubo = (int)Math.Pow(i, 3);

                Console.WriteLine($"{i} {quadrado} {cubo}");

            }
        }
    }
}