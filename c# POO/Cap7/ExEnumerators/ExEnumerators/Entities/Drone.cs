using ExEnumerators.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExEnumerators.Entities
{
    internal class Drone
    {
        public string Name { get; private set; }
        public int BatteryLevel { get; private set; }

        public DroneTask CurretTask { get; set; }


        public Drone(string name,int baterry,DroneTask a) {
            Name = name;
            BatteryLevel = baterry;
            CurretTask = a;
        }

        public override string ToString()
        {
            return $"{Name} | {BatteryLevel}% | {CurretTask}";
        }

    }
}
