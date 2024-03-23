using System;
using System.Collections.Generic;
using System.Text;

namespace StudentDashboard.Classes
{
    class Student : User
    {
        private double gpa;
        private int semester;
        private string deparment;
        private string faculty;


        protected double GPA
        {
            get => gpa;
            set { gpa = value; } 
        }
        protected int Semester
        {
            get => semester;
            set { semester = value; }
        } 
        protected string Deparment
        {
            get => deparment;
            set { deparment = value; }
        }
        protected string Faculty
        {
            get => faculty;
            set { faculty = value; }
        }
        

    }
}
