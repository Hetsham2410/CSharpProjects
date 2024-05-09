using System;

namespace Parser
{
    class Program 
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Please Enter match expression: ");
                var Expression = Parser.ParseOperand(Console.ReadLine());
                var Result = CalculateResult.GetResult(Expression);
                Console.WriteLine($"Left Side: {Expression.LeftSideOperand}," +
                        $"Operation: {Expression.Operation}," +
                        $" Right Side: {Expression.RightSideOperand}");
                if (Expression.LeftSideOperand != 0)
                    Console.WriteLine($"{Expression.LeftSideOperand}" +
                        $" {Expression.Operation}" +
                        $" {Expression.RightSideOperand}" +
                        $" = {Result}");
                else
                    Console.WriteLine($"{Expression.Operation}" +
                    $" {Expression.RightSideOperand}" +
                    $" = {Result}");


            }
        }
    }
}
