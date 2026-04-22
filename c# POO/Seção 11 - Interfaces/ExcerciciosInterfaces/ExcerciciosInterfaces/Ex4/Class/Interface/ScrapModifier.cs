using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciciosInterfaces.Ex4.Class.Interface
{
    internal class ScrapModifier : IMaterialModifier
    {
       public double ApllyModifer(double damage) { return damage -(damage * 0.20); }
    }
}
