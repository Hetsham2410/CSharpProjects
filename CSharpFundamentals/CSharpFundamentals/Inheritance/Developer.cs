using System;
namespace Inheritance
{
    public class Developer : Employee
    {
        private const decimal Commission = 0.03m;
        private bool IsTaskCompleted { get; set; }

        public Developer(int Id, string Name, decimal LoggedHours, decimal Wage, bool IsTaskCompleted)
            : base(Id, Name, LoggedHours, Wage)
        {
            this.IsTaskCompleted = IsTaskCompleted;
        }
        protected override decimal Calculate()
        {
            return base.Calculate() + CalculateBonus();
        }
        protected decimal CalculateBonus()
        {
            if (IsTaskCompleted)
                return base.Calculate() * Commission;
            return 0;
        }

        public override string ToString()
        {
            return base.ToString() +
                $"\nTask Completed: {(IsTaskCompleted ? "Yes" : "No")}" +
                $"\nBonus: {Math.Round(CalculateBonus(), 2):N0} $" +
                $"\nNet Salary: {Math.Round(this.Calculate(), 2):N0} $";
        }

    }

}

