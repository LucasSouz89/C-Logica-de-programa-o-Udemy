namespace Ex_Lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ex1
            /*
            List <int> hordaZumbis = new List<int> { 100, 20, 80, 15, 50 };
            for (int i = 0; i < hordaZumbis.Count; i++) {
                hordaZumbis[i] -= 20;
                
                
            }
            hordaZumbis.RemoveAll(x => x <= 0);
            
            Console.WriteLine($"Sobraram {hordaZumbis.Count} zumbis");
            Console.WriteLine($"Suas vidas: " );
            foreach(int obj in hordaZumbis) { Console.Write($"{obj} "); }
            */
            //Ex2
            /*
            List<string> bau = new List<string> { "Faca", "Munição", "Erva Verde", "Chave Antiga", "Munição" };
            Console.WriteLine($"Numero de itens encontrados {bau.Count}");
            bau.RemoveAll(x => x == "Munição");
            if (bau.Contains("Chave Antiga")) { Console.WriteLine("Item de missão encontrado!"); }
            Console.Write("Todos os itens encontrados: ");
            foreach (string obj in bau) { Console.Write(obj+ " "); }
            */
            //Ex3
            /*
            List<int> vidaInimigos = new List<int> {50,60,45,80,100};
            for (int i = 0; i < vidaInimigos.Count; i++) {
                if (vidaInimigos[i] < 60) { vidaInimigos[i] += 25; } else { vidaInimigos[i] += 10; }
            }
            foreach (int obj in vidaInimigos) {
                Console.WriteLine(obj);
            }
            */
            //Ex4
            List<double> precoItems = new List<double> { 10.5, 50, 25,100,5};
            int index = precoItems.FindIndex(x => x == 100);
            Console.WriteLine($"Item valioso na posição {index}");
            precoItems.RemoveAt(index);
            Console.WriteLine("Item removido");

        }
    }
}
