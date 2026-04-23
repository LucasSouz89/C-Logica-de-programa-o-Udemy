using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerançasMultiplasEoProblemaDoDiamante.Entites.Interface;

namespace HerançasMultiplasEoProblemaDoDiamante.Entites.Class
{
    sealed class ComboDevice : Device,IPrinter, IScanner
    {

        
        public ComboDevice(int serialNumber) : base(serialNumber)
        {

        }
        public override void ProcessDoc(string document)
        {
            Console.WriteLine($"ComboDevice process {document}");
        }
        public void Print(string document) 
        {
            Console.WriteLine($"ComboDevice print {document}");
        }
        public string Scan()
        {
            return "ComboDevice scan result";
        }
    }
}
