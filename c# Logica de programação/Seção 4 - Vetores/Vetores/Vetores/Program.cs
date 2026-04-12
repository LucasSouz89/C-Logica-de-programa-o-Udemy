using System;
using System.Globalization;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {
           int N = int.Parse(Console.ReadLine());
           //declaração e instanciação
           double[] vet = new double[N];

            for (int i = 0; i < vet.Length; i++) {
                //acesso
                vet[i] = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);                
            }
            Console.Clear();
            for (int i = 0; i < vet.Length; i++) {
                Console.WriteLine(vet[i].ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}