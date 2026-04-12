using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExStruct {
    struct CorRGB {
        public int Red { get; private set; }
        public int Green { get; private set; }
        public int Blue { get; private set; }

        public CorRGB(int r, int g, int b) {
            Red = r;
            Green = g;
            Blue = b;
        }
        public override string ToString() {
            return $"Sangue : RED:{Red}, GREEN:{Green}, BLUE:{Blue}";
        }
    }
}
