using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms.VisualStyles;

namespace StudentDashboard.Classes
{
    internal class User
    {
        private int id;
        private string name;
        private string surname;
        private string email;
        private string phone;
        private string role;
        private string birthDate;


        protected int ID
        {
            get => id;
            set { id = value; }
        }
        protected string Name
        {
            get => name;
            set { name = value; }
        }
        protected string Surname
        {
            get => surname;
            set { surname = value; }
        }
        protected string Email
        {
            get => email;
            set { email = value; }
        }
        protected string Phone
        {
            get => phone;
            set { phone = value; }
        }
        protected string Role
        {
            get => role;
            set { role = value; }
        }
        protected string BirthDate
        {
            get => birthDate;
            set { birthDate = value; }
        }

        
    }
}
