using ExcerciciosInterfaces.Ex1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciciosInterfaces.Ex1.Class
{
    sealed class EmailService : IMessageService
    {
        public void Send(string message)  { Console.WriteLine($"Enviando E-mail: {message}"); }
    }
}
