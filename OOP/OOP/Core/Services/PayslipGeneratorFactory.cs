using OOPHRSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHRSystem.Core.Services
{
    internal class PayslipGeneratorFactory
    {
        public static IPayslipGenerator Create(INotifier notifier)
        {
            return new PayslipGenerator(notifier);
        }
    }
}
