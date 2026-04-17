using Exercicio_de_fixação.Class;
using System.Globalization;
using Exercicio_de_fixação.Exceptions;

namespace Exercicio_de_fixação
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string SourcePath = @"C:\Temp\produtos.csv";
            string FinalPath = @"C:\Temp\produtosFinal.csv";

            //Priemira forma
            //try
            //{
            //    Console.WriteLine("Registro de produtos");
            //    Console.Write("Quantos produtos devem ser adicionados? ");
            //    int qtd = int.Parse(Console.ReadLine());


            //    using (StreamWriter sw = File.CreateText(SourcePath))
            //    {
            //        List<Produtos> list = new List<Produtos>();
            //        for (int i = 0; i < qtd; i++)
            //        {
            //            Console.Write("Nome: ");
            //            string name = Console.ReadLine();
            //            Console.Write("Preço: ");
            //            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //            Console.Write("Quantidade: ");
            //            int q = int.Parse(Console.ReadLine());
            //            list.Add(new Produtos(name, price, q));

            //        }
            //        foreach (var p in list)
            //        {
            //            sw.WriteLine(p.Catalog());
            //        }
            //        using (StreamWriter sw2 = File.CreateText(FinalPath))
            //        {
            //            foreach (var p in list) { sw2.WriteLine(p); }
            //        }
            //    }
            //}
            //catch (ExceptionDomain e)
            //{
            //    Console.WriteLine($"Um erro ocorreu: {e.Message}");
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine($"Um erro ocorreu: {e.Message}");
            //}
            //catch (Exception e) 
            //{

            //}
            //SegundaForma
            try
            {
                using (StreamReader sr = File.OpenText(SourcePath))
                {
                    List<Produtos> list = new List<Produtos>();
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(",");
                        string name = line[0];
                        double price = double.Parse(line[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(line[2]);
                        list.Add(new Produtos(name, price, quantity));
                    }
                    using (StreamWriter sw = File.CreateText(FinalPath))
                    {
                        foreach (Produtos produto in list)
                        {
                            sw.WriteLine(produto);
                        }
                    }

                }

            }
            catch (ExceptionDomain e)
            {
                Console.WriteLine($"Um erro ocorreu: {e.Message}");
            }
            catch (IOException e)
            {
                Console.WriteLine($"Um erro ocorreu: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Um erro ocorreu: {e.Message}");

            }


        }
    }
}
