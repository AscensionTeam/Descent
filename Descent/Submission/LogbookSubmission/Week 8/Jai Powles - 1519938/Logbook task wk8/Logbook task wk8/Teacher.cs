using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logbook_task_wk8
{
    class Teacher : Person
    {
        private int staffID;
        private string subject;

        public Teacher (string firstName, string lastName, int staffID, string subject) : base(firstName , lastName)
        {
            this.staffID = staffID;
            this.subject = subject;
        }

        public void StartLesson ()
        {
            Console.WriteLine("The lesson has started");
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Staff ID: " + staffID.ToString());
            Console.WriteLine("Course: " + subject);
        }
    }
}
