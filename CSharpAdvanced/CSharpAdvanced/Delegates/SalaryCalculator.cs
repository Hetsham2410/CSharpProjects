using System;
using System.Collections.Generic;
namespace DelegatesAndEvents
{
    public delegate void EmployeeSalaryCalculatedEventHandler(Employee employee, int salary);
    public class SalaryCalculator
    {       
        public event EmployeeSalaryCalculatedEventHandler EmployeeSalaryCalculated;
        //public delegate bool CalculateSalariesDelegate(Employee employee);        
        public void CalculateSalaries(List<Employee> employees, Predicate<Employee> predicate)
        {
            foreach (var employee in employees)
            {
                if (predicate(employee))
                {
                    var salary = employee.BasicSalary + employee.Bonus - employee.Deduction;
                    EmployeeSalaryCalculated?.Invoke(employee,salary);//Firing the event
                }
            }
        }
    }
} 