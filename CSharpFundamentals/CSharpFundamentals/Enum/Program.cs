using System;

namespace Enums
{
    public enum Color
    {
        Black,
        DarkBlue,
        DarkGreen,
        DarkCyan,
        DarkRed,
        DarkMagenta,
        DarkYellow,
        Gray,
        DarkGray,
        Blue,
        Green,
        Cyan,
        Red,
        Magenta,
        Yellow,
        White,
    }
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var color in Enum.GetNames(typeof(Color)))
                Console.WriteLine($"{color} = {(int)Enum.Parse(typeof(Color), color, true)}");
            //while (true)
            //{   
                //Console.WriteLine("Choose Background Color");
                //Console.Write("Please Select an option: ");
                //string backgroundoption = Console.ReadLine();
                //Console.WriteLine("Choose Foreground Color");
                //Console.Write("Please Select an option: ");
                //string forgroundoption = Console.ReadLine();
                //ConsoleColor backgroundcolor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor),backgroundoption,true);
                //ConsoleColor forgroundcolor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), forgroundoption, true);
                //Console.BackgroundColor = backgroundcolor;
                //Console.ForegroundColor = forgroundcolor;
                //Console.WriteLine("Hello, Git");
                //Console.BackgroundColor = ConsoleColor.Black;
                //Console.ForegroundColor = ConsoleColor.White;
            //}

        }
    }
}
