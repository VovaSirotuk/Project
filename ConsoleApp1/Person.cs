using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LAB_1
{
    internal class Person
    {
        protected string FirstName;
        protected string LastName;
        protected void skating() 
        {
            Console.WriteLine("Особа катається на ковзанах ");  
        }

        public Person(string first, string last)
        {
            first = FirstName;
            last = LastName;
        }
        public string GetFirst()
        {
            return FirstName;
        }

        public string GetLast()
        {
            return LastName;
        }

    }
}
