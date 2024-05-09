using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHRSystem.Core.Services
{
    internal class InternEmployeeSalaryCalculator : SalaryCalculator, IInternEmployeeSalaryCalculator
    {

        public override decimal GetSalary()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            return 2000;
        }
    }
}
