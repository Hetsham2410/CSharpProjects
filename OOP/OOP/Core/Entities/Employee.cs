using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHRSystem.Core.Entities
{
    internal abstract class Employee : Person
    {
        public string Email { get; internal set; }

        //public abstract decimal GetSalary();
        public abstract IEnumerable<PayItem> GetPayItems();
        //public decimal basicsalary { get; private set; }
        //public void setbasicsalary(decimal basicsalary)
        //{
        //    if (basicsalary < 0)
        //        throw new argumentexception("invalid salary");
        //    basicsalary = basicsalary;
        //}
        //public int taxpercentage { get; private set; }
        //public void settaxpercentage(int taxpercentage)
        //{
        //    if (taxpercentage > 100)
        //        throw new argumentexception("invalid tax percentage");
        //    taxpercentage = taxpercentage;

        //}

    }
}
