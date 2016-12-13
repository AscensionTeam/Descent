using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentClass student1 = new StudentClass();
            student1.firstName = "Jai";
            student1.secondName = "Powles";
            student1.studentID = 1407802;
            student1.faculty = "Science And Technology";
            student1.courseName = "Computer Gaming Technology";

            Console.WriteLine("New Student Created");


            StudentClass student2 = new StudentClass();
            student2.firstName = "Ben";
            student2.secondName = "Law";
            student2.studentID = 1543912;
            student2.faculty = "Science And Technology";
            student2.courseName = "Computer Gaming Technology";

            Console.WriteLine("New Student Created");

            Console.WriteLine("Student 1 Information");
            Console.WriteLine("");
            Console.WriteLine(student1.firstName);
            Console.WriteLine(student1.secondName);
            Console.WriteLine(student1.studentID);
            Console.WriteLine(student1.faculty);
            Console.WriteLine(student1.courseName);
            Console.WriteLine("");
            Console.WriteLine("Student 2 Information");
            Console.WriteLine("");
            Console.WriteLine(student2.firstName);
            Console.WriteLine(student2.secondName);
            Console.WriteLine(student2.studentID);
            Console.WriteLine(student2.faculty);
            Console.WriteLine(student2.courseName);
            student1 = null;
            student2 = null;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Student 1 Deleted");
            Console.WriteLine("Student 2 Deleted");
            Console.ReadLine();
        }

    }
}
