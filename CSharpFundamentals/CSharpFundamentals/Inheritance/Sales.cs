using System;
namespace Inheritance
{
    public class Sales : Employee
    {
        private decimal SalesVolume { get; set; }
        private decimal Commission { get; set; }

        public Sales(int Id, string Name, decimal LoggedHours, decimal Wage, decimal Commission ,decimal SalesVolume) 
            : base(Id, Name, LoggedHours, Wage)
        {
            this.SalesVolume = SalesVolume;
            this.Commission = Commission;
        }
        protected override decimal Calculate()
        {
            return base.Calculate() + CalculateBonus();
        }
        protected decimal CalculateBonus()
        {
            
            return SalesVolume * Commission;
        }

        public override string ToString()
        {
            return base.ToString() +
                $"\nCommission: {Commission} $" +
                $"\nBonus: {Math.Round(CalculateBonus(), 2):N0} $" +
                $"\nNet Salary: {Math.Round(this.Calculate(), 2):N0} $";
        }

    }

}

