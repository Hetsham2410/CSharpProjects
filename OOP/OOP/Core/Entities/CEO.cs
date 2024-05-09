using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHRSystem.Core.Entities
{
    internal class CEO : Employee
    {
        public override IEnumerable<PayItem> GetPayItems()
        {
            throw new NotImplementedException();
        }
    }
}
