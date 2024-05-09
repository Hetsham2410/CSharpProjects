using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(Divide(10, 2));
                Console.WriteLine(Divide(10, 0));
                
            }
            catch (DivideByZeroException ex)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(ex.ToString());
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        static int Divide(int num1, int num2)
        {
            if (num2 == 0)
                return 0;
            return num1 / num2;
        }
    }
}
