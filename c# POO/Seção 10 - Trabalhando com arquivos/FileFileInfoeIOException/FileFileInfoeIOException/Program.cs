using System.IO;

namespace FileFileInfoeIOException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Caminhos chumbados para teste
            string sourcePath = @"C:\Windows\Temp\file1.txt";
            string targetPath = @"C:\Windows\Temp\file2.txt";

            try
            {
                // Prepara as informações do arquivo original na memória (não abre o arquivo ainda)
                FileInfo fileinfo = new FileInfo(sourcePath);

                // Copia para o destino. O 'true' serve para esmagar o arquivo velho se já existir um file2.txt lá
                fileinfo.CopyTo(targetPath, true);

                // Puxa todas as linhas de uma vez pra memória RAM. (Perigoso se o txt tiver 5GB!)
                string[] lines = File.ReadAllLines(sourcePath);

                // Imprime linha por linha
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException error)
            {
                // Se der B.O (ex: arquivo não existe ou o Windows bloqueou o acesso), cai aqui
                Console.WriteLine("An error occurred");
                Console.WriteLine(error.Message);
            }
        }
    }
}