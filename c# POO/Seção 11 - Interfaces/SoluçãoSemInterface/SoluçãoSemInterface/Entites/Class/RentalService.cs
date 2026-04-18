using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoluçãoSemInterface.Entites;
using SoluçãoSemInterface.Entites.Services;

namespace SoluçãoSemInterface.Entites.Class
{
    sealed class RentalService
    {
        public double PricePerHour { get;private set; }
        public double PricePerDay { get; private set; }

        private BrazilTaxService _brazilTaxService = new BrazilTaxService();

        public RentalService(double pricePerHour, double pricePerDay)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
        }
        public void ProcessInvoice(CarRental carRental)
        {
           
           TimeSpan duration = carRental.Finish.Subtract(carRental.Start);
           double durationHoursCeiling = Math.Ceiling(duration.TotalHours), durationDaysCeiling = Math.Ceiling(duration.TotalDays);
           double payment = (durationHoursCeiling <= 12) ? PricePerHour*durationHoursCeiling : PricePerDay*durationDaysCeiling;
           double tax = _brazilTaxService.Tax(payment);
           carRental.Invoice = new Invoice(payment, tax);
        
        }
    }
}
