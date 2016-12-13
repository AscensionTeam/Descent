using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SID_database
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Console.WriteLine("new student created");
            student.FirstName = "Tony";
            student.LastName = "Baldock";
            student.Course = "Computer Games Technology";
            student.StudentNumber = 1530845;

            Console.WriteLine("First Name: " + student.FirstName + " " + student.LastName);
            Console.WriteLine("Course: " + student.Course);
            Console.WriteLine("Student ID Number: " + student.StudentNumber);
            Console.ReadLine();



            Student SecondStudent = new Student();
            Console.WriteLine("New student created");
            SecondStudent.FirstName = "Wade";
            SecondStudent.LastName = "Wilson";
            SecondStudent.Course = "Business Administration";
            SecondStudent.StudentNumber = 100005;

            Console.WriteLine("First Name: " + SecondStudent.FirstName + " " + SecondStudent.LastName);
            Console.WriteLine("Course: " + SecondStudent.Course);
            Console.WriteLine("Student ID Number: " + SecondStudent.StudentNumber);
            Console.ReadLine();

            Student ThirdStudent = new Student();
            Console.WriteLine("New Student Created");
            ThirdStudent.FirstName = "";
            ThirdStudent.LastName = "";
            ThirdStudent.Course = "";
            ThirdStudent.StudentNumber = 0;

            Console.WriteLine("First Name: " + ThirdStudent.FirstName + " " + ThirdStudent.LastName);
            Console.WriteLine("Course: " + ThirdStudent.Course);
            Console.WriteLine("Student ID Number: " + ThirdStudent.StudentNumber);
            Console.ReadLine();

            ThirdStudent = null;

            if(ThirdStudent == null)
            {
                Console.WriteLine("No data. Will be destroyed.");
                Console.ReadLine();
            }


        }
    }
}
