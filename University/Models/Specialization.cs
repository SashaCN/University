using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Models
{
    public sealed class Specialization
    {
        public string Name { get; set; }
        public List<Subject> Subjects { get; set; }

        public Specialization() { 
            Subjects = new List<Subject>();
        }

        public Specialization(string name) { 
            Name = name;
            Subjects = new List<Subject>();
        }
    }
}
