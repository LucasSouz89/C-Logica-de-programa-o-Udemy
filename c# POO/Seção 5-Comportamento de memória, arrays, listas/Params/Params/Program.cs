using Params;
using System;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {
            //Jeito 1
            int result = Calculator.Sum(new int[] { 10, 20, 30, 40, 40 });
            Console.WriteLine(result);

            //Jeito 2
            result = Calculator.Sum2( 10, 20, 30, 40, 40 );
            Console.WriteLine(result);
        }
    }
}