using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHRSystem.Core.Entities
{
    class SalariedEmployee : DissmissableEmployee
    {
        public decimal BasicSalary { get; set; }
        public decimal Transportation { get; set; }
        public decimal Housing { get; set; }

        public override IEnumerable<PayItem> GetPayItems()
        {
            return new[]
            {
                new PayItem("Basic Salary", BasicSalary),
                new PayItem("Transportation", Transportation),
                new PayItem("Housing", Housing)

            };
        }




    }
}
