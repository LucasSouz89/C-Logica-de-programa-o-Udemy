using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExParms {
    internal class Situacao {
        public void MostrarAvisos(params string[] mensagens) {
            foreach (string mensagem in mensagens) {
                if (mensagem != null) { Console.WriteLine(mensagem); }
            }
        }
    }
}
