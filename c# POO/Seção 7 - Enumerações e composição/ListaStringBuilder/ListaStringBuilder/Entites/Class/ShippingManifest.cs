using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaStringBuilder.Entites.Class
{
    internal class ShippingManifest
    {
        public string TruckPlate { get;private set; }
        public string Destination { get; private set; }

        public DateTime DepuarateDate { get; private set; }

        public List<Pallet> Pallets { get; private set; } = new List<Pallet>();

        public ShippingManifest() { }

        public ShippingManifest(string truckPlate, string destination, DateTime depuarateDate)
        {
            TruckPlate = truckPlate;
            Destination = destination;
            DepuarateDate = depuarateDate;
        }
        public void AddPallet(Pallet pallet)
        {
            Pallets.Add(pallet);
        }
        public void RemovePallet(Pallet pallet) {
            Pallets.Remove(pallet);
        }
        public override string ToString()
        {
           StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Truck plate: {TruckPlate}");
            sb.AppendLine($"Destination: {Destination}");
            sb.AppendLine($"Pallets quantity {Pallets.Count}");
            sb.AppendLine($"Total cargo weight: {totalWeight()}");
            sb.AppendLine($"Depurate date: {DepuarateDate.ToString("dd/MM/yyyy")}");
            int count = 1;
            foreach (Pallet p in Pallets) {
                sb.AppendLine($"Pallet {count}| ID: {p.Id} | Content: {p.Content} | Weight: {p.Weight}");
                count++;
            }
            return sb.ToString();
        }
        public double totalWeight() {
            double sum = 0;
            foreach (Pallet p in Pallets) { sum += p.Weight; }
            return sum;
        }
    }
}
