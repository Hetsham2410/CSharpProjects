using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Password_Manager
{
    class Program
    {
        private static readonly Dictionary<string, string> _passwordEntries = new();

        static void Main(string[] args)
        {
            ReadPaswords();
            Console.WriteLine("\t\t\t\t\tWelcome to password manager applications        ");
            while (true)
            {

                Console.WriteLine("Select an option:\n" +
                    "1- List all passwords\n" +
                    "2- Add/Change password\n" +
                    "3- Get password\n" +
                    "4- Delete password\n" +
                    "5- Exit\n");
                Console.Write("Selected Option: ");
                var selectedoption = Console.ReadLine();
                Console.WriteLine("");
                switch (selectedoption)
                {
                    case "1":
                        ListAllPassword();
                        break;
                    case "2":
                        AddOrChange();
                        break;
                    case "3":
                        GetPassword();
                        break;
                    case "4":
                        DeletePassword();
                        break;
                    case "5":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Enter a right option\n");
                        break;
                }
            }
        }

        private static void ListAllPassword()
        {
            if (_passwordEntries.Count() != 0)
            {
                foreach (var entry in _passwordEntries)
                {
                    Console.WriteLine($"{entry.Key}:{entry.Value}");
                }
            }

        }

        private static void AddOrChange()
        {
            Console.Write("Please enter website/app name: ");
            var appName = Console.ReadLine();
            Console.Write("Please enter your password: ");
            var appPassword = Console.ReadLine();
            if (_passwordEntries.ContainsKey(appName))
                _passwordEntries[appName] = appPassword;
            else
                _passwordEntries.Add(appName, appPassword);
            SavePasswords();
        }

        private static void GetPassword()
        {
            Console.Write("Please enter website/app name: ");
            var appName = Console.ReadLine();
            if (_passwordEntries.ContainsKey(appName))
                Console.WriteLine($"Your password is: {_passwordEntries[appName]}");
            else
                Console.WriteLine("Password not found");
        }

        private static void DeletePassword()
        {
            Console.Write("Please enter website/app name: ");
            var appName = Console.ReadLine();
            if (_passwordEntries.ContainsKey(appName))
            {
                _passwordEntries.Remove(appName);
                SavePasswords();
            }
        }
        private static void ReadPaswords()
        {
            if (File.Exists(@"D:\Projects\\C#\CSharpFundamentals\CSharpFundamentals\Password Manager\Passwords.txt"))
            {
                var passwordline = File.ReadAllText(@"D:\Projects\\C#\CSharpFundamentals\CSharpFundamentals\Password Manager\Passwords.txt");
                foreach (var line in passwordline.Split(Environment.NewLine))
                {
                    if (!string.IsNullOrEmpty(line))
                    {
                        var seperatorIndex = line.IndexOf(":");
                        var appName = line.Substring(0, seperatorIndex);
                        var appPassword = line.Substring(seperatorIndex + 1);
                        _passwordEntries.Add(appName, EncryptionUtility.Decrypt(appPassword));
                    }
                }
            }
        }
        private static void SavePasswords()
        {
            var sb = new StringBuilder();
            foreach (var entry in _passwordEntries)
            {
                sb.AppendLine($"{entry.Key}:{EncryptionUtility.Encrypt(entry.Value)}");
            }
            File.WriteAllText(@"D:\Projects\\C#\CSharpFundamentals\CSharpFundamentals\Password Manager\Passwords.txt", sb.ToString());
        }


    }
}








