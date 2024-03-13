using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Models
{
    public class Student : User
    {
        public Specialization Specialization; // Спеціальність
        public Student(string name, string surname, string email, string password, Specialization specialization) : base(name, surname, email, password)
        {
            Specialization = specialization;
        }
    }
}
