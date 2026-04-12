using System;
using System.Globalization;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {
            //Ex 1
            /*
            int N = int.Parse(Console.ReadLine());
            double[] numeros = new double[N];
            string[] s = Console.ReadLine().Split(' ');
            double maior = 0; int Posicao = 0;
            for (int i = 0; i < numeros.Length; i++) {
                
                numeros[i] = double.Parse(s[i],CultureInfo.InvariantCulture);
                if (i == 0) { maior = numeros[i]; Posicao = i; } else if (maior < numeros[i]) { maior = numeros[i];Posicao = i; }
            }
            //Logica de senior
            double Max = numeros.Max();
            int posicao = Array.IndexOf(numeros, Max);
            Console.WriteLine(Max.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine(posicao);
            Console.WriteLine();
            //Logica de Junior
            Console.WriteLine(maior.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine(Posicao);
            */
            //Ex 2
            /*
            int N = int.Parse(Console.ReadLine());
            int[] numeros = new int[N];
            string[] s = Console.ReadLine().Split(' ');
            for (int i = 0; i < numeros.Length; i++) {
                numeros[i] = int.Parse(s[i]);
            }
            int quantidade = 0;
            foreach (int numero in numeros) {
                if (numero % 2 == 0) {
                    Console.Write($"{numero} ");
                    quantidade++;
                }
            }
            Console.WriteLine();
            Console.WriteLine(quantidade);
            */
            //Ex3
            /*
            int N = int.Parse(Console.ReadLine());
            int[] vet1 = new int[N];
            int[] vet2 = new int[N];
            int[] somas = new int[N];
            string[] s = Console.ReadLine().Split(' ');
            for (int i = 0; i < vet1.Length; i++) {
                vet1[i] = int.Parse(s[i]);
            }
            s = Console.ReadLine().Split(' ');
            for (int i = 0; i < vet2.Length; i++) {
                vet2[i] = int.Parse(s[i]);
            }
            for (int i = 0; i < somas.Length; i++) {
                somas[i] = vet1[i] + vet2[i];
            }
            foreach(int soma in somas) {
                Console.Write(soma+ " ");
            }
            */
            //Ex 4
            /*
            int N = int.Parse(Console.ReadLine());
            double[] numeros = new double[N];
            string[] s = Console.ReadLine().Split(' ');
            double soma = 0, media= 0;
            for(int i = 0; i < numeros.Length; i++) {
                numeros[i] = double.Parse(s[i],CultureInfo.InvariantCulture);
                soma += numeros[i];
            }
            Console.Clear();
            media = (double)soma / N;
            Console.WriteLine(media.ToString("F3", CultureInfo.InvariantCulture));
            foreach(double numero in numeros) {
                if(numero < media) { Console.WriteLine(numero.ToString("F1",CultureInfo.InvariantCulture)); }
            }
            */
            //Ex 5
            /*
            int N = int.Parse(Console.ReadLine());
            int[] numeros = new int[N];
            double soma = 0, media = 0;
            int quantidadePares = 0;
            string[] s = Console.ReadLine().Split(' ');
            for (int i = 0; i< numeros.Length; i++) {
                numeros[i] = int.Parse(s[i]);
                if(numeros[i] % 2 == 0) { soma += numeros[i];quantidadePares++;}
            }
            if (quantidadePares > 0) {
                media = (double)soma / quantidadePares;
                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
            */
            //Ex 6
            /*
            int N = int.Parse(Console.ReadLine());
            string[] nome = new string[N];
            int[] idade = new int[N];
            string NomeMaisVelho = " ";
            int MaisVelho = 0;
            for (int i = 0; i < N; i++) {
                string[] s = Console.ReadLine().Split(' ');
                nome[i] = s[0];
                idade[i] = int.Parse(s[1]);
                if (i == 0) {
                    MaisVelho = idade[i];
                    NomeMaisVelho = nome[i];
                }
                if (MaisVelho < idade[i]) {
                    NomeMaisVelho = nome[i];
                    MaisVelho = idade[i];
                }
                
            }
            
            Console.WriteLine($"Pessoa mais velha: {NomeMaisVelho}");
            */
            //Ex 7
            /*
            int N = int.Parse(Console.ReadLine());
            string[] nomes = new string[N];
            double[] nota1 = new double[N];
            double[] nota2 = new double[N];
            string[] aprovados = new string[N];
           
            double media = 0;
            for (int i = 0; i < N; i++) {
                string[] s = Console.ReadLine().Split(' ');
                nomes[i] = s[0];
                nota1[i] = double.Parse(s[1],CultureInfo.InvariantCulture);
                nota2[i] = double.Parse(s[2],CultureInfo.InvariantCulture);
                media = (double)(nota1[i]+nota2[i])/2;
                if (media >= 6) { aprovados[i] = nomes[i]; }
            }
            Console.WriteLine("Alunos aprovados");
            foreach(string aprovado in aprovados) {
                if (aprovado == null) { } else {
                    Console.WriteLine(aprovado);
                }
                
            }
            */

            //Ex 8
            /*
            int N = int.Parse(Console.ReadLine());
            double[] altura = new double[N];
            char[] sexo = new char[N];
            double somaAltura = 0, media = 0 ;
            int homens = 0,mulheres = 0;
            for (int i = 0; i < N; i++) {
                string[] s = Console.ReadLine().Split(' ');
                altura[i] = double.Parse(s[0],CultureInfo.InvariantCulture);
                sexo[i] = char.Parse(s[1]);
                if (sexo[i] == 'F') { somaAltura += altura[i];mulheres++;} else { homens++; }
            }
            double max = altura.Max();
            double min = altura.Min();
            media = (double)somaAltura/mulheres;
            Console.WriteLine($"Menor altura = {min.ToString("F2",CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Maior altura = {max.ToString("F2", CultureInfo.InvariantCulture)}");
            if (mulheres > 0) {
                Console.WriteLine($"Media das alturas das mulheres = {media.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            Console.WriteLine($"Numero de homens = {homens}");
            */
            int N = int.Parse(Console.ReadLine());
            string[] nome = new string[N];
            double[] compra = new double[N];
            double[] venda = new double[N];
            int lucroAbaixo = 0, lucroMedio = 0, lucroAlto = 0;
            double totalCompra = 0, totalVenda = 0, lucroTotal = 0;

            for(int i= 0; i < N; i++) {
                string[] vet = Console.ReadLine().Split(' ');
                nome[i] = vet[0];
                compra[i] = double.Parse(vet[1], CultureInfo.InvariantCulture);
                venda[i] = double.Parse(vet[2], CultureInfo.InvariantCulture);
                if(venda[i] / compra[i] < 1.10 ) {lucroAbaixo++;}else if (venda[i]/compra[i] >= 1.10 && venda[i]/compra[i] <= 1.20) { lucroMedio++; } else { lucroAlto++;}
                totalCompra += compra[i];
                totalVenda += venda[i];
                lucroTotal += venda[i] - compra[i];
            }
            Console.WriteLine($"Lucro abaixo de 10%: {lucroAbaixo}");
            Console.WriteLine($"Lucro entre 10% e 20%: {lucroMedio}");
            Console.WriteLine($"Lucro acima de 20%: {lucroAlto}");
            Console.WriteLine($"Valor total de compra: {totalCompra.ToString("F2",CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor total de venda: {totalVenda.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Lucro total: {lucroTotal.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}