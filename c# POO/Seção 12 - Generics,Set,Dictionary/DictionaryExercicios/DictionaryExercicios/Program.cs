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
            Dictionary<string,string> traducoes = new Dictionary<string,string>();
            traducoes["cat"] = "gato";
            traducoes["dog"] = "cachorro";
            traducoes["pen"] = "caneta";
            traducoes["black"] = "preto";
            traducoes["this"] = "esse";
            traducoes["is"] = "é";
            Console.Write("Digite um frase: ");
            string[] frase = Console.ReadLine().ToLower().Split(" ");
            foreach (string palavra in frase) {
                if (traducoes.TryGetValue(palavra, out var value))
                {
                    Console.Write(value + " ");
                }
                else 
                {
                    Console.Write(palavra + " ");
                }
            }



        }
    }
}
