using System.Runtime.Serialization;

namespace ExerciciosDirectoryDirectoryInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ex1 
            /*
            string rootPath = @"C:\Windows\Temp\MeuNovoJogo";
            string[] pathsName = new string[] { "Scripts", "Prefabs", "Scenes", "Audio" };
            try
            {

                if (!Directory.Exists(rootPath))
                {
                   Directory.CreateDirectory(rootPath);
                    
                }
                foreach (string path in pathsName) {
                    string caminho = Path.Combine(rootPath, path);
                    Directory.CreateDirectory(caminho);
                }
                

                

   
            }
            catch(IOException e) { Console.WriteLine(e.Message); }
            */
            try
            {
                string rootPath = @"C:\Windows\Temp\PastaBaguncada";
                string newPath = @"C:\Windows\Temp\PastaBaguncada\Textos_Backup";
                string[] filesList = new string[] { "notas.txt", "foto.jpg", "planilha.csv", "lembrete.txt" };
                
                if (!Directory.Exists(rootPath)) { Directory.CreateDirectory(rootPath); }
                
                foreach (string file in filesList)
                {
                    string newpath = Path.Combine(rootPath, file);
                    File.Create(newpath).Close();

                }
                Directory.CreateDirectory(newPath);
                IEnumerable<string> files = Directory.EnumerateFiles(rootPath, "*.txt");
                Console.WriteLine("Copiando arquivos...");
                foreach (string fileDestines in files)
                {
                    string fileName = Path.GetFileName(fileDestines);

                    string finalDestiny = Path.Combine(newPath, fileName);
                    
                    File.Move(fileDestines, finalDestiny);
                    Console.WriteLine($"Movido: {fileName}");
                }
            }catch(IOException ex) { Console.WriteLine(ex.Message); }
        }
    }
}
