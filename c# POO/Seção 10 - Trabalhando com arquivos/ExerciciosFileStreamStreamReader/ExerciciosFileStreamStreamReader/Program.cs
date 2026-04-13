using System.Globalization;

namespace ExerciciosFileStreamStreamReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ex 1
            /*
            string path = @"C:\Windows\Temp\Treinamentos\server_log.txt";
            StreamReader sr =null;

            try {
                sr = File.OpenText(path);
                while (!sr.EndOfStream) { string line = sr.ReadLine();if (line.Contains("[ERROR]")) { Console.WriteLine(line); } }

            }catch(IOException e) { Console.WriteLine($"An error occurred: {e.Message}"); }
            finally
            {
                if(sr != null) {  sr.Close(); }
            }
            */
            //Ex 2
            var total = 0.0;
            string path = @"C:\Windows\Temp\Treinamentos\vendas_diarias.txt";
            StreamReader sr = null;
            try
            {
                sr = File.OpenText(path);
                while (!sr.EndOfStream) { string line = sr.ReadLine(); total += double.Parse(line, CultureInfo.InvariantCulture); }

            }
            catch (IOException e) { Console.WriteLine($"An error occurred: {e.Message}"); }
            finally { if (sr != null) { sr.Close(); } }
            Console.WriteLine($"Total de vendas do dia: R${total.ToString("F2",CultureInfo.InvariantCulture)}");
        }
    }
}
