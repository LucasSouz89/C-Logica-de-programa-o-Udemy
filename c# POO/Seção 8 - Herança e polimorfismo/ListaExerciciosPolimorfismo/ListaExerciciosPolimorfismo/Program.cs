using ListaExerciciosPolimorfismo.Entites.Class;
using ListaExerciciosPolimorfismo.Ex_2.Entites.Class;
using System.Globalization;

namespace ListaExerciciosPolimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ex 1
            /*
            Console.Write("Digite a quantidade de itens: ");
            var qtd = int.Parse(Console.ReadLine());
            List<Item> list = new List<Item>();
            for (int i = 1; i <= qtd; i++) {
                Console.WriteLine($"Item #{i}");
                Console.Write("Digite o nome e o preco base do item (Municao-2000): ");
                string[] vet = Console.ReadLine().Split('-');
                var nome = vet[0];
                var preco = double.Parse(vet[1],CultureInfo.InvariantCulture);
                var condi = true;
                while (condi)
                {
                    Console.WriteLine("Selecione o tipo de item:");
                    Console.Write("1-Normal 2-Arma 3-Erva: ");
                    var option = int.Parse(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            list.Add(new Item (nome, preco));
                            condi = false;
                            break;
                        case 2:
                            Console.Write("Digite o poder de fogo da arma: ");
                            var poderDeFogo = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                            list.Add(new Arma (nome, preco,poderDeFogo));
                            condi = false;
                            break;
                        case 3:
                            Console.Write("Qual é o tipo de erva?(Amarela,Verde,Vermelha): ");
                            var cor = Console.ReadLine();
                            list.Add(new Erva(nome,preco,cor));
                            condi = false;
                            break;
                        default:
                            break;
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Lista de todos os itens");
            foreach (Item i in list) {
                Console.WriteLine(i.Inspecionar());
            }
            */
            //Ex2
            List<Magia> magias = new List<Magia>();
            magias.Add(new Magia("Furacoes caoticos", 2000));
            magias.Add(new MagiaDeFogo("Meteoro do inferno", 5000, 3));
            magias.Add(new Necromancia("Roubo de alma", 1000, true));
            magias.Add(new Necromancia("Enxurrada de esqueletos", 2500, false));

            foreach (var magia in magias) {
                Console.WriteLine(magia.Conjurar());
            }
        }
    }
}
