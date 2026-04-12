using ExComposicao.Ex3.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExComposicao.Ex3.Class
{
    internal class Drone
    {
        public string CallSign { get; private set; }
        public DroneStatus Status { get; set; }

        public Battery PowerSource { get; private set;}

        public List<DeliveryItem> DeliveryItems { get; private set; } = new List<DeliveryItem>();

        public Drone() { }

        public Drone(string callSign, DroneStatus status, Battery powerSource)
        {
            CallSign = callSign;
            Status = status;
            PowerSource = powerSource;
            
        }
        public void AddItem(DeliveryItem item) { DeliveryItems.Add(item); }

        public double TotalCargoWeight() {
            double sum = 0;
            foreach(DeliveryItem item in DeliveryItems)
            {
                sum += item.Weight;
            }
            return sum;
        }
        public bool CanTakeoff(double maxPayload)
        {
            double TotalCargo = TotalCargoWeight();
            if (maxPayload >= TotalCargo) {return true;}
            else {return false;}
        }

    }
}
