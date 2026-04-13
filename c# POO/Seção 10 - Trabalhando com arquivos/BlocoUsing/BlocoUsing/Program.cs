using System.IO;

namespace BlocoUsing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Windows\Temp\Treinamentos\file1.txt";
            try
            {
                // O bloco using é um try-finally disfarçado. 
                // Ele garante que o StreamReader vai ser fechado automaticamente no final, poupando código.
                using (StreamReader sr = File.OpenText(path))
                {
                    // Lemos linha por linha normalmente
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                } // <--- Chegou aqui? O C# dá o .Close() no arquivo sozinho!

            }
            catch (IOException e)
            {
                Console.WriteLine($"An error occurred: {e.Message}");
            }
        }
    }
}