using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace University.Models
{
    public sealed class Teacher : User
    {
        public string fileName = "teacher.json";
        public int salary = 0;

        public Teacher() { }

        public Teacher(string name, string surname, string email, string password) : base(name, surname, email, password)
        {

        }


        public void Create(string name, string surname, string email, string password)
        {
            List<Teacher> teachers = ReadAll();

            Teacher teacher = new(name, surname, email, password);
            teachers.Add(teacher);

            IFile<Teacher> fileTeacher = new FileController<Teacher>(fileName);
            fileTeacher.writeList(teachers);
        }

        public void Create()
        {
            List<Teacher> teachers = ReadAll();

            Teacher teacher = new(Name, Surname, Email, Password);
            teachers.Add(teacher);

            IFile<Teacher> fileTeacher = new FileController<Teacher>(fileName);
            fileTeacher.writeList(teachers);
        }

        public List<Teacher> ReadAll()
        {
            IFile<Teacher> file = new FileController<Teacher>(fileName);
            List<Teacher> teachers = file.readList();

            return teachers;
        }
    }
}
