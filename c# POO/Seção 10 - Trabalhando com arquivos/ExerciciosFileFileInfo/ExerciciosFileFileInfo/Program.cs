
using ExerciciosFileFileInfo.Entites;
using System.IO;
namespace ExerciciosFileFileInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ex1
            /*
            try
            {
                string sourcePath = @"C:\Windows\Temp\Treinamentos\settings.txt";
                string[] lines = File.ReadAllLines(sourcePath);

                foreach (string line in lines) {
                    Console.WriteLine(line);
                }
            }
            catch (IOException)
            {

                Console.WriteLine("Aviso: Arquivo de configurações não encontrado. Carregando configurações padrão do sistema.");
            }
            */
            //Ex2
            /*
            try {
                FileInfo file = new FileInfo(@"C:\Windows\Temp\Treinamentos\savegame.txt");
                if (file.Exists) 
                { 
                    Console.WriteLine($"Tamanho do arquivo {file.Length}, data de criação {file.CreationTime}");
                    file.CopyTo(@"C:\Windows\Temp\Treinamentos\savegame_backup.txt",true);
                }
                else
                {
                    throw new IOException("Erro: arquivo não encontrado");
                }
            }
            catch(IOException e) { Console.WriteLine(e.Message); }
            */
            //Ex3
            try
            {
                Logger logger = new Logger();
                Console.WriteLine("Escreva uma mensagem para o arquivo: ");
                string message = Console.ReadLine();
                logger.WriteLog(message);
                

            }
            catch (IOException) { Console.WriteLine("Não foi possivel escrever o arquivo"); }
            


        }
    }
}
