using ExercicioCapitulo;
using System;
using System.Globalization;

namespace MyApp {
        internal class Program {
            static void Main(string[] args) {
            Conta c;
            Console.Write("Entre o número da conta: ");
                int numero = int.Parse(Console.ReadLine());
                Console.Write("Entre o titular da conta: ");
                string nome = Console.ReadLine();
                Console.Write("Havera um deposito inicial (s/n)? ");
                string alternativa = Console.ReadLine();
                double valor;

            if (alternativa == "s" || alternativa == "S") {
                Console.Write("Entre o valor de depósito inicial: ");
                valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c = new Conta(nome, numero, valor);
            } else {
                c = new Conta(nome, numero);
            }


                Console.WriteLine();
                Console.WriteLine("Dados da conta:");
                Console.WriteLine(c);
                Console.WriteLine();
                Console.Write("Entre um valor para depósito: ");
                valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c.Deposito(valor);
                Console.WriteLine("Dados da conta atualizados:");
                Console.WriteLine(c);
                Console.WriteLine();
                Console.Write("Entre um valor para saque: ");
                valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c.Sacar(valor);
                Console.WriteLine("Dados da conta atualizados:");
                Console.WriteLine(c);

            }
        }
    }
