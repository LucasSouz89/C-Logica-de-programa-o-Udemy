using ListaDeExercicios2.Ex1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExercicios2.Ex1
{
    internal class SistemaDeAlerta
    {
        private readonly IMensageiro _mensageiro;

        public SistemaDeAlerta(IMensageiro mensageiro)
        {
            _mensageiro = mensageiro;
        }
        public void Enviar(string msg)
        {
            _mensageiro.Enviar(msg);
        }
    }
}
