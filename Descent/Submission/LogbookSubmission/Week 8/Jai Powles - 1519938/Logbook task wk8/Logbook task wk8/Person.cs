using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logbook_task_wk8
{
    class Person
    {
        protected string firstName;
        protected string lastName;

        public Person (string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine("First Name: " + firstName);
            Console.WriteLine("Last Name: " + lastName);
        }
    }
}
