using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System;

static class StringExtension
{
    public static string Capitalize(this string s) => s[0].ToString().ToUpper() + s.Substring(1).ToLower();

    public static int CountVowels(this string s)
    {
        
        int sum = 0;
        foreach (var c in s.ToLower())
        {
            switch (c) {
                case 'a': 
                case 'e':
                case 'i':
                case 'o':
                case 'u': sum++; break;
                
            }
        }
        return sum;
    }
}
