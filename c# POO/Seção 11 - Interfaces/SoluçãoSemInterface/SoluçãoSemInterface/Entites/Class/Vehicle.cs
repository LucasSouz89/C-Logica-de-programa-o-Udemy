using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoluçãoSemInterface.Entites.Class
{
    sealed class Vehicle
    {
        public string Model { get; private set; }

        public Vehicle() { }

        public Vehicle(string model) { Model = model; }
    }
}
