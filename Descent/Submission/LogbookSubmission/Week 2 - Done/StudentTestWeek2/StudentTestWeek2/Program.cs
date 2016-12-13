using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTestWeek2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.firstName = "Michael";
            student1.secondName = "Sharpington";
            student1.studentID = 1407802;
            student1.faculty = "Science And Technology";
            student1.courseName = "Computer Gaming Technology";

            Console.WriteLine("Student Michael Created");


            Student student2 = new Student();
            student2.firstName = "Charley";
            student2.secondName = "Hicks";
            student2.studentID = 1407912;
            student2.faculty = "Science And Technology";
            student2.courseName = "Computer Gaming Technology";

            Console.WriteLine("Student Charley Created");

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
