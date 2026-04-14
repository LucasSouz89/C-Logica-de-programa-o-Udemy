using System.Collections.Generic;

namespace DirectoryDirectoryInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Windows\Temp\Myfolder";
            //Detecta o sistema operciaonal correto e inverte a barra ou não
            string newFolder = Path.Combine(path, "newFolder");

            try
            {
                //Mostrar todas as subpastas
                IEnumerable<string> folder = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS: ");
                foreach (string item in folder)
                {
                    Console.WriteLine(item);
                }
                //Mostrar os aqruivos no diretorio
                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FIles: ");
                foreach (string item in files)
                {
                    Console.WriteLine(item);
                }
                //Criando subpast no diretorio
                Directory.CreateDirectory(newFolder);

                } 
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
