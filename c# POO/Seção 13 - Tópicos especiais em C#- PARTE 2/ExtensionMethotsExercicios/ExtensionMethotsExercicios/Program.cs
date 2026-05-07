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
        }
    }
}
