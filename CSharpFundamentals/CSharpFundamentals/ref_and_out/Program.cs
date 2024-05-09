using System;

namespace Ref_and_Out
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Please Enter a number: ");
            var isConverted = int.TryParse(Console.ReadLine(), out num);
            Console.WriteLine($"IsConverted: {isConverted}");
            Console.WriteLine($"Num: {num}");
            //TestRef();
            //TestOut();
            //Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
        }
        private static void TestRef()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            /* 1- Ref Variable must be initialized.
               2- The called method can't assign a value to the ref parameter in its all paths.
             */
            bool isSuccessful = true;
            var result = DivideRef(10, 0, ref isSuccessful);
            Console.WriteLine($"isSuccessful = {isSuccessful}");
            Console.WriteLine($"result = {result}");
        }
        private static void TestOut()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            /* 1- Out Variable can't be initialized.
               2- The called method must assign a vlaue to the out parameter in its all paths.
             */
            bool isSuccessful;
            var result = DivideOut(10, 0, out isSuccessful);
            Console.WriteLine($"isSuccessful = {isSuccessful}");
            Console.WriteLine($"result = {result}");
        }
        static double DivideRef(double number, double divisor, ref bool isSuccessful)
        {
            if (divisor == 0)
            {
                Console.WriteLine("Can't divide on zero");
                isSuccessful = false;
                return 0;
            }
            isSuccessful = true;
            return number / divisor;
        }
        static double DivideOut(double number, double divisor, out bool isSuccessful)
        {
            if (divisor == 0)
            {
                Console.WriteLine("Can't divide on zero");
                isSuccessful = false;
                return 0;
            }
            isSuccessful = true;
            return number / divisor;
        }
    }
}
