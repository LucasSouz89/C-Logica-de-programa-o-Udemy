using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System;

static class StringExtension
{
    public static string Cut(this string str,int value) {
        if (str.Length <= value) return str;
        else { return str.Substring(0, value) + "..."; }
    }
}
