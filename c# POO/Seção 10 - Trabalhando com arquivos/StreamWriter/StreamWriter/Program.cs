namespace StreamWriterTeste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Windows\Temp\Myfolder\file1.txt";
            string copyPath = @"C:\Windows\Temp\Myfolder\file2.txt";
        
            try {
                string[] lines = File.ReadAllLines(path);

                using (StreamWriter sw = File.AppendText(copyPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }

                }
            }catch (IOException ex) { Console.WriteLine($"An error occurred: {ex.Message}"); }
        }
    }
}
