using System;
using UpDownCastingExercicios.Ex1.Entites.Class;
using UpDownCastingExercicios.Ex2.Entites.Class;

namespace UpDownCastingExercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ex 1
            List<Entidade> entity = new List<Entidade>();

            for (int i = 0; i < 5; i++)
            {
                if (i < 3) entity.Add(new Zumbi($"Zumbi {i}", i + 1)); 
                else entity.Add(new Cacodemon($"Cacodemon {i}", i + 1));
            }
            foreach(Entidade e in entity)
            {
                Console.WriteLine(e);
            }
            //Ex 2
            List<Item> itens = new List<Item>();
            Console.Write("Quantidade de armas: ");
            var qtd = int.Parse(Console.ReadLine());
            for (int i = 1;i <= qtd; i++) {
                Console.Write($"Arma {i}#: ");
                itens.Add(new Arma(Console.ReadLine()));
            }
            Console.Write("Quantidade de consumiveis: ");
            qtd = int.Parse(Console.ReadLine());
            for (int i = 1; i <= qtd; i++)
            {
                Console.Write($"Consumivel {i}#: ");
                itens.Add(new Consumivel(Console.ReadLine()));
            }
            foreach (Item index in itens)
            {
                if (index is Arma arma) { arma.Atacar(); }
                else if (index is Consumivel consumivel) {consumivel.Curar(); }
            }
        }
    }
}
