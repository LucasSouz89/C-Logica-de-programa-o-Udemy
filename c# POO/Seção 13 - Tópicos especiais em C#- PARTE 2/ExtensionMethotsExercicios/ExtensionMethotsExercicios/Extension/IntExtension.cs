using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethotsExercicios.Extension;

static class IntExtension
{
    
    public static bool IsEven(this int obj) {

        return obj % 2 == 0;
    }
    public static int Fatorial(this int obj) {
        int newValue = obj;
        for (int i = 1; i < obj; i++) {
            newValue *= i;
        }
        return newValue;
    }
}
