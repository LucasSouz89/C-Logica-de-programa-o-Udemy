using ExComposicao.Ex2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExComposicao.Ex2.Class
{
    internal class Truck
    {
        public string LicensePlate { get; private set; }
        public TruckType TruckModel { get; private set; }
        public Carrier Carrier { get; private set; }
        public List<Delivery> Deliveries { get; private set; } = new List<Delivery>();


        public Truck() { }
        public Truck(string licensePlate, TruckType truckk, Carrier carrier)
        {
            LicensePlate = licensePlate;
            TruckModel = truckk;
            Carrier = carrier;
        }
        public void AddDelivery(Delivery delivery) {
            Deliveries.Add(delivery);
        }
        public double CalculateMonthlyRevenue(int year, int mouth)
        {
            double sum = 0;
            foreach (Delivery delivery in Deliveries)
            {
                if (delivery.Date.Year == year && delivery.Date.Month == mouth) {
                    sum += delivery.Revenue;
                }
                
            }
            return sum;
        }
        public override string ToString()
        {
            return $"PLACA: {LicensePlate} | MODELO: {TruckModel.ToString()} | TRANSPORTADORA: {Carrier.Name}\n" +
                $"QUANTIDADE DE ENTREGAS: {Deliveries.Count}";
        }
    }
}
