using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class StringExtensions
    {
        public static string RemoveWhiteSpaces(this string value)
        {
            return value.Replace(" ","");
        }
        public static string Reverse(this string value)
        {
            var charArray = value.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
