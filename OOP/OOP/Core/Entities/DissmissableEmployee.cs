using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHRSystem.Core.Entities
{
    internal abstract class DissmissableEmployee : Employee
    {
        public bool IsDismissed { get; private set; }
        public virtual void Dismiss()
        {
            IsDismissed = true;
        }
    }
}
