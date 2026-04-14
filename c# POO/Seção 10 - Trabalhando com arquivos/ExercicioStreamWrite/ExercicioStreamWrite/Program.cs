using System.Text;

namespace ExercicioStreamWrite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ex1
            /*
            string path = @"C:\Windows\Temp\Treinamentos\log_sistema.txt";
            string mensagens = "";
            
            try {
                using (StreamWriter sw = File.AppendText(path))
                {
                    Console.WriteLine("CHAT DE TEXTO");
                    while (mensagens.ToLower() != "sair")
                    {
                        
                            mensagens = Console.ReadLine();
                            if (mensagens.ToLower() != "sair")
                            {
                                sw.WriteLine($"[{DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}] {mensagens}");
                            }
                        
                    }
                }
                
            } catch (IOException e) { Console.WriteLine(e); }
            */
            //Ex 2
            
            string path = @"C:\Windows\Temp\Treinamentos\relatorio_vendas.csv";
            try
            {
              List<string> produtos = new List<string> { "Teclado Mecânico,250.50", "Mouse Gamer,120.00", "Monitor,899.99" };
                using (StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8))
                {
                    sw.WriteLine("Produto,Preco");

                    foreach (var produto in produtos)
                    {
                        sw.WriteLine(produto);
                    }
                }
            }catch (IOException e) { Console.WriteLine(e); }
        }
    }
}
