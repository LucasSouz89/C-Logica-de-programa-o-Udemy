using System;

namespace MyApp {
    internal class Program {
        //ex1
        /*
        static void Main(string[] args) {

            double? distanciaAlvo = null;
            Detector(distanciaAlvo);
            distanciaAlvo = 20;
            Detector(distanciaAlvo);

        }
        public static void Detector(double ? d) {
            if (d.HasValue) { Console.WriteLine($"Alvo detectado a {d} m"); } else {
                Console.WriteLine("Nenhum alvo detectado");
            }
        }
        */
        //Ex 2
        /*
        static void Main(string[] args) {

            int? pontuacaoSalva = null;
            int pontuacaoAtual = pontuacaoSalva ?? 0;
            Console.WriteLine(pontuacaoAtual);

        }
        */
        //Ex3
        static void Main(string[] args) {

            int? municaoExtra = null;
            int municaoTotal = 30 + municaoExtra.GetValueOrDefault();
        }
    }
}