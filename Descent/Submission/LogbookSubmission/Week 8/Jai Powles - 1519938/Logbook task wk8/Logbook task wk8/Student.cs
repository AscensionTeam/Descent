using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logbook_task_wk8
{
    class Student : Person
    {
        private int studentID;
        private string course;

        public Student(string firstName, string lastName, int studentID, string course) : base(firstName, lastName)
        {
            this.studentID = studentID;
            this.course = course;
        }

        public void Learn()
        {
            Console.WriteLine("Student is learning");
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Student ID: " + studentID.ToString());
            Console.WriteLine("Course: " + course);
        }
    }
}
