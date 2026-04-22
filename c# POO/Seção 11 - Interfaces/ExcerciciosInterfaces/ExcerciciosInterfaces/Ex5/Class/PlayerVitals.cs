using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciciosInterfaces.Ex5.Class
{
    sealed class PlayerVitals
    {
        public string PlayerName { get;private set; }

        public double CurrentHealth { get; set; }

        public PlayerVitals(string name, double currentHealth) { PlayerName = name;CurrentHealth = currentHealth; }
    }
}
