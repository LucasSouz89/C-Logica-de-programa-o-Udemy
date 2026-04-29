using GenericsRestricoes.Ex1.Class;
using GenericsRestricoes.Ex2.Class;

namespace GenericsRestricoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ex1
            //try
            //{
            //    Caixa<int> caixa = new Caixa<int>();
            //    Caixa<string> caixa1 = new Caixa<string>();
            //    caixa.Guardar(23);
            //    // caixa.Inspecionar();
            //    caixa.Guardar(23);
            //}
            //catch (Exception ex) { Console.WriteLine(ex.Message); }
            //Ex2
            string campeao = "Ryze";
            string Jogador = "Faker";
            Magia.TrocarValores(ref campeao,ref Jogador);
            Console.WriteLine(campeao);
            Console.WriteLine(Jogador);
        }
    }
}
