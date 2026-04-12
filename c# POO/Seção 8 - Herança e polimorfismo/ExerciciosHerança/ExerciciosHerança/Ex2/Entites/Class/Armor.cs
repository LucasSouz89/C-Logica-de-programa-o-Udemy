using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosHerança.Ex2.Entites.Class
{
    internal class Armor : Item
    {
        public int DefensePoints { get; private set; }

        public Armor() { }

        public Armor(string name, string material, int durability, int defensePoints) : base(name, material, durability) { DefensePoints = defensePoints; }

        public void Repair(int amount) { Durability += amount; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Dados:");
            sb.AppendLine($"Nome: {Name} | Material {Material} | Durabilidade: {Durability} | Pontos de defesa: {DefensePoints}");
            sb.AppendLine();
            return sb.ToString();
        }
    }
}
