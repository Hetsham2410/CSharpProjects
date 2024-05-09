using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter value: ");
            var input = Console.ReadLine();
            Console.WriteLine(input.RemoveWhiteSpaces().Reverse());
            //int percentage = 10;
            //if (percentage.IsBetween(0,100))
            //    Console.WriteLine("Percentage is valid");
            //else
            //    Console.WriteLine("Percentage isn't valid");
        }
    }
}
