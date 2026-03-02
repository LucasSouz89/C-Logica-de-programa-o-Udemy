using System;
using System.Globalization;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {
            int x;

            x = 5;
            double y = x * 2;
            Console.WriteLine(x);
            Console.WriteLine(y);

            double b, B, H, area;
            b = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            H = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = (b+B)/2.0 *H;

            Console.WriteLine(area.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("CALCULE A DIVISÃO");
            int a, c;
            double resultado;

            a = 5;
            c = 2;
            resultado = (double)a / c;

            Console.WriteLine(resultado.ToString("F2", CultureInfo.InvariantCulture));

            double j = 5;
            int k = (int)j;

            Console.WriteLine(k);

            

        }
    }
}