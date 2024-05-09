using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHRSystem.Core.Entities
{
    class InternEmployee : DissmissableEmployee
    {
        const decimal basicsalary = 2000;
        public override IEnumerable<PayItem> GetPayItems()
        {
            return new[] { new PayItem("Basic Salary", basicsalary) };
        }


    }
}
