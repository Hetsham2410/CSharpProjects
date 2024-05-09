using OOPHRSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHRSystem.Core.Services
{
     class DismissEmployee
    {
        //public DismissEmployee(DissmissableEmployee employee)
        //{
        //    Employee = employee;
        //}

        //public DissmissableEmployee Employee { get; }
        public static void Dismiss(DissmissableEmployee employee)
        {
            employee.Dismiss();
            Console.WriteLine($"Employee '{employee.FullName}' has been dismissed.");
        }
    }
}
