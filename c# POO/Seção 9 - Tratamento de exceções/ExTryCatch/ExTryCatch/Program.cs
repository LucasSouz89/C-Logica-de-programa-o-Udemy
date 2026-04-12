namespace ExTryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ex1
/*
try
{
    var preco = 50;
    Console.Write("Digite a quantidade de poções: ");
    var qtd = int.Parse(Console.ReadLine());
    int valorTotal = qtd * 50;
    Console.WriteLine($"Valor total: {valorTotal}");
}
catch (FormatException) { Console.WriteLine("Formato invalido"); }
*/
/*
//Ex2
try
{
    string[] prateleiras = { "Placa de Vídeo", "Processador", "Memória RAM", "Gabinete", "Fonte" };
    Console.Write("Digite o numero da prateleira: ");
    var position = int.Parse(Console.ReadLine());
    Console.WriteLine(prateleiras[position]);
}
catch (FormatException) { Console.WriteLine("Formato invalido"); }
catch (IndexOutOfRangeException) { Console.WriteLine("Posição invalida"); }
*/
//Ex 3

try
{
    Console.Write("Qual o nivel do jogador? ");
    var nivelJogador = int.Parse(Console.ReadLine());
    Console.Write("Qual o nivel da espada? ");
    var nivelEspada = int.Parse(Console.ReadLine());

    if (nivelJogador < nivelEspada)
    {
        throw new Exception("Seu Nivel é muito baixo para empunhar esta arma");
    }
    Console.WriteLine("Espada obtida");
}
catch (Exception e) { Console.WriteLine(e.Message); }
}
}
}
