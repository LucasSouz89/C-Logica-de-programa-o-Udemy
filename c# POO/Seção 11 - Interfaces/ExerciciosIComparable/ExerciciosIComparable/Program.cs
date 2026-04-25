using ExerciciosIComparable.Ex1;
using ExerciciosIComparable.Ex2;
using ExerciciosIComparable.Ex3;

namespace ExerciciosIComparable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ex1
            //List<Item> items = new List<Item>();
            //items.Add(new Item("Poção de cura", 200));
            //items.Add(new Item("Espada longa",150));
            //items.Add(new Item("Arco curto",110));
            //items.Sort();
            //foreach (var item in items) { Console.WriteLine(item); }
            //Ex2
            //List<Jogador> jogadores = new List<Jogador>();
            //jogadores.Add(new Jogador("Faker", 100, 15.5));
            //jogadores.Add(new Jogador("Caps", 90, 14));
            //jogadores.Add(new Jogador("ShowMaker", 100, 13.2));
            //jogadores.Sort();
            //foreach(var jogador in jogadores)
            //{
            //    Console.WriteLine(jogador);
            //}
            //Ex3
            List<CampeaoLol> tanks = new List<CampeaoLol>();
            tanks.Add(new CampeaoLol("Sion", 8000, 150));
            tanks.Add(new CampeaoLol("DR.Mundo", 8000, 140));
            tanks.Add(new CampeaoLol("Orn", 8500, 110));
            tanks.Sort();
            foreach (var tank in tanks) { Console.WriteLine(tank); }
        }
    }
}
