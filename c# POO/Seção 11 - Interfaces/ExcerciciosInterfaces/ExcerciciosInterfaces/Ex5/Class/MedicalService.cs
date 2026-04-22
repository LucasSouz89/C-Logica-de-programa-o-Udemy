using ExcerciciosInterfaces.Ex5.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciciosInterfaces.Ex5.Class
{
    sealed class MedicalService
    {
       public IInfectionState _infectionState;

        public MedicalService() { }

        public MedicalService(IInfectionState state) { _infectionState = state; }

        public HealReport ApplyMedkit(PlayerVitals player,double baseHealAmount)
        {
            double initialHeal = player.CurrentHealth;
            double healAmount = _infectionState.CalculateHeal(baseHealAmount);
            player.CurrentHealth+=healAmount;
            return new HealReport(initialHeal,healAmount,player.CurrentHealth);
        }
    }
}
