using System;

namespace ShuffleString
{
    class Program
    {
        private static readonly string _originalChar = 
            "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        public static void Main()
        {
            string shuffledString = ShuffleString(_originalChar);
            Console.WriteLine(shuffledString);
        }

        public static string ShuffleString(string str)
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
