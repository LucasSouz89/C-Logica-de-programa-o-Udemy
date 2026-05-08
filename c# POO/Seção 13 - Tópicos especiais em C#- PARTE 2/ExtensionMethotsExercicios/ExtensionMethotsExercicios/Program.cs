using ExtensionMethotsExercicios.Extension;

namespace ExtensionMethotsExercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ex1
            bool resultado = 10.IsEven();
            Console.WriteLine(resultado);
            //Ex2
            string preco = 2300.00.ToBRL();
            Console.WriteLine(preco);
            //Ex 3
            int numero = 5.Fatorial();
            Console.WriteLine(numero);
            //Ex4
            string nome = "lucas".Capitalize();
            Console.WriteLine(nome);
            //Ex5
            Console.WriteLine("otorrinolaringologista".CountVowels());
            //Ex 6
            DateTime today = DateTime.Now;
            Console.WriteLine(today.IsWeekend());
            //Ex 6
            List<string> frutas = new List<string>() {"Abacaxi","Morango","Uva","Abacate","Melancia","Ameixa","Laranja" };
            Console.WriteLine($"Fruta selecionada: {frutas.GetRandom()}");
            //Ex7
            List<int> numeros = new List<int> { 1, 5, 8, 10, 42, 99, 100 };
            numeros.PrintAll();
            List<double> precos = new List<double> { 10.50, 42.99, 100.00, 0.99, 1500.55 };
            precos.PrintAll();
            List<string> nomes = new List<string> { "Lucas", "Maria", "Alex", "Bob", "Ana" };
            nomes.PrintAll();
            //Ex 8
            Dictionary<int,string> categoria = new Dictionary<int, string>();
            categoria.AddOrUpdate(1, "Esportes");
            categoria.AddOrUpdate(2, "Politica");
            categoria.AddOrUpdate(2, "Comunicação");
            Dictionary<string, double> notas = new Dictionary<string, double>();
            notas.AddOrUpdate("Joao", 10.00);
            notas.AddOrUpdate("Maria", 8.00);
            notas.AddOrUpdate("Miguel", 4.00);
        }
    }
}
