using System;
using System.Collections.Generic;
namespace DelegatesAndEvents
{
    #region Passionate Coders
    #region Event
    //static class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        List<Employee> employees = new();
    //        var rnd = new Random();
    //        for (int i = 0; i < 100; i++)
    //        {
    //            employees.Add(new Employee
    //            {
    //                Name = $"Employee {i + 1}",
    //                BasicSalary = rnd.Next(1000, 5001),
    //                Deduction = rnd.Next(0, 501),
    //                Bonus = rnd.Next(0, 1001)
    //            });
    //        }
    //        var salarycalculator = new SalaryCalculator();
    //        var salarylogger = new SalaryLogger(salarycalculator);
    //        salarycalculator.CalculateSalaries(employees, employee => employee.BasicSalary <= 2000);
    //    }

    #endregion
    #region Basic Delegate
    //delegate int CalculateDelegate(int num1, int num2);
    //    //static void Main(string[] args)
    //    //{
    //    //    int n1 = 10;
    //    //    int n2 = 2;
    //    //    CalculateDelegate dlg = Add;
    //    //    CalculateWithDelegate(n1, n2, dlg);
    //    //    dlg = Subtract;
    //    //    CalculateWithDelegate(n1, n2, dlg);
    //    //    CalculateWithDelegate(n1, n2, "Add", (int x, int y) => x + y);
    //    //    CalculateWithDelegate(n1, n2, "Subtract", (int x, int y) => x - y);
    //    //    CalculateWithDelegate(n1, n2, "Multiply", (int x, int y) => x * y);
    //    //    CalculateWithDelegate(n1, n2, "Divide", (int x, int y) => x / y);
    //    //    CalculateWithDelegate(n1, n2, "Mod", (int x, int y) => x % y);
    //    //    CalculateWithDelegate(n1, n2, Divide);
    //    //}

    //    //static void CalculateWithDelegate(int number1, int number2,string operation, CalculateDelegate dlg)
    //    //{
    //    //    int result = dlg(number1, number2);
    //    //    Console.WriteLine($"{operation} Result: {result}");
    //    //}
    //    //static int Calculate(int number1, int number2, char op)
    //    //{
    //    //    int result = 0;
    //    //    switch (op)
    //    //    {
    //    //        case '+':
    //    //            result = Add(number1, number2);
    //    //            break;
    //    //        case '-':
    //    //            result = Subtract(number1, number2);
    //    //            break;
    //    //        case '*':
    //    //            result = Multiply(number1, number2);
    //    //            break;
    //    //        case '/':
    //    //            result = Divide(number1, number2);
    //    //            break;
    //    //    }
    //    //    return result;
    //    //}
    //    //static int Add(int num1, int num2)
    //    //{
    //    //    Console.WriteLine("Add");
    //    //    return num1 + num2;
    //    //}
    //    //static int Subtract(int num1, int num2)
    //    //{
    //    //    Console.WriteLine("Subtract");
    //    //    return num1 - num2;
    //    //}
    //    //static int Multiply(int num1, int num2)
    //    //{
    //    //    Console.WriteLine("Multiply");
    //    //    return num1 * num2;
    //    //}
    //    //static int Divide(int num1, int num2)
    //    //{
    //    //    Console.WriteLine("Divide");
    //    //    return num1 / num2;
    //    //}
    //}  
    #endregion
    //}
    #endregion

    #region Piece of Cake Dev
    #region Basic Delegate
    //static class Program
    //{
    //    static void Main(string[] args)
    //    {
    //    }
    //}
    #endregion
    #region EventHandler & EventArgs
    static class program
    {
        static void Main(string[] args)
        {

            YoutubeChannel youtubechannel1 = 
                new YoutubeChannel("Mr.Beast");
            YoutubeChannel youtubechannel2 = 
                new YoutubeChannel("Elzero Web School");

            Subscriber subscriber1 = 
                new Subscriber("Subscriber1");
            Subscriber subscriber2 = 
                new Subscriber("Subscriber2");
            Subscriber subscriber3 = 
                new Subscriber("Subscriber3");

            subscriber1.Subscribe(youtubechannel1);
            subscriber2.Subscribe(youtubechannel1);
            subscriber3.Subscribe(youtubechannel1); 
            
            subscriber2.Subscribe(youtubechannel2);
            subscriber3.Subscribe(youtubechannel2);

            var video1inof = youtubechannel1.EnterVideoInfo("Delegates and Event", "An Important topic in C# Course", 15);

            var video2inof = youtubechannel2.EnterVideoInfo("Fonts", "An Important topic in HTML Course", 5);

            youtubechannel1.UploadVideo(video1inof);

            youtubechannel2.UploadVideo(video2inof);
 
        }
    }
    #endregion
    #endregion
}


