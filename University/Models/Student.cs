using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Models
{
    public sealed class Student : User
    {
        public Specialization Specialization { get; set; } // Спеціальність

        public Student()
        {
            Specialization = new Specialization();
        }
        public Student(string name, string surname, string email, string password, Specialization specialization) : base(name, surname, email, password)
        {
            Specialization = specialization;
        }

        public override List<string> getInfo()
        {
            List<string> info = base.getInfo();
            info.Add(Specialization.Name);
            return info;
        }
    }
}
