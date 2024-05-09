using OOPHRSystem.Core.Entities;

namespace OOPHRSystem.Core.Services
{
    internal interface IHourlyEmployeeSalaryCalculator
    {
        HourlyEmployee Employee { get; }

        decimal GetSalary();
    }
}