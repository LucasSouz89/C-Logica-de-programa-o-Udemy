using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciciosInterfaces.Ex6.Services
{
    sealed class EnemyTarget
    {
        public string EnemyName { get;private set; }

        public double ArmorValue { get; set; }

        public EnemyTarget(string enemyName, double armorValue) { EnemyName = enemyName; ArmorValue = armorValue; }

    }
}
