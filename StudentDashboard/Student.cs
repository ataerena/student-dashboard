using System;
using System.Collections.Generic;
using System.Text;

namespace StudentDashboard
{
   public class Student
    {
        public int id { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public int StudentId { get; set; }

        public string Password { get; set; }

        public int Semester { get; set; }
        public Student() 
        {
        }


    }
}
