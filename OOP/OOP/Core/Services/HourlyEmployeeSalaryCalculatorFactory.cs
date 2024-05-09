using OOPHRSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHRSystem.Core.Services
{
    internal class HourlyEmployeeSalaryCalculatorFactory
    {
        public static IHourlyEmployeeSalaryCalculator Create (HourlyEmployee employee)
        {
            return new HourlyEmployeeSalaryCalculator(employee);
        }
    }
}
