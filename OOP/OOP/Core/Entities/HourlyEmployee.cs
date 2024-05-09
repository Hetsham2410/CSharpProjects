using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHRSystem.Core.Entities
{
    class HourlyEmployee : DissmissableEmployee
    {
        public decimal HourRate { get; set; }
        public int TotalWorkingHours { get; set; }

        public override IEnumerable<PayItem> GetPayItems()
        {
            return new[] {
                new PayItem("HourRate", HourRate),
                new PayItem("TotalWorkingHours", TotalWorkingHours)
            };
        }


    }
}
