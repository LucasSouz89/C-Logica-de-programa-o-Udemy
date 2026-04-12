using ExExceptionsPersonalizadas.Entites.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExExceptionsPersonalizadas.Entites.Class
{
    sealed class TankBuild
    {
        public string ChampionName { get; private set; }
        public int BaseHealth { get; private set; }
        public int BonusHealth { get; private set; }


        public TankBuild() { }

        public TankBuild(string name, int baseHealth) : this()
        {
            ChampionName = name;
            BaseHealth = baseHealth;
        }
        public void BuyItem(int healthProvided)
        {
            BonusHealth += healthProvided;
        }
        public void AtivateWarmogsHEart()
        {
            if (BonusHealth < 1100) { throw new ExceptionDomain($"Vida bônus insuficiente! Faltam {1100-BonusHealth} pontos de vida para ativar a passiva."); }
            Console.WriteLine("Passiva ativada: Regeneração de vida máxima do Warmog rodando!");
        }
    }
}
