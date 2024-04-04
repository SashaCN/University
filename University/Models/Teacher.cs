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
            Teacher teacher = new(name, surname, email, password);
            Repository<Teacher>
                .GetRepo(fileName)
                .Create(teacher);
        }

        public void Create()
        {
            Teacher teacher = new(Name, Surname, Email, Password);
            Repository<Teacher>
                .GetRepo(fileName)
                .Create(teacher);
        }

        public List<Teacher> ReadAll()
        {
            List<Teacher> teachers = Repository<Teacher>
                .GetRepo(fileName)
                .GetAll();

            return teachers;
        }
    }
}
