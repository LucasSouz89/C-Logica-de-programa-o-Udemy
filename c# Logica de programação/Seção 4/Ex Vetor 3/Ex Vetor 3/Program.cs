using System;
using System.Globalization;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {
            int N  = int.Parse(Console.ReadLine());
            string[] nomes = new string[N];
            int[] idade = new int[N];
            double[] altura = new double[N];
            
            double somaAltura = 0,media =0,porcentagemMenosDe16 = 0;
            int menosDe16 = 0;

            for (int i = 0; i < N; i++) {
                string[] vet = Console.ReadLine().Split(' ');
                nomes[i] = vet[0];
                idade[i] = int.Parse(vet[1]);
                altura[i] = double.Parse(vet[2],CultureInfo.InvariantCulture);
                somaAltura += altura[i];
                if (idade[i] < 16) { menosDe16++; }
            }
            media = somaAltura / N;
            porcentagemMenosDe16 = (double)(menosDe16 * 100.0 / N);
            Console.WriteLine($"Altura média: {media.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Pessoas com menos de 16 anos: {porcentagemMenosDe16.ToString("F1", CultureInfo.InvariantCulture)}%");
        }
    }
}