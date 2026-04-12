using ListaExComposicao.Ex1.Entities.Enuns;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExComposicao.Ex1.Entities.Class
{
    internal class CombatEncounter
    {
        public DateTime Moment { get; private set; }
        public CombatStatus Status { get; private set; }
        public Character Character { get; private set; }

        public List<CastAction> Actions { get; private set; } = new List<CastAction>();

        public CombatEncounter() { }

        public CombatEncounter(DateTime date, CombatStatus status, Character character)
        {
            Moment = date;
            Status = status;
            Character = character;
        }
        public void AddAction(CastAction action) { Actions.Add(action); }
        public void RemoveAction(CastAction action) { Actions.Remove(action); }

        public double TotalDamage() {
            double sum = 0;
            foreach (CastAction action in Actions) {
                sum += action.SubTotalDamage();
            }
            return sum;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Dados do personagem: ");
            sb.AppendLine(Character.ToString());
            sb.AppendLine($"Momento do combate: {Moment} | Status do combate: {Status.ToString()}");
            sb.AppendLine("Ações:");
            foreach (CastAction action in Actions) {
                sb.AppendLine(action.ToString());
            }
            double damage = TotalDamage();
            sb.AppendLine($"Total Damage: {damage.ToString("F2",CultureInfo.InvariantCulture)}");
            return sb.ToString();
        }
    }
}
