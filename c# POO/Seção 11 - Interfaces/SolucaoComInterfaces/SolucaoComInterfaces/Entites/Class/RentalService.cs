using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolucaoComInterfaces.Entites.Services;

namespace SolucaoComInterfaces.Entites.Class
{
    sealed class RentalService
    {
        public double PricePerHour { get;private set; }
        public double PricePerDay { get; private set; }

        private ITaxService _taxservice;

        public RentalService(double pricePerHour, double pricePerDay,ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxservice = taxService;
        }
        public void ProcessInvoice(CarRental carRental)
        {
           
           TimeSpan duration = carRental.Finish.Subtract(carRental.Start);
           double durationHoursCeiling = Math.Ceiling(duration.TotalHours), durationDaysCeiling = Math.Ceiling(duration.TotalDays);
           double payment = (durationHoursCeiling <= 12) ? PricePerHour*durationHoursCeiling : PricePerDay*durationDaysCeiling;
           double tax = _taxservice.Tax(payment);
           carRental.Invoice = new Invoice(payment, tax);
        
        }
    }
}
