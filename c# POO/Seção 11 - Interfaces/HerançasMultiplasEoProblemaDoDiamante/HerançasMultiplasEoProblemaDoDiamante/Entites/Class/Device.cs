using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerançasMultiplasEoProblemaDoDiamante.Entites.Class
{
    abstract class Device
    {
        public int SerialNumber { get; set; }

        public Device(int serialNumber)
        {
            SerialNumber = serialNumber;
        }

        public abstract void ProcessDoc(string document);
    }
}
