using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExerciciosDaIA {
    internal class Nave {
        public string Modelo { get; private set; }
        public int Velocidade { get; private set; }
        public double Combustivel { get; private set; }

        public Nave(string modelo) {
            Modelo = modelo;
            Velocidade = 0;
            Combustivel = 100.00;
        }
        public void Acelerar() {
            if (Combustivel >= 15.5) { Velocidade += 20;Combustivel -= 15.5; }
        }
        public void Frear() {
            Velocidade -= 20;
            if (Velocidade < 0) { Velocidade = 0; }
        }
        public void Abastecer(double quantidade) {
            Combustivel += quantidade;
            if (Combustivel > 100) {  Combustivel = 100; }
        }
        public override string ToString() {
            return $"Dados da nave: Modelo: {Modelo}, Velocidade: {Velocidade}KM/H, Combustivel: {Combustivel.ToString("F2", CultureInfo.InvariantCulture)}L";
        }
        
        

        
    }
}
