using System;
using System.Globalization;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {
            while (true) {
                
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Clear();
                double raiz = Math.Sqrt(valor), potencia = Math.Pow(valor,4), absoluto = Math.Abs(valor);
                Resultado("raiz", valor, raiz);
                Resultado("potencia", valor, potencia);
                Resultado("absoluto", valor, absoluto);


            }
        }
        public static void Resultado(string tipo, double numero, double equacao) 
            {
            
             Console.WriteLine($"Valor {tipo} de {numero.ToString("F2", CultureInfo.InvariantCulture)} é = {equacao.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}