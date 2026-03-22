using System.Collections;

namespace BoxingUnboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ex1
            /*
            int Itemid = 1500;
            object caixaDePresent = Itemid;
            int idRecuperado = (int) caixaDePresent;
            */
            //Ex2
            double pesoArma = 12.5;
            object obj = pesoArma;
            //Linha do erro
            // int Descompactar = (int)obj;
            //Correção
            double Descompactar = (double)obj;
            int final = (int)Descompactar;
            Console.WriteLine(final);
            //Ex3
            ArrayList listaMisteriosa = new ArrayList();
            int municao = int.Parse(Console.ReadLine());
            object obj1 = municao;
            listaMisteriosa.Add(obj1);
            bool estaVivo = bool.Parse(Console.ReadLine());
            object obj2 = estaVivo;
            listaMisteriosa.Add(obj2);
            float velocidade = float.Parse(Console.ReadLine());
            object obj3 = velocidade;
            listaMisteriosa.Add(obj3);
            
            foreach(object lista in listaMisteriosa) {
                if(lista is int) { int unboxing = (int)lista; Console.WriteLine($"O jogador tem {unboxing} de munição"); }
                else if(lista is bool) {  bool unboxing = (bool)lista;
                    if (unboxing) { Console.WriteLine("Jogador esta vivo"); } else { Console.WriteLine("Jogador esta morto"); }
                }
                else if (lista is float) { float unboxing = (float)lista; Console.WriteLine($"A velocidade do jogador é de {unboxing} km/h"); }
            }
        }
    }
}
