using ExericiosInterfaceEHerança.Ex1.Entites.Class;
using ExericiosInterfaceEHerança.Ex2.Entites.Class;
using ExericiosInterfaceEHerança.Ex2.Entites.Interfaces;
using ExericiosInterfaceEHerança.Ex3.Entites.Class;
using ExericiosInterfaceEHerança.Ex3.Entites.Interfaces;
using System.Globalization;

namespace ExericiosInterfaceEHerança
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EX1
            //List<Campeao> campeoes = new List<Campeao>();
            // campeoes.Add(new Tanque("Sion",2000));
            // campeoes.Add(new Mago("Ryze", 1500));
            // foreach (var campeao in campeoes) { Console.WriteLine($"Vida final do campeao {campeao.Name}: {campeao.CalcularVidaFinal(200).ToString("F2",CultureInfo.InvariantCulture)}"); }
            //Ex2
            //List<Porta> portas = new List<Porta>();
            //portas.Add(new Porta(new CartaoMagnetico()));
            //portas.Add(new Porta(new ChaveDeEspadas()));

            //foreach(var porta in portas)
            //{
            //    porta.TentarAbrir();
            //}
            //Ex3
            List<Arma> armas = new List<Arma>();
            armas.Add(new EscopetaCanoDuplo("Escopeta explosiva", new TiroExplosivo()));
            armas.Add(new EscopetaCanoDuplo("Escopeta de plasma", new TiroPlasma()));

            foreach (var arma in armas) { arma.PuxarGatilho(); }
        }
    }
}
