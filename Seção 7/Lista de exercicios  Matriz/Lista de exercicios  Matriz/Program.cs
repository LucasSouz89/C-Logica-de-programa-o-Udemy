using System;
using System.ComponentModel.Design;
using System.Globalization;
using System.Runtime.Serialization;


namespace MyApp {
    internal class Program {
        static void Main(string[] args) {
            //Ex 1
            /*
            string[] s = Console.ReadLine().Split(' ');
            int M = int.Parse(s[0]), N = int.Parse(s[1]);
            int[,] matriz = new int[M, N];

            for (int i = 0; i < M; i++) {
                s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    matriz[i,j] = int.Parse(s[j]);
                }
            }
            Console.WriteLine("VALORES NEGATIVOS");
            for (int i = 0; i < M; i++) {
                
                for (int j = 0; j < N; j++) {
                    if (matriz[i,j] < 0) { Console.WriteLine(matriz[i,j]); }
                }
            }
            */
            //Ex 2
            /*
            int N = int.Parse(Console.ReadLine());
            int[,] matriz = new int[N, N];
            int[] somas = new int[N];

            for (int i = 0; i < N; i++) {
                string[] s = Console.ReadLine().Split(' ');
                somas[i] = 0;
                for (int j = 0; j < N; j++) {
                    matriz[i,j] = int.Parse(s[j]);
                    somas[i] += matriz[i, j];
                }
                
            }
            foreach (int soma in somas) {
                Console.WriteLine(soma);
            }
            */
            //Ex 3
            /*
            int N = int.Parse(Console.ReadLine());
            int[,] matriz = new int[N, N];
            int[] maiores = new int[N];
            for (int i = 0; i < N; i++) {
                string[] s = Console.ReadLine().Split(' ');
                maiores[i] = 0;
                for (int j = 0;j < N; j++) {
                    
                    matriz[i,j] = int.Parse(s[j]);
                    if(j ==0) { maiores[i] = matriz[i,j];}else if(maiores[i] < matriz[i, j]) {maiores[i] = matriz[i,j];}
                }
                
            }
            foreach (int maior in maiores) {
                Console.WriteLine(maior);
            }
            */
            //Ex 4
            /*
            int N = int.Parse(Console.ReadLine());
            int[,] matriz = new int[N, N];

            int soma = 0;
            for (int i = 0; i < N; i++) {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    matriz[i, j] = int.Parse(s[j]);
                    
                }
            }
            
            for (int i = 0; i < N; i++) {
                   
                
                for (int j = 0; j <= i; j++) {
                    if (i != 0 && j != 0) {
                        soma += matriz[i-j, i];
                    }
                }                                               
                
            }
            Console.WriteLine(soma);
            */
            //Ex 5
            /*
            string[] s = Console.ReadLine().Split(' ');
            int N = int.Parse(s[0]);
            int M = int.Parse(s[1]);
            int[,] matrizUm = new int[N,M];
            int[,] matrizDois = new int[N, M];
            int[,] matrizFinal = new int[N, M];

            for (int i = 0; i < N; i++) {
                s = Console.ReadLine().Split(' ');
                for (int j = 0; j < M; j++) {
                    matrizUm[i,j] = int.Parse(s[j]);
                }
            }
            for (int i = 0; i < N; i++) {
                s = Console.ReadLine().Split(' ');
                for (int j = 0; j < M; j++) {
                    matrizDois[i, j] = int.Parse(s[j]);
                }
            }
            for (int i = 0; i < N; i++) {
                
                for (int j = 0; j < M; j++) {
                    matrizFinal[i, j] = matrizUm[i,j] + matrizDois[i,j];
                    Console.Write(matrizFinal[i, j] + " ");
                }
                Console.WriteLine();
            }
           */
            //ex 6
            /*
            int N = int.Parse(Console.ReadLine());
            double[,] matriz = new double[N, N];
            double positivos = 0;
            for (int i = 0; i < N; i++) {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    matriz[i, j] = double.Parse(s[j],CultureInfo.InvariantCulture);
                    if (matriz[i,j] > 0) { positivos += matriz[i, j];}
                }
            }
            int linha = int.Parse(Console.ReadLine());
            int coluna = int.Parse(Console.ReadLine());


            Console.WriteLine($"SOMA DOS POSITIVOS: {positivos.ToString("F1",CultureInfo.InvariantCulture)}");
            Console.Write($"LINHA ESCOLHIDA: ");
            for (int i = 0; i < N; i++) {
                Console.Write(matriz[linha,i].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();
            Console.Write($"COLUNA ESCOLHIDA: ");
            for (int i = 0; i < N; i++) {
                Console.Write(matriz[i, coluna].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();
            Console.Write($"DIAGONAL PRINCIPAL: ");
            for (int i = 0; i < N; i++) {
                Console.Write(matriz[i,i].ToString("F1", CultureInfo.InvariantCulture) + " " );
            }
            Console.WriteLine();
            Console.WriteLine("MATRIZ ALTERADA");
            double[,] matrizAlterada = new double[N,N];
            for (int i = 0; i < N; i++) {
                
                for (int j = 0; j < N; j++) {
                    if (matriz[i, j] < 0) {
                        matrizAlterada[i, j] = Math.Pow(matriz[i, j], 2);
                        Console.Write(matrizAlterada[i,j].ToString("F1", CultureInfo.InvariantCulture) + " "); } 
                    else {
                        matrizAlterada[i, j] = matriz[i, j]; 
                        Console.Write(matrizAlterada[i,j].ToString("F1", CultureInfo.InvariantCulture) + " "); }
                }
                Console.WriteLine();
            }
            */
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int[,] matriz = new int[M, N];
            int[,] matrizFinal = new int[M, N];

            for (int i = 0; i < M; i++) {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    matriz[i, j] = int.Parse(s[j]);
                }
            }
            int l = int.Parse(Console.ReadLine());
            int lF = l - 1;
            for (int i = 0; i < M; i++) {
                for (int j = 0; j < N; j++) {

                    if (i == lF) {
                        if (j == 0) { matrizFinal[i, j] = matriz[i, N - 1]; } else { matrizFinal[i,j]=matriz[i, j - 1]; }
                    } else { matrizFinal[i, j] = matriz[i, j]; }
                    Console.Write(matrizFinal[i,j] + " ");
                    
                }
                Console.WriteLine();
            }
        }
    }
}