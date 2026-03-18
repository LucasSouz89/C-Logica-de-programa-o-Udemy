using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExercicioCapitulo {
    internal class Conta {
        public int Numero { get; private set; }
        private string _nome;
        public double Saldo { get; private set; }

        public string Nome {
            get { return _nome; }
            set { _nome = value; }
        }
        
        public Conta(string nome, int numero) {
            this.Nome = nome;
            this.Numero = numero;

        }
        public Conta(string nome, int numero, double saldo) : this(nome,numero){
            Saldo = saldo;
        }
        public void Deposito(double valor) {
             Saldo += valor;
        }
        public void Sacar(double valor) {
             Saldo -= valor + 5;
        }
        public override string ToString() {
            return $"Conta {Numero}, Titular: {_nome}, Saldo: $ {Saldo.ToString("F2",CultureInfo.InvariantCulture)}";
        }
    }
}
