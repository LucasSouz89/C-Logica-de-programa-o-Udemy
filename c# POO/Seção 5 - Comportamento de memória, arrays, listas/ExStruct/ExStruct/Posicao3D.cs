using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExStruct {
    struct Posicao3D {
        public double X,Y,Z;

        public override string ToString() {
            return $"{X}, {Y}, {Z}";
        }
    }
}
