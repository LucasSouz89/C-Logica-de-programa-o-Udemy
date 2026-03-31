using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExComposicao.Ex3.Class
{
    internal class DeliveryItem
    {
        public string TrackingCode { get; private set; }
        public double Weight { get; private set; }

        public DeliveryItem() { }

        public DeliveryItem(string trackingCode, double weight) { TrackingCode = trackingCode; Weight = weight; }
    }
}
