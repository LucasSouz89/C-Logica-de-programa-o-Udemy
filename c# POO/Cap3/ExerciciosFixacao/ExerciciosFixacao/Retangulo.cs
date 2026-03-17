using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosFixacao {
    internal class Retangulo {
        public double altura;
        public double largura;


        public double Area() {
            return altura*largura;
        }
        public double Perimetro() {
            return (largura+altura)*2;
        }
        public double Diagonal() {
            return Math.Sqrt(Math.Pow(altura,2)+ Math.Pow(largura, 2));
        }
        public override string ToString() {
            return $"AREA = {Area().ToString("F2",CultureInfo.InvariantCulture)}\n" +
                $"PERÍMETRO = {Perimetro().ToString("F2", CultureInfo.InvariantCulture)}\n" +
                $"DIAGONAL = {Diagonal().ToString("F2", CultureInfo.InvariantCulture)}\n";
        }
    }
}
