using System;


namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            Managers m = new Managers(1001, "Mohamed W.", 178, 10);
            Maintanance ms = new Maintanance(1002, "Sedak S.", 176, 9);
            Sales s = new Sales(1003, "Islam E.", 177, 12, 0.05m, 1000m);
            Developer d = new Developer(1004, "Ahmed H.", 180, 15, true);
            Employee[] employees = { m, ms, s, d };
            foreach (var employee in employees)  
            {
                Console.WriteLine(employee);
                Console.WriteLine("-------------------------");              
            }
            Console.ReadKey();
        }
    }
}

