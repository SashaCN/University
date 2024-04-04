using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace University.Models
{
    public sealed class Student : User
    {
        public Specialization Specialization { get; set; } // Спеціальність
        public string fileName = "students.json";

        public Student()
        {
            Specialization = new Specialization();
        }
        public Student(string name, string surname, string email, string password, Specialization specialization) : base(name, surname, email, password)
        {
            Specialization = specialization;
        }

        public Student(string name, string surname, string email, string password, string specialization) : base(name, surname, email, password)
        {
            Specialization = Repository<Specialization>
                .GetRepo($"Faculties\\FIT\\{specialization}.json")
                .GetOne();
        }

        public void Create(string name, string surname, string email, string password, string specializationName)
        {
            Specialization specialization = Specialization = Repository<Specialization>
                .GetRepo($"Faculties\\FIT\\{specializationName}.json")
                .GetOne();

            Student student = new(name, surname, email, password, specialization);
            Repository<Student>
                .GetRepo(fileName)
                .Create(student);
        }

        public void Create()
        {
            Student student = new(Name, Surname, Email, Password, Specialization);
            Repository<Student>
                .GetRepo(fileName)
                .Create(student);
        }

        public List<Student> ReadAll()
        {
            List<Student> students = Repository<Student>
                .GetRepo(fileName)
                .GetAll();

            return students;
        }
    }
}