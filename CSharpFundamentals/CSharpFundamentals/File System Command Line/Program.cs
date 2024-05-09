using System;
using System.IO;
namespace File_System_Command_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write(">> ");
                var input = Console.ReadLine().Trim();
                var whitespaceindex = input.IndexOf(' ');
                string command = null;
                string path = null;
                if (input != "ex")
                {
                     command= input.Substring(0, whitespaceindex).ToLower();
                     path = input.Substring(whitespaceindex + 1).Trim();
                }
                else if (input == "ex")
                {
                    break;
                }
                    
                if (command == "ls")
                {
                    foreach (var entry in Directory.GetDirectories(path))
                    {
                        Console.WriteLine($"dr--r--r-- {entry}");
                    }
                    foreach (var entry in Directory.GetFiles(path))
                    {
                        Console.WriteLine($"-r--r--r-- {entry}");
                    }

                }
                else if (command == "nf")
                {
                    if (Directory.Exists(path))
                    {
                        var directoryinfo = new DirectoryInfo(path);
                        Console.WriteLine($"Type: Directory\n" +
                            $"Created at: {directoryinfo.CreationTime}\n" +
                            $"Last modified at: {directoryinfo.LastWriteTime}");
                    }
                    else if (File.Exists(path))
                    {
                        var fileinfo = new FileInfo(path);
                        Console.WriteLine($"Type: File\n" +
                            $"Created at: {fileinfo.CreationTime}\n" +
                            $"Last modified at: {fileinfo.LastWriteTime}\n" +
                            $"Size in Bytes: {fileinfo.Length} B");
                    }
                }
                else if (command == "mkdir")
                {
                    Directory.CreateDirectory(path);
                }
                else if (command == "touch")
                {
                    File.Create(path);
                }
                else if (command == "cat")
                {
                    if (File.Exists(path))
                    {
                        var content = File.ReadAllText(path);
                        Console.WriteLine(content);
                    }
                }
                else if (command == "rm")
                {
                    if (Directory.Exists(path))
                        Directory.Delete(path);
                    else if (File.Exists(path))
                        File.Delete(path);
                }
            }
        }
    }
}
