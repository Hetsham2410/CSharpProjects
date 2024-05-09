using OOPHRSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHRSystem.Core.Services
{
    internal class HourlyEmployeeSalaryCalculator : SalaryCalculator, IHourlyEmployeeSalaryCalculator
    {
        public HourlyEmployeeSalaryCalculator(HourlyEmployee employee)
        {
            Employee = employee;
        }

        public HourlyEmployee Employee { get; }

        public override decimal GetSalary()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            return Employee.HourRate * Employee.TotalWorkingHours;

        }
    }
}
