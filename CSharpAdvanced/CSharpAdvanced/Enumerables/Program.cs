using System;
using System.Linq;

namespace Enumerables
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee();
            employee.AddPayItem("Basic Salary", 1000);
            employee.AddPayItem("Housing", 500);
            employee.AddPayItem("Transportations", 200);
            employee.AddPayItem("Insurance", -300);

            //var payItem1 = employee.GetPayItems();
            //var payItem2 = employee.GetEnumerator();

            foreach (var payItem in employee)
                Console.WriteLine($"{payItem.Name} = {payItem.Value}");
            for (var i = 0; i < employee.Count(); i++)
                Console.WriteLine($"{employee[i].Name} = {employee[i].Value}");

        }
    }
}
 