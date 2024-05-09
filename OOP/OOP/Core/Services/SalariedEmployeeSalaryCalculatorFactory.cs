using OOPHRSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHRSystem.Core.Services
{
    internal class SalariedEmployeeSalaryCalculatorFactory
    {
        public static ISalariedEmployeeSalaryCalculator Create(SalariedEmployee employee)
        {
            return new SalariedEmployeeSalaryCalculator(employee);
        }
    }
}
