using System;
using System.Globalization;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {
            int tamanho = 3;
            double[] triangulo1 = new double[tamanho];
            double[] triangulo2 = new double[tamanho];
            double[] area = new double[2];

            Console.WriteLine("Entre com as medidas do triangulo X: ");
            triangulo1 = Gravacao();
            Console.WriteLine("Entre com as medidas do triangulo Y: ");
            triangulo2 = Gravacao();
            
            area[0] = Area(triangulo1[0], triangulo1[1], triangulo1[2]);
            Console.WriteLine($"Area de X: {area[0].ToString("F4",CultureInfo.InvariantCulture)}");
            area[1] = Area(triangulo2[0], triangulo2[1], triangulo2[2]);
            Console.WriteLine($"Area de Y: {area[1].ToString("F4",CultureInfo.InvariantCulture)}");
            Maximo(area[0], area[1]);

        }

        public static double[] Gravacao() {
            double[] Vetor = new double[3];
            for (int i = 0; i < Vetor.Length; i++) {
                 Vetor[i] = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            }
            return Vetor;
        }
        public static double Area(double a, double b, double c) {
            double p = (double)(a + b + c) / 2;
            double area = Math.Sqrt(p*(p - a)*(p - b)*(p - c));
            return area;
        }
        public static void Maximo(double a, double b) {
            double max = Math.Max(a, b);
            if (max == a) { Console.WriteLine("Maior área: X"); } else if (max == b) { Console.WriteLine("Maior área: Y"); } else { Console.WriteLine("Empate!"); }
        }

    }
}