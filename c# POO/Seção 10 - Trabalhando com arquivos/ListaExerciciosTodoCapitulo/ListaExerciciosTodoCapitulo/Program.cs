namespace ListaExerciciosTodoCapitulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ex1
            //string path = @"C:\Temp\origem.txt";
            //string copyPath = @"C:\Temp\destino.txt";
            //File.Copy(path, copyPath,true);

            //Ex2

            //try
            //{

            //    string path = @"C:\Temp\fantasma.txt";
            //    File.ReadAllLines(path);

            //}
            //catch (IOException e) { Console.WriteLine($"Error: {e.Message}"); }

            //Ex 3
            //try
            //{
            //    FileStream fs = new FileStream(path, FileMode.Open);
            //    StreamReader sr = new StreamReader(fs);

            //    while (!sr.EndOfStream)
            //    {
            //        string line = sr.ReadLine();
            //        Console.WriteLine(line);
            //    }
            //    sr.Close();
            //    fs.Close();
            //}
            //catch (IOException e) { Console.WriteLine($"Error: {e.Message}"); }
            //Ex 4
            //try
            //{
            //    using (StreamReader sr = File.OpenText(path))
            //    {

            //        while (!sr.EndOfStream)
            //        {
            //            string line = sr.ReadLine();
            //            Console.WriteLine(line);
            //        }
            //    }
            //}catch(IOException E) { Console.WriteLine($"Error: {E.Message}"); }
            //Ex 5
            //string[] inimigos = new string[] { "Zumbi", "Esqueleto", "Creeper" };
            //string newPath = @"C:\Temp\inimigo.txt";

            //try
            //{
            //    using (StreamWriter sw = File.CreateText(newPath))
            //    {
            //        foreach (var inimigo in inimigos)
            //        {
            //            sw.WriteLine(inimigo);
            //        }
            //    }
            //}
            //catch (IOException E) { Console.WriteLine($"Error: {E.Message}"); }
            //Ex 6
            //string chefe = "Ender dragon";
            //string newPath = @"C:\Temp\inimigo.txt";

            //try
            //{
            //    using (StreamWriter sw = File.AppendText(newPath))
            //    {


            //            sw.WriteLine(chefe);

            //    }
            //}
            //catch (IOException E) { Console.WriteLine($"Error: {E.Message}"); }

            //Ex 7
            //string directory = @"C:\Windows\Temp\SaveGames";
            //try
            //{
            //    if (!Directory.Exists(directory))
            //    {
            //        Directory.CreateDirectory(directory);
            //    }

            //}
            //catch (IOException E) { Console.WriteLine($"Error: {E.Message}"); }

            //Ex 8
            //string falsePath = @"C:\Windows\Temp\SaveGames\save_01.dat";
            //try
            //{
            //    Console.WriteLine(Path.GetDirectoryName(falsePath));
            //    Console.WriteLine(Path.GetFileNameWithoutExtension(falsePath));
            //    Console.WriteLine(Path.GetExtension(falsePath));

            //}
            //catch (IOException E) { Console.WriteLine($"Error: {E.Message}"); }
            //Ex 9
            string path = @"C:\Temp\numeros.txt";
            string newPath = @"C:\Temp\dobro.txt";
            try
            {
                List<int> numbers = new List<int>();
                using (StreamReader sr = File.OpenText(path))
                {
                        
                    while (!sr.EndOfStream) {
                        int line = int.Parse(sr.ReadLine());
                        numbers.Add(line);
                    }
                   
                }
                using (StreamWriter sw = File.CreateText(newPath)) {

                    foreach (int number in numbers) {
                        sw.WriteLine(number*2);
                    }

                }

            }
            catch (IOException E) { Console.WriteLine($"Error: {E.Message}"); }

        }
    }
}
