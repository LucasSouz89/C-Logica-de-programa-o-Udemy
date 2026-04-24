using HerançasMultiplasEoProblemaDoDiamante.Entites.Class;
using HerançasMultiplasEoProblemaDoDiamante.Entites.Interface;

namespace HerançasMultiplasEoProblemaDoDiamante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Device> devices = new List<Device>();
            devices.Add(new Printer(1234));
            devices.Add(new Scanner(1321));
            devices.Add(new ComboDevice(3212));

            foreach(var device in devices)
            {
                if(device is IPrinter printer) { printer.Print("Jornal");}
                if(device is IScanner scanner) { Console.WriteLine(scanner.Scan()); }
                device.ProcessDoc("Layer page");
                Console.WriteLine();
            }

        }
    }
}
