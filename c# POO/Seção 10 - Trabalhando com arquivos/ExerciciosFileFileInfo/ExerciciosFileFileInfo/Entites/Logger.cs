using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosFileFileInfo.Entites
{
    sealed class Logger
    {
        
        public void WriteLog(string message) {
            
            File.AppendAllText(@"C:\Windows\Temp\Treinamentos\exercicio3.txt", message + Environment.NewLine);
        }
    }
}
