using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SID_database
{
    class Student
    {
        string firstName;
        string lastName;
        int studentNumber;
        string course;

     public string FirstName
        {
            set
            {
                firstName = value;
            }

            get
            {
                return firstName;
            }
        }

        public string LastName
        {
            set
            {
                lastName = value;
            }

            get
            {
                return lastName;
            }
        }

        public string Course
        {
            set
            {
                course = value;
            }

            get
            {
                return course;
            }

       
        }

        public int StudentNumber
        {
            get
            {
                return studentNumber;
            }

           set
            {
                studentNumber = value;
            }
        }
    
    }

    

}
