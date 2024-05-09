using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHRSystem.Core.Entities
{
    abstract class Person: Entity
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public void SetName(string fname, string lname)
        {
            if (string.IsNullOrWhiteSpace(fname) || string.IsNullOrWhiteSpace(lname))
                throw new ArgumentException("Invalid Name");
            FirstName = fname;
            LastName = lname;
        }
        public string FullName { get { return FirstName + " " + LastName; } private set { } }

        public DateTime BirthDate { get; private set; }
        public void SetBirthDate(DateTime birthdate)
        {
            if (birthdate < new DateTime(1990, 1, 1))
                throw new ArgumentException("Invalid birth date");
            BirthDate = birthdate;
        }
    }
}
