using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeratorEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Employee e1 = new Employee
            {
                Id = 100,
                Name = "Ahmed A.",
                Salary = 1000m,
                Department = "IT"
            };
            Employee e2 = new Employee
            {
                Id = 100,
                Name = "Ahmed A.",
                Salary = 1000m,
                Department = "IT"
            };
            Console.WriteLine(e1.Equals(e2));
            Console.WriteLine(e1 == e2);
            */
            var ints = new FiveIntegers(1, 2, 3, 4, 5);
            foreach (var item in ints)
            {
                Console.WriteLine(item); ;
            }
            
            Console.ReadKey();
        }
    }
}
