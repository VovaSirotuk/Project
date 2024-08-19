using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_1
{
    internal class Musician : Person
    {
        public Musician(string FirstName, string LastName) : base(FirstName, LastName)
        {
            base.FirstName = FirstName;
            base.LastName = LastName;
        }
    }

    internal class Pilot : Person
    {
        public Pilot(string FirstName, string LastName) : base(FirstName, LastName)
        {
            base.FirstName = FirstName;
            base.LastName = LastName;
        }
    }
}
