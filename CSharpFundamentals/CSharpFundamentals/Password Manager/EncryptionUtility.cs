using System;
using System.Text;

namespace Password_Manager
{
    public static class EncryptionUtility
    {
        private static readonly string _originalChar =
            "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        private static readonly string _altChar =
        "zdoYqDSU3xHIi4MGXgLmNWvKbt8Z16QAVuCnlT7JsPpakjR5h0e2BEOfcFyrw9";

        public static string Encrypt(string password)
        {
            var sb = new StringBuilder();
            foreach (var ch in password)
            {
                var charIndex = _originalChar.IndexOf(ch);
                sb.Append(_altChar[charIndex]);
            }
            return sb.ToString();
        }
        public static string Decrypt(string password)
        {

            var sb = new StringBuilder();
            foreach (var ch in password)
            {
                var charIndex = _altChar.IndexOf(ch);
                sb.Append(_originalChar[charIndex]);
            }
            return sb.ToString();
        }
    }
}
