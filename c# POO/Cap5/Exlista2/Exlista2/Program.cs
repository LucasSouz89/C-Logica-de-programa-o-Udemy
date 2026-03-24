using System.Globalization;

namespace Exlista2 {
    internal class Program {

        static void Main(string[] args) {
            //Ex 1
            /*
            Console.Write("Quantos produtos serão registrados? ");
            int qtd = int.Parse(Console.ReadLine());
            List<Produto> list = new List<Produto>();
            Console.WriteLine();
            for (int i = 0; i < qtd; i++) {
                Console.WriteLine($"Produto #{i+1}");
                Console.Write("Digite o ID do produto (100-999): ");
                int id = int.Parse(Console.ReadLine());


                while (list.Find(x => x.Id == id) != null || (id <= 99 || id >= 1000)){
                    Console.Write("Digite o ID do produto (100-999): ");
                    id = int.Parse(Console.ReadLine());

                }
                Console.Write("Digite o nome do produto: ");
                string nome = Console.ReadLine();
                while (nome.Length <= 0) {
                    Console.Write("Digite o nome do produto: "); nome = Console.ReadLine();
                }
                Console.Write("Digite a quantidade do produto: ");
                int quantidade = int.Parse(Console.ReadLine());
                while (quantidade < 0) {
                    Console.Write("Digite a quantidade do produto: ");
                    quantidade = int.Parse(Console.ReadLine());
                }
                list.Add(new Produto(id, nome, quantidade));
                Console.WriteLine();
            }
            Console.Write("Qual o id do produto que recebeu o novo lote? ");
            bool condicao = true;
            while (condicao) {
                int index = int.Parse(Console.ReadLine());
                Produto p = list.Find(x => x.Id == index);
                if (p != null) {
                    Console.Write("Adicione a quantidade: ");
                    int quantidadeAdd = int.Parse(Console.ReadLine());
                    p.AdicionarQuantidade(quantidadeAdd);
                    condicao = false;
                } else { Console.Write("Posicao não encontrada, digite novamente: "); }
            }
            int j = 1;
            foreach (Produto produtos in list) {
                Console.WriteLine($"#{j} {produtos}");
                j++;
            }
            */
            //Ex2
            /*
            Console.WriteLine("Registrador de armas");
            Console.Write("Digite a quantidade de armas a serem registradas: ");
            int qtd = int.Parse(Console.ReadLine());
            List<Arma> a = new List<Arma>();
            Console.WriteLine();
            for (int i = 0; i < qtd; i++) {
                Console.WriteLine($"Arma {i+1}");
                Console.Write("Qual o ID da arma?: ");
                int id = int.Parse(Console.ReadLine());

                while (a.Find(x => x.Id == id) != null) { Console.Write("Digite outro id: "); id = int.Parse(Console.ReadLine()); }
                Console.Write("Qual o nome da arma?: ");
                string nome = Console.ReadLine();
                while (nome.Length <= 0) { Console.Write("Digite um nome de arma valido: "); nome = Console.ReadLine(); }
                Console.Write("Qual o dano da arma?: ");
                double dano = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                while (dano <= 0) { Console.Write("Digite um dano valido: "); dano = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture); }
                a.Add(new Arma(id, nome, dano));
                Console.WriteLine();
            }
            Console.Write("Digite o id da arma que você deseja melhorar: ");
            int MelhorarId = int.Parse(Console.ReadLine());
            Arma b = a.Find(x => x.Id == MelhorarId);
            bool condicao = true;
            while (condicao) {
                if (b != null) { Console.Write("Digite a porcentagem do dano: "); double pct = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture); b.MelhorDano(pct); condicao = false; } 
                else { Console.Write("Digite um id valido: "); MelhorarId = int.Parse(Console.ReadLine()); b = a.Find(x => x.Id == MelhorarId); }
            }
            Console.WriteLine();
            for (int i = 0; i < a.Count; i++) {
                Console.WriteLine($"Arma #{i+1} {a[i]}");
            }
            */
        }

    }
}

