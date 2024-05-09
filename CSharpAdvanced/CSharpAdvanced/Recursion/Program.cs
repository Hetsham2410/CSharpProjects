using System;
using System.IO;

namespace Recursion
{
    static class Program
    {
        static void Main(string[] args)
        {
            PrintDirectoryFileSystemENtries(@"D:\Courses\Web Development\Back End\.Net\SOLID Principles", 1);
            var size = CalculateDirectorySize(@"D:\Courses\Web Development\Back End\.Net\SOLID Principles");
            Console.WriteLine($"{size/1024/1024} MB"); 
        }
        public static void PrintDirectoryFileSystemENtries(string dirPath, int level)
        {
            foreach (var fileName in Directory.GetFiles(dirPath))
            {
                Console.WriteLine($"{new string('-', level)}File: {new FileInfo(fileName).Name}");
            }
            foreach (var dirName in Directory.GetDirectories(dirPath))
            {
                Console.WriteLine($"{new string('-', level)}Directory: {new DirectoryInfo(dirName).Name}");
                PrintDirectoryFileSystemENtries(dirName, level + 1);
            }

        }
        public static long CalculateDirectorySize(string dirPath)
        {
            long size = 0;
            foreach (var fileName in Directory.GetFiles(dirPath))
            {
                size += new FileInfo(fileName).Length;
            }
            foreach (var dirName in Directory.GetDirectories(dirPath))
            {
                size += CalculateDirectorySize(dirName);
            }
            return size;

        }

    }
}
