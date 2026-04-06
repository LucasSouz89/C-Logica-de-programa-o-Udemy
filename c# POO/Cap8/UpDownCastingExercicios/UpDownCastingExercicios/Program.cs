using System;
using UpDownCastingExercicios.Ex1.Entites.Class;
using UpDownCastingExercicios.Ex2.Entites.Class;
using UpDownCastingExercicios.Ex3.Entites.Class;
using UpDownCastingExercicios.Ex4.Entites.Class;
using UpDownCastingExercicios.Ex5.Entites.Class;

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
                //Jeito antigo : if (index is Arma) { Arma arma = new Arma();arma.Atacar(); }
                //Novo jeito:
                if (index is Arma arma) { arma.Atacar(); }
                else if (index is Consumivel consumivel) {consumivel.Curar(); }
            }
            //Ex3
            Habilidade habilidade = new Magia(20);
            Magia magia = habilidade as Magia;

            if (magia != null)
            {
                Console.WriteLine($"Magia com {magia.CustoDeMana} custo de mana");
            }
            else { Console.WriteLine("Essa magia não tem custo de mana"); }

            //Ex4
            NPC npc1 = new Vendedor("Astolfo");
            NPC npc2 = new QuestGiver("Ronaldo");
            InteragirNpc(npc1);
            InteragirNpc(npc2);
            //Ex5
            Veiculo v = new Moto("Honda");
            Tanque t =(Tanque)v;
        }
        public static void InteragirNpc(NPC npc)
        {
            if(npc is QuestGiver questgiver) { Console.WriteLine("Esse NPC da as quests");questgiver.EntregarMissao(); }
            else if(npc is Vendedor vendedor) { Console.WriteLine("Esse NPC é um vendedor");vendedor.AbrirLoja(); }
        }
    }
}
