using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Manager
{
    public class ShuffleString
    {
        public static string shuffleString(string str)
        {
            Random rng = new Random();
            char[] chars = str.ToCharArray();
            int n = chars.Length;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                char value = chars[k];
                chars[k] = chars[n];
                chars[n] = value;
            }
            return new string(chars);
        }
    }
}
