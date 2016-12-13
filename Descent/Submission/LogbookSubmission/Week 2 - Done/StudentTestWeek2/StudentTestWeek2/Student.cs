using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTestWeek2
{
    class Student
    {
        private string _firstname;
        private string _secondname;
        private int _studentID;
        private string _coursename;
        private string _faculty;

        public string firstName
        {
            get
            {
                return _firstname;
            }
            set
            {
                _firstname = value;
            }
        }

        public string secondName
        {
            get
            {
                return _secondname;
            }
            set
            {
                 _secondname = value;
            }
        }

        public int studentID
        {
            get
            {
                return _studentID;
            }
            set
            {
                _studentID = value;
            }
        }

        public string courseName
        {
            get
            {
                return _coursename;
            }
            set
            {
                _coursename = value;
            }
        }

        public string faculty
        {
            get
            {
                return _faculty;
            }
            set
            {
                _faculty = value;
            }
        }


    public Student() { }
   }
}

