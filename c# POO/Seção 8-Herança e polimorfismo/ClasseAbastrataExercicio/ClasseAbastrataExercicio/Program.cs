using ClasseAbastrataExercicio.Ex1.Entites.Class;
using ClasseAbastrataExercicio.Ex2.Entites.Class;

namespace ClasseAbastrataExercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ex 1
            List<Campeao> campeoes = new List<Campeao>();
            campeoes.Add(new Assassino("Zed",200));
            campeoes.Add(new Atirador("Jinx",300));

            foreach(var c in campeoes)
            {
                c.UsarUltimate();
                c.AtaqueBasico();
            }
            //Ex 2
            List<Veiculo> veiculos = new List<Veiculo>();
            veiculos.Add(new Moto("Shotaro",120,true));
            veiculos.Add(new Moto("Bati 801", 100, false));
            veiculos.Add(new Helicoptero("Buzzard",300,100));
            
            foreach(var veiculo in veiculos)
            {
                Console.WriteLine(veiculo.TentarFuga());
                veiculo.Frear();
            }
        }
    }
}
