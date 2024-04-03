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
        public string fileName = "students.json";

        public Student()
        {
            Specialization = new Specialization();
        }
        public Student(string name, string surname, string email, string password, Specialization specialization) : base(name, surname, email, password)
        {
            Specialization = specialization;
        }

        public void Create(string name, string surname, string email, string password, string specializationName)
        {
            List<Student> students = ReadAll();

            IFile<Specialization> fileSpecialization = new FileController<Specialization>($"Faculties\\FIT\\{specializationName}.json");
            Specialization specialization = fileSpecialization.readObject();

            Student student = new Student(name, surname, email, password, specialization);
            students.Add(student);

            IFile<Student> fileStudent = new FileController<Student>(fileName);
            fileStudent.writeList(students);
        }

        public List<Student> ReadAll()
        {
            IFile<Student> file = new FileController<Student>(fileName);
            List<Student> students = file.readList();

            return students;
        }
    }
}