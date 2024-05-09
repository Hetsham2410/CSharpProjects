using System;
namespace Inheritance
{
    public class Maintanance : Employee
    {
        public const decimal Hardship = 100m;
        public Maintanance(int Id, string Name, decimal LoggedHours, decimal Wage) : base(Id, Name, LoggedHours, Wage)
        {

        }
        protected override decimal Calculate()
        {
            return base.Calculate() + Hardship;
        }

        public override string ToString()
        {
            return base.ToString() +
                $"\nHardship: {Math.Round(Hardship, 2):N0} $" +
                $"\nNet Salary: {Math.Round(this.Calculate(), 2):N0} $";
        }

    }

}

