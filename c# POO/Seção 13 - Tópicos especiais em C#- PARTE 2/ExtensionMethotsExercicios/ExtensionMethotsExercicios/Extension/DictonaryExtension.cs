using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethotsExercicios.Extension
{
    static class DictonaryExtension
    {

        public static void AddOrUpdate<TKey,TValue>(this Dictionary<TKey,TValue> dictionary, TKey key, TValue value)
        {
            dictionary[key] = value;
        }
    }
}
