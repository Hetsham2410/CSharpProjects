using System;
namespace Inheritance
{
    public class Managers : Employee
    {
        public const decimal Allowance = 0.05m;
        public Managers(int Id, string Name, decimal LoggedHours, decimal Wage) : base( Id,  Name,  LoggedHours,  Wage)
        {

        }
        protected override decimal Calculate()
        {
            return base.Calculate() + CalculateAllowance();
        }
        private decimal CalculateAllowance()
        {
            return Allowance * base.Calculate();
        }

        public override string ToString()
        {
            return base.ToString() + 
                $"\nAllownace: {Math.Round(CalculateAllowance(),2):N0} $"+
                $"\nNet Salary: {Math.Round(Calculate(), 2):N0} $";
        }

    }

}

