using System;
namespace Inheritance
{
    public abstract class Employee
    {
        private const int MinumumLoggedHours = 176;
        private const decimal OverTimeRate = 1.25m;
        protected int Id { get; set; }
        protected string Name { get; set; }
        protected decimal LoggedHours { get; set; }
        protected decimal Wage { get; set; }

        public Employee(int Id, string Name, decimal LoggedHours, decimal Wage)
        {
            this.Id = Id;
            this.Name = Name;
            this.LoggedHours = LoggedHours;
            this.Wage = Wage;
        }

        protected virtual decimal Calculate ()
        { 
            return CalculateBaseSalary() + CalculateOverTimeSalary();
        }
        protected decimal CalculateBaseSalary()
        {
            return LoggedHours * Wage;
        }
        protected decimal CalculateOverTimeSalary()
        {
            var additionalHoures = ((LoggedHours - MinumumLoggedHours) > 0 ? (LoggedHours - MinumumLoggedHours) : 0);
            return additionalHoures * Wage * OverTimeRate;
        }
        public override string ToString()
        {
            var type = GetType().ToString().Replace("Inheritance.", "");
            return $"{type}"+
                $"\nId: {Id}" +
                $"\nName: {Name}" +
                $"\nLogged Hours: {LoggedHours} hrs" +
                $"\nWage: {Wage} $/hr" +
                $"\nBase Salary: {Math.Round(CalculateBaseSalary(), 2):N0} $" +
                $"\nOvertime Salary: {Math.Round(CalculateOverTimeSalary(), 2):N0} $";

        }


    }

}

