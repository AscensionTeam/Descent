using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logbook_task_wk8
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Jai", "Powles");
            person1.PrintInfo();

            Student student1 = new Student("Ian", "Mutch", 1623853, "Forensic Science");
            student1.PrintInfo();
            student1.Learn();

            Teacher teacher1 = new Teacher("Tommy", "Thompson", 1865385, "Computer games dev");
            teacher1.PrintInfo();
            teacher1.StartLesson();

            Person person2 = new Student("John", "Diggle", 1519938, "Fighter");
            Student student2 = (Student)person2;
            student2.PrintInfo();
            student2.Learn();

            Console.ReadLine();


        }
    }
}
