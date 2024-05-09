using System;

namespace DelegatesAndEvents
{
    public class SalaryLogger
    {
        public SalaryLogger(SalaryCalculator salarycalculator)
        {
            salarycalculator.EmployeeSalaryCalculated += LogEmployeeSalary;
            salarycalculator.EmployeeSalaryCalculated += (employee, salary) =>
             Console.WriteLine($"Paysslip sent to employee '{employee.Name}'");
        }
        private static void LogEmployeeSalary(Employee employee, int salary)
        {
            Console.WriteLine($"Salary for employee '{employee.Name}' = {salary}");
        }

    }
}
