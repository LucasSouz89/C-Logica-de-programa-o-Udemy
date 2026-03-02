using System;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {
            int N =int.Parse(Console.ReadLine());
            string[] nomes = new string[N];
            

            for (int i = 0; i < nomes.Length; i++) {
                nomes[i] = Console.ReadLine();
            }
            Console.Clear();
            Console.WriteLine("Nomes lidos:");
            //USando o foreacth para pecorrrer uma coleção
            //Ele é apenas para saida de dados e não para entrada
            //Com o for tbm é possivel fazer a mesma coisa mas o forecth é mais elegante
            foreach(string nome in nomes) {
                Console.WriteLine(nome);
            }
        }
    }
}