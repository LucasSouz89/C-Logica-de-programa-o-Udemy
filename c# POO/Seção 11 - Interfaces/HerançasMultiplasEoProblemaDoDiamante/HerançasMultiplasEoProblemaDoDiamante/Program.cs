using HerançasMultiplasEoProblemaDoDiamante.Entites.Class;

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
                if (device is Printer printer) 
                { 
                    printer.ProcessDoc("Payment contract");
                    printer.Print("My letter");
                }
                else if (device is Scanner scanner) 
                { scanner.ProcessDoc("My email");
                  Console.WriteLine(scanner.Scan());
                }
                else if(device is ComboDevice comboDevice) 
                {
                    Console.WriteLine(comboDevice.Scan()); 
                    comboDevice.ProcessDoc("jornal");
                    comboDevice.Print("Contract");
                }
                Console.WriteLine();
            }
        }
    }
}
