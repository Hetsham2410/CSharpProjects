using OOPHRSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHRSystem.Core.Services
{
    internal class SalariedEmployeeSalaryCalculator : SalaryCalculator, ISalariedEmployeeSalaryCalculator
    {
        public SalariedEmployeeSalaryCalculator(SalariedEmployee employee)
        {
            Employee = employee;
        }

        public SalariedEmployee Employee { get; }

        public override decimal GetSalary()
        {

            Console.ForegroundColor = ConsoleColor.Green;
            return Employee.BasicSalary + Employee.Transportation + Employee.Housing;
        }
        public decimal GetSalary(int taxPercentage)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            return GetSalary() - (Employee.BasicSalary * taxPercentage / 100);
        }
        public decimal GetSalary(int taxPercentage, decimal bonus)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            return GetSalary(taxPercentage) + bonus;
        }
    }
}
