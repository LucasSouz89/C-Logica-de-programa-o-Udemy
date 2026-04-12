using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExExceptionsPersonalizadas.Entites.Exceptions;

namespace ExExceptionsPersonalizadas.Entites.Class
{
    sealed class Hypercar
    {
        public string Model { get;private set; }
        public int CurrentSpeed { get;private set; }

        public int TopSpeed { get;private set; }

        public Hypercar() { }

        public Hypercar(string model, int curretSpeed, int topSpeed) {
            if (topSpeed <= 0) { throw new ExceptionDomain("A velocidade maxíma não deve ser negativa ou igual a zero"); }
            if (curretSpeed < 0) { throw new ExceptionDomain("A velocidade atual não pode ser negativa"); }
            if (topSpeed < curretSpeed) { throw new ExceptionDomain("A velocidade maxima deve ser maior ou igual a velocidade atual"); }
            Model = model;
            CurrentSpeed = curretSpeed;
            TopSpeed = topSpeed;
        }
        public void Accelerate(int targetSpeed)
        {
            if (targetSpeed < CurrentSpeed) { throw new ExceptionDomain("A velocidade alvo deve ser maior que a velocidade atual para acelerar."); }
            if (targetSpeed > TopSpeed) { throw new ExceptionDomain($"Velocidade não suportada! O limite do motor para este modelo é {TopSpeed} km/h."); }
            CurrentSpeed = targetSpeed;
            
            

        }
        public override string ToString()
        {
            return $"Velocidade atual: {CurrentSpeed} Km/h | Velocidade maxima: {TopSpeed} Km/h";
        }

    }
}
