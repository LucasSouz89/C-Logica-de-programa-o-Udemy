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
            Console.WriteLine("Registrador de zumbis");
            Console.Write("Digite o numero de zumbis: ");
            int qtd = int.Parse(Console.ReadLine());
            List<Zumbi> list = new List<Zumbi>();
            Console.WriteLine();
            for (int i = 0; i < qtd; i++) {
                Console.WriteLine($"Zumbi #{i+1}");
                Console.Write("Digite o id do zumbi");
                int id = int.Parse(Console.ReadLine());
                while (list.Find(x => x.Id == id) != null) { Console.Write("Digite outro id: ");id = int.Parse(Console.ReadLine());}
                Console.WriteLine("Escolha um tipo de zumbi");
                Console.WriteLine("1 - Corredor");
                Console.WriteLine("2 - Tanque");
                Console.WriteLine("3 - Espreitador");
                int escolha = int.Parse(Console.ReadLine());
                string nome = "";
                bool c = true;
                while (c) {
                    switch (escolha) {
                        case 1: nome = "Corredor";
                            c = false;
                            break;
                        case 2: nome = "Tanque";
                            c = false;
                            break;
                        case 3: nome = "Espreitador";
                            c = false;
                            break;
                        default:
                            Console.WriteLine("Escollha uma opcão valida: ");
                            escolha = int.Parse(Console.ReadLine());
                            break;
                    }
                }
                Console.Write("Digite a vida: ");
                int vida = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                while (vida <= 0) { Console.Write("Digite a vida valida: "); vida = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture); }

                list.Add(new Zumbi(id,nome,vida));
                Console.WriteLine();
            }
            Console.Write("Qual o ID do zumbi que tomou o tiro? ");
            int Id = int.Parse(Console.ReadLine());
            Zumbi zumbiDano = list.Find(x => x.Id == Id);
            bool condi = true;
            while (condi) {
                if (zumbiDano != null) {
                    Console.Write("Digite o dano aplicado: ");
                    double dano = double.Parse(Console.ReadLine());
                    while (dano <= 0) { Console.Write("Digite um dano valido: "); dano = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); }
                    zumbiDano.TomarDano(dano);
                    condi = false;
                } else {
                    Console.Write("Digite o id valido: ");
                    Id = int.Parse(Console.ReadLine());
                    zumbiDano = list.Find(x => x.Id == Id);
                }
            }
            int contador = 1;
            foreach(Zumbi unidade in list) {
                if (unidade.Vida == 0) { Console.WriteLine($"Zumbi morto #{contador} {unidade}"); } 
                else { Console.WriteLine($"Zumbi #{contador} {unidade}"); }
                contador++;
            }

            


        }

    }
}

