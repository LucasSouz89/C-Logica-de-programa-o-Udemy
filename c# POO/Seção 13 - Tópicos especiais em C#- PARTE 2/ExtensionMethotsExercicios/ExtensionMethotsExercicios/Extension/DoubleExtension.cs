using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethotsExercicios.Extension
{
    static class DoubleExtension
    {
        public static string ToBRL(this double value) =>value.ToString("C",new CultureInfo("pt-BR"));
    }
}
