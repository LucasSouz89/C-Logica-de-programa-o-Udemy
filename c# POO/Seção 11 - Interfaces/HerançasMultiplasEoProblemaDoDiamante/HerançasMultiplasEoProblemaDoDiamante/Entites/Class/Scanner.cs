using HerançasMultiplasEoProblemaDoDiamante.Entites.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerançasMultiplasEoProblemaDoDiamante.Entites.Class
{
    internal class Scanner : Device,IScanner
    {
        public Scanner(int serialNumber) : base(serialNumber)
        {
        }
        public override void ProcessDoc(string document)
        {
            Console.WriteLine($"Scanner proccesing {document}");
        }
        public string Scan()
        {
            return "Scanner scan result";
        }
    }
}
