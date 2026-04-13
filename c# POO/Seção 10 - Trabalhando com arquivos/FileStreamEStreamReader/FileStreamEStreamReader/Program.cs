using System.IO;

namespace FileStreamEStreamReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Windows\Temp\Treinamentos\file1.txt";

            // Declaramos o leitor FORA do try. 
            // Se colocar dentro, o bloco 'finally' lá embaixo não vai conseguir enxergar ele.
            StreamReader sr = null;

            try
            {
                // Atalho top: O C# já cria o FileStream por baixo dos panos e entrega o leitor pronto
                sr = File.OpenText(path);

                // Enquanto NÃO chegar no final do arquivo...
                while (!sr.EndOfStream)
                {
                    // Lê só a linha atual, imprime e joga fora da RAM. Muito mais leve!
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"An error occurred: {e.Message}");
            }
            finally
            {
                // Aconteça o que acontecer (dando erro ou não), a gente precisa devolver a "chave" do arquivo pro Windows.
                // O 'if' garante que a gente não vai tentar fechar algo que nem chegou a ser aberto.
                if (sr != null) sr.Close();
            }
        }
    }
}