using System;
using System.Globalization;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {
            string opcao;


            do {
                Console.Write("Digite a temperatura em Celsius: ");
                double temp = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture), resultado;
                resultado = Faher(temp);
                Console.WriteLine($"Equivalente em Fahrenheit: {resultado.ToString("F1", CultureInfo.InvariantCulture)}");
                Console.Write("Deseja repetir (s/n)? ");
                opcao = Console.ReadLine();
                switch (opcao) {
                    case "s":
                        break;
                    case "n":
                        break;
                    default:
                        while (opcao != "n" && opcao != "s") {
                            Console.Write("Deseja repetir (s/n)? ");
                            opcao = Console.ReadLine();
                        }
                        break;
                }
            } while (opcao == "s");

        }
        public static double Faher(double temp) {
            double f = ((9 * temp) / 5) + 32;
            return f;
        }
    }

}