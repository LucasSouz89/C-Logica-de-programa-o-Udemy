using System.Globalization;

namespace DictionaryExercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ex 1
            //Dictionary<string, double> produtos = new Dictionary<string, double>();
            //produtos["RTX 4060"] = 3000.99;
            //produtos["RTX 4060"] = 2590.99;
            //produtos["RYZEN 7 7800"] = 2000.50;
            //produtos["SSD 4TB Kingston"] = 4000.90;
            //produtos.Remove("SSD 4TB Kingston");
            //foreach (var item in produtos)
            //{
            //    Console.WriteLine($"{item.Key} : R${item.Value.ToString("F2", CultureInfo.InvariantCulture)}");
            //}
            //Ex 2
            //Dictionary<string,long> phones = new Dictionary<string,long>();
            //phones["Maria"] = 11952728982;
            //phones["Joao"] = 1198129908;
            //phones["Alex"] = 1198134908;
            //Console.Write("Digite um nome valido: ");
            //string nome = Console.ReadLine();
            //string resultado = (phones.TryGetValue(nome,out var value)) ? $"telefone: {value}" : "Usuario não encontrado";
            //Console.WriteLine(resultado);
            //Ex 3
            //Dictionary<string, int> candidatos = new Dictionary<string, int>();

            //while (true)
            //{
            //    Console.Write("Digite o nome do candidado: ");
            //    string nome = Console.ReadLine();
            //    if (nome.ToLower() == "fim") { break; }

            //    candidatos[nome] = candidatos.GetValueOrDefault(nome,0) + 1;

            //}
            //foreach (var candidato in candidatos)
            //{
            //    Console.WriteLine($"Candidato {candidato.Key},votos: {candidato.Value}");
            //}
            //Ex 4
            //Dictionary<char,int> palavras = new Dictionary<char,int>();
            //Console.WriteLine("Digite alguma palavra: ");
            //string palavra = (Console.ReadLine()).Trim().Replace(" ","").ToLower();
            //foreach (char letter in palavra) 
            //{
            //    palavras[letter] = palavras.GetValueOrDefault(letter,0) + 1;
            //}

            //foreach (var letter in palavras) {
            //    Console.WriteLine($"{letter.Key} {letter.Value}x");
            //}
            //Ex 5
            //Dictionary<string,string> traducoes = new Dictionary<string,string>();
            //traducoes["cat"] = "gato";
            //traducoes["dog"] = "cachorro";
            //traducoes["pen"] = "caneta";
            //traducoes["black"] = "preto";
            //traducoes["this"] = "esse";
            //traducoes["is"] = "é";
            //Console.Write("Digite um frase: ");
            //string[] frase = Console.ReadLine().ToLower().Split(" ");
            //foreach (string palavra in frase) {
            //    if (traducoes.TryGetValue(palavra, out var value))
            //    {
            //        Console.Write(value + " ");
            //    }
            //    else 
            //    {
            //        Console.Write(palavra + " ");
            //    }
            //}
            //Ex 6
            //Dictionary<string, int> filialA = new Dictionary<string, int>() { { "Mouse", 10 }, { "Teclado", 5 } };
            //Dictionary<string, int> filialB = new Dictionary<string, int>() { { "Monitor", 3 }, { "Mouse", 4 } };
            //Dictionary<string, int> totalConsolidado = new Dictionary<string, int>();

            //foreach (var item in filialA)
            //{
            //    totalConsolidado[item.Key] = totalConsolidado.GetValueOrDefault(item.Key, 0)+ item.Value;
            //}
            //foreach (var item in filialB)
            //{
            //    totalConsolidado[item.Key] = totalConsolidado.GetValueOrDefault(item.Key, 0) + item.Value; 
            //}
            //foreach (var item in totalConsolidado) { Console.WriteLine($"{item.Key} {item.Value} unidades"); }
            //Ex 7
            //Dictionary<string,List<double>> alunos = new Dictionary<string,List<double>>();
            //alunos["Lucas"] = new List<double>() { 8.0, 7.5 , 9.0 };
            //alunos["Maria"] = new List<double>() { 10.0, 6.0, 8.0 };

            //foreach (var item in alunos) {

            //    double media = item.Value.Average();
            //    Console.WriteLine($"Media do aluno(a) {item.Key} {media.ToString("F2",CultureInfo.InvariantCulture)}");
            //}
            //Ex8
            //Dictionary<char,List<string>> agrupador = new Dictionary<char,List<string>>();
            //Console.WriteLine("Digite o nome de cinco animais: ");

            //for (int i = 0; i < 5; i++) {
            //    string animal = Console.ReadLine().ToLower();
            //    if (agrupador.TryGetValue(animal[0], out List<string> list)) 
            //    {
            //        list.Add(animal);

            //    }
            //    else 
            //    {


            //        agrupador[animal[0]] = new List<string>() { animal };

            //    }
            //}
            //foreach (var i in agrupador)
            //{
            //    Console.Write($"Letra {i.Key}: ");
            //    foreach (var j in i.Value) 
            //    {
            //        if (j == i.Value.Last()) { Console.Write(j); }
            //        else { Console.Write(j + ", "); }

            //    }
            //    Console.WriteLine();
            //}
            //Ex 9
            //try
            //{
            //    Dictionary<string, int> estoque = new Dictionary<string, int>() { { "Notebook", 5 }, { "Mouse", 2 } };
            //    Console.Write("Digite o produto a ser comprado e a quantidade(TV 3): ");
            //    string[] line = Console.ReadLine().Split(" ");
            //    string name = line[0];
            //    int qtd = int.Parse(line[1]);

            //    if (estoque.TryGetValue(name, out int value))
            //    {
            //        if (value < qtd) { throw new Exception("Quantidade insuficiente"); }
            //        value -= qtd;
            //        if (value == 0) { estoque.Remove(name); }
            //        else
            //        {
            //            estoque[name] = value;
            //        }
            //    }
            //    else { { throw new Exception("Produto não encontrado"); } }

            //    foreach (var item in estoque)
            //    {
            //        Console.WriteLine($"{item.Key} {item.Value} unidades");
            //    }
            //}
            //catch (Exception ex) { Console.WriteLine(ex.Message); }
            //Ex 10
            string[] logServidor = {
            "amanda 20:45",
            "alex86 21:49",
            "amanda 22:10",
            "bobbrown 23:00",
            "amanda 23:15",
            "alex86 23:30"
             };
            Dictionary<string,int> logs = new Dictionary<string,int>();
            foreach (var item in logServidor)
            {
                string[] line = item.Split(' ');
                string name = line[0];
                if(logs.TryGetValue(name,out int value)) { logs[name] = value + 1; }
                else { logs[name] = logs.GetValueOrDefault(name,0) + !; }
            }
            foreach (var item in logs)
            {
                Console.WriteLine($"{item.Key} {item.Value} vezes");
            }
        }
    }
}
