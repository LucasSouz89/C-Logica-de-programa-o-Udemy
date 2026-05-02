using HashcodeEqualsExercicios.Ex1;
using HashcodeEqualsExercicios.Ex2;
using HashcodeEqualsExercicios.Ex3;
using HashcodeEqualsExercicios.Ex4;
using HashcodeEqualsExercicios.Ex5;

namespace HashcodeEqualsExercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ex1
            //Produto p = new Produto(1334, "TV");
            //Produto p2 = new Produto(1334, "TV");
            //HashSet<Produto> set = new HashSet<Produto>();
            //set.Add(p);
            //set.Add(p2);
            //Console.WriteLine(set.Count);
            //Ex2
            //Cordenada c1 = new Cordenada(10, 20);
            //Cordenada c2 = new Cordenada(10, 20);
            //Cordenada c3 = new Cordenada(15, 20);
            //HashSet<Cordenada> cordenadas = new HashSet<Cordenada>();
            //cordenadas.Add(c1);
            //cordenadas.Add(c2);
            //cordenadas.Add(c3);
            //Console.WriteLine(cordenadas.Count);
            //Ex3
            //Usuario usuario = new Usuario() {UserName = "Admin" };
            //Usuario usuario2 = new Usuario() { UserName = "admin" };
            //HashSet<Usuario> usuarios = new HashSet<Usuario>();
            //usuarios.Add(usuario);
            //usuarios.Add(usuario2);
            //Console.WriteLine(usuarios.Count);
            //Ex4
            //Carro carro = new Carro() {Placa ="akj-2019" };
            //HashSet<Carro> carros = new HashSet<Carro>();
            //carros.Add(carro);
            //Console.WriteLine(carros.Contains(carro));
            //carro.Placa = "kjs-2025";
            //Console.WriteLine(carros.Contains(carro));
            //Ex5
            Funcionario f1 = new Funcionario((100));
            Gerente g1 = new Gerente("Eletrica",100);
            Console.WriteLine(f1.Equals(g1));

        }
    }
}
