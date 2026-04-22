using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciciosInterfaces.Ex3.Class.Entites1
{
    sealed class Subscription
    {
        public string GameTag { get;private set; }

        public double MotlyPrice { get; set; }

        public int Months { get;private set; }

        public Subscription() { }

        public Subscription(string gameTag, double motlyPrice, int months)
        {
            GameTag = gameTag;
            MotlyPrice = motlyPrice;
            Months = months;
        }
    }
}
