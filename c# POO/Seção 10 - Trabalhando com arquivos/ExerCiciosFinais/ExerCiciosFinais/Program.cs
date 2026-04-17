using ExerCiciosFinais.Class;
using System;
using System.Globalization;

namespace ExerCiciosFinais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ex 1
            //string path = @"C:\Users\Lucas\Downloads\Planilha1.csv";


            //try
            //{
            //    using (StreamReader sr = File.OpenText(path))
            //    {
            //        string pastaBase = Path.GetDirectoryName(path);
            //        string novaPasta = pastaBase + @"\relatorios";
            //        string finalPath = novaPasta + @"\xp_lucas.txt";
            //        int sum = 0;
            //        while (!sr.EndOfStream)
            //        {
            //            string[] line = sr.ReadLine().Trim(' ', '\'', '\"').Split(",");
            //            string nome = line[0];
            //            string enemy = line[1];
            //            int xp = int.Parse(line[2]);
            //            if(nome == "Lucas") { sum += xp; }
            //        }
            //        using(StreamWriter sw = File.CreateText(novaPasta))
            //        {
            //            sw.WriteLine($"Total de xp acumulado {sum}");
            //        }
            //    }
            //}catch(IOException E) { Console.WriteLine($"Um erro ocorreu: {E.Message}"); }

            string path = @"C:\Temp\Pesos.csv";
            string directory = Path.GetDirectoryName(path) + @"\resultado";
            string finalPath = directory + @"\pesosfinais.csv";
            try {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Itens> list = new List<Itens>();
                    while (!sr.EndOfStream)
                    {
                        string linhaLida = sr.ReadLine();
                        if (string.IsNullOrWhiteSpace(linhaLida)) { continue;}

                        string[] line = linhaLida.Split(",");
                        
                        string name  = line[0];
                        double weight = double.Parse(line[1].Trim(' ', '\'', '\"'), CultureInfo.InvariantCulture);
                        int qtd = int.Parse(line[2].Trim(' ', '\'', '\"'), CultureInfo.InvariantCulture) ;
                        list.Add(new Itens(name,weight,qtd));
                    }
                    if (!Directory.Exists(directory)) { Directory.CreateDirectory(directory); }
                    using (StreamWriter sw = File.CreateText(finalPath))
                    {
                        foreach (var item in list) { sw.WriteLine(item); }
                    }
                }
            }catch (IOException E) { Console.WriteLine($"Um erro ocorreu: {E.Message}"); }
            catch(FormatException E) { Console.WriteLine($"Um erro ocorreu: {E.Message}"); }

        }
    }
}
