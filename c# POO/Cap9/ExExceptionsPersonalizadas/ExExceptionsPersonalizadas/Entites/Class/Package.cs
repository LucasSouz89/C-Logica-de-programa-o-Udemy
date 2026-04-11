using ExExceptionsPersonalizadas.Entites.Exceptions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExExceptionsPersonalizadas.Entites.Class
{
    sealed class Package
    {
        public string TrackingCode { get; private set; }
        public double Weight { get; private set; }

        public double MaxCapacity { get; private set; }


        public Package() { }

        public Package(string trackinCode, double weight, double maxCapacity)
        {

            if (weight <= 0) { throw new ExceptionDomain("O peso inicial não pode ser negativo ou zero."); }
            if (maxCapacity <= weight) { throw new ExceptionDomain("A capacidade maxima deve ser maior que o peso inicial"); }
            TrackingCode = trackinCode;
            Weight = weight;
            MaxCapacity = maxCapacity;
        }
        public void AddWeight(double additionalWeight)
        {
            if (MaxCapacity < Weight + additionalWeight) { throw new ExceptionDomain($"Capacidade máxima excedida! O pacote suporta apenas {MaxCapacity} kg."); }
            Weight += additionalWeight;
            
        }
        public override string ToString() 
        {
            return $"Codigo de rastreio: {TrackingCode} | Peso do pacote: {Weight.ToString("F2", CultureInfo.InvariantCulture)}kg | Capacidade maxima: {MaxCapacity.ToString("F2", CultureInfo.InvariantCulture)}kg";
        }
    }
}
