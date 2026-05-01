using HashcodeEqualsExercicios.Ex1;
using HashcodeEqualsExercicios.Ex2;

namespace HashcodeEqualsExercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ex1
            //Produto p = new Produto(1334, "TV");
            //Produto p2 = new Produto(1334, "TV");
            //HashSet<Produto> set = new HashSet<Produto>();
            //set.Add(p);
            //set.Add(p2);
            //Console.WriteLine(set.Count);
            //Ex2
            Cordenada c1 = new Cordenada(10, 20);
            Cordenada c2 = new Cordenada(10, 20);
            Cordenada c3 = new Cordenada(15, 20);
            HashSet<Cordenada> cordenadas = new HashSet<Cordenada>();
            cordenadas.Add(c1);
            cordenadas.Add(c2);
            cordenadas.Add(c3);
            Console.WriteLine(cordenadas.Count);
        }
    }
}
