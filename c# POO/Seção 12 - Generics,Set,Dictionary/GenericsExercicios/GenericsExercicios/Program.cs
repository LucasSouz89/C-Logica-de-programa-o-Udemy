using GenericsExercicios.Ex1;
using GenericsExercicios.Ex2;
using GenericsExercicios.Ex3;
using GenericsExercicios.Ex4;
using GenericsExercicios.Ex5;
using GenericsExercicios.Ex6;
using GenericsExercicios.Ex7;
using GenericsExercicios.Ex8.Class;
using GenericsExercicios.Ex8.Interface;
using GenericsExercicios.Ex9.Class;
using System.Globalization;

namespace GenericsExercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ex1
            //try
            //{
            //    Console.WriteLine("Guardano uma senha");
            //    Cofre<string> senhas = new Cofre<string>();
            //    senhas.Guardar("Wsxok20kx=");
            //    senhas.Destrancar();
            //    Cofre<double> ouro = new Cofre<double>();
            //    ouro.Guardar(3000.80);
            //    ouro.Destrancar();
            //}catch(InvalidOperationException e) { Console.WriteLine($"Um erro ocorreu: {e.Message}"); }
            //Ex2

            //RegistroDuplo<string, int> Campeao = new RegistroDuplo<string, int>("Sion",4000);
            //RegistroDuplo<int, string> Jogador = new RegistroDuplo<int, string>(1, "Faker");
            //Console.WriteLine(Campeao);
            //Console.WriteLine(Jogador);
            //Ex 3
            //List<int> numeros = new List<int>() {10,30,40,50,60};
            //Console.WriteLine(Avaliador.EncontrarMaior(numeros));
            //Ex4
            //FilaTrabalho<string> caminhoes = new FilaTrabalho<string>();
            //caminhoes.Adicionar("Carreta");
            //caminhoes.Adicionar("Bi-trem");
            //caminhoes.Adicionar("Truck");
            //caminhoes.Listar();
            //caminhoes.Proximo();
            //Console.WriteLine();
            //caminhoes.Listar();
            //Console.WriteLine();
            //FilaTrabalho<int> notaFiscal = new FilaTrabalho<int>();
            //notaFiscal.Adicionar(220);
            //notaFiscal.Adicionar(140);
            //notaFiscal.Adicionar(100);
            //notaFiscal.Adicionar(80);
            //notaFiscal.Listar();
            //notaFiscal.Proximo();
            //Console.WriteLine();
            //notaFiscal.Listar();
            //Ex5
            //Fabrica<Cofre<string>> cofre= new Fabrica<Cofre<string>>();
            //Console.WriteLine(cofre.CriarNovo()); 
            //Ex 6
            //NÃO VAI FUNCIONAR pois dentro da classe foi definido que só aceita tipos genericos do tipo classe
            //Armazem<int> numeros = new Armazem<int>();
            //Armazem<string> numeros = new Armazem<string>();
            //ex 7
            //List<string> list = new List<string>() {"Pão","Arroz","Feijão","Mussarela"};
            //string situacao = (Buscador.ContemItem<String>(list, "Mussarela")) ? "O item foi achado" : "O item não foi achado";
            //Console.WriteLine(situacao);
            //situacao = (Buscador.ContemItem<String>(list, "Presunto")) ? "O item foi achado" : "O item não foi achado";
            //Console.WriteLine(situacao);
            //eX 8
            //    List<PlacaDeVideo> placaDeVideos = new List<PlacaDeVideo>();
            //    placaDeVideos.Add(new PlacaDeVideo(12000.99));
            //    placaDeVideos.Add(new PlacaDeVideo(2000.23));
            //    placaDeVideos.Add(new PlacaDeVideo(1100.46));
            //    placaDeVideos.Add(new PlacaDeVideo(7000.95));
            //    //Somando o preco de todas as placas de video
            //    Console.WriteLine($"Valor total em estoque $ {CalcularEstoque.SomaTotal<PlacaDeVideo>(placaDeVideos).ToString("F2",CultureInfo.InvariantCulture)}");
            //    List<Livro> livros = new List<Livro>();
            //    livros.Add(new Livro(20.50));
            //    livros.Add(new Livro(30.40));
            //    livros.Add(new Livro(75.90));
            //    Console.WriteLine($"Valor total em estoque $ {CalcularEstoque.SomaTotal<Livro>(livros).ToString("F2", CultureInfo.InvariantCulture)}");
            //}
            //Ex 9
            Relatorio.ImprimirDicionario<string, double>("BR-149", 200.50);
            Relatorio.ImprimirDicionario<double, string>(200.50, "BR-149");
        }
    }
}
