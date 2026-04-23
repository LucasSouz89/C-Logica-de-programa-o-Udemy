using HerançasMultiplasEoProblemaDoDiamante.Entites.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerançasMultiplasEoProblemaDoDiamante.Entites.Class
{
    internal class Printer : Device,IPrinter
    {
        public Printer(int serialNumber) :base(serialNumber) { }

        public override void ProcessDoc(string document)
        {
            Console.WriteLine($"Printer proccesing {document}");
        }
        public virtual void Print(string document) { Console.WriteLine($"Printer print {document}"); }
    }
}
