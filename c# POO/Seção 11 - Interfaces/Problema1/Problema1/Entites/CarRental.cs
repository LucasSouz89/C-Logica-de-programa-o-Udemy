using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problema1.Entites.Exception;

namespace Problema1.Entites
{
    sealed class CarRental
    {
        public string CarModel { get; private set; }

        public TimeSpan Duration { get; private set; }

        public double PriceDay { get; private set; }

        public double PriceHour { get; private set; }

        public CarRental() { }

        public CarRental(string carModel, DateTime pickup, DateTime returnn, double priceDay, double priceHour)
        {
            if (string.IsNullOrWhiteSpace(carModel)) { throw new ExceptionDomain("Digite um nome valido"); }
            if(pickup < DateTime.Now|| returnn < pickup) { throw new ExceptionDomain("Um data esta invalida"); }
            if (priceDay <= 0 || priceHour <= 0) { throw new ExceptionDomain("Digite um preço valido"); }
            
            CarModel = carModel;
            Duration = returnn - pickup;
            PriceDay = priceDay;
            PriceHour = priceHour;
        }
        public override string ToString()
        {
            return $"Basic payment: {BasicPayment().ToString("F2", CultureInfo.InvariantCulture)}\n" +
                $"Tax: {Tax().ToString("F2",CultureInfo.InvariantCulture)}\n" +
                $"Total payment: {TotalPayment().ToString("F2", CultureInfo.InvariantCulture)}";
                
        }
        public double BasicPayment() {
            double horasArredondadas = Math.Ceiling(Duration.TotalHours),diasArredondados = Math.Ceiling(Duration.TotalDays);
            
            double valor = (horasArredondadas <= 12) ? horasArredondadas*PriceHour : diasArredondados * PriceDay;
            return valor;
        }
        public double Tax()
        {
            double basicPayment = BasicPayment();
            if (basicPayment <= 100) { return basicPayment * 0.20; }
            else { return basicPayment * 0.15; }
        }
        public double TotalPayment()
        {
            return Tax()+BasicPayment();
        }
    } }
