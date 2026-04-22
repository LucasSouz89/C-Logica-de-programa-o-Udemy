using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExercicios2.Ex4.Class
{
    sealed class Inventario
    {

        public List<Pocao> Pocoes { get; private set; } = new List<Pocao>();


        public void ComprarPocoes(int qtd){
            for (int i = 0; i < qtd; i++)
            {
                Console.Write("Nome da poção: ");
                Pocao potion = new Pocao(Console.ReadLine());
                AddPocao(potion);
            }
        }

        public void AddPocao(Pocao pocao)
        {
            Pocoes.Add(pocao);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Tamnho do inventario: {Pocoes.Count}");
            sb.AppendLine($"Todas as poções:");
            foreach (Pocao p in Pocoes) { sb.AppendLine(p.Name); }
            return sb.ToString();
        }
    }
}
