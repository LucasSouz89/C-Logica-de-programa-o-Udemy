using ExercicioResolvido.Entites;
using System.Globalization;

namespace ExercicioResolvido
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            ReadPath(products);
            ShowInformation(products);
        }
        public static void ReadPath(List<Product> p) 
        {
            try
            {
                Console.Write("Enter full file path: ");
                string path = @"" + Console.ReadLine();
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        p.Add(new Product(line));
                    }
                }
            }
            catch (IOException e) { Console.WriteLine($"A error ocurred: {e.Message}"); }
            catch (InvalidOperationException e) { Console.WriteLine($"A error ocurred: {e.Message}"); }
            catch (FormatException e) { Console.WriteLine($"A error ocurred: {e.Message}"); }
            catch (Exception e) { Console.WriteLine($"A error ocurred: {e.Message}"); }
        }
        public static void ShowInformation(List<Product> p) {
            
                var avarengePrice = p.DefaultIfEmpty().Average(x => x.Price);
                Console.WriteLine($"Average price: {avarengePrice.ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine(string.Join("\n", p.Where(x => x.Price < avarengePrice).OrderByDescending(x => x.Name).Select(x => x.Name)));
            

        }
    }
}
