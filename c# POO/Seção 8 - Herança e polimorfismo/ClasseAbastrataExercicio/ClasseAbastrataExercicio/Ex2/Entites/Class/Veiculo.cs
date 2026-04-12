using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAbastrataExercicio.Ex2.Entites.Class
{
    abstract class Veiculo
    {
        public string Modelo { get; private set; }

        public double VelocidadeAtual { get;protected set; }

        public Veiculo() { }

        public Veiculo(string modelo, double velocidade) 
        {
            Modelo = modelo;
            VelocidadeAtual = velocidade;
        }
        public void Frear()
        {
            VelocidadeAtual = 0;
            Console.WriteLine($"O {Modelo} parou totalmente.");
        }
        public abstract string TentarFuga();

    }
}
