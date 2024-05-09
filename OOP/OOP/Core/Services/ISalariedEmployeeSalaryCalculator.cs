using OOPHRSystem.Core.Entities;

namespace OOPHRSystem.Core.Services
{
    internal interface ISalariedEmployeeSalaryCalculator
    {
        SalariedEmployee Employee { get; }

        decimal GetSalary();
        decimal GetSalary(int taxPercentage);
        decimal GetSalary(int taxPercentage, decimal bonus);
    }
}