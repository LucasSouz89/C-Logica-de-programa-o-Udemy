using ExExceptionsPersonalizadas.Entites.Class;
using ExExceptionsPersonalizadas.Entites.Exceptions;

namespace ExExceptionsPersonalizadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Package> packages = new List<Package>();
                packages.Add(new Package("AHJL-2026", 20, 40)); // Sem erros
                packages.Add(new Package("SASA-2025",20,21)); // Erro ao adicionar uma carga maior que a capacidade maxima
                packages.Add(new Package("Q2DSA-2024", 20, 19)); //Erro de peso maior que capacidade maxima

                foreach(var i in packages)
                {
                    i.AddWeight(5);
                    Console.WriteLine(i);
                }
            }
            catch (ExceptionDomain domain) { Console.WriteLine(domain.Message); }
            
        }
    }
}
