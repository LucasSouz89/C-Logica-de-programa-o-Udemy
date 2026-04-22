using ExcerciciosInterfaces.Ex1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciciosInterfaces.Ex1.Class
{
    sealed class SecuritySystem
    {
        IMessageService _messageService;

        

        public SecuritySystem(IMessageService messageService)
        {
            _messageService = messageService;
        }
        public void TriggerAlarm()
        {
            _messageService.Send("Invasão detectada");
        }
    }
}
